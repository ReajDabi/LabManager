using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;

namespace ComlabManager.Infrastructure.Repositories
{
    public class BorrowRequestRepository : IBorrowRequestRepository
    {
        private readonly string _connectionString;

       
        public BorrowRequestRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        public IEnumerable<BorrowRequest> GetAllRequests()
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = @"
    SELECT 
        br.*, 
        u.Firstname AS StudentName 
    FROM BorrowRequests br
    JOIN Users u ON br.StudentId = u.Id
    ORDER BY br.RequestedDate DESC";

                return db.Query<BorrowRequest>(sql).ToList();
            }
        }
        public void AddRequest(BorrowRequest request)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
              
                bool isSuspended = db.ExecuteScalar<bool>("SELECT IsSuspended FROM Users WHERE Id = @StudentId", new { StudentId = request.StudentId });
                if (isSuspended)
                {
                    throw new InvalidOperationException("Your account has been suspended by an Administrator. You cannot borrow equipment at this time.");
                }

                if (request.EquipmentId.HasValue)
                {
                    string locSql = "SELECT StationNumber FROM Equipment WHERE Id = @Id";
                    string actualLocation = db.ExecuteScalar<string>(locSql, new { Id = request.EquipmentId.Value });

                    if (string.IsNullOrWhiteSpace(actualLocation) || !actualLocation.Equals(request.TargetLocation, StringComparison.OrdinalIgnoreCase))
                    {
                        string displayLocation = string.IsNullOrWhiteSpace(actualLocation) ? "an unassigned location" : actualLocation;
                        throw new InvalidOperationException($"The requested equipment is currently located in {displayLocation}, not {request.TargetLocation}. Please correct the room location.");
                    }
                }

                // 3. Save Request (Your existing code)
                string sql = @"INSERT INTO BorrowRequests 
                       (StudentId, EquipmentId, TargetLocation, Purpose, RequestedDate, StartTime, EndTime, Status) 
                       VALUES 
                       (@StudentId, @EquipmentId, @TargetLocation, @Purpose, @RequestedDate, @StartTime, @EndTime, @Status)";

                db.Execute(sql, request);
            }
        }
        public IEnumerable<BorrowRequest> GetRequestsByStudent(int studentId)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = @"
            SELECT 
                br.*, 
                u.Username AS StudentName 
            FROM BorrowRequests br
            JOIN Users u ON br.StudentId = u.Id
            WHERE br.StudentId = @StudentId 
            ORDER BY br.RequestedDate DESC";

                return db.Query<BorrowRequest>(sql, new { StudentId = studentId }).ToList();
            }
        }

        public IEnumerable<BorrowRequest> GetPendingRequests()
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM BorrowRequests WHERE Status = 'Pending' ORDER BY RequestedDate ASC";
                return db.Query<BorrowRequest>(sql).ToList();
            }
        }
        public void ApproveAndLockEquipment(int requestId)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                db.Open();
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        var request = db.QuerySingle<BorrowRequest>("SELECT * FROM BorrowRequests WHERE Id = @Id", new { Id = requestId }, transaction);
                        string dayOfWeek = request.RequestedDate.DayOfWeek.ToString(); // e.g., 'Monday'

                        // Rule 1: Check against official ComLabSchedules
                        string scheduleSql = @"
                    SELECT COUNT(1) FROM ComLabSchedules 
                    WHERE ComLabName = @TargetLocation 
                      AND DayOfWeek = @DayOfWeek 
                      AND StartTime < @EndTime 
                      AND EndTime > @StartTime";

                        int scheduleConflicts = db.ExecuteScalar<int>(scheduleSql, new { request.TargetLocation, DayOfWeek = dayOfWeek, request.StartTime, request.EndTime }, transaction);
                        if (scheduleConflicts > 0)
                            throw new InvalidOperationException($"Cannot approve. '{request.TargetLocation}' has an official class scheduled during this time.");

                        // Rule 2: Check against other previously approved BorrowRequests
                        string borrowSql = @"
                    SELECT COUNT(1) FROM BorrowRequests 
                    WHERE TargetLocation = @TargetLocation 
                      AND Status = 'Approved' 
                      AND DATE(RequestedDate) = DATE(@RequestedDate) 
                      AND StartTime < @EndTime 
                      AND EndTime > @StartTime";

                        int borrowConflicts = db.ExecuteScalar<int>(borrowSql, new { request.TargetLocation, request.RequestedDate, request.StartTime, request.EndTime }, transaction);
                        if (borrowConflicts > 0)
                            throw new InvalidOperationException($"Cannot approve. '{request.TargetLocation}' is already reserved by another student during this time.");

                       
                        if (request.EquipmentId.HasValue)
                        {
                            var equipmentStatus = db.QuerySingle<string>("SELECT Status FROM Equipment WHERE Id = @Id", new { Id = request.EquipmentId }, transaction);

                            if (equipmentStatus != "Available" && equipmentStatus != "Active")
                                throw new InvalidOperationException($"Equipment cannot be approved because its current status is: {equipmentStatus}");

                            db.Execute("UPDATE Equipment SET Status = 'In Use' WHERE Id = @Id", new { Id = request.EquipmentId }, transaction);
                        }

                        
                        db.Execute("UPDATE BorrowRequests SET Status = 'Approved' WHERE Id = @Id", new { Id = requestId }, transaction);

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void ReturnEquipment(int requestId)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                db.Open();
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        var request = db.QuerySingle<BorrowRequest>("SELECT * FROM BorrowRequests WHERE Id = @Id", new { Id = requestId }, transaction);

                        if (request.Status != "Approved")
                        {
                            throw new InvalidOperationException("Only approved and actively borrowed equipment can be returned.");
                        }

                   
                        if (request.EquipmentId.HasValue)
                        {
                      
                            string equipSql = "UPDATE Equipment SET Status = 'Available', UsageCount = UsageCount + 1 WHERE Id = @Id";
                            db.Execute(equipSql, new { Id = request.EquipmentId.Value }, transaction);
                        }

                        db.Execute("UPDATE BorrowRequests SET Status = 'Returned' WHERE Id = @Id", new { Id = requestId }, transaction);

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void UpdateRequestStatus(int requestId, string status)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = "UPDATE BorrowRequests SET Status = @Status WHERE Id = @Id";
                db.Execute(sql, new { Status = status, Id = requestId });
            }
        }

        public int GetPendingCount()
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                return db.ExecuteScalar<int>("SELECT COUNT(*) FROM BorrowRequests WHERE Status = 'Pending'");
            }
        }
    }
}