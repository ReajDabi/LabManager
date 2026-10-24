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

        public void ApproveAndDeductInventory(int requestId)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                db.Open();
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        var request = db.QuerySingle<SparePartRequest>("SELECT * FROM SparePartRequests WHERE Id = @Id", new { Id = requestId }, transaction);
                        var part = db.QuerySingle<SparePart>("SELECT * FROM SpareParts WHERE Id = @Id", new { Id = request.RequestPartId }, transaction);

                        if (part.Quantity < request.Quantity)
                        {
                            throw new InvalidOperationException($"Insufficient stock.\nAvailable: {part.Quantity}\nRequested: {request.Quantity}");
                        }

                        db.Execute("UPDATE SpareParts SET Quantity = Quantity - @Qty WHERE Id = @PartId", new { Qty = request.Quantity, PartId = request.RequestPartId }, transaction);
                        db.Execute("UPDATE SparePartRequests SET Status = 'Approved' WHERE Id = @Id", new { Id = requestId }, transaction);

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
    }
}