using System.Collections.Generic;
using ComLabManager.Core.Models;

namespace ComLabManager.Core.Interfaces
{
    public interface IBorrowRequestRepository
    {
      
        void AddRequest(BorrowRequest request);
        IEnumerable<BorrowRequest> GetRequestsByStudent(int studentId);

        IEnumerable<BorrowRequest> GetPendingRequests();
        void UpdateRequestStatus(int requestId, string newStatus);
        IEnumerable<BorrowRequest> GetAllRequests();
       


        int GetPendingCount();
    }
}