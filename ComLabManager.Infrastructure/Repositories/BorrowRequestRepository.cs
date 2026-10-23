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
                u.UserName AS StudentName 
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
                string sql = "SELECT * FROM BorrowRequests WHERE StudentId = @StudentId ORDER BY RequestedDate DESC";
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

        public void UpdateRequestStatus(int requestId, string newStatus)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = "UPDATE BorrowRequests SET Status = @Status WHERE Id = @Id";
                db.Execute(sql, new { Status = newStatus, Id = requestId });
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