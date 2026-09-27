using System;
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.UI.NavigationStrategies
{
    public class AdminStrategy : IRoleNavigationStrategy
    {
        public bool CanViewDashboard => true;
        public bool CanViewEquipment => true;
        public bool CanViewTickets => true;
        public bool CanViewSpareParts => true;
        public bool CanViewScheduler => true;

        public bool CanViewUsers => true;
        public string TicketButtonText => "Maintenance Tickets";

        public void LoadInitialView(MainForm form)
        {
            form.OpenDashboard();
        }
    }
}
