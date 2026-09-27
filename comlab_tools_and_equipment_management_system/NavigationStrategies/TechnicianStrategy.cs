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

      public bool CanViewUsers => false;
        public bool CanViewScheduler => false;

        public string TicketButtonText => "My Tasks";

        public void LoadInitialView(MainForm form)
        {
          
            form.OpenTickets();
        }
    }
}
