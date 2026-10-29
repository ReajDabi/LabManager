using System.Collections.Generic;
using ComLabManager.Core.Models;

namespace ComLabManager.Core.Interfaces
{
    public interface IPreventiveMaintenanceRepository
    {
        List<PreventiveMaintenanceTask> GetAllTasks();
        void AddTask(PreventiveMaintenance task);
        void UpdateTask(PreventiveMaintenance task);
        void DeleteTask(int id);
        void CompleteTask(int id);
    }
}
