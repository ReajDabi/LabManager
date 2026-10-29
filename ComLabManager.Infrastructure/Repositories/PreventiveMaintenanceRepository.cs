using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComLabManager.Infrastructure.Repositories
{
    public class PreventiveMaintenanceRepository : IPreventiveMaintenanceRepository
    {
        private readonly string _connectionString;

        public PreventiveMaintenanceRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<PreventiveMaintenanceTask> GetAllTasks()
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                string sql = @"SELECT pm.Id, pm.TargetLocation, pm.EquipmentId, e.AssetTag, e.Name AS EquipmentName,
                                      pm.TaskName, pm.Frequency, pm.LastCompleted, pm.NextDueDate, pm.AssignedTo,
                                      COALESCE(NULLIF(TRIM(CONCAT_WS(' ', u.FirstName, u.LastName)), ''), u.Username) AS AssignedToName
                               FROM PreventiveMaintenance pm
                               LEFT JOIN Equipment e ON e.Id = pm.EquipmentId
                               LEFT JOIN Users u ON u.Id = pm.AssignedTo
                               ORDER BY pm.NextDueDate, pm.Id";

                return connection.Query<PreventiveMaintenanceTask>(sql).ToList();
            }
        }

        public void AddTask(PreventiveMaintenance task)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                string sql = @"INSERT INTO PreventiveMaintenance (TargetLocation, EquipmentId, TaskName, Frequency, NextDueDate, AssignedTo)
                               VALUES (@TargetLocation, @EquipmentId, @TaskName, @Frequency, @NextDueDate, @AssignedTo)";

                connection.Execute(sql, task);
            }
        }

        public void UpdateTask(PreventiveMaintenance task)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                string sql = @"UPDATE PreventiveMaintenance
                               SET TargetLocation = @TargetLocation, EquipmentId = @EquipmentId, TaskName = @TaskName,
                                   Frequency = @Frequency, NextDueDate = @NextDueDate, AssignedTo = @AssignedTo
                               WHERE Id = @Id";

                if (connection.Execute(sql, task) == 0)
                {
                    throw new InvalidOperationException("This task no longer exists.");
                }
            }
        }

        public void DeleteTask(int id)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                string sql = "DELETE FROM PreventiveMaintenance WHERE Id = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }

        public void CompleteTask(int id)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                // The next due date rolls forward from today based on the task's frequency
                string sql = @"UPDATE PreventiveMaintenance
                               SET LastCompleted = CURDATE(),
                                   NextDueDate = CASE Frequency
                                                     WHEN 'Weekly' THEN DATE_ADD(CURDATE(), INTERVAL 1 WEEK)
                                                     WHEN 'Monthly' THEN DATE_ADD(CURDATE(), INTERVAL 1 MONTH)
                                                     WHEN 'Quarterly' THEN DATE_ADD(CURDATE(), INTERVAL 3 MONTH)
                                                     WHEN 'Biannually' THEN DATE_ADD(CURDATE(), INTERVAL 6 MONTH)
                                                     WHEN 'Annually' THEN DATE_ADD(CURDATE(), INTERVAL 1 YEAR)
                                                     ELSE DATE_ADD(CURDATE(), INTERVAL 1 MONTH)
                                                 END
                               WHERE Id = @Id";

                if (connection.Execute(sql, new { Id = id }) == 0)
                {
                    throw new InvalidOperationException("This task no longer exists.");
                }
            }
        }
    }
}
