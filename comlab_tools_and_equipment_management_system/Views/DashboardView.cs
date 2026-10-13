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
        
        public DashboardView(IEquipmentRepository equipmentRepo)
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
            lblValueEq.Text = _equipmentRepo.GetTotalActiveCount().ToString();
            lblValueUsage.Text = _equipmentRepo.GetHighUsageCount().ToString();
        }
    }
}
