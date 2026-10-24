using System;
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.Core.Interfaces
{
    public interface IApprovalRequest
    {
        int Id { get; set; }
        string Status { get; set; }
    }
}