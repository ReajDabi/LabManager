using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;

namespace ComLabManager.UI.Views
{
    public partial class EquipmentInventoryView : UserControl
    {
        private readonly IEquipmentRepository _equipmentRepo;

       
        private readonly Dictionary<string, (Color Back, Color Fore)> _statusColors;

        public EquipmentInventoryView(IEquipmentRepository equipmentRepo)
        {
            InitializeComponent();
            _equipmentRepo = equipmentRepo;

            dgvEquipment.AutoGenerateColumns = false;
            _statusColors = new Dictionary<string, (Color, Color)>
            {
                { "High Usage", (Color.FromArgb(255, 243, 205), Color.FromArgb(133, 100, 4)) },
                { "Under Repair", (Color.FromArgb(248, 215, 218), Color.FromArgb(114, 28, 36)) },
                { "Active", (Color.White, Color.Black) }
            };
        }

        private void EquipmentInventoryView_Load(object sender, EventArgs e)
        {
            if (cmbCategoryFilter.Items.Count > 0) cmbCategoryFilter.SelectedIndex = 0;
            if (cmbStatusFilter.Items.Count > 0) cmbStatusFilter.SelectedIndex = 0;

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            if (_equipmentRepo != null)
            {
                var equipmentList = _equipmentRepo.GetAllEquipment();
                dgvEquipment.DataSource = equipmentList;
            }
        }

        private void dgvEquipment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvEquipment.Rows[e.RowIndex].Cells["Status"].Value != null)
            {
                string status = dgvEquipment.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                DataGridViewRow row = dgvEquipment.Rows[e.RowIndex];

                
                if (_statusColors.TryGetValue(status, out var colors))
                {
                    row.DefaultCellStyle.BackColor = colors.Back;
                    row.DefaultCellStyle.ForeColor = colors.Fore;
                }
                else
                {
                    
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            EquipmentModalForm form = new EquipmentModalForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
               
                _equipmentRepo.AddEquipment(form.ProcessedEquipment);
                RefreshGrid();
            }
        }

        private void btnEditEquipment_Click(object sender, EventArgs e)
        {
            if (dgvEquipment.SelectedRows.Count == 0) return;

            Equipment selectedEquipment = (Equipment)dgvEquipment.SelectedRows[0].DataBoundItem;

            EquipmentModalForm form = new EquipmentModalForm(selectedEquipment);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _equipmentRepo.UpdateEquipment(form.ProcessedEquipment);
                RefreshGrid();
            }
        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            if (dgvEquipment.SelectedRows.Count == 0) return;

            Equipment selectedEquipment = (Equipment)dgvEquipment.SelectedRows[0].DataBoundItem;

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to permanently delete {selectedEquipment.AssetTag}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _equipmentRepo.DeleteEquipment(selectedEquipment.Id);
                RefreshGrid();
            }
        }
       
        private void ApplyFilters()
        {
            
            string keyword = txtSearch.Text.Trim();
            string selectedCategory = cmbCategoryFilter.SelectedItem?.ToString() ?? "All Categories";
            string selectedStatus = cmbStatusFilter.SelectedItem?.ToString() ?? "All Statuses";

          
            var baseList = string.IsNullOrWhiteSpace(keyword)
                ? _equipmentRepo.GetAllEquipment()
                : _equipmentRepo.SearchEquipment(keyword);

           
            var filteredList = baseList.Where(e =>
                (selectedCategory == "All Categories" || e.Category == selectedCategory) &&
                (selectedStatus == "All Statuses" || e.Status == selectedStatus)
            ).ToList();

          
            dgvEquipment.DataSource = filteredList;
        }

        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}