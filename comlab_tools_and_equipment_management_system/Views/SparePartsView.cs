using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ComLabManager.UI 
{

    //TODO: make the add and minus button sa grid works, then dapat dili pede mag add og minus button ang tech
    public partial class SparePartsView : UserControl
    {
        private readonly int _currentUserId;
        private readonly string _userRole;
        private readonly IMaintenanceRepository _maintenanceRepo;
        private readonly ISparePartRequestRepository _partRequestRepo;

        public SparePartsView(int currentUserId, string userRole, IMaintenanceRepository maintenanceRepo, ISparePartRequestRepository partRequestRepo)
        {
            InitializeComponent();

            _currentUserId = currentUserId;
            _userRole = userRole;
            _maintenanceRepo = maintenanceRepo ?? throw new ArgumentNullException(nameof(maintenanceRepo));
            _partRequestRepo = partRequestRepo ?? throw new ArgumentNullException(nameof(partRequestRepo));

            ConfigureUI();
            RefreshGrid();
        }

        private void ConfigureUI()
        {

            if (_userRole == "Technician")
            {
                buttonAddSparePart.Visible = false;
                buttonDelete.Visible = false;
                btnRequestPart.Visible = true;
            }
            else if (_userRole == "Admin")
            {
                buttonAddSparePart.Visible = true;
                buttonDelete.Visible = true;
                btnRequestPart.Visible = false;
            }
        }

        private void RefreshGrid()
        {
            if (_maintenanceRepo != null)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = _maintenanceRepo.GetAllSpareParts();
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteSparePartForm deletesparepartform = new DeleteSparePartForm();
            deletesparepartform.ShowDialog();
            RefreshGrid();
        }

        private void buttonAddSparePart_Click(object sender, EventArgs e)
        {
            AddSparePartForm addsparepartform = new AddSparePartForm();
            addsparepartform.ShowDialog();
            RefreshGrid();
        }


        private void btnRequestPart_Click(object sender, EventArgs e)
        {
            var availableParts = _maintenanceRepo.GetAllSpareParts();

            if (availableParts == null || !availableParts.Any())
            {
                MessageBox.Show("No spare parts available in the inventory.", "Empty Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SparePartModalForm modal = new SparePartModalForm(_currentUserId, availableParts))
            {
                if (modal.ShowDialog() == DialogResult.OK && modal.ProcessedRequest != null)
                {
                    _partRequestRepo.AddRequest(modal.ProcessedRequest);
                    MessageBox.Show("Part request submitted to the Admin for approval.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].DataBoundItem is SparePart currentPart)
            {
               
                if (currentPart.Quantity <= currentPart.RestockLevel)
                {
                    
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204); 
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                }
            }
        }
    }
}