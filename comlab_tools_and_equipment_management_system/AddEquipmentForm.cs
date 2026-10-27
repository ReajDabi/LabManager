using System;
using System.Windows.Forms;
using ComLabManager.Core.Models;

namespace ComLabManager.UI
{
    public partial class AddEquipmentForm : Form
    {
        public Equipment ProcessedEquipment { get; private set; }
        private readonly int _existingId;

        public AddEquipmentForm()
        {
            InitializeComponent();
            PopulateDropdowns();

            lblTitle.Text = "Add New Equipment";
            _existingId = 0;
            numUsageCount.Value = 0;
            dtpDateAcquired.Value = DateTime.Now;

            SetupDynamicUI();
        }

        public AddEquipmentForm(Equipment equipmentToEdit)
        {
            InitializeComponent();
            PopulateDropdowns();

            lblTitle.Text = "Edit Equipment";
            _existingId = equipmentToEdit.Id;

            txtAssetTag.Text = equipmentToEdit.AssetTag;
            txtName.Text = equipmentToEdit.Name;
            cmbCategory.SelectedItem = equipmentToEdit.Category;
            cmbStatus.SelectedItem = equipmentToEdit.Status;

     
            if (cmbLocation.Items.Contains(equipmentToEdit.StationNumber))
                cmbLocation.SelectedItem = equipmentToEdit.StationNumber;
            else
                cmbLocation.Text = equipmentToEdit.StationNumber;

            dtpDateAcquired.Value = equipmentToEdit.DateAcquired;
            numUsageCount.Value = equipmentToEdit.UsageCount;

            SetupDynamicUI();
        }

        private void PopulateDropdowns()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new string[] { "System Unit", "Monitor", "Peripheral", "Networking", "Tool" });

            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[] { "Available", "Active", "In Use", "Under Repair", "Decommissioned" });

            cmbLocation.Items.Clear();
            cmbLocation.Items.AddRange(LabLocations.All);
        }

        private void SetupDynamicUI()
        {
            cmbStatus.SelectedIndexChanged += CmbStatus_SelectedIndexChanged;
            CmbStatus_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentStatus = cmbStatus.SelectedItem?.ToString();

          
            if (currentStatus == "Under Repair" || currentStatus == "Decommissioned")
            {
                cmbLocation.SelectedIndex = -1;
                cmbLocation.Text = string.Empty;
                cmbLocation.Enabled = false;
            }
            else
            {
                cmbLocation.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;

            if (string.IsNullOrWhiteSpace(txtAssetTag.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                cmbCategory.SelectedItem == null ||
                cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Asset Tag, Name, Category, and Status are required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbLocation.Enabled && string.IsNullOrWhiteSpace(cmbLocation.Text))
            {
                MessageBox.Show("An Assigned Location is required when an asset is available or actively deployed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProcessedEquipment = new Equipment
            {
                Id = _existingId,
                AssetTag = txtAssetTag.Text.Trim(),
                Name = txtName.Text.Trim(),
                Category = cmbCategory.SelectedItem.ToString(),
                Status = cmbStatus.SelectedItem.ToString(),
                StationNumber = cmbLocation.Text.Trim(),
                UsageCount = (int)numUsageCount.Value,
                DateAcquired = dtpDateAcquired.Value.Date
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}