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
                // Every card's count in a single round trip
                string sql = $@"
            SELECT
                (SELECT COUNT(*) FROM Equipment WHERE TRIM(Status) = 'Active') AS TotalActiveAssets,
                (SELECT COUNT(*) FROM Equipment WHERE UsageCount >= @Threshold) AS HighUsageFlags,
                (SELECT COUNT(*) FROM BorrowRequests WHERE Status = 'Pending')
                  + (SELECT COUNT(*) FROM SparePartRequests WHERE Status = 'Pending') AS PendingApprovals,
                (SELECT COUNT(*) FROM Equipment WHERE TRIM(Status) = 'Under Repair') AS DamagedEquipment,
                (SELECT COUNT(*) FROM SpareParts WHERE IsDeleted = 0 AND Quantity <= RestockLevel) AS LowStockParts,
                (SELECT COUNT(DISTINCT br.StudentId) FROM BorrowRequests br WHERE {BorrowRequestSql.ActiveLoanCondition}) AS ActiveBorrowers,
                (SELECT COUNT(*) FROM BorrowRequests br WHERE {BorrowRequestSql.OverdueCondition}) AS OverdueItems,
                (SELECT COUNT(*) FROM PreventiveMaintenance WHERE NextDueDate <= CURDATE() + INTERVAL 7 DAY) AS UpcomingPMTasks";

                return db.QuerySingle<DashboardMetrics>(sql, new { Threshold = Equipment.HighUsageThreshold });
            }
        }

        public IEnumerable<UrgentTask> GetUrgentTasks()
        {
            using (var db = new MySqlConnection(_connectionString))
            {
                string sql = $@"
            SELECT 'Borrow Request' AS Type,
                   CONCAT(IFNULL(TargetLocation, 'Equipment'), ' - ', Purpose) AS Details,
                   RequestedDate AS Date
            FROM BorrowRequests WHERE Status = 'Pending'

            UNION ALL

            SELECT 'Overdue Item' AS Type,
                   CONCAT(e.AssetTag, ' - ', COALESCE(NULLIF(TRIM(CONCAT_WS(' ', u.FirstName, u.LastName)), ''), u.Username)) AS Details,
                   br.RequestedDate AS Date
            FROM BorrowRequests br
            JOIN Equipment e ON br.EquipmentId = e.Id
            JOIN Users u ON br.StudentId = u.Id
            WHERE {BorrowRequestSql.OverdueCondition}

            UNION ALL

            SELECT 'Maintenance' AS Type,
                   CONCAT(e.AssetTag, ' - ', m.IssueDescription) AS Details,
                   m.DateReported AS Date
            FROM MaintenanceLogs m
            JOIN Equipment e ON m.EquipmentId = e.Id
            WHERE m.Status = 'Open'

            UNION ALL

            SELECT 'Preventive Maintenance' AS Type,
                   CONCAT(TargetLocation, ' - ', TaskName) AS Details,
                   NextDueDate AS Date
            FROM PreventiveMaintenance
            WHERE NextDueDate <= CURDATE() + INTERVAL 7 DAY

            ORDER BY Date ASC LIMIT 10";

                return db.Query<UrgentTask>(sql).ToList();
            }
        }
    }
}
