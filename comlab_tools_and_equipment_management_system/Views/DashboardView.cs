using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComLabManager.Core.Interfaces;

namespace ComLabManager.UI
{
    public partial class DashboardView : UserControl
    {
        private readonly IEquipmentRepository _equipmentRepo;
        IBorrowRequestRepository _borrowRepo;
        private readonly IComLabScheduleRepository _scheduleRepo;

        public DashboardView(IEquipmentRepository equipmentRepo, IBorrowRequestRepository borrowRepo, IComLabScheduleRepository scheduleRepo)
        {
            InitializeComponent();
            _equipmentRepo = equipmentRepo;
            _scheduleRepo = scheduleRepo ?? throw new ArgumentNullException(nameof(scheduleRepo));
        

        lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {
            LoadMetrics();
        }

        private void LoadMetrics()
        {
            lblValueBorrows.Text = _borrowRepo.GetPendingCount().ToString();
            lblValueEq.Text = _equipmentRepo.GetTotalActiveCount().ToString();
            lblValueUsage.Text = _equipmentRepo.GetHighUsageCount().ToString();
        }

        private void btnManageSchedules_Click(object sender, EventArgs e)
        {
            using (ManageSchedulesForm scheduleForm = new ManageSchedulesForm(_scheduleRepo))
            {
                scheduleForm.ShowDialog();
            }
        }
    }
}
