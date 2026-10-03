using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class MaintenanceView : UserControl
    {
        public MaintenanceView()
        {
            InitializeComponent();
        }

        private void buttonCreateTicket_Click(object sender, EventArgs e)
        {
            CreateTicketForm ticketForm = new CreateTicketForm();
            ticketForm.ShowDialog();
        }
    }
}
