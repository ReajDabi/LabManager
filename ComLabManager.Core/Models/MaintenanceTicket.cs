using System;
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.Core.Models
{
    // A MaintenanceLog joined with its equipment and the spare part used, as shown on the task board
    public class MaintenanceTicket
    {
        public int Id { get; set; }
        public string AssetTag { get; set; }
        public string EquipmentName { get; set; }
        public string IssueDescription { get; set; }
        public string Status { get; set; }
        public string? SparePartName { get; set; }
        public int? AssignedTechnicianId { get; set; }
        public string? AssignedTechnicianName { get; set; }
        public DateTime DateReported { get; set; }
    }
}
