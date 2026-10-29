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
                string? frequency = connection.ExecuteScalar<string?>("SELECT Frequency FROM PreventiveMaintenance WHERE Id = @Id", new { Id = id });

                if (frequency == null)
                {
                    throw new InvalidOperationException("This task no longer exists.");
                }

                // The next due date rolls forward from today, using the same rule as the Schedule Task form
                DateTime today = DateTime.Today;
                string sql = @"UPDATE PreventiveMaintenance
                               SET LastCompleted = @Today, NextDueDate = @NextDueDate
                               WHERE Id = @Id";

                connection.Execute(sql, new { Id = id, Today = today, NextDueDate = PmFrequency.NextDueDate(today, frequency) });
            }
        }
    }
}
