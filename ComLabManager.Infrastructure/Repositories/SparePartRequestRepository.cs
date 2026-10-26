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
                    INSERT INTO SparePartRequests (TechId, RequestedPartId, Quantity, Reason, Status, RequestDate)
                    VALUES (@TechId, @RequestedPartId, @Quantity, @Reason, @Status, @RequestDate)";
                db.Execute(sql, request);
            }
        }


        public IEnumerable<SparePartRequest> GetAllRequests()
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = @"
            SELECT 
                spr.Id, 
                spr.TechId, 
                spr.RequestedPartId, 
                spr.Quantity, 
                spr.Reason, 
                spr.Status, 
                spr.RequestDate,
                CONCAT(u.FirstName, ' ', u.LastName) AS TechnicianName,
                sp.Name AS SparePartName
            FROM SparePartRequests spr
            JOIN Users u ON spr.TechId = u.Id
            JOIN SpareParts sp ON spr.RequestedPartId = sp.Id
            ORDER BY spr.RequestDate DESC";

                return db.Query<SparePartRequest>(sql).ToList();
            }
        }




        public void UpdateRequestStatus(int requestId, string status)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = "UPDATE SparePartRequests SET Status = @Status WHERE Id = @Id AND Status = 'Pending'";

                if (db.Execute(sql, new { Status = status, Id = requestId }) == 0)
                {
                    throw new InvalidOperationException("This request has already been processed.");
                }
            }
        }

        public void ApproveAndDeductInventory(int requestId)
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                db.Open();
                using (var transaction = db.BeginTransaction())
                {
                    string query = @"
                SELECT spr.RequestedPartId, spr.Quantity, spr.Status, sp.Quantity AS CurrentStock, sp.Name
                FROM SparePartRequests spr
                JOIN SpareParts sp ON spr.RequestedPartId = sp.Id
                WHERE spr.Id = @RequestId
                FOR UPDATE";

                    var req = db.QueryFirstOrDefault<dynamic>(query, new { RequestId = requestId }, transaction);

                    if (req == null) throw new Exception("Request not found.");

                    if ((string)req.Status != "Pending")
                    {
                        throw new InvalidOperationException("This request has already been processed.");
                    }

                    int requestedQty = (int)req.Quantity;
                    int currentStock = (int)req.CurrentStock;

                    if (currentStock < requestedQty)
                    {
                        throw new InvalidOperationException($"Cannot approve request. Insufficient stock for '{req.Name}'. Available: {currentStock}, Requested: {requestedQty}.");
                    }

                    db.Execute("UPDATE SpareParts SET Quantity = Quantity - @Qty WHERE Id = @PartId",
                        new { Qty = requestedQty, PartId = (int)req.RequestedPartId }, transaction);

                    db.Execute("UPDATE SparePartRequests SET Status = 'Approved' WHERE Id = @RequestId",
                        new { RequestId = requestId }, transaction);

                    transaction.Commit();
                }
            }
        }
    }
        
}