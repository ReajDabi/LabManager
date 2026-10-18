using System;
using System.Windows.Forms;
using ComLabManager.Core.Models;

namespace ComLabManager.UI
{
    public partial class EquipmentModalForm : Form
    {
        public Equipment ProcessedEquipment { get; private set; }
        private readonly int _existingId;
        private readonly int _existingUsageCount;

        public EquipmentModalForm()
        {
            InitializeComponent();
            PopulateDropdowns(); 

            lblTitle.Text = "Add New Equipment";
            _existingId = 0;
            _existingUsageCount = 0;
            dtpDateAcquired.Value = DateTime.Now;
        }

        public EquipmentModalForm(Equipment equipmentToEdit)
        {
            InitializeComponent();
            PopulateDropdowns(); 

            lblTitle.Text = "Edit Equipment";
            _existingId = equipmentToEdit.Id;
            _existingUsageCount = equipmentToEdit.UsageCount;

            txtAssetTag.Text = equipmentToEdit.AssetTag;
            txtName.Text = equipmentToEdit.Name;
            cmbCategory.SelectedItem = equipmentToEdit.Category;
            cmbStatus.SelectedItem = equipmentToEdit.Status;
            txtLocation.Text = equipmentToEdit.StationNumber;
            dtpDateAcquired.Value = equipmentToEdit.DateAcquired;
        }

        private void PopulateDropdowns()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new string[] { "System Unit", "Monitor", "Peripheral", "Networking", "Tool" });

            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[] { "Active", "High Usage", "Under Repair", "Decommissioned" });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAssetTag.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                cmbCategory.SelectedItem == null ||
                cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Asset Tag, Name, Category, and Status are required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProcessedEquipment = new Equipment
            {
                Id = _existingId,
                AssetTag = txtAssetTag.Text.Trim(),
                Name = txtName.Text.Trim(),
                Category = cmbCategory.SelectedItem.ToString(),
                Status = cmbStatus.SelectedItem.ToString(),
                StationNumber = txtLocation.Text.Trim(),
                UsageCount = _existingUsageCount,
                DateAcquired = dtpDateAcquired.Value.Date
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}