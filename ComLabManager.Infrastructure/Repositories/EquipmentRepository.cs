using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;


namespace ComLabManager.Infrastructure.Repositories
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
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                return db.Query<Equipment>("SELECT * FROM Equipment ORDER BY Category, Name").ToList();
            }
        }

        public IEnumerable<Equipment> GetEquipmentByCategory(string category)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Equipment WHERE Category = @Category";
                return db.Query<Equipment>(sql, new { Category = category }).ToList();
            }
        }

        public void AddEquipment(Equipment equipment)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = @"INSERT INTO Equipment 
                               (AssetTag, Name, Category, Status, StationNumber, UsageCount, DateAcquired) 
                               VALUES (@AssetTag, @Name, @Category, @Status, @StationNumber, @UsageCount, @DateAcquired)";

                db.Execute(sql, equipment);
            }
        }

        public void UpdateEquipment(Equipment equipment)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = @"UPDATE Equipment 
                               SET AssetTag = @AssetTag, 
                                   Name = @Name, 
                                   Category = @Category, 
                                   Status = @Status, 
                                   StationNumber = @StationNumber, 
                                   UsageCount = @UsageCount, 
                                   DateAcquired = @DateAcquired 
                               WHERE Id = @Id";

                db.Execute(sql, equipment);
            }
        }

        public void DeleteEquipment(int id)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                db.Execute("DELETE FROM Equipment WHERE Id = @Id", new { Id = id });
            }
        }

        
        public List<Equipment> SearchEquipment(string keyword)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = @"SELECT * FROM Equipment 
                               WHERE AssetTag LIKE @Keyword 
                                  OR Name LIKE @Keyword 
                                  OR StationNumber LIKE @Keyword 
                               ORDER BY Category, Name";

               
                return db.Query<Equipment>(sql, new { Keyword = $"%{keyword}%" }).ToList();
            }
        }

        
        public int GetTotalActiveCount()
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                return db.ExecuteScalar<int>("SELECT COUNT(*) FROM Equipment WHERE Status = 'Active'");
            }
        }

        public int GetHighUsageCount()
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                return db.ExecuteScalar<int>("SELECT COUNT(*) FROM Equipment WHERE UsageCount >= @Threshold", new { Threshold = Equipment.HighUsageThreshold });
            }
        }

        public string GenerateNextAssetTag(string categoryName)
        {
            string categoryCode = categoryName switch
            {
                "System Unit" => "SYS",
                "Monitor" => "MON",
                "Peripheral" => "PER",
                "Networking" => "NET",
                "Tool" => "EQ",
                "Cable" => "CBL",
                _ => "GEN" 
            };

            string prefix = $"UM-{categoryCode}-";

            using (var db = new MySqlConnection(_connectionString))
            {
                string sql = "SELECT AssetTag FROM Equipment WHERE AssetTag LIKE @Prefix ORDER BY AssetTag DESC LIMIT 1";
                string lastTag = db.ExecuteScalar<string>(sql, new { Prefix = prefix + "%" });

                int nextNumber = 1;

               
                if (!string.IsNullOrWhiteSpace(lastTag))
                {
                    string numberPart = lastTag.Substring(prefix.Length);
                    if (int.TryParse(numberPart, out int lastNumber))
                    {
                        nextNumber = lastNumber + 1;
                    }
                }

               
                return $"{prefix}{nextNumber:D3}";
            }
        }
    }
}