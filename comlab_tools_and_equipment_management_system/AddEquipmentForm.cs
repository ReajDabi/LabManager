using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class AddEquipmentForm : Form
    {
        public Equipment ProcessedEquipment { get; private set; }

        private readonly int _existingId;
        private readonly IEquipmentRepository _equipmentRepo; 

      
        public AddEquipmentForm(IEquipmentRepository equipmentRepo)
        {
            InitializeComponent();
            _equipmentRepo = equipmentRepo ?? throw new ArgumentNullException(nameof(equipmentRepo));

            PopulateDropdowns();

            lblTitle.Text = "Add New Equipment";
            _existingId = 0;
            numUsageCount.Value = 0;
            dtpDateAcquired.Value = DateTime.Now;

          
            txtAssetTag.ReadOnly = true;
            txtAssetTag.BackColor = SystemColors.Control;

           
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;

            SetupDynamicUI();
        }

    
        public AddEquipmentForm(Equipment existingEquipment, IEquipmentRepository equipmentRepo)
        {
            InitializeComponent();
            _equipmentRepo = equipmentRepo;

            PopulateDropdowns();

            lblTitle.Text = "Edit Equipment";
            _existingId = existingEquipment.Id;

           
            txtAssetTag.ReadOnly = true;
            txtAssetTag.BackColor = SystemColors.Control;

           
            txtAssetTag.Text = existingEquipment.AssetTag;
            txtName.Text = existingEquipment.Name;
            cmbCategory.SelectedItem = existingEquipment.Category;
            cmbStatus.SelectedItem = existingEquipment.Status;
            cmbLocation.Text = existingEquipment.StationNumber;
            numUsageCount.Value = existingEquipment.UsageCount;
            dtpDateAcquired.Value = existingEquipment.DateAcquired;

            SetupDynamicUI();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem != null)
            {
                string selectedCategory = cmbCategory.SelectedItem.ToString();
                try
                {
                    txtAssetTag.Text = _equipmentRepo.GenerateNextAssetTag(selectedCategory);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating Asset Tag: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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