using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class BorrowModalForm : Form
    {
        public BorrowRequest ProcessedRequest { get; private set; }

        private readonly IEquipmentRepository _equipmentRepo;
        private readonly int _studentId;
        private List<Equipment> _cachedAvailableEquipment;

        public BorrowModalForm(IEquipmentRepository equipmentRepo, int studentId)
        {
            InitializeComponent();
            _equipmentRepo = equipmentRepo;
            _studentId = studentId;
            _cachedAvailableEquipment = new List<Equipment>();

            dtpRequestedDate.MinDate = DateTime.Today;
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.ShowUpDown = true;
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.ShowUpDown = true;

      
            cmbEquipmentName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbEquipmentName.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbScope.Items.AddRange(new[] { "Borrow Entire Room", "Borrow ComLab PC", "Borrow Lab Equipment" });
        }

        private void cmbScope_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEquipmentName.Items.Clear();
            cmbAssetTag.Items.Clear();
            cmbEquipmentName.Text = string.Empty;
            cmbAssetTag.Text = string.Empty;

            string selectedScope = cmbScope.SelectedItem?.ToString();

            if (selectedScope == "Borrow Entire Room")
            {
                cmbAssetTag.Enabled = false; 
                cmbEquipmentName.Items.AddRange(LabLocations.Rooms);
            }
            else if (selectedScope == "Borrow ComLab PC" || selectedScope == "Borrow Lab Equipment")
            {
                cmbAssetTag.Enabled = true;
                bool isPc = selectedScope == "Borrow ComLab PC";
                string targetCategory = isPc ? "System Unit" : "Tool";

                // Lab PCs sit at their stations as "Active"; tools wait in storage as "Available"
                _cachedAvailableEquipment = _equipmentRepo.GetAllEquipment()
                    .Where(eq => eq.Category == targetCategory && (eq.Status == "Available" || (isPc && eq.Status == "Active")))
                    .ToList();

                
                var uniqueNames = _cachedAvailableEquipment.Select(eq => eq.Name).Distinct().ToArray();
                cmbEquipmentName.Items.AddRange(uniqueNames);
            }
        }

        private void cmbEquipmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAssetTag.Items.Clear();
            cmbAssetTag.Text = string.Empty;

            string selectedScope = cmbScope.SelectedItem?.ToString();
            string selectedName = cmbEquipmentName.SelectedItem?.ToString();

            if (selectedScope != "Borrow Entire Room" && !string.IsNullOrWhiteSpace(selectedName))
            {
                
                var matchingTags = _cachedAvailableEquipment
                    .Where(eq => eq.Name == selectedName)
                    .Select(eq => eq.AssetTag)
                    .ToArray();

                cmbAssetTag.Items.AddRange(matchingTags);

                if (cmbAssetTag.Items.Count == 1)
                {
                    cmbAssetTag.SelectedIndex = 0;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;

            string scope = cmbScope.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(scope) || cmbEquipmentName.SelectedItem == null || string.IsNullOrWhiteSpace(txtPurpose.Text))
            {
                MessageBox.Show("Scope, Item, and Purpose are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (scope != "Borrow Entire Room" && cmbAssetTag.SelectedItem == null)
            {
                MessageBox.Show("Please select a specific Asset Tag.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpStartTime.Value.TimeOfDay >= dtpEndTime.Value.TimeOfDay)
            {
                MessageBox.Show("Start Time must be strictly before End Time.", "Validation Time Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? finalEquipmentId = null;
            string finalTargetLocation = null;

            if (scope == "Borrow Entire Room")
            {
                finalTargetLocation = cmbEquipmentName.SelectedItem.ToString();
            }
            else
            {
                string selectedTag = cmbAssetTag.SelectedItem.ToString();
                var specificEquipment = _cachedAvailableEquipment.FirstOrDefault(eq => eq.AssetTag == selectedTag);

                if (specificEquipment != null)
                {
                    finalEquipmentId = specificEquipment.Id;
                    finalTargetLocation = specificEquipment.StationNumber;
                }
            }

            ProcessedRequest = new BorrowRequest
            {
                StudentId = _studentId,
                EquipmentId = finalEquipmentId,
                TargetLocation = finalTargetLocation,
                Purpose = txtPurpose.Text.Trim(),
                RequestedDate = dtpRequestedDate.Value.Date,
                StartTime = dtpStartTime.Value.TimeOfDay,
                EndTime = dtpEndTime.Value.TimeOfDay,
                Status = "Pending"
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}