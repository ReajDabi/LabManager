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
                { "Denied", Color.FromArgb(220, 53, 69) }
            };

            
            SetupGrid();

            
            RefreshGrid();

            
            PopulateRoomFilter();
        }

        private void SetupGrid()
        {
           
            dgvMyRequests.AutoGenerateColumns = false;
            dgvSchedules.AutoGenerateColumns = false;

            Target.DataPropertyName = "TargetLocation";
            Date.DataPropertyName = "RequestedDate";
            Status.DataPropertyName = "Status";

            
            Subject.DataPropertyName = "SubjectCode";
            Instructor.DataPropertyName = "InstructorName";
            StartTime.DataPropertyName = "StartTime";
            EndTime.DataPropertyName = "EndTime";
        }

        private void RefreshGrid()
        {
            if (_borrowRepo != null)
            {
                var myRequests = _borrowRepo.GetRequestsByStudent(_studentId);
                dgvMyRequests.DataSource = myRequests;
            }
        }

        private void PopulateRoomFilter()
        {
            if (_scheduleRepo == null) return;

            var allSchedules = _scheduleRepo.GetAllSchedules();
            var uniqueRooms = allSchedules.Select(s => s.ComLabName).Distinct().ToList();

            cmbRoomFilter.Items.Clear();
            cmbRoomFilter.Items.Add("All Rooms");
            cmbRoomFilter.Items.AddRange(uniqueRooms.ToArray());

            if (cmbRoomFilter.Items.Count > 0)
            {
                
                cmbRoomFilter.SelectedIndex = 0;
            }
        }

        private void ApplyScheduleFilter()
        {
            if (_scheduleRepo == null) return;

            string selectedRoom = cmbRoomFilter.SelectedItem?.ToString() ?? "All Rooms";
            var allSchedules = _scheduleRepo.GetAllSchedules();

            if (selectedRoom == "All Rooms")
            {
                dgvSchedules.DataSource = allSchedules;
            }
            else
            {
                var filteredSchedules = allSchedules.Where(s => s.ComLabName == selectedRoom).ToList();
                dgvSchedules.DataSource = filteredSchedules;
            }
        }

        private void cmbRoomFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyScheduleFilter();
        }

        private void dgvSchedules_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.Value is TimeSpan timeValue &&
               (dgvSchedules.Columns[e.ColumnIndex].Name == "StartTime" || dgvSchedules.Columns[e.ColumnIndex].Name == "EndTime"))
            {
                DateTime time = DateTime.Today.Add(timeValue);
                e.Value = time.ToString("h:mm tt");
                e.FormattingApplied = true;
            }
        }

        private void dgvMyRequests_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvMyRequests.Rows[e.RowIndex];
                var request = row.DataBoundItem as BorrowRequest;

                if (request != null)
                {
                    string columnName = dgvMyRequests.Columns[e.ColumnIndex].Name;

                   
                    if (columnName == "colTime")
                    {
                        DateTime start = DateTime.Today.Add(request.StartTime);
                        DateTime end = DateTime.Today.Add(request.EndTime);
                        e.Value = $"{start:h:mm tt} - {end:h:mm tt}"; 
                        e.FormattingApplied = true;
                    }

                    if (columnName == "Status")
                    {
                        if (_statusColors.TryGetValue(request.Status, out Color statusColor))
                        {
                            row.Cells[e.ColumnIndex].Style.ForeColor = statusColor;
                        }
                    }
                }
            }
        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            using (BorrowModalForm form = new BorrowModalForm(_equipmentRepo, _studentId))
            {
                if (form.ShowDialog() == DialogResult.OK && form.ProcessedRequest != null)
                {
                    _borrowRepo.AddRequest(form.ProcessedRequest);
                    RefreshGrid();
                }
            }
        }

        private void btnToggleSchedule_Click(object sender, EventArgs e)
        {
            pnlSchedules.BringToFront();
            btnToggleSchedule.BackColor = Color.FromArgb(0, 120, 215);
            btnToggleBorrow.BackColor = Color.FromArgb(30, 41, 59);
        }

        private void btnToggleBorrow_Click(object sender, EventArgs e)
        {
            pnlBorrow.BringToFront();
            btnToggleBorrow.BackColor = Color.FromArgb(0, 120, 215);
            btnToggleSchedule.BackColor = Color.FromArgb(30, 41, 59);
        }
    }
}