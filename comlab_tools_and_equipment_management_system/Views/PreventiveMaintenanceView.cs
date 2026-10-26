using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class PreventiveMaintenanceView : UserControl
    {
        private readonly IPreventiveMaintenanceRepository? _pmRepo;
        private readonly IEquipmentRepository? _equipmentRepo;
        private readonly IUserRepository? _userRepo;
        private readonly User? _currentUser;

        private const int DueSoonDays = 7;

        public PreventiveMaintenanceView()
        {
            InitializeComponent();
        }

        public PreventiveMaintenanceView(IPreventiveMaintenanceRepository pmRepo, IEquipmentRepository equipmentRepo, IUserRepository userRepo, User currentUser)
        {
            _pmRepo = pmRepo ?? throw new ArgumentNullException(nameof(pmRepo));
            _equipmentRepo = equipmentRepo ?? throw new ArgumentNullException(nameof(equipmentRepo));
            _userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
            _currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));

            InitializeComponent();

            LoadTasks();
        }

        private void LoadTasks()
        {
            if (_pmRepo == null) return;

            try
            {
                dataGridView1.Rows.Clear();

                IEnumerable<PreventiveMaintenanceTask> tasks = _pmRepo.GetAllTasks();

                // Technicians see the tasks assigned to them first
                if (_currentUser?.Role == "Technician")
                {
                    tasks = tasks.OrderBy(t => t.AssignedTo == _currentUser.Id ? 0 : 1);
                }

                foreach (var t in tasks)
                {
                    string equipment = t.EquipmentId.HasValue ? $"{t.AssetTag} - {t.EquipmentName}" : "Whole lab";
                    string lastCompleted = t.LastCompleted?.ToString("yyyy-MM-dd") ?? "Never";
                    string status = GetDueStatus(t);

                    int rowIndex = dataGridView1.Rows.Add(t.TaskName, t.TargetLocation, equipment, t.Frequency, lastCompleted,
                        t.NextDueDate.ToString("yyyy-MM-dd"), status, t.AssignedToName ?? "Unassigned");

                    var row = dataGridView1.Rows[rowIndex];
                    row.Tag = t;

                    if (status == "Overdue")
                        row.DefaultCellStyle.BackColor = Color.MistyRose;
                    else if (status == "Due Soon")
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                }

                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the maintenance tasks: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateActionButtons();
        }

        private static string GetDueStatus(PreventiveMaintenanceTask task)
        {
            if (task.NextDueDate.Date < DateTime.Today) return "Overdue";
            if (task.NextDueDate.Date <= DateTime.Today.AddDays(DueSoonDays)) return "Due Soon";
            return "Scheduled";
        }

        private PreventiveMaintenanceTask? GetSelectedTask()
        {
            return dataGridView1.SelectedRows.Count > 0 ? dataGridView1.SelectedRows[0].Tag as PreventiveMaintenanceTask : null;
        }

        private void UpdateActionButtons()
        {
            bool hasSelection = GetSelectedTask() != null;
            buttonEdit.Enabled = hasSelection;
            buttonDelete.Enabled = hasSelection;
            buttonMarkDone.Enabled = hasSelection;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e) => UpdateActionButtons();

        private void buttonScheduleTask_Click(object sender, EventArgs e)
        {
            OpenTaskForm(null);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedTask();
            if (selected == null) return;

            OpenTaskForm(selected);
        }

        private void OpenTaskForm(PreventiveMaintenanceTask? existingTask)
        {
            if (_pmRepo == null || _equipmentRepo == null || _userRepo == null) return;

            try
            {
                using (ScheduleTaskForm taskForm = new ScheduleTaskForm(_pmRepo, _equipmentRepo, _userRepo, existingTask))
                {
                    if (taskForm.ShowDialog() == DialogResult.OK)
                        LoadTasks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the task form: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedTask();
            if (_pmRepo == null || selected == null) return;

            var result = MessageBox.Show($"Are you sure you want to delete the task '{selected.TaskName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            try
            {
                _pmRepo.DeleteTask(selected.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the task: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadTasks();
        }

        private void buttonMarkDone_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedTask();
            if (_pmRepo == null || selected == null) return;

            var result = MessageBox.Show($"Mark '{selected.TaskName}' as done today? The next due date will be moved forward based on its {selected.Frequency.ToLower()} frequency.",
                "Confirm Completion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                _pmRepo.CompleteTask(selected.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while completing the task: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadTasks();
        }
    }
}
