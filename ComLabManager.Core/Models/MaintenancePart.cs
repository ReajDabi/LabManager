using System;
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.Core.Models
{
    public class MaintenancePart
    {
        public int Id { get; set; }
        public int LogId { get; set; }
        public int SparePartId { get; set; }
        public int Quantity { get; set; }
    }
}
