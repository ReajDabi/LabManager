using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using ComLabManager.UI.Navigation;
using MySql.Data.MySqlClient;

namespace ComLabManager.UI.Views
{
    public partial class EquipmentInventoryView : UserControl, IFilterableView
    {
        private readonly IEquipmentRepository _equipmentRepo;
        private bool _highUsageOnly;

        private readonly Dictionary<string, (Color Back, Color Fore)> _statusColors;

        public EquipmentInventoryView(IEquipmentRepository equipmentRepo)
        {
            InitializeComponent();
            _equipmentRepo = equipmentRepo;

            dgvEquipment.AutoGenerateColumns = false;
            _statusColors = new Dictionary<string, (Color, Color)>
            {
                { "Under Repair", (Color.FromArgb(248, 215, 218), Color.FromArgb(114, 28, 36)) },
                { "Active", (Color.White, Color.Black) }
            };

            filterBanner.Cleared += (s, e) =>
            {
                _highUsageOnly = false;
                ApplyFilters();
            };
        }

        public void ApplyFilter(ViewFilter filter)
        {
            switch (filter)
            {
                case ViewFilter.ActiveAssets:
                    cmbStatusFilter.SelectedItem = "Active";
                    break;
                case ViewFilter.UnderRepair:
                    cmbStatusFilter.SelectedItem = "Under Repair";
                    break;
                case ViewFilter.HighUsage:
                    _highUsageOnly = true;
                    filterBanner.ShowFilter($"High usage equipment ({Equipment.HighUsageThreshold}+ uses)");
                    ApplyFilters();
                    break;
            }
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
            if (e.RowIndex >= 0 && dgvEquipment.Rows[e.RowIndex].DataBoundItem is Equipment currentEquipment)
            {
                if (currentEquipment.UsageCount >= Equipment.HighUsageThreshold)
                {
                    e.CellStyle.BackColor = Color.LightGoldenrodYellow;
                    e.CellStyle.ForeColor = Color.DarkGoldenrod;
                    e.CellStyle.SelectionBackColor = Color.Goldenrod;
                    e.CellStyle.SelectionForeColor = Color.White;
                }
            }
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
          
            using (AddEquipmentForm form = new AddEquipmentForm(_equipmentRepo))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveEquipment(() => _equipmentRepo.AddEquipment(form.ProcessedEquipment), form.ProcessedEquipment.AssetTag, "adding");
                }
            }
        }

        private void SaveEquipment(Action saveAction, string assetTag, string actionName)
        {
            try
            {
                saveAction();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show($"The asset tag '{assetTag}' is already in use.", "Duplicate Asset Tag", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while {actionName} the equipment: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ApplyFilters();
        }

        private void btnEditEquipment_Click(object sender, EventArgs e)
        {
            if (dgvEquipment.SelectedRows.Count == 0) return;

            Equipment selectedEquipment = (Equipment)dgvEquipment.SelectedRows[0].DataBoundItem;

           
            using (AddEquipmentForm form = new AddEquipmentForm(selectedEquipment, _equipmentRepo))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SaveEquipment(() => _equipmentRepo.UpdateEquipment(form.ProcessedEquipment), form.ProcessedEquipment.AssetTag, "updating");
                }
            }
        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            if (dgvEquipment.SelectedRows.Count == 0) return;

            Equipment selectedEquipment = (Equipment)dgvEquipment.SelectedRows[0].DataBoundItem;

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to permanently delete {selectedEquipment.AssetTag}?{Environment.NewLine}{Environment.NewLine}" +
                "This also removes its maintenance tickets, borrow requests, and preventive maintenance tasks.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                SaveEquipment(() => _equipmentRepo.DeleteEquipment(selectedEquipment.Id), selectedEquipment.AssetTag, "deleting");
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
                (selectedStatus == "All Statuses" || e.Status == selectedStatus) &&
                (!_highUsageOnly || e.UsageCount >= Equipment.HighUsageThreshold)
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