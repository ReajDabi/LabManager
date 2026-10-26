using System;
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.Core.Models
{
    public class UserMaintenanceHistoryDto
    {
        public string AssetTag { get; set; }
        public string Issue { get; set; }
        public string Status { get; set; }
        public DateTime Reported { get; set; }
    }
}
