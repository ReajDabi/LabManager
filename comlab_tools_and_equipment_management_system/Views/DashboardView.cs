using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using ComLabManager.UI.Navigation;
using ComLabManager.UI.Views.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class DashboardView : UserControl
    {
        private readonly IDashboardRepository _dashboardRepo;
        private readonly IComLabScheduleRepository _scheduleRepo;
        private readonly Action<AppPage, ViewFilter> _navigate;

        // Where each card takes the user, the same idea as MainForm's navigation map
        private readonly Dictionary<KpiCard, (AppPage Page, ViewFilter Filter)> _cardRoutes;

        public DashboardView(IDashboardRepository dashboardRepo, IComLabScheduleRepository scheduleRepo, Action<AppPage, ViewFilter> navigate)
        {
            InitializeComponent();
            _dashboardRepo = dashboardRepo ?? throw new ArgumentNullException(nameof(dashboardRepo));
            _scheduleRepo = scheduleRepo ?? throw new ArgumentNullException(nameof(scheduleRepo));
            _navigate = navigate ?? throw new ArgumentNullException(nameof(navigate));

            _cardRoutes = new Dictionary<KpiCard, (AppPage, ViewFilter)>
            {
                { cardActiveAssets, (AppPage.Equipment, ViewFilter.ActiveAssets) },
                { cardHighUsage, (AppPage.Equipment, ViewFilter.HighUsage) },
                { cardPendingApprovals, (AppPage.Approvals, ViewFilter.PendingApprovals) },
                { cardUpcomingPM, (AppPage.Scheduler, ViewFilter.None) },
                { cardDamaged, (AppPage.Equipment, ViewFilter.UnderRepair) },
                { cardLowStock, (AppPage.SpareParts, ViewFilter.LowStock) },
                { cardActiveBorrowers, (AppPage.Approvals, ViewFilter.ActiveBorrows) },
                { cardOverdue, (AppPage.Approvals, ViewFilter.Overdue) }
            };

            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

            dgvActionItems.DefaultCellStyle.ForeColor = Color.Black;
            dgvActionItems.AutoGenerateColumns = true;

            LoadMetrics();
            refreshTimer.Start();
        }

        private void LoadMetrics()
        {
            try
            {
                var metrics = _dashboardRepo.GetMetrics();

                cardActiveAssets.Value = metrics.TotalActiveAssets.ToString();
                cardHighUsage.Value = metrics.HighUsageFlags.ToString();
                cardPendingApprovals.Value = metrics.PendingApprovals.ToString();
                cardUpcomingPM.Value = metrics.UpcomingPMTasks.ToString();
                cardDamaged.Value = metrics.DamagedEquipment.ToString();
                cardLowStock.Value = metrics.LowStockParts.ToString();
                cardActiveBorrowers.Value = metrics.ActiveBorrowers.ToString();
                cardOverdue.Value = metrics.OverdueItems.ToString();

                dgvActionItems.DataSource = _dashboardRepo.GetUrgentTasks();
            }
            catch (Exception ex)
            {
                refreshTimer.Stop();
                MessageBox.Show($"An error occurred while loading the dashboard: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Card_Click(object? sender, EventArgs e)
        {
            if (sender is KpiCard card && _cardRoutes.TryGetValue(card, out var route))
            {
                // Navigating disposes this view, so wait until the click has finished processing
                BeginInvoke(new Action(() => _navigate(route.Page, route.Filter)));
            }
        }

        private void refreshTimer_Tick(object? sender, EventArgs e) => LoadMetrics();

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
