using System;
using System.Collections.Generic;
using System.Text;
using ComLabManager.Core.Interfaces;

namespace ComLabManager.Core.Models
{
    public class SparePartRequest: IApprovalRequest
    {
        public int Id { get; set; }
        public int TechId { get; set; }
        public int RequestedPartId { get; set; }
        public int Quantity { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public DateTime RequestDate { get; set; }
        public string TechnicianName { get; set; }
        public string SparePartName { get; set; }
    }
}
