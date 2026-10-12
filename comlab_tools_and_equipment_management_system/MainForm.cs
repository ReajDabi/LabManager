using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using ComLabManager.UI.NavigationStrategies;
using ComLabManager.UI.Views;

namespace ComLabManager.UI
{
    public partial class MainForm : Form
    {
        private readonly IEquipmentRepository _equipmentRepository;
        private User _currentUser;


        private UserControl _currentActiveView;
        private Button _activeButton;

        private readonly Dictionary<Button, (string Title, Func<UserControl> ViewFactory)> _navigationMap;

        public MainForm(IEquipmentRepository equipmentRepository)
        {
            InitializeComponent();
            _equipmentRepository = equipmentRepository;


            _navigationMap = new Dictionary<Button, (string, Func<UserControl>)>
            {
                { btnNavDashboard, ("Dashboard", () => new DashboardView()) },
                { btnNavEquipment, ("Equipment Inventory", () => new EquipmentInventoryView()) },
                { btnNavTickets, ("Maintenance Tickets", () => new MaintenanceView()) },
                { btnNavSpareParts, ("Spare Parts", () => new SparePartsView()) },
                { btnNavScheduler, ("Maintenance Scheduler", () => new PreventiveMaintenanceView()) },
                { btnNavUser, ("User Management", () => new UserManagementView()) }


            };


            AttachNavigationEvents();
        }

        public void SetCurrentUser(User user, IRoleNavigationStrategy accessStrategy)
        {
            _currentUser = user;
            lblCurrentUser.Text = $"Viewing as: {_currentUser.UserName} ({_currentUser.Role})";


            if (_currentUser.Role == "Admin")
            {
                _navigationMap[btnNavRequestApproval] = ("Pending Requests", () => new AdminApprovalsView());
            }
            else if (_currentUser.Role == "Student" || _currentUser.Role == "Technician")
            {
                _navigationMap[btnNavRequestApproval] = ("My Requests", () => new StudentDashboardView(_equipmentRepository));
            }


            btnNavDashboard.Visible = accessStrategy.CanViewDashboard;
            btnNavEquipment.Visible = accessStrategy.CanViewEquipment;
            btnNavTickets.Visible = accessStrategy.CanViewTickets;
            btnNavSpareParts.Visible = accessStrategy.CanViewSpareParts;
            btnNavScheduler.Visible = accessStrategy.CanViewScheduler;
            btnNavUser.Visible = accessStrategy.CanViewUsers;

            lblMonitor.Visible = accessStrategy.CanViewDashboard;
            lblAssets.Visible = accessStrategy.CanViewEquipment;
            lblUM.Visible = accessStrategy.CanViewUsers;
            lblMaintenance.Visible = accessStrategy.CanViewTickets || accessStrategy.CanViewSpareParts;

            btnNavTickets.Text = accessStrategy.TicketButtonText;
            btnNavRequestApproval.Text = accessStrategy.RequestButtonText;

            accessStrategy.LoadInitialView(this);
        }


        public void OpenDashboard() => UniversalNavigation_Click(btnNavDashboard, EventArgs.Empty);
        public void OpenStudentDashboard() => UniversalNavigation_Click(btnNavRequestApproval, EventArgs.Empty);
        public void OpenTickets() => UniversalNavigation_Click(btnNavSpareParts, EventArgs.Empty);


        private void UniversalNavigation_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton && _navigationMap.TryGetValue(clickedButton, out var route))
            {
                HighlightActiveButton(clickedButton);
                lblPageTitle.Text = route.Title;
                LoadView(route.ViewFactory.Invoke());
            }
        }

        private void AttachNavigationEvents()
        {
            foreach (var button in _navigationMap.Keys)
            {

                button.Click += UniversalNavigation_Click;
            }


            btnNavRequestApproval.Click += UniversalNavigation_Click;
        }

        private void HighlightActiveButton(Button clickedButton)
        {
            if (clickedButton == _activeButton) return;


            Color defaultColor = Color.FromArgb(30, 41, 59);
            foreach (var button in _navigationMap.Keys)
            {
                button.BackColor = defaultColor;
            }

            btnNavRequestApproval.BackColor = defaultColor;
            clickedButton.BackColor = Color.FromArgb(0, 120, 215);
            _activeButton = clickedButton;
        }

        private void LoadView(UserControl view)
        {

            if (_currentActiveView != null)
            {
                pnlMainContent.Controls.Remove(_currentActiveView);
                _currentActiveView.Dispose();
            }

            _currentActiveView = view;
            _currentActiveView.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(_currentActiveView);
            _currentActiveView.BringToFront();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }
    }
}