using System;
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.Core.Models
{
    public class MaintenanceLog
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public int ReportedById { get; set; }
        public string IssueDescription { get; set; }
        public string Status { get; set; }
        public DateTime DateReported { get; set; }
        public DateTime? DateResolved { get; set; }
    }
}
