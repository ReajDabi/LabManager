using ComlabManager.Core.Interfaces;
using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class MaintenanceView : UserControl
    {
        private readonly IMaintenanceRepository? _maintenanceRepo;
        private readonly IEquipmentRepository? _equipmentRepo;
        private readonly IUserRepository? _userRepo;
        private readonly ISparePartRepository? _sparePartRepo; // Added new repository
        private readonly User? _currentUser;

        public MaintenanceView()
        {
            InitializeComponent();
        }

        // Updated constructor to require ISparePartRepository
        public MaintenanceView(IMaintenanceRepository maintenanceRepo, IEquipmentRepository equipmentRepo, IUserRepository userRepo, ISparePartRepository sparePartRepo, User currentUser)
        {
            _maintenanceRepo = maintenanceRepo ?? throw new ArgumentNullException(nameof(maintenanceRepo));
            _equipmentRepo = equipmentRepo ?? throw new ArgumentNullException(nameof(equipmentRepo));
            _userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
            _sparePartRepo = sparePartRepo ?? throw new ArgumentNullException(nameof(sparePartRepo));
            _currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));

            InitializeComponent();

            bool canUpdateStatus = _currentUser.Role != "Student";
            buttonStartRepair.Visible = canUpdateStatus;
            buttonResolve.Visible = canUpdateStatus;
            buttonAssign.Visible = _currentUser.Role == "Admin";

            LoadTickets();
        }

        private void LoadTickets()
        {
            if (_maintenanceRepo == null) return;

            try
            {
                dataGridView1.Rows.Clear();

                IEnumerable<MaintenanceTicket> tickets = _maintenanceRepo.GetAllTickets();

                if (_currentUser?.Role == "Technician")
                {
                    tickets = tickets.OrderBy(t => GetTaskRank(t, _currentUser.Id));
                }

                foreach (var t in tickets)
                {
                    int rowIndex = dataGridView1.Rows.Add($"TKT-{t.Id:D4}", t.AssetTag, t.EquipmentName, t.IssueDescription, t.Status, t.SparePartName ?? "", t.AssignedTechnicianName ?? "Unassigned");
                    dataGridView1.Rows[rowIndex].Tag = t;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the tickets: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateStatusButtons();
        }

        private MaintenanceTicket? GetSelectedTicket()
        {
            return dataGridView1.SelectedRows.Count > 0 ? dataGridView1.SelectedRows[0].Tag as MaintenanceTicket : null;
        }

        private static int GetTaskRank(MaintenanceTicket ticket, int technicianId)
        {
            if (ticket.Status != "Resolved" && ticket.AssignedTechnicianId == technicianId) return 0;
            if (ticket.Status == "Open" && ticket.AssignedTechnicianId == null) return 1;
            return 2;
        }

        private void UpdateStatusButtons()
        {
            var selected = GetSelectedTicket();
            buttonAssign.Enabled = selected != null && selected.Status != "Resolved";
            buttonStartRepair.Enabled = selected?.Status == "Open";
            buttonResolve.Enabled = selected?.Status == "Under Repair";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e) => UpdateStatusButtons();

        private void buttonCreateTicket_Click(object sender, EventArgs e)
        {
            if (_maintenanceRepo == null || _equipmentRepo == null || _currentUser == null) return;

            try
            {
                using (CreateTicketForm ticketForm = new CreateTicketForm(_maintenanceRepo, _equipmentRepo, _currentUser))
                {
                    if (ticketForm.ShowDialog() == DialogResult.OK)
                        LoadTickets();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the ticket form: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedTicket();
            if (_maintenanceRepo == null || _userRepo == null || selected == null) return;

            try
            {
                using (AssignTechnicianForm assignForm = new AssignTechnicianForm(_maintenanceRepo, _userRepo, selected))
                {
                    if (assignForm.ShowDialog() == DialogResult.OK)
                        LoadTickets();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the assign form: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStartRepair_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedTicket();
            if (_maintenanceRepo == null || _currentUser == null || selected == null) return;

            try
            {
                int? technicianId = _currentUser.Role == "Technician" ? _currentUser.Id : null;
                _maintenanceRepo.StartRepair(selected.Id, technicianId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the ticket: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadTickets();
        }

        private void buttonResolve_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedTicket();

            // Added null check for _sparePartRepo
            if (_maintenanceRepo == null || _sparePartRepo == null || selected == null) return;

            try
            {
                // Passing all three required arguments to ResolveTicketForm
                using (ResolveTicketForm resolveForm = new ResolveTicketForm(_maintenanceRepo, _sparePartRepo, selected))
                {
                    if (resolveForm.ShowDialog() == DialogResult.OK)
                        LoadTickets();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the resolve form: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}