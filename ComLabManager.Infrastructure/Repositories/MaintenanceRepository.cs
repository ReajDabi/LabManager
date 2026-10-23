using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComlabManager.Infrastructure.Repositories
{
    public class MaintenanceRepository : IMaintenanceRepository
    {
        private readonly string _connectionString;

        public MaintenanceRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<MaintenanceTicket> GetAllTickets()
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                string sql = @"SELECT l.Id, e.AssetTag, e.Name AS EquipmentName, l.IssueDescription,
                                      l.Status, l.DateReported, l.AssignedTechnicianId,
                                      COALESCE(NULLIF(TRIM(CONCAT_WS(' ', u.FirstName, u.LastName)), ''), u.Username) AS AssignedTechnicianName,
                                      GROUP_CONCAT(sp.Name SEPARATOR ', ') AS SparePartName
                               FROM MaintenanceLogs l
                               INNER JOIN Equipment e ON e.Id = l.EquipmentId
                               LEFT JOIN Users u ON u.Id = l.AssignedTechnicianId
                               LEFT JOIN MaintenanceParts mp ON mp.LogId = l.Id
                               LEFT JOIN SpareParts sp ON sp.Id = mp.SparePartId
                               GROUP BY l.Id, e.AssetTag, e.Name, l.IssueDescription, l.Status, l.DateReported,
                                        l.AssignedTechnicianId, u.FirstName, u.LastName, u.Username
                               ORDER BY (l.Status = 'Resolved'), l.DateReported DESC, l.Id DESC";

                return connection.Query<MaintenanceTicket>(sql).ToList();
            }
        }

        public int CreateTicket(MaintenanceLog log)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                string sql = @"INSERT INTO MaintenanceLogs (EquipmentId, ReportedById, IssueDescription, Status)
                               VALUES (@EquipmentId, @ReportedById, @IssueDescription, 'Open');
                               SELECT LAST_INSERT_ID();";

                return connection.ExecuteScalar<int>(sql, log);
            }
        }

        public void AssignTechnician(int ticketId, int technicianId)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                string sql = @"UPDATE MaintenanceLogs SET AssignedTechnicianId = @TechnicianId
                               WHERE Id = @Id AND Status <> 'Resolved'";

                if (connection.Execute(sql, new { Id = ticketId, TechnicianId = technicianId }) == 0)
                {
                    throw new InvalidOperationException("A Resolved ticket can no longer be assigned.");
                }
            }
        }

        public void StartRepair(int ticketId, int? technicianId)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    string ticketSql = @"UPDATE MaintenanceLogs
                                         SET Status = 'Under Repair',
                                             AssignedTechnicianId = COALESCE(AssignedTechnicianId, @TechnicianId)
                                         WHERE Id = @Id AND Status = 'Open'";

                    if (connection.Execute(ticketSql, new { Id = ticketId, TechnicianId = technicianId }, transaction) == 0)
                    {
                        throw new InvalidOperationException("Only an Open ticket can be moved to Under Repair.");
                    }

                    string equipmentSql = @"UPDATE Equipment SET Status = 'Under Repair'
                                            WHERE Id = (SELECT EquipmentId FROM MaintenanceLogs WHERE Id = @Id)";
                    connection.Execute(equipmentSql, new { Id = ticketId }, transaction);

                    transaction.Commit();
                }
            }
        }

        public void ResolveTicket(int ticketId, int? sparePartId)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    string ticketSql = @"UPDATE MaintenanceLogs SET Status = 'Resolved', DateResolved = NOW()
                                         WHERE Id = @Id AND Status = 'Under Repair'";

                    if (connection.Execute(ticketSql, new { Id = ticketId }, transaction) == 0)
                    {
                        throw new InvalidOperationException("Only a ticket that is Under Repair can be resolved.");
                    }

                    if (sparePartId.HasValue)
                    {
                        string stockSql = @"UPDATE SpareParts SET Quantity = Quantity - 1
                                            WHERE Id = @SparePartId AND Quantity > 0";

                        if (connection.Execute(stockSql, new { SparePartId = sparePartId.Value }, transaction) == 0)
                        {
                            throw new InvalidOperationException("The selected spare part is out of stock.");
                        }

                        string partSql = @"INSERT INTO MaintenanceParts (LogId, SparePartId, Quantity)
                                           VALUES (@LogId, @SparePartId, 1)";
                        connection.Execute(partSql, new { LogId = ticketId, SparePartId = sparePartId.Value }, transaction);
                    }

                  
                    string equipmentSql = @"UPDATE Equipment e SET e.Status = 'Active'
                                            WHERE e.Id = (SELECT EquipmentId FROM MaintenanceLogs WHERE Id = @Id)
                                            AND e.Status = 'Under Repair'
                                            AND NOT EXISTS (SELECT 1 FROM MaintenanceLogs o
                                                            WHERE o.EquipmentId = e.Id AND o.Status = 'Under Repair')";
                    connection.Execute(equipmentSql, new { Id = ticketId }, transaction);

                    transaction.Commit();
                }
            }
        }

        public List<SparePart> GetAllSpareParts()
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                string sql = "SELECT Id, Name, Category, Quantity, RestockLevel FROM SpareParts ORDER BY Name";
                return connection.Query<SparePart>(sql).ToList();
            }
        }
    }
}
