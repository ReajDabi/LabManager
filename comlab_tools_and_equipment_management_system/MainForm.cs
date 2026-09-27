using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;

namespace ComLabManager.UI
{
    public partial class MainForm : Form
    {
        private readonly IEquipmentRepository _equipmentRepository;
        private User _currentUser;


        public MainForm(IEquipmentRepository equipmentRepository)
        {
            InitializeComponent();
            btnNavDashboard_Click(btnNavDashboard, EventArgs.Empty);
            _equipmentRepository = equipmentRepository;
        }


        public void SetCurrentUser(User user)
        {
            _currentUser = user;

            lblCurrentUser.Text = $"Viewing as: {_currentUser.UserName} ({_currentUser.Role})";
        }

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
    
