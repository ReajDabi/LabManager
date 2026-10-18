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

       
        private readonly Dictionary<string, Func<IEnumerable<string>>> _scopeDataLoaders;
        private readonly Dictionary<string, Func<string, (int? EquipmentId, string TargetLocation)>> _scopeParsers;

        public BorrowModalForm(IEquipmentRepository equipmentRepo, int studentId)
        {
            InitializeComponent();
            _equipmentRepo = equipmentRepo;
            _studentId = studentId;

            dtpRequestedDate.MinDate = DateTime.Today;
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.ShowUpDown = true;
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.ShowUpDown = true;

           
            _scopeDataLoaders = new Dictionary<string, Func<IEnumerable<string>>>
            {
                { "Borrow Entire Room", () => new[] { "CLV1", "CLV2", "CLV3", "Engineering", "ICT" } },
                { "Borrow ComLab PC", () => _equipmentRepo.GetEquipmentByCategory("System Unit").Select(e => e.AssetTag) },
                { "Borrow Lab Equipment", () => _equipmentRepo.GetEquipmentByCategory("Tool").Select(e => e.Name) }
            };

           
            _scopeParsers = new Dictionary<string, Func<string, (int?, string)>>
            {
                { "Borrow Entire Room", (item) => (null, item) }, 
                { "Borrow ComLab PC", (item) => {
                    var eq = _equipmentRepo.GetAllEquipment().FirstOrDefault(e => e.AssetTag == item);
                    return (eq?.Id, eq?.StationNumber);
                }},
                { "Borrow Lab Equipment", (item) => {
                    var eq = _equipmentRepo.GetAllEquipment().FirstOrDefault(e => e.Name == item);
                    return (eq?.Id, null);
                }}
            };

            InitializeDropdowns();
        }

        private void InitializeDropdowns()
        {
            cmbScope.Items.Clear();
            cmbScope.Items.AddRange(_scopeDataLoaders.Keys.ToArray());
        }

        private void cmbScope_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbItem.Items.Clear();

            if (cmbScope.SelectedItem is string selectedScope &&
                _scopeDataLoaders.TryGetValue(selectedScope, out var dataLoader))
            {
                var itemsToLoad = dataLoader.Invoke().ToArray();
                cmbItem.Items.AddRange(itemsToLoad);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbScope.SelectedItem == null || cmbItem.SelectedItem == null || string.IsNullOrWhiteSpace(txtPurpose.Text))
            {
                MessageBox.Show("Scope, Item, and Purpose are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpStartTime.Value.TimeOfDay >= dtpEndTime.Value.TimeOfDay)
            {
                MessageBox.Show("Start Time must be strictly before End Time.", "Validation Time Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedScope = cmbScope.SelectedItem.ToString();
            string selectedItem = cmbItem.SelectedItem.ToString();

            int? parsedEquipmentId = null;
            string parsedTargetLocation = null;

            if (_scopeParsers.TryGetValue(selectedScope, out var parser))
            {
                var result = parser(selectedItem);
                parsedEquipmentId = result.EquipmentId;
                parsedTargetLocation = result.TargetLocation;
            }

            ProcessedRequest = new BorrowRequest
            {
                StudentId = _studentId,
                EquipmentId = parsedEquipmentId,
                TargetLocation = parsedTargetLocation,
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