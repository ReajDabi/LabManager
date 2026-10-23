using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using ComLabManager.UI.Views;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class SparePartsView : UserControl
    {
        private readonly int _currentUserId;
        private readonly bool _canEditInventory;
        private readonly IMaintenanceRepository _maintenanceRepo;
        private readonly ISparePartRequestRepository _partRequestRepo;
     

        public SparePartsView(int currentUserId,  bool canEditInventory, IMaintenanceRepository maintenanceRepo, ISparePartRequestRepository partRequestRepo)
        {
            InitializeComponent();

            _currentUserId = currentUserId;
           
            _maintenanceRepo = maintenanceRepo ?? throw new ArgumentNullException(nameof(maintenanceRepo));
            _partRequestRepo = partRequestRepo ?? throw new ArgumentNullException(nameof(partRequestRepo));
            _canEditInventory = canEditInventory;

            ConfigureUI();
            RefreshGrid();
        }

        private void ConfigureUI()
        {
            buttonAddSparePart.Visible = _canEditInventory;
            buttonDelete.Visible = _canEditInventory;
            btnRequestPart.Visible = !_canEditInventory;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (!_canEditInventory && col.DataPropertyName != "Name" && col.DataPropertyName != "Category" && col.DataPropertyName != "Quantity")
                {
                    col.Visible = false;
                }
                else
                {
                    col.Visible = true;
                }
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
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a spare part row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedPart = (SparePart)dataGridView1.SelectedRows[0].DataBoundItem;
            var result = MessageBox.Show($"Are you sure you want to delete '{selectedPart.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _maintenanceRepo.DeleteSparePart(selectedPart.Id);
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot delete this part because it is currently linked to an active request.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAddSparePart_Click(object sender, EventArgs e)
        {
            using (AddSparePartForm addForm = new AddSparePartForm(_maintenanceRepo))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid(); 
                }
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || !_canEditInventory) return;

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            var part = (SparePart)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            bool needsUpdate = true;

            switch (colName)
            {
                case "minus" when part.Quantity > 0:
                    part.Quantity--;
                    break;
                case "plus":
                    part.Quantity++;
                    break;
                case "restockminus" when part.RestockLevel > 0:
                    part.RestockLevel--;
                    break;
                case "restockplus":
                    part.RestockLevel++;
                    break;
                default:
                    needsUpdate = false; 
                    break;
            }

            if (needsUpdate)
            {
                _maintenanceRepo.UpdateSparePart(part);
                RefreshGrid();
            }
        }
    }
}