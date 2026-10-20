using System.Collections.Generic;
using ComLabManager.Core.Models;

namespace ComLabManager.Core.Interfaces
{
    public interface ISparePartRequestRepository
    {
        IEnumerable<SparePartRequest> GetAllRequests();
        void UpdateRequestStatus(int requestId, string status);
    }
}