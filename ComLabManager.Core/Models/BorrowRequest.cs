using System;
using ComLabManager.Core.Interfaces;
namespace ComLabManager.Core.Models
{
    public class BorrowRequest: IApprovalRequest
    {
        // Statuses that mean the item is still out with the student
        public static readonly string[] ActiveLoanStatuses = { "Approved", "In Use" };

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

        // An end time at or before the start time means the booking runs overnight into the next day.
        // Keep in sync with BorrowRequestSql.OverdueCondition in Infrastructure.
        public DateTime DueAt => RequestedDate.Date.Add(EndTime).AddDays(EndTime <= StartTime ? 1 : 0);

        public bool IsActiveLoan => EquipmentId.HasValue && Array.IndexOf(ActiveLoanStatuses, Status) >= 0;

        public bool IsOverdue => IsOverdueAt(DateTime.Now);

        public bool IsOverdueAt(DateTime now) => IsActiveLoan && now > DueAt;
    }
}
