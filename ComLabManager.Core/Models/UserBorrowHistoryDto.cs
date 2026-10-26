using System;
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.Core.Models
{
    public class UserBorrowHistoryDto
    {
        public string Location { get; set; }
        public string Purpose { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Status { get; set; }
    }
}
