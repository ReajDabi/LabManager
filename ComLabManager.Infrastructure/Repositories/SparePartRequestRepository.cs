using ComLabManager.Core.Models;
using MySql.Data.MySqlClient;
using ComLabManager.Core.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ComLabManager.Infrastructure.Repositories
{
   
    public class SparePartRequestRepository : ISparePartRequestRepository
    {
        private readonly string _connectionString;

      
        public SparePartRequestRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

      
        public void AddRequest(SparePartRequest request)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = @"
                    INSERT INTO SparePartRequests (TechId, RequestPartId, Quantity, Reason, Status, RequestDate) 
                    VALUES (@TechId, @RequestPartId, @Quantity, @Reason, @Status, @RequestDate)";
                db.Execute(sql, request);
            }
        }

     
        public IEnumerable<SparePartRequest> GetAllRequests()
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = @"
                    SELECT 
                        spr.*, 
                        u.UserName AS TechName, 
                        sp.Name AS PartName 
                    FROM SparePartRequests spr 
                    JOIN Users u ON spr.TechId = u.Id 
                    JOIN SpareParts sp ON spr.RequestPartId = sp.Id
                    ORDER BY spr.RequestDate DESC";

                return db.Query<SparePartRequest>(sql).ToList();
            }
        }

        public void UpdateRequestStatus(int requestId, string status)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = "UPDATE SparePartRequests SET Status = @Status WHERE Id = @Id";
                db.Execute(sql, new { Status = status, Id = requestId });
            }
        }
    }
}