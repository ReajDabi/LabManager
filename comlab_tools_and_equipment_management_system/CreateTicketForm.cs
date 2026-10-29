using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class CreateTicketForm : Form
    {
        private readonly IMaintenanceRepository _maintenanceRepo;
        private readonly User _currentUser;
        private readonly List<Equipment> _equipment;

        public CreateTicketForm(IMaintenanceRepository maintenanceRepo, IEquipmentRepository equipmentRepo, User currentUser)
        {
            InitializeComponent();
            _maintenanceRepo = maintenanceRepo;
            _currentUser = currentUser;

            _equipment = equipmentRepo.GetAllEquipment();

            // Suggest asset tags as the user types
            var assetTags = new AutoCompleteStringCollection();
            assetTags.AddRange(_equipment.Select(e => e.AssetTag).ToArray());
            textBox1.AutoCompleteCustomSource = assetTags;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string assetTag = textBox1.Text.Trim();
            string issue = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(assetTag) || string.IsNullOrWhiteSpace(issue))
            {
                MessageBox.Show("Please enter both the asset tag and the issue description.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var equipment = _equipment.FirstOrDefault(x => string.Equals(x.AssetTag, assetTag, StringComparison.OrdinalIgnoreCase));

            if (equipment == null)
            {
                MessageBox.Show($"No equipment found with asset tag '{assetTag}'.", "Unknown Asset Tag", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            try
            {
                _maintenanceRepo.CreateTicket(new MaintenanceLog
                {
                    EquipmentId = equipment.Id,
                    ReportedById = _currentUser.Id,
                    IssueDescription = issue
                });

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the ticket: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
