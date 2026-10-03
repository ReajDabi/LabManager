using System;
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.Core.Models
{
    public class SparePartRequest
    {
        public int Id { get; set; }
        public int TechId { get; set; }
        public int RequestPartId { get; set; }
        public int Quantity { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public DateTime RequestDate { get; set; }

    }
}
