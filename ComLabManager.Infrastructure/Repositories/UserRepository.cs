using BCrypt.Net;
using ComlabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using Dapper;
using MySql.Data.MySqlClient;

namespace ComlabManager.Infrastructure.Repositories
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
                    {
                        return user;
                    }

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
                string sql = @"SELECT Id, Username, Role, FirstName, LastName, CreatedAt
                               FROM Users
                               WHERE Role = @Role
                               ORDER BY FirstName, LastName, Username";

                return connection.Query<User>(sql, new { Role = role }).ToList();
            }
        }
    }
}