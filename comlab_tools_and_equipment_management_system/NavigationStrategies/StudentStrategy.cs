using System;
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.UI.NavigationStrategies
{
    public class StudentStrategy : IRoleNavigationStrategy
    {
        public bool CanViewDashboard => false;
        public bool CanViewEquipment => false;
        public bool CanViewTickets => true;
        public bool CanViewSpareParts => false;
        public bool CanViewScheduler => false;
        public bool CanViewUsers => false;
        public bool CanViewRequest => true;
        public bool CanEditInventory => false;
        public bool UsesAdminApprovalView => false;
        public string TicketButtonText => "Report Issue";
        public string RequestButtonText => "Requests";
        public void LoadInitialView(MainForm form)
        {
            form.OpenStudentDashboard();
        }
    }
}
