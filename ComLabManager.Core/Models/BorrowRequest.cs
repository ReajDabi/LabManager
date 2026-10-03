using System;
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.Core.Models
{
    public class BorrowRequest
    {

        public int Id { get; set; }
        public int StudentId { get; set; }

        public int? EquipmentId { get; set; }
        public string TargetLocation{ get; set; }
        public string Purpose { get; set; }
        public DateTime RequestDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Status { get; set; }
    }
}
