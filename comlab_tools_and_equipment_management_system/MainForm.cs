using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using ComLabManager.UI.NavigationStrategies;

namespace ComLabManager.UI
{
    public partial class MainForm : Form
    {
        private readonly IEquipmentRepository _equipmentRepository;
        private User _currentUser;


        public MainForm(IEquipmentRepository equipmentRepository)
        {
            InitializeComponent();

            _equipmentRepository = equipmentRepository;
        }

        public void OpenDashboard() => btnNavDashboard_Click(btnNavDashboard, EventArgs.Empty);
        public void OpenTickets() => btnNavTickets_Click(btnNavTickets, EventArgs.Empty);




        //Limit other Users to certain views based on their role
        public void SetCurrentUser(User user, IRoleNavigationStrategy accessStrategy)
        {
            _currentUser = user;
            lblCurrentUser.Text = $"Viewing as: {_currentUser.UserName} ({_currentUser.Role})";


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

            accessStrategy.LoadInitialView(this);
        }




        //Button Logics etc...

        private Button _activeButton;

        private void HighlightActiveButton(Button clickedButton)
        {

            if (clickedButton == _activeButton) return;

            Color defaultColor = Color.FromArgb(30, 41, 59);
            btnNavDashboard.BackColor = defaultColor;
            btnNavEquipment.BackColor = defaultColor;
            btnNavTickets.BackColor = defaultColor;
            btnNavSpareParts.BackColor = defaultColor;
            btnNavScheduler.BackColor = defaultColor;


            clickedButton.BackColor = Color.FromArgb(0, 120, 215);


            _activeButton = clickedButton;
        }

        private void LoadView(UserControl view)
        {

            pnlMainContent.Controls.Clear();


            view.Dock = DockStyle.Fill;


            pnlMainContent.Controls.Add(view);
        }




        //Click Events

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            lblPageTitle.Text = "Dashboard";

            DashboardView dashView = new DashboardView();
            LoadView(dashView);
        }

        private void btnNavEquipment_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            lblPageTitle.Text = "Equipment Inventory";

            EquipmentView equipView = new EquipmentView();
            LoadView(equipView);
        }

        private void btnNavTickets_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            lblPageTitle.Text = "Maintenance Tickets";

            MaintenanceView maintenanceView = new MaintenanceView();
            LoadView(maintenanceView);
        }

        private void btnNavSpareParts_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            lblPageTitle.Text = "Spare Parts";

            SparePartsView sparepartview = new SparePartsView();
            LoadView(sparepartview);
        }

        private void btnNavScheduler_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            lblPageTitle.Text = "Maintenance Scheduler";

            PreventiveMaintenanceView preventivemaintenance = new PreventiveMaintenanceView();
            LoadView(preventivemaintenance);
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


        private void btnNavUser_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            lblPageTitle.Text = "User Management";

            UserManagementView usermanagement = new UserManagementView();
            LoadView(usermanagement);
        }
    }

}
    
