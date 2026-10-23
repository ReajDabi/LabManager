using System;
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.UI.NavigationStrategies
{
    public class TechnicianStrategy : IRoleNavigationStrategy
    {
       
        public bool CanViewDashboard => false;
        public bool CanViewEquipment => false;

        public bool CanViewTickets => true;
        public bool CanViewSpareParts => true;
        public bool CanEditInventory => false;
        public bool UsesAdminApprovalView => false;
        public bool CanViewUsers => false;
        public bool CanViewScheduler => false;
        public bool CanViewRequest => false;

        public string TicketButtonText => "My Tasks";
        public string RequestButtonText => "Requests";
        public void LoadInitialView(MainForm form)
        {
          
            form.OpenTickets();
        }
    }
}
