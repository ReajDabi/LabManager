using System;
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.Core.Models
{
    public class ComLabSchedule
    {
        public int Id { get; set; }
        public string ComLabName { get; set; }
        public string SubjectCode { get; set; }
        public string InstructorName { get; set; }
        public string DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

    }
}
