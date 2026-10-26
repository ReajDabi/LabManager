using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class ScheduleTaskForm : Form
    {
        private readonly IPreventiveMaintenanceRepository _pmRepo;
        private readonly List<Equipment> _equipment;
        private readonly PreventiveMaintenanceTask? _existingTask;

        public ScheduleTaskForm(IPreventiveMaintenanceRepository pmRepo, IEquipmentRepository equipmentRepo, IUserRepository userRepo, PreventiveMaintenanceTask? existingTask = null)
        {
            InitializeComponent();
            _pmRepo = pmRepo ?? throw new ArgumentNullException(nameof(pmRepo));
            _existingTask = existingTask;

            comboBoxLocation.Items.AddRange(LabLocations.All);
            comboBoxFrequency.Items.AddRange(new string[] { "Weekly", "Monthly", "Quarterly", "Biannually", "Annually" });

            _equipment = equipmentRepo.GetAllEquipment();

            // Suggest asset tags as the user types
            var assetTags = new AutoCompleteStringCollection();
            assetTags.AddRange(_equipment.Select(e => e.AssetTag).ToArray());
            textBox2.AutoCompleteCustomSource = assetTags;
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            comboBox1.Items.Add(new TechnicianOption(null, "(Unassigned)"));
            comboBox1.Items.AddRange(userRepo.GetUsersByRole("Technician")
                .Select(u => new TechnicianOption(u))
                .ToArray());
            comboBox1.SelectedIndex = 0;

            if (_existingTask != null)
            {
                this.Text = "Edit Task";
                label1.Text = "Edit Task";

                textBox1.Text = _existingTask.TaskName;
                comboBoxLocation.SelectedItem = _existingTask.TargetLocation;
                textBox2.Text = _existingTask.AssetTag ?? "";
                comboBoxFrequency.SelectedItem = _existingTask.Frequency;
                dateTimePicker1.Value = _existingTask.NextDueDate;
                comboBox1.SelectedItem = comboBox1.Items.Cast<TechnicianOption>()
                    .FirstOrDefault(o => o.Id == _existingTask.AssignedTo) ?? comboBox1.Items[0];
            }
            else
            {
                dateTimePicker1.Value = DateTime.Today;
            }
        }

        // Fill in the location from the equipment's station when the user picks an asset tag
        private void textBox2_Leave(object sender, EventArgs e)
        {
            var equipment = FindEquipment(textBox2.Text.Trim());
            if (equipment?.StationNumber == null) return;

            string? location = comboBoxLocation.Items.Cast<string>()
                .FirstOrDefault(l => equipment.StationNumber.StartsWith(l, StringComparison.OrdinalIgnoreCase));

            if (location != null)
                comboBoxLocation.SelectedItem = location;
        }

        private Equipment? FindEquipment(string assetTag)
        {
            return _equipment.FirstOrDefault(x => string.Equals(x.AssetTag, assetTag, StringComparison.OrdinalIgnoreCase));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taskName = textBox1.Text.Trim();
            string assetTag = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(taskName) || comboBoxLocation.SelectedItem == null || comboBoxFrequency.SelectedItem == null)
            {
                MessageBox.Show("Please enter the task, location, and frequency.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Equipment? equipment = null;
            if (!string.IsNullOrEmpty(assetTag))
            {
                equipment = FindEquipment(assetTag);

                if (equipment == null)
                {
                    MessageBox.Show($"No equipment found with asset tag '{assetTag}'.", "Unknown Asset Tag", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return;
                }
            }

            var task = new PreventiveMaintenance
            {
                Id = _existingTask?.Id ?? 0,
                TaskName = taskName,
                TargetLocation = comboBoxLocation.SelectedItem.ToString(),
                EquipmentId = equipment?.Id,
                Frequency = comboBoxFrequency.SelectedItem.ToString(),
                NextDueDate = dateTimePicker1.Value.Date,
                AssignedTo = (comboBox1.SelectedItem as TechnicianOption)?.Id
            };

            try
            {
                if (_existingTask == null)
                    _pmRepo.AddTask(task);
                else
                    _pmRepo.UpdateTask(task);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the task: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private class TechnicianOption
        {
            public int? Id { get; }
            private readonly string _label;

            public TechnicianOption(int? id, string label)
            {
                Id = id;
                _label = label;
            }

            public TechnicianOption(User user)
            {
                Id = user.Id;
                string fullName = $"{user.FirstName} {user.LastName}".Trim();
                _label = string.IsNullOrEmpty(fullName) ? user.UserName : fullName;
            }

            public override string ToString() => _label;
        }
    }
}
