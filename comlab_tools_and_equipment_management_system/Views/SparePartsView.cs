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
        private readonly ISparePartRepository _sparePartRepo;
        private readonly ISparePartRequestRepository _partRequestRepo;

        public SparePartsView(int currentUserId, bool canEditInventory, ISparePartRepository sparePartRepo, ISparePartRequestRepository partRequestRepo)
        {
            InitializeComponent();

            _currentUserId = currentUserId;
            _sparePartRepo = sparePartRepo ?? throw new ArgumentNullException(nameof(sparePartRepo));
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

            foreach (DataGridViewColumn col in dgvSpareParts.Columns)
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
            if (_sparePartRepo != null)
            {
                dgvSpareParts.AutoGenerateColumns = false;
                dgvSpareParts.DataSource = _sparePartRepo.GetAllSpareParts();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dgvSpareParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a spare part row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedPart = (SparePart)dgvSpareParts.SelectedRows[0].DataBoundItem;
            var result = MessageBox.Show($"Are you sure you want to delete '{selectedPart.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _sparePartRepo.DeleteSparePart(selectedPart.Id);
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvSpareParts_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvSpareParts.IsCurrentCellDirty)
            {
               
                dgvSpareParts.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dgvSpareParts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

           string dataPropertyName = dgvSpareParts.Columns[e.ColumnIndex].DataPropertyName;

            if (dataPropertyName == "Quantity")
            {
                var sparePart = dgvSpareParts.Rows[e.RowIndex].DataBoundItem as SparePart;
                if (sparePart != null)
                {
                    try
                    {
                        if (sparePart.Quantity < 0)
                        {
                            MessageBox.Show("Quantity cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            RefreshGrid();
                            return;
                        }

                        _sparePartRepo.UpdateSparePartQuantity(sparePart.Id, sparePart.Quantity);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to update quantity: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RefreshGrid();
                    }
                }
            }
        }
        private void buttonAddSparePart_Click(object sender, EventArgs e)
        {
            using (AddSparePartForm addForm = new AddSparePartForm(_sparePartRepo))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        private void btnRequestPart_Click(object sender, EventArgs e)
        {
            var availableParts = _sparePartRepo.GetAllSpareParts();

            if (availableParts == null || !availableParts.Any())
            {
                MessageBox.Show("No spare parts available in the inventory.", "Empty Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SparePartModalForm modal = new SparePartModalForm(_currentUserId, availableParts))
            {
                if (modal.ShowDialog() == DialogResult.OK && modal.ProcessedRequest != null)
                {
                    try
                    {
                        _partRequestRepo.AddRequest(modal.ProcessedRequest);
                        MessageBox.Show("Part request submitted to the Admin for approval.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while submitting the request: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvSpareParts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSpareParts.Rows[e.RowIndex].DataBoundItem is SparePart currentPart)
            {
                if (currentPart.Quantity <= currentPart.RestockLevel)
                {
                    
                    e.CellStyle.BackColor = Color.FromArgb(255, 204, 204);
                    e.CellStyle.ForeColor = Color.DarkRed;

                  
                    e.CellStyle.SelectionBackColor = Color.IndianRed;
                    e.CellStyle.SelectionForeColor = Color.White;
                }
            }
        }

        private void dgvSpareParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || !_canEditInventory) return;

            string colName = dgvSpareParts.Columns[e.ColumnIndex].Name;
            var part = (SparePart)dgvSpareParts.Rows[e.RowIndex].DataBoundItem;
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
                _sparePartRepo.UpdateSparePart(part);
                RefreshGrid();
            }
        }
    }
}