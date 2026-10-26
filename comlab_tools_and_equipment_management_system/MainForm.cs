
using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using ComLabManager.UI.NavigationStrategies;
using ComLabManager.UI.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class MainForm : Form
    {
        private readonly IEquipmentRepository _equipmentRepository;
        private readonly IMaintenanceRepository _maintenanceRepository;
        private readonly IUserRepository _userRepository;
        private readonly IBorrowRequestRepository _borrowRepository;
        private readonly IComLabScheduleRepository _scheduleRepository;
        private readonly ISparePartRequestRepository _partRepository;
        private readonly ISparePartRepository _sparePartRepository; 
        private readonly IDashboardRepository _dashboardRepository;
        private readonly IPreventiveMaintenanceRepository _pmRepository;
        private User _currentUser;
        private UserControl _currentActiveView;
        private Button _activeButton;

        private readonly Dictionary<Button, (string Title, Func<UserControl> ViewFactory)> _navigationMap;

        public MainForm(
            IEquipmentRepository equipmentRepository,
            IBorrowRequestRepository borrowRepository,
            IComLabScheduleRepository scheduleRepository,
            IMaintenanceRepository maintenanceRepository,
            ISparePartRequestRepository partRepository,
            IUserRepository userRepository,
            ISparePartRepository sparePartRepository,
            IDashboardRepository dashboardRepository,
            IPreventiveMaintenanceRepository pmRepository)
        {
            InitializeComponent();

            _equipmentRepository = equipmentRepository ?? throw new ArgumentNullException(nameof(equipmentRepository));
            _borrowRepository = borrowRepository ?? throw new ArgumentNullException(nameof(borrowRepository));
            _scheduleRepository = scheduleRepository ?? throw new ArgumentNullException(nameof(scheduleRepository));
            _maintenanceRepository = maintenanceRepository ?? throw new ArgumentNullException(nameof(maintenanceRepository));
            _partRepository = partRepository ?? throw new ArgumentNullException(nameof(partRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _sparePartRepository = sparePartRepository ?? throw new ArgumentNullException(nameof(sparePartRepository));
            _dashboardRepository = dashboardRepository ?? throw new ArgumentNullException(nameof(dashboardRepository));
            _pmRepository = pmRepository ?? throw new ArgumentNullException(nameof(pmRepository));

            _navigationMap = new Dictionary<Button, (string, Func<UserControl> ViewFactory)>
{
    { btnNavDashboard, ("Dashboard", () => new DashboardView( _dashboardRepository,_scheduleRepository)) },
    { btnNavEquipment, ("Equipment Inventory", () => new EquipmentInventoryView(_equipmentRepository)) },
    
    
    { btnNavTickets, ("Maintenance Tickets", () => new MaintenanceView(_maintenanceRepository, _equipmentRepository, _userRepository, _sparePartRepository, _currentUser)) },

    { btnNavScheduler, ("Maintenance Scheduler", () => new PreventiveMaintenanceView(_pmRepository, _equipmentRepository, _userRepository, _currentUser)) },
    { btnNavUser, ("User Management", () => new UserManagementView(_userRepository)) },
    { btnNavSpareParts, ("", () => null) }, 
    { btnNavRequestApproval, ("", () => null) } 
};

            AttachNavigationEvents();
        }

        public void SetCurrentUser(User user, IRoleNavigationStrategy accessStrategy)
        {
            _currentUser = user ?? throw new ArgumentNullException(nameof(user));
            lblCurrentUser.Text = $"Viewing as: {_currentUser.UserName} ({_currentUser.Role})";

            
            _navigationMap[btnNavSpareParts] = ("Spare Parts", () =>
                new SparePartsView(_currentUser.Id, accessStrategy.CanEditInventory, _sparePartRepository, _partRepository));

            if (accessStrategy.UsesAdminApprovalView)
            {
                _navigationMap[btnNavRequestApproval] = ("Pending Requests", () =>
                    new AdminApprovalsView(_borrowRepository, _partRepository));
            }
            else
            {
                _navigationMap[btnNavRequestApproval] = ("My Requests", () =>
                    new StudentDashboardView(_equipmentRepository, _borrowRepository, _scheduleRepository, _currentUser.Id));
            }

          
            btnNavDashboard.Visible = accessStrategy.CanViewDashboard;
            btnNavEquipment.Visible = accessStrategy.CanViewEquipment;
            btnNavTickets.Visible = accessStrategy.CanViewTickets;
            btnNavSpareParts.Visible = accessStrategy.CanViewSpareParts;
            btnNavScheduler.Visible = accessStrategy.CanViewScheduler;
            btnNavUser.Visible = accessStrategy.CanViewUsers;
            btnNavRequestApproval.Visible = accessStrategy.CanViewRequest;

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
        public void OpenTickets() => UniversalNavigation_Click(btnNavTickets, EventArgs.Empty); 

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
        }

        private void HighlightActiveButton(Button clickedButton)
        {
            if (clickedButton == _activeButton) return;

            Color defaultColor = Color.FromArgb(30, 41, 59);
            foreach (var button in _navigationMap.Keys)
            {
                button.BackColor = defaultColor;
            }

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
            
         
               
                DialogResult result = MessageBox.Show(this,
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
    
