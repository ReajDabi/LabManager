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
        private readonly ISparePartRepository _sparePartRepo;
        private readonly MaintenanceTicket _ticket;

        public ResolveTicketForm(IMaintenanceRepository maintenanceRepo, ISparePartRepository sparePartRepo, MaintenanceTicket ticket)
        {
            InitializeComponent();
            _maintenanceRepo = maintenanceRepo ?? throw new ArgumentNullException(nameof(maintenanceRepo));
            _sparePartRepo = sparePartRepo ?? throw new ArgumentNullException(nameof(sparePartRepo));
            _ticket = ticket ?? throw new ArgumentNullException(nameof(ticket));

            // Fixed the syntax error to compile safely
            lblTicket.Text = $"{ticket.AssetTag}{Environment.NewLine}{ticket.EquipmentName}";

            // Using the correct repository to fetch parts
            cmbSparePart.Items.Add(new SparePartOption(null, "(None)"));
            cmbSparePart.Items.AddRange(_sparePartRepo.GetAllSpareParts()
                .Where(p => p.Quantity > 0)
                .Select(p => new SparePartOption(p.Id, $"{p.Name} ({p.Quantity} in stock)"))
                .ToArray());
            cmbSparePart.SelectedIndex = 0;
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedPart = cmbSparePart.SelectedItem as SparePartOption;
                if (selectedPart == null) return;

                _maintenanceRepo.ResolveTicket(_ticket.Id, selectedPart.Id);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while resolving the ticket: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

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