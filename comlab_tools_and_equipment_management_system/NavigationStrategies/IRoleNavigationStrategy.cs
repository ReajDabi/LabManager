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
        string TicketButtonText { get; }
        string RequestButtonText { get; }
        void LoadInitialView(MainForm form);
    }
}
