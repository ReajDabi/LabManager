using System;

namespace ComLabManager.Core.Models
{
    public class UnifiedScheduleDto
    {
        public string ComLabName { get; set; }
        public string Subject { get; set; }
        public string Instructor { get; set; }
        public string DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string BookingType { get; set; }
    }
}