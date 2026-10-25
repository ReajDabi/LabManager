using System;
using ComLabManager.Core.Interfaces;
namespace ComLabManager.Core.Models
{
    public class BorrowRequest: IApprovalRequest
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int? EquipmentId { get; set; } 
        public string TargetLocation { get; set; }
        public string Purpose { get; set; }
        public DateTime RequestedDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Schedule => $"{StartTime:hh\\:mm} - {EndTime:hh\\:mm}";
        public string Status { get; set; }
    }
}