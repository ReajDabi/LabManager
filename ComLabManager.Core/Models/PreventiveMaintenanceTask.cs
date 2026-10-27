using System;
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.Core.Models
{
    // A PreventiveMaintenance row joined with its equipment and technician, as shown on the PM Scheduler
    public class PreventiveMaintenanceTask
    {
        public int Id { get; set; }
        public string TargetLocation { get; set; }
        public int? EquipmentId { get; set; }
        public string? AssetTag { get; set; }
        public string? EquipmentName { get; set; }
        public string TaskName { get; set; }
        public string Frequency { get; set; }
        public DateTime? LastCompleted { get; set; }
        public DateTime NextDueDate { get; set; }
        public int? AssignedTo { get; set; }
        public string? AssignedToName { get; set; }
    }
}
