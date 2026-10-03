using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class PreventiveMaintenanceView : UserControl
    {
        public PreventiveMaintenanceView()
        {
            InitializeComponent();
        }

        private void buttonScheduleTask_Click(object sender, EventArgs e)
        {
             ScheduleTaskForm scheduletaskform = new ScheduleTaskForm();
            scheduletaskform.ShowDialog();
        }
    }
}
