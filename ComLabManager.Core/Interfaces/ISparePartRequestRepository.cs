using ComLabManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.Core.Interfaces
{
    public interface ISparePartRequestRepository
    {
        IEnumerable<SparePartRequest> GetAllRequests();
        void UpdateRequestStatus(int requestId, string status); 
        void ApproveAndDeductInventory(int requestId);         
        void AddRequest(SparePartRequest request);
    }
}
