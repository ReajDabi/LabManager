using System.Collections.Generic;
using ComLabManager.Core.Models;

namespace ComLabManager.Core.Interfaces
{
    public interface IBorrowRequestRepository
    {
        IEnumerable<BorrowRequest> GetAllRequests();
        void UpdateRequestStatus(int requestId, string status);
        void AddRequest(BorrowRequest request);
        IEnumerable<BorrowRequest> GetRequestsByStudent(int studentId);

        IEnumerable<BorrowRequest> GetPendingRequests();
       

      
        int GetPendingCount();
    }
}