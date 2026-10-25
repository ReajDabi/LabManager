using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;



namespace ComLabManager.Infrastructure.Repositories
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly string _connectionString;

        public DashboardRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DashboardMetrics GetMetrics()
        {
            using (var db = new MySqlConnection(_connectionString))
            {
                return new DashboardMetrics
                {
                    TotalActiveAssets = db.ExecuteScalar<int>("SELECT COUNT(*) FROM Equipment WHERE TRIM(Status) = 'Active'"),
                   
                    HighUsageFlags = db.ExecuteScalar<int>("SELECT COUNT(*) FROM Equipment WHERE UsageCount >= 15"),
                    PendingBorrowReqs = db.ExecuteScalar<int>("SELECT COUNT(*) FROM BorrowRequests WHERE TRIM(Status) = 'Pending'"),
                    UpcomingPMTasks = db.ExecuteScalar<int>("SELECT COUNT(*) FROM MaintenanceLogs WHERE TRIM(Status) = 'Open'")
                };
            }
        }

        public IEnumerable<UrgentTask> GetUrgentTasks()
        {
            using (var db = new MySqlConnection(_connectionString))
            {
                
                string sql = @"
                    SELECT 'Borrow Request' AS Type, CONCAT('Room ', TargetLocation, ' - ', Purpose) AS Details, RequestedDate AS Date 
                    FROM BorrowRequests WHERE Status = 'Pending'
                    
                    UNION ALL
                    
                    SELECT 'Maintenance' AS Type, CONCAT(e.AssetTag, ' - ', m.IssueDescription) AS Details, m.DateReported AS Date 
                    FROM MaintenanceLogs m 
                    JOIN Equipment e ON m.EquipmentId = e.Id 
                    WHERE m.Status = 'Open'
                    
                    ORDER BY Date ASC LIMIT 10";

                return db.Query<UrgentTask>(sql).ToList();
            }
        }
    }
}