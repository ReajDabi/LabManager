using System.Collections.Generic;
using ComLabManager.Core.Models;

namespace ComLabManager.Core.Interfaces
{
    public interface IMaintenanceRepository
    {
        List<MaintenanceTicket> GetAllTickets();
        int CreateTicket(MaintenanceLog log);
        void AssignTechnician(int ticketId, int technicianId);
        void StartRepair(int ticketId, int? technicianId);
        void ResolveTicket(int ticketId, int? sparePartId);
    }
}