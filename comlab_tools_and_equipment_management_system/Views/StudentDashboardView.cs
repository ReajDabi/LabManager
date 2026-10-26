using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ComLabManager.UI.Views
{
    public partial class StudentDashboardView : UserControl
    {
        private readonly IEquipmentRepository _equipmentRepo;
        private readonly IBorrowRequestRepository _borrowRepo;
        private readonly IComLabScheduleRepository _scheduleRepo;
        private readonly Dictionary<string, Color> _statusColors;
        private readonly int _studentId;

        private IEnumerable<UnifiedScheduleDto> _cachedSchedules;
        private enum ActiveTab { Schedule, Borrow }

        public StudentDashboardView(IEquipmentRepository equipmentRepo, IBorrowRequestRepository borrowRepo, IComLabScheduleRepository scheduleRepo, int studentId)
        {
            InitializeComponent();
            _equipmentRepo = equipmentRepo ?? throw new ArgumentNullException(nameof(equipmentRepo));
            _borrowRepo = borrowRepo ?? throw new ArgumentNullException(nameof(borrowRepo));
            _scheduleRepo = scheduleRepo ?? throw new ArgumentNullException(nameof(scheduleRepo));
            _studentId = studentId;

            _statusColors = new Dictionary<string, Color>
            {
                { "Pending", Color.FromArgb(255, 193, 7) },
                { "Approved", Color.FromArgb(25, 135, 84) },
                { "Denied", Color.FromArgb(220, 53, 69) },
                { "Returned", Color.FromArgb(108, 117, 125) }
            };

            SetupGrids();
            RefreshGrid();
            PopulateRoomFilter();

            
            SetActiveTab(ActiveTab.Schedule);
        }

        private void SetupGrids()
        {
            dgvSchedules.AutoGenerateColumns = true;
            dgvMyRequests.AutoGenerateColumns = true;
        }

        private void RefreshGrid()
        {
            if (_borrowRepo != null)
            {
                var myRequests = _borrowRepo.GetRequestsByStudent(_studentId);
                dgvMyRequests.DataSource = myRequests;
                FormatMyRequestsGridUI(); 
            }
        }

        private void PopulateRoomFilter()
        {
            if (_scheduleRepo == null) return;

            _cachedSchedules = _scheduleRepo.GetUnifiedComLabSchedules();
            var uniqueRooms = _cachedSchedules
      .Where(s => !string.IsNullOrWhiteSpace(s.ComLabName))
      .Select(s => s.ComLabName)
      .Distinct()
      .OrderBy(r => r)
      .ToArray();

            cmbRoomFilter.Items.Clear();
            cmbRoomFilter.Items.Add("All Rooms");
            cmbRoomFilter.Items.AddRange(uniqueRooms);

            if (cmbRoomFilter.Items.Count > 0)
            {
                cmbRoomFilter.SelectedIndex = 0;
            }
        }

        private void ApplyScheduleFilter()
        {
            if (_cachedSchedules == null) return;

            string selectedRoom = cmbRoomFilter.SelectedItem?.ToString() ?? "All Rooms";

            if (selectedRoom == "All Rooms")
                dgvSchedules.DataSource = _cachedSchedules.ToList();
            else
                dgvSchedules.DataSource = _cachedSchedules.Where(s => (string)s.ComLabName == selectedRoom).ToList();

            FormatScheduleGridUI(); 
        }

        private void cmbRoomFilter_SelectedIndexChanged(object sender, EventArgs e) => ApplyScheduleFilter();

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            using (BorrowModalForm form = new BorrowModalForm(_equipmentRepo, _studentId))
            {
                if (form.ShowDialog() == DialogResult.OK && form.ProcessedRequest != null)
                {
                    try
                    {
                       
                        _borrowRepo.AddRequest(form.ProcessedRequest);
                        RefreshGrid();
                        MessageBox.Show("Borrow request submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (InvalidOperationException ex)
                    {
                        
                        MessageBox.Show(ex.Message, "Request Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void SetActiveTab(ActiveTab tab)
        {
            bool isSchedule = (tab == ActiveTab.Schedule);

          
            if (isSchedule) pnlSchedules.BringToFront();
            else pnlBorrow.BringToFront();

          
            btnToggleSchedule.BackColor = isSchedule ? Color.FromArgb(0, 120, 215) : Color.FromArgb(30, 41, 59);
            btnToggleBorrow.BackColor = !isSchedule ? Color.FromArgb(0, 120, 215) : Color.FromArgb(30, 41, 59);

           
            cmbRoomFilter.Visible = isSchedule;
            btnNewRequest.Visible = !isSchedule;
            pnlHeader.Refresh();
        }

        private void btnToggleSchedule_Click(object sender, EventArgs e) => SetActiveTab(ActiveTab.Schedule);
        private void btnToggleBorrow_Click(object sender, EventArgs e) => SetActiveTab(ActiveTab.Borrow);

       

        private void FormatScheduleGridUI()
        {
            if (dgvSchedules.Columns.Count == 0) return;

            if (dgvSchedules.Columns["ComLabName"] != null) dgvSchedules.Columns["ComLabName"].HeaderText = "Room";
            if (dgvSchedules.Columns["DayOfWeek"] != null) dgvSchedules.Columns["DayOfWeek"].HeaderText = "Day";
            if (dgvSchedules.Columns["StartTime"] != null) dgvSchedules.Columns["StartTime"].HeaderText = "Start Time";
            if (dgvSchedules.Columns["EndTime"] != null) dgvSchedules.Columns["EndTime"].HeaderText = "End Time";
            if (dgvSchedules.Columns["BookingType"] != null) dgvSchedules.Columns["BookingType"].HeaderText = "Type";
        }

        private void FormatMyRequestsGridUI()
        {
            if (dgvMyRequests.Columns.Count == 0) return;

            string[] columnsToHide = { "Id", "StudentId", "StudentName", "EquipmentId" };
            foreach (string col in columnsToHide)
            {
                if (dgvMyRequests.Columns[col] != null) dgvMyRequests.Columns[col].Visible = false;
            }

            if (dgvMyRequests.Columns["TargetLocation"] != null) dgvMyRequests.Columns["TargetLocation"].HeaderText = "Target Room";
            if (dgvMyRequests.Columns["RequestedDate"] != null) dgvMyRequests.Columns["RequestedDate"].HeaderText = "Date";
            if (dgvMyRequests.Columns["StartTime"] != null) dgvMyRequests.Columns["StartTime"].HeaderText = "Start Time";
            if (dgvMyRequests.Columns["EndTime"] != null) dgvMyRequests.Columns["EndTime"].HeaderText = "End Time";
        }



        private string FormatToAmPm(object val)
        {
            
            if (val is TimeSpan ts)
            {
                return DateTime.Today.Add(ts).ToString("h:mm tt").ToLower();
            }

            if (val is DateTime dt)
            {
                return dt.ToString("h:mm tt").ToLower();
            }

            return val?.ToString();
        }

        private void dgvSchedules_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string colName = dgvSchedules.Columns[e.ColumnIndex].Name;

            if (colName == "StartTime" || colName == "EndTime")
            {
                e.Value = FormatToAmPm(e.Value);
                e.FormattingApplied = true;
            }
        }

        private void dgvMyRequests_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var request = dgvMyRequests.Rows[e.RowIndex].DataBoundItem as BorrowRequest;
            if (request == null) return;

            string colName = dgvMyRequests.Columns[e.ColumnIndex].Name;

            if (colName == "StartTime" || colName == "EndTime")
            {
                e.Value = FormatToAmPm(e.Value);
                e.FormattingApplied = true;
            }
            else if (colName == "RequestedDate" && e.Value is DateTime dateValue)
            {
                e.Value = dateValue.ToString("MMM dd, yyyy");
                e.FormattingApplied = true;
            }
            else if (colName == "Status")
            {
                if (_statusColors.TryGetValue(request.Status, out Color statusColor))
                {
                   
                    e.CellStyle.ForeColor = statusColor;
                    e.CellStyle.Font = new Font(e.CellStyle.Font ?? dgvMyRequests.Font, FontStyle.Bold);
                }
            }
        }
    }
}