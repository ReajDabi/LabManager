using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComLabManager.UI.Views
{
    public partial class AdminApprovalsView : UserControl
    {
        public AdminApprovalsView()
        {
            InitializeComponent();
            btnToggleBorrow_Click(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnToggleBorrow_Click(object sender, EventArgs e)
        {
            pnlBorrowRequests.BringToFront();

           
            btnToggleBorrow.BackColor = Color.FromArgb(0, 120, 215);

            
            btnToggleParts.BackColor = Color.FromArgb(30, 41, 59);

        }

        private void btnToggleParts_Click(object sender, EventArgs e)
        {
            
            pnlPartRequests.BringToFront();

            
            btnToggleParts.BackColor = Color.FromArgb(0, 120, 215);

            
            btnToggleBorrow.BackColor = Color.FromArgb(30, 41, 59);
        }
    }
}
