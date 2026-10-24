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
        public int RequestPartId { get; set; }
        public int Quantity { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public DateTime RequestDate { get; set; }
        public string TechName { get; set; }
        public string PartName { get; set; }
    }
}
