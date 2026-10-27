using System;   
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.Core.Models
{
    public class Equipment
    {
        // Equipment used this many times or more is flagged as high usage
        public const int HighUsageThreshold = 15;

        public int Id { get; set; }
        public string AssetTag { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public string? StationNumber { get; set; }
        public int UsageCount { get; set; }
        public DateTime DateAcquired { get; set; }
        public DateTime CreatedAt { get; set; }


    }
}
