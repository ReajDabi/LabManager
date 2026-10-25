using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using System;
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
            txtRoom.Clear();
            txtSubject.Clear();
            txtInstructor.Clear();
            cmbDay.SelectedIndex = -1;
            dtpStartTime.Value = DateTime.Today.AddHours(8); 
            dtpEndTime.Value = DateTime.Today.AddHours(9);   
        }

        private void dgvSchedules_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSchedules.SelectedRows.Count > 0)
            {
                _selectedSchedule = (ComLabSchedule)dgvSchedules.SelectedRows[0].DataBoundItem;
                txtRoom.Text = _selectedSchedule.ComLabName;
                txtSubject.Text = _selectedSchedule.SubjectCode;
                txtInstructor.Text = _selectedSchedule.InstructorName;
                cmbDay.SelectedItem = _selectedSchedule.DayOfWeek;
                dtpStartTime.Value = DateTime.Today.Add(_selectedSchedule.StartTime);
                dtpEndTime.Value = DateTime.Today.Add(_selectedSchedule.EndTime);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoom.Text) || string.IsNullOrWhiteSpace(txtSubject.Text) || cmbDay.SelectedItem == null)
            {
                MessageBox.Show("Room, Subject, and Day are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newSchedule = new ComLabSchedule
            {
                ComLabName = txtRoom.Text.Trim(),
                SubjectCode = txtSubject.Text.Trim(),
                InstructorName = txtInstructor.Text.Trim(),
                DayOfWeek = cmbDay.SelectedItem.ToString(),
                StartTime = dtpStartTime.Value.TimeOfDay,
                EndTime = dtpEndTime.Value.TimeOfDay
            };

            _scheduleRepo.AddSchedule(newSchedule);
            LoadSchedules();
            MessageBox.Show("Schedule added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedSchedule == null) return;

            _selectedSchedule.ComLabName = txtRoom.Text.Trim();
            _selectedSchedule.SubjectCode = txtSubject.Text.Trim();
            _selectedSchedule.InstructorName = txtInstructor.Text.Trim();
            _selectedSchedule.DayOfWeek = cmbDay.SelectedItem.ToString();
            _selectedSchedule.StartTime = dtpStartTime.Value.TimeOfDay;
            _selectedSchedule.EndTime = dtpEndTime.Value.TimeOfDay;

            _scheduleRepo.UpdateSchedule(_selectedSchedule);
            LoadSchedules();
            MessageBox.Show("Schedule updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedSchedule == null) return;

            var result = MessageBox.Show($"Are you sure you want to delete the schedule for {_selectedSchedule.SubjectCode}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _scheduleRepo.DeleteSchedule(_selectedSchedule.Id);
                LoadSchedules();
            }
        }
    }
}