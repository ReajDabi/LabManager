using ComLabManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.Core.Interfaces
{
    public interface IDashboardRepository
    {
        DashboardMetrics GetMetrics();
        IEnumerable<UrgentTask> GetUrgentTasks();
    }
}

namespace ComLabManager.Core.Models
{
    public class DashboardMetrics
    {
        public int TotalActiveAssets { get; set; }
        public int HighUsageFlags { get; set; }
        public int PendingBorrowReqs { get; set; }
        public int UpcomingPMTasks { get; set; }
    }

    public class UrgentTask
    {
        public string Type { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
    }
}
