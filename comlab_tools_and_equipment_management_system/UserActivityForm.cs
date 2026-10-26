using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class UserActivityForm : Form
    {
        private readonly IUserRepository _userRepo;
        private readonly User _selectedUser;

        public UserActivityForm(User user, IUserRepository userRepo)
        {
            InitializeComponent();
            _selectedUser = user;
            _userRepo = userRepo;

            lblTitle.Text = $"Activity Profile: {user.FirstName} {user.LastName} ({user.Role})";

            dgvBorrowHistory.AutoGenerateColumns = true;
            dgvMaintenanceHistory.AutoGenerateColumns = true;

            LoadData();
        }

        private void LoadData()
        {
            dgvBorrowHistory.DataSource = _userRepo.GetUserBorrowHistory(_selectedUser.Id);
            dgvMaintenanceHistory.DataSource = _userRepo.GetUserMaintenanceHistory(_selectedUser.Id);

            if (dgvBorrowHistory.Columns["Date"] != null)
                dgvBorrowHistory.Columns["Date"].DefaultCellStyle.Format = "MMM dd, yyyy";

            if (dgvMaintenanceHistory.Columns["Reported"] != null)
                dgvMaintenanceHistory.Columns["Reported"].DefaultCellStyle.Format = "MMM dd, yyyy";
        }
    }
}