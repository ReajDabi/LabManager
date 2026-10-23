using System;
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.UI.NavigationStrategies
{
    public interface IRoleNavigationStrategy
    {
        bool CanViewDashboard { get; }
        bool CanViewEquipment { get; }
        bool CanViewTickets { get; }
        bool CanViewSpareParts { get; }
        bool CanViewScheduler { get; }
        bool CanViewUsers { get; }
        bool CanViewRequest { get; }
        string TicketButtonText { get; }
        string RequestButtonText { get; }
        bool CanEditInventory { get; }
        bool UsesAdminApprovalView { get; }
        void LoadInitialView(MainForm form);
    }
}
