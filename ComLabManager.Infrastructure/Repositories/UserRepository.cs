using BCrypt.Net;
using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComLabManager.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public User AuthenticateUser(string username, string rawPassword)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    string sql = "SELECT * FROM Users WHERE Username = @Username LIMIT 1";
                    var user = connection.QuerySingleOrDefault<User>(sql, new { Username = username });

                    if (user != null && BCrypt.Net.BCrypt.Verify(rawPassword, user.PasswordHash))
                        return user;

                    return null;
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("Unable to connect to the database. Please check if the server is running.", ex);
            }
        }

        public List<User> GetUsersByRole(string role)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                string sql = "SELECT Id, Username, Role, FirstName, LastName, CreatedAt FROM Users WHERE Role = @Role ORDER BY FirstName, LastName, Username";
                return connection.Query<User>(sql, new { Role = role }).ToList();
            }
        }

      

        public void AddUser(User user, string rawPassword)
        {
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(rawPassword);
            using (var connection = new MySqlConnection(_connectionString))
            {
               

                string sql = @"INSERT INTO Users (FirstName, LastName, Username, PasswordHash, Role, CreatedAt)
                       VALUES (@FirstName, @LastName, @UserName, @PasswordHash, @Role, NOW())";

                connection.Execute(sql, new
                {
                    user.FirstName,
                    user.LastName,
                    user.UserName,
                    user.PasswordHash,
                    user.Role
                });
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                // Added IsSuspended to the SELECT query
                string sql = "SELECT * FROM Users ORDER BY Role, LastName, FirstName";
                return connection.Query<User>(sql).ToList();
            }
        }

        public void UpdateUser(User user, string rawPassword)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                if (!string.IsNullOrWhiteSpace(rawPassword))
                {
                    user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(rawPassword);
                    string sql = @"UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Username = @UserName, Role = @Role, IsSuspended = @IsSuspended, PasswordHash = @PasswordHash WHERE Id = @Id";

                    connection.Execute(sql, new
                    {
                        user.FirstName,
                        user.LastName,
                        user.UserName,
                        user.Role,
                        user.IsSuspended,
                        user.PasswordHash,
                        user.Id
                    });
                }
                else
                {
                    string sql = @"UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Username = @UserName, Role = @Role, IsSuspended = @IsSuspended WHERE Id = @Id";

                    connection.Execute(sql, new
                    {
                        user.FirstName,
                        user.LastName,
                        user.UserName,
                        user.Role,
                        user.IsSuspended,
                        user.Id
                    });
                }
            }
        }
        public void DeleteUser(int id)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Users WHERE Id = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }

        public IEnumerable<UserBorrowHistoryDto> GetUserBorrowHistory(int userId)
        {
            using (var db = new MySqlConnection(_connectionString))
            {
                string sql = @"
            SELECT IFNULL(TargetLocation, 'Room/Tool') AS Location, Purpose, 
                   RequestedDate AS Date, StartTime, EndTime, Status 
            FROM BorrowRequests WHERE StudentId = @UserId ORDER BY RequestedDate DESC";
                return db.Query<UserBorrowHistoryDto>(sql, new { UserId = userId }).ToList();
            }
        }

        public IEnumerable<UserMaintenanceHistoryDto> GetUserMaintenanceHistory(int userId)
        {
            using (var db = new MySqlConnection(_connectionString))
            {
                string sql = @"
            SELECT e.AssetTag, m.IssueDescription AS Issue, m.Status, m.DateReported AS Reported 
            FROM MaintenanceLogs m
            JOIN Equipment e ON m.EquipmentId = e.Id
            WHERE m.ReportedById = @UserId ORDER BY m.DateReported DESC";
                return db.Query<UserMaintenanceHistoryDto>(sql, new { UserId = userId }).ToList();
            }
        }
    }
}