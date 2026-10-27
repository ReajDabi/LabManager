using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ComLabManager.Infrastructure.Repositories
{
    public class SparePartRepository : ISparePartRepository
    {
        private readonly string _connectionString;

        public SparePartRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void UpdateSparePartQuantity(int id, int newQuantity)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = "UPDATE SpareParts SET Quantity = @Quantity WHERE Id = @Id";
                db.Execute(sql, new { Quantity = newQuantity, Id = id });
            }
        }
        public IEnumerable<SparePart> GetAllSpareParts()
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM SpareParts WHERE IsDeleted = 0";
                return db.Query<SparePart>(sql).ToList();
            }
        }

        public void AddSparePart(SparePart part)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                // A deleted part keeps its unique Name, so bring it back instead of inserting a duplicate
                string restoreSql = "UPDATE SpareParts SET Category = @Category, Quantity = @Quantity, RestockLevel = @RestockLevel, IsDeleted = 0 WHERE Name = @Name AND IsDeleted = 1";
                if (db.Execute(restoreSql, part) > 0) return;

                string sql = "INSERT INTO SpareParts (Name, Category, Quantity, RestockLevel, IsDeleted) VALUES (@Name, @Category, @Quantity, @RestockLevel, 0)";
                db.Execute(sql, part);
            }
        }

        public void UpdateSparePart(SparePart part)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = "UPDATE SpareParts SET Name = @Name, Category = @Category, Quantity = @Quantity, RestockLevel = @RestockLevel WHERE Id = @Id";
                db.Execute(sql, part);
            }
        }

        public void DeleteSparePart(int id)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = "UPDATE SpareParts SET IsDeleted = 1 WHERE Id = @Id";
                db.Execute(sql, new { Id = id });
            }
        }
    }
}