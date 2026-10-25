using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class DashboardView : UserControl
    {
        private readonly IDashboardRepository _dashboardRepo;
        private readonly IComLabScheduleRepository _scheduleRepo;

        public DashboardView(IDashboardRepository dashboardRepo, IComLabScheduleRepository scheduleRepo)
        {
            InitializeComponent();
            _dashboardRepo = dashboardRepo ?? throw new ArgumentNullException(nameof(dashboardRepo));
            _scheduleRepo = scheduleRepo ?? throw new ArgumentNullException(nameof(scheduleRepo));

            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

            dgvActionItems.DefaultCellStyle.ForeColor = Color.Black;
            dgvActionItems.AutoGenerateColumns = true;

            LoadMetrics();
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {
            LoadMetrics();
        }

        private void dgvActionItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (e.RowIndex >= 0 && dgvActionItems.Rows[e.RowIndex].DataBoundItem is Equipment currentEquipment)
            {
               
                if (currentEquipment.UsageCount >= 15)
                {
                    dgvActionItems.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    dgvActionItems.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGoldenrod; 
                }
            }
        }
        private void LoadMetrics()
        {
            if (_dashboardRepo == null) return;

            var metrics = _dashboardRepo.GetMetrics();

            lblValueEq.Text = metrics.TotalActiveAssets.ToString();
            lblValueUsage.Text = metrics.HighUsageFlags.ToString();
            lblValueBorrows.Text = metrics.PendingBorrowReqs.ToString();

           
            lblValuePM.Text = metrics.UpcomingPMTasks.ToString();

            dgvActionItems.DataSource = _dashboardRepo.GetUrgentTasks();
        }

        private void btnManageSchedules_Click(object sender, EventArgs e)
        {
            using (ManageSchedulesForm scheduleForm = new ManageSchedulesForm(_scheduleRepo))
            {
                if (scheduleForm.ShowDialog() == DialogResult.OK)
                {
                    
                    LoadMetrics();
                }
            }
        }
    }
}