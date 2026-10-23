using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ComLabManager.UI.Views
{
    public partial class AdminApprovalsView : UserControl
    {
        
        private readonly IBorrowRequestRepository _borrowRepo;
        private readonly ISparePartRequestRepository _partRepo;
        private readonly Dictionary<string, Color> _statusColors;

        private enum ActiveRequestTab { Borrow, Parts }
        private ActiveRequestTab _activeTab;

        public AdminApprovalsView(IBorrowRequestRepository borrowRepo, ISparePartRequestRepository partRepo)
        {
            InitializeComponent();

            _borrowRepo = borrowRepo ?? throw new ArgumentNullException(nameof(borrowRepo));
            _partRepo = partRepo ?? throw new ArgumentNullException(nameof(partRepo));

            _statusColors = new Dictionary<string, Color>
            {
                { "Pending", Color.FromArgb(255, 193, 7) },
                { "Approved", Color.FromArgb(25, 135, 84) },
                { "Denied", Color.FromArgb(220, 53, 69) }
            };

            SetupGrids();
            RefreshBorrowGrid();
            RefreshPartGrid();

            btnToggleBorrow_Click(this, EventArgs.Empty);
        }

        private void SetupGrids()
        {
            dgvBorrowRequests.AutoGenerateColumns = false;
            dgvPartRequests.AutoGenerateColumns = false;

            RequestId.DataPropertyName = "Id";
            StudentName.DataPropertyName = "StudentName";
            TargetLocation.DataPropertyName = "TargetLocation";
            Purpose.DataPropertyName = "Purpose";
            Status.DataPropertyName = "Status";

           
            colPartRequestId.DataPropertyName = "Id";
            colPartTech.DataPropertyName = "TechName";
            colRequestedPart.DataPropertyName = "Name";
            Quantity.DataPropertyName = "Quantity";
            colPartReason.DataPropertyName = "Reason";
            colParrtStatus.DataPropertyName = "Status";
        }

        private void RefreshBorrowGrid()
        {
            if (_borrowRepo != null) dgvBorrowRequests.DataSource = _borrowRepo.GetAllRequests();
        }

        private void RefreshPartGrid()
        {
            if (_partRepo != null) dgvPartRequests.DataSource = _partRepo.GetAllRequests();
        }

        
        private void btnApprove_Click(object sender, EventArgs e) => ProcessSelectedRequest("Approved");
        private void btnDeny_Click(object sender, EventArgs e) => ProcessSelectedRequest("Denied");

        private void ProcessSelectedRequest(string newStatus)
        {
            if (_activeTab == ActiveRequestTab.Borrow)
            {
                if (dgvBorrowRequests.SelectedRows.Count == 0) return;
                var selectedReq = (BorrowRequest)dgvBorrowRequests.SelectedRows[0].DataBoundItem;

                if (selectedReq.Status != "Pending") { ShowWarning(); return; }
                if (ConfirmAction(newStatus) == DialogResult.Yes)
                {
                    _borrowRepo.UpdateRequestStatus(selectedReq.Id, newStatus);
                    RefreshBorrowGrid();
                }
            }
            else if (_activeTab == ActiveRequestTab.Parts)
            {
                if (dgvPartRequests.SelectedRows.Count == 0) return;
                var selectedReq = (SparePartRequest)dgvPartRequests.SelectedRows[0].DataBoundItem;

                if (selectedReq.Status != "Pending") { ShowWarning(); return; }
                if (ConfirmAction(newStatus) == DialogResult.Yes)
                {
                    _partRepo.UpdateRequestStatus(selectedReq.Id, newStatus);
                    RefreshPartGrid();
                }
            }
        }

        private void ShowWarning() => MessageBox.Show("You can only modify Pending requests.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private DialogResult ConfirmAction(string status) => MessageBox.Show($"Are you sure you want to mark this request as {status}?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

       
        private void btnToggleBorrow_Click(object sender, EventArgs e)
        {
            _activeTab = ActiveRequestTab.Borrow;
            pnlBorrowRequests.BringToFront();
            btnToggleBorrow.BackColor = Color.FromArgb(0, 120, 215);
            btnToggleParts.BackColor = Color.FromArgb(30, 41, 59);
        }

        private void btnToggleParts_Click(object sender, EventArgs e)
        {
            _activeTab = ActiveRequestTab.Parts;
            pnlPartRequests.BringToFront();
            btnToggleParts.BackColor = Color.FromArgb(0, 120, 215);
            btnToggleBorrow.BackColor = Color.FromArgb(30, 41, 59);
        }
    }
}