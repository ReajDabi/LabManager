using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class ResolveTicketForm : Form
    {
        private readonly IMaintenanceRepository _maintenanceRepo;
        private readonly MaintenanceTicket _ticket;

        public ResolveTicketForm(IMaintenanceRepository maintenanceRepo, MaintenanceTicket ticket)
        {
            InitializeComponent();
            _maintenanceRepo = maintenanceRepo;
            _ticket = ticket;

            lblTicket.Text = $"{ticket.AssetTag} - {ticket.EquipmentName}";

            // Only parts that are in stock can be consumed
            cmbSparePart.Items.Add(new SparePartOption(null, "(None)"));
            cmbSparePart.Items.AddRange(_maintenanceRepo.GetAllSpareParts()
                .Where(p => p.Quantity > 0)
                .Select(p => new SparePartOption(p.Id, $"{p.Name} ({p.Quantity} in stock)"))
                .ToArray());
            cmbSparePart.SelectedIndex = 0;
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedPart = (SparePartOption)cmbSparePart.SelectedItem!;
                _maintenanceRepo.ResolveTicket(_ticket.Id, selectedPart.Id);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while resolving the ticket: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private class SparePartOption
        {
            public int? Id { get; }
            private readonly string _label;

            public SparePartOption(int? id, string label)
            {
                Id = id;
                _label = label;
            }

            public override string ToString() => _label;
        }
    }
}
