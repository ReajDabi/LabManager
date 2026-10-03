using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ComlabManager.Infrastructure.Repositories
{
    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly string _connectionString;


        public EquipmentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Equipment> GetAllEquipment()
        {

            using (var connection = new MySqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Equipment";
                return connection.Query<Equipment>(sql).ToList();
            }
        }

        public void AddEquipment(Equipment equipment)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {

                string sql = @"INSERT INTO Equipment (Name, SerialNumber, Category, Status, Location, DateAcquired) 
                       VALUES (@Name, @SerialNumber, @Category, @Status, @Location, @DateAcquired)";

                connection.Execute(sql, equipment);
            }
        }

        public void UpdateEquipment(Equipment equipment)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                string sql = @"UPDATE Equipment 
                       SET Name = @Name, SerialNumber = @SerialNumber, 
                           Category = @Category, Status = @Status, 
                           Location = @Location, DateAcquired = @DateAcquired 
                       WHERE Id = @Id";

                connection.Execute(sql, equipment);
            }
        }

        public void DeleteEquipment(int id)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Equipment WHERE Id = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }


        public List<Equipment> SearchEquipment(string keyword)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {

                string sql = @"SELECT * FROM Equipment 
                       WHERE Name LIKE @Search 
                       OR SerialNumber LIKE @Search 
                       OR Category LIKE @Search 
                       OR Status LIKE @Search";

                return connection.Query<Equipment>(sql, new { Search = $"%{keyword}%" }).ToList();
            }
        }

        public IEnumerable<Equipment> GetEquipmentByCategory(string category)
        {
            using (IDbConnection connection = new MySqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Equipment WHERE Category = @Category";

                return connection.Query<Equipment>(sql, new { Category = category }).ToList();
            }
        }
    }
}