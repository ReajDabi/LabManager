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

        // Tells the form which page to load first
        void LoadInitialView(MainForm form);
    }
}
