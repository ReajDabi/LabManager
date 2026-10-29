using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class ManageSchedulesForm : Form
    {
        private readonly IComLabScheduleRepository _scheduleRepo;
        private ComLabSchedule _selectedSchedule;

        public ManageSchedulesForm(IComLabScheduleRepository scheduleRepo)
        {
            InitializeComponent();
            _scheduleRepo = scheduleRepo ?? throw new ArgumentNullException(nameof(scheduleRepo));

            dtpStartTime.CustomFormat = "hh:mm tt";
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.CustomFormat = "hh:mm tt";
            dtpEndTime.Format = DateTimePickerFormat.Custom;

            
            cmbRoom.Items.AddRange(LabLocations.Rooms);

            LoadSchedules();
        }

        private void LoadSchedules()
        {
            dgvSchedules.DataSource = _scheduleRepo.GetAllSchedules();
            ClearInputs();
        }

        private void ClearInputs()
        {
            _selectedSchedule = null;
            cmbRoom.SelectedIndex = -1;
            txtSubject.Clear();
            txtInstructor.Clear();
            cmbDay.SelectedIndex = -1;
            dtpStartTime.Value = DateTime.Today.AddHours(8);
            dtpEndTime.Value = DateTime.Today.AddHours(9);
            dgvSchedules.ClearSelection();
        }

        private void dgvSchedules_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSchedules.SelectedRows.Count > 0)
            {
                _selectedSchedule = (ComLabSchedule)dgvSchedules.SelectedRows[0].DataBoundItem;
                cmbRoom.SelectedItem = _selectedSchedule.ComLabName;
                txtSubject.Text = _selectedSchedule.SubjectCode;
                txtInstructor.Text = _selectedSchedule.InstructorName;
                cmbDay.SelectedItem = _selectedSchedule.DayOfWeek;
                dtpStartTime.Value = DateTime.Today.Add(_selectedSchedule.StartTime);
                dtpEndTime.Value = DateTime.Today.Add(_selectedSchedule.EndTime);
            }
        }

       
        private bool IsScheduleConflict(string room, string day, TimeSpan start, TimeSpan end, int? excludeId = null)
        {
            if (start >= end)
            {
                MessageBox.Show("Start time must be strictly before End time.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            var existingSchedules = _scheduleRepo.GetAllSchedules()
                .Where(s => s.ComLabName == room && s.DayOfWeek == day);

            if (excludeId.HasValue)
            {
                existingSchedules = existingSchedules.Where(s => s.Id != excludeId.Value);
            }

            foreach (var existing in existingSchedules)
            {
                if (start < existing.EndTime && end > existing.StartTime)
                {
                    MessageBox.Show($"Time conflict! There is already a class ({existing.SubjectCode}) in {room} on {day} from {DateTime.Today.Add(existing.StartTime):h:mm tt} to {DateTime.Today.Add(existing.EndTime):h:mm tt}.",
                        "Schedule Overlap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }

            return false;
        }

        private bool HasRequiredFields()
        {
            if (cmbRoom.SelectedItem == null || string.IsNullOrWhiteSpace(txtSubject.Text) || cmbDay.SelectedItem == null)
            {
                MessageBox.Show("Room, Subject, and Day are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!HasRequiredFields()) return;

            TimeSpan newStart = dtpStartTime.Value.TimeOfDay;
            TimeSpan newEnd = dtpEndTime.Value.TimeOfDay;

            if (IsScheduleConflict(cmbRoom.SelectedItem.ToString(), cmbDay.SelectedItem.ToString(), newStart, newEnd))
                return;

            var newSchedule = new ComLabSchedule
            {
                ComLabName = cmbRoom.SelectedItem.ToString(),
                SubjectCode = txtSubject.Text.Trim(),
                InstructorName = txtInstructor.Text.Trim(),
                DayOfWeek = cmbDay.SelectedItem.ToString(),
                StartTime = newStart,
                EndTime = newEnd
            };

            try
            {
                _scheduleRepo.AddSchedule(newSchedule);
                LoadSchedules();
                MessageBox.Show("Schedule added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the schedule: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedSchedule == null)
            {
                MessageBox.Show("Please select a schedule from the list to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!HasRequiredFields()) return;

            TimeSpan newStart = dtpStartTime.Value.TimeOfDay;
            TimeSpan newEnd = dtpEndTime.Value.TimeOfDay;

            if (IsScheduleConflict(cmbRoom.SelectedItem.ToString(), cmbDay.SelectedItem.ToString(), newStart, newEnd, _selectedSchedule.Id))
                return;

            _selectedSchedule.ComLabName = cmbRoom.SelectedItem.ToString();
            _selectedSchedule.SubjectCode = txtSubject.Text.Trim();
            _selectedSchedule.InstructorName = txtInstructor.Text.Trim();
            _selectedSchedule.DayOfWeek = cmbDay.SelectedItem.ToString();
            _selectedSchedule.StartTime = newStart;
            _selectedSchedule.EndTime = newEnd;

            try
            {
                _scheduleRepo.UpdateSchedule(_selectedSchedule);
                LoadSchedules();
                MessageBox.Show("Schedule updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the schedule: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedSchedule == null) return;

            var result = MessageBox.Show($"Are you sure you want to delete the schedule for {_selectedSchedule.SubjectCode}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _scheduleRepo.DeleteSchedule(_selectedSchedule.Id);
                    LoadSchedules();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the schedule: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}