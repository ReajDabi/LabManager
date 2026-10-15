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

        public DashboardView(IEquipmentRepository equipmentRepo, IBorrowRequestRepository borrowRepo)
        {
            InitializeComponent();
            _equipmentRepo = equipmentRepo;

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
    }
}
