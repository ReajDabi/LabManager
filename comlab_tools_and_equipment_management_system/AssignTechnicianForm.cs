using ComlabManager.Core.Interfaces;
using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class AssignTechnicianForm : Form
    {
        private readonly IMaintenanceRepository _maintenanceRepo;
        private readonly MaintenanceTicket _ticket;

        public AssignTechnicianForm(IMaintenanceRepository maintenanceRepo, IUserRepository userRepo, MaintenanceTicket ticket)
        {
            InitializeComponent();
            _maintenanceRepo = maintenanceRepo;
            _ticket = ticket;

            lblTicket.Text = $"{ticket.AssetTag} - {ticket.EquipmentName}";

            cmbTechnician.Items.AddRange(userRepo.GetUsersByRole("Technician")
                .Select(u => new TechnicianOption(u))
                .ToArray());

            // Start on the technician who already has the ticket, if any
            cmbTechnician.SelectedItem = cmbTechnician.Items.Cast<TechnicianOption>()
                .FirstOrDefault(o => o.Id == ticket.AssignedTechnicianId);
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cmbTechnician.SelectedItem is not TechnicianOption selected)
            {
                MessageBox.Show("Please select a technician.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _maintenanceRepo.AssignTechnician(_ticket.Id, selected.Id);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while assigning the technician: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private class TechnicianOption
        {
            public int Id { get; }
            private readonly string _label;

            public TechnicianOption(User user)
            {
                Id = user.Id;
                string fullName = $"{user.FirstName} {user.LastName}".Trim();
                _label = string.IsNullOrEmpty(fullName) ? user.UserName : fullName;
            }

            public override string ToString() => _label;
        }
    }
}
