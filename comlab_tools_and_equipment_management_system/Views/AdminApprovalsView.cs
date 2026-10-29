using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using ComLabManager.UI.Navigation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ComLabManager.UI.Views
{
    public partial class AdminApprovalsView : UserControl, IFilterableView
    {
        private static readonly Color OverdueBackColor = Color.FromArgb(255, 205, 210);

        private readonly IBorrowRequestRepository _borrowRepo;
        private readonly ISparePartRequestRepository _partRepo;
        private readonly Dictionary<string, Color> _statusColors;

        // Optional pre-filters, set when the view is opened from a dashboard card
        private Func<BorrowRequest, bool>? _borrowFilter;
        private Func<SparePartRequest, bool>? _partFilter;

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


            SetActiveTab(ActiveRequestTab.Borrow);

            filterBanner.Cleared += (s, e) =>
            {
                _borrowFilter = null;
                _partFilter = null;
                RefreshBorrowGrid();
                RefreshPartGrid();
            };

            overdueTimer.Start();
        }

        public void ApplyFilter(ViewFilter filter)
        {
            switch (filter)
            {
                case ViewFilter.PendingApprovals:
                    _borrowFilter = r => r.Status == "Pending";
                    _partFilter = r => r.Status == "Pending";
                    filterBanner.ShowFilter("Pending requests");
                    break;
                case ViewFilter.ActiveBorrows:
                    _borrowFilter = r => r.IsActiveLoan;
                    filterBanner.ShowFilter("Equipment currently borrowed");
                    break;
                case ViewFilter.Overdue:
                    _borrowFilter = r => r.IsOverdue;
                    filterBanner.ShowFilter("Overdue equipment");
                    break;
                default:
                    return;
            }

            RefreshBorrowGrid();
            RefreshPartGrid();

            // Pending approvals can live on either tab; open whichever has work waiting
            bool showParts = filter == ViewFilter.PendingApprovals && dgvBorrowRequests.Rows.Count == 0 && dgvPartRequests.Rows.Count > 0;
            SetActiveTab(showParts ? ActiveRequestTab.Parts : ActiveRequestTab.Borrow);
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

            Schedule.DataPropertyName = "Schedule";

            colPartRequestId.DataPropertyName = "Id";
            colPartTech.DataPropertyName = "TechnicianName";
            colRequestedPart.DataPropertyName = "SparePartName";
            Quantity.DataPropertyName = "Quantity";
            colPartReason.DataPropertyName = "Reason";
            colPartStatus.DataPropertyName = "Status";
        }

        private void RefreshBorrowGrid()
        {
            if (_borrowRepo == null) return;

            var requests = _borrowRepo.GetAllRequests();
            dgvBorrowRequests.DataSource = _borrowFilter == null ? requests : requests.Where(_borrowFilter).ToList();
        }

        private void RefreshPartGrid()
        {
            if (_partRepo == null) return;

            var requests = _partRepo.GetAllRequests();
            dgvPartRequests.DataSource = _partFilter == null ? requests : requests.Where(_partFilter).ToList();
        }

        // Styles only this cell's copy (e.CellStyle), never the row, so colours can't bleed between rows after a re-bind
        private void dgvBorrowRequests_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.CellStyle == null || dgvBorrowRequests.Rows[e.RowIndex].DataBoundItem is not BorrowRequest request) return;

            bool isStatusColumn = dgvBorrowRequests.Columns[e.ColumnIndex] == Status;

            if (request.IsOverdue)
            {
                e.CellStyle.BackColor = OverdueBackColor;
                e.CellStyle.ForeColor = Color.DarkRed;
                e.CellStyle.SelectionBackColor = Color.IndianRed;
                e.CellStyle.SelectionForeColor = Color.White;

                if (isStatusColumn)
                {
                    e.Value = "Overdue";
                    e.FormattingApplied = true;
                }
            }
            else if (isStatusColumn && _statusColors.TryGetValue(request.Status, out Color statusColor))
            {
                e.CellStyle.ForeColor = statusColor;
            }
        }

        // Re-paint so loans turn red the moment they pass their end time
        private void overdueTimer_Tick(object? sender, EventArgs e) => dgvBorrowRequests.Invalidate();

        private void btnApprove_Click(object sender, EventArgs e) => ProcessSelectedRequest("Approved");
        private void btnDeny_Click(object sender, EventArgs e) => ProcessSelectedRequest("Denied");

        private void ProcessSelectedRequest(string newStatus)
        {
            if (_activeTab == ActiveRequestTab.Borrow)
            {
                Action<int, string> action = (id, status) =>
                {
                    if (status == "Approved") _borrowRepo.ApproveAndLockEquipment(id);
                    else _borrowRepo.UpdateRequestStatus(id, status);
                };

                ExecuteApprovalFlow(dgvBorrowRequests, newStatus, action, RefreshBorrowGrid);
            }
            else if (_activeTab == ActiveRequestTab.Parts)
            {
                Action<int, string> action = (id, status) =>
                {
                    if (status == "Approved") _partRepo.ApproveAndDeductInventory(id);
                    else _partRepo.UpdateRequestStatus(id, status);
                };

                ExecuteApprovalFlow(dgvPartRequests, newStatus, action, RefreshPartGrid);
            }
        }

        private void ExecuteApprovalFlow(DataGridView grid, string newStatus, Action<int, string> repoAction, Action refreshAction)
        {
            if (grid.SelectedRows.Count == 0) return;

            var selectedReq = (IApprovalRequest)grid.SelectedRows[0].DataBoundItem;

            if (selectedReq.Status != "Pending")
            {
                ShowWarning();
                return;
            }

            if (ConfirmAction(newStatus) == DialogResult.Yes)
            {
                try
                {
                    repoAction(selectedReq.Id, newStatus);
                    refreshAction();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Action Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowWarning() => MessageBox.Show("You can only modify Pending requests.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private DialogResult ConfirmAction(string status) => MessageBox.Show($"Are you sure you want to mark this request as {status}?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


        private void SetActiveTab(ActiveRequestTab tab)
        {
            _activeTab = tab;
            bool isBorrowTab = (_activeTab == ActiveRequestTab.Borrow);


            if (isBorrowTab) pnlBorrowRequests.BringToFront();
            else pnlPartRequests.BringToFront();


            btnToggleBorrow.BackColor = isBorrowTab ? Color.FromArgb(0, 120, 215) : Color.FromArgb(30, 41, 59);
            btnToggleParts.BackColor = !isBorrowTab ? Color.FromArgb(0, 120, 215) : Color.FromArgb(30, 41, 59);


            btnReturnEquipment.Visible = isBorrowTab;
        }

        private void btnToggleBorrow_Click(object sender, EventArgs e) => SetActiveTab(ActiveRequestTab.Borrow);
        private void btnToggleParts_Click(object sender, EventArgs e) => SetActiveTab(ActiveRequestTab.Parts);

        private void btnReturnEquipment_Click(object sender, EventArgs e)
        {
            if (dgvBorrowRequests.SelectedRows.Count == 0) return;

            var selectedReq = (BorrowRequest)dgvBorrowRequests.SelectedRows[0].DataBoundItem;

            if (Array.IndexOf(BorrowRequest.ActiveLoanStatuses, selectedReq.Status) < 0)
            {
                MessageBox.Show("You can only return equipment that is currently borrowed.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Confirm this equipment has been returned?", "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _borrowRepo.ReturnEquipment(selectedReq.Id);
                    RefreshBorrowGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Return Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
