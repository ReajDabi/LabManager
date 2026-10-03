using ComLabManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComLabManager.UI.Views
{
    public partial class StudentDashboardView : UserControl
    {
        private readonly IEquipmentRepository _equipmentRepo;

        public StudentDashboardView()
        {
            InitializeComponent();

        }

        public StudentDashboardView(IEquipmentRepository equipmentRepo)
        {
            _equipmentRepo = equipmentRepo ?? throw new ArgumentNullException(nameof(equipmentRepo));
            InitializeComponent();
        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {

            using (BorrowModalForm form = new BorrowModalForm(_equipmentRepo))
            {
                form.ShowDialog();
            }
        }

        private void btnToggleSchedule_Click(object sender, EventArgs e)
        {
            pnlSchedules.BringToFront();


            btnToggleSchedule.BackColor = Color.FromArgb(0, 120, 215);


            btnToggleBorrow.BackColor = Color.FromArgb(30, 41, 59);
        }

        private void btnToggleBorrow_Click(object sender, EventArgs e)
        {
            pnlBorrow.BringToFront();


            btnToggleBorrow.BackColor = Color.FromArgb(0, 120, 215);


            btnToggleSchedule.BackColor = Color.FromArgb(30, 41, 59);
        }
    }
}
