using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using System;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class UserManagementView : UserControl
    {
        private readonly IUserRepository _userRepository;
        
        public UserManagementView(IUserRepository userRepository)
        {
            InitializeComponent();
            dgvUsers.DefaultCellStyle.ForeColor = Color.Black;
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));

            dgvUsers.AutoGenerateColumns = true;
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgvUsers.DataSource = _userRepository.GetAllUsers();

            if (dgvUsers.Columns["PasswordHash"] != null) dgvUsers.Columns["PasswordHash"].Visible = false;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (UserModalForm form = new UserModalForm())
            {
                if (form.ShowDialog() == DialogResult.OK && form.ProcessedUser != null) 
                {
                    _userRepository.AddUser(form.ProcessedUser, form.RawPassword);
                    LoadUsers();
                }
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) return;

            var selectedUser = (User)dgvUsers.SelectedRows[0].DataBoundItem;

            using (UserModalForm modal = new UserModalForm(selectedUser))
            {
                if (modal.ShowDialog() == DialogResult.OK && modal.ProcessedUser != null) 
                {
                    _userRepository.UpdateUser(modal.ProcessedUser, modal.RawPassword);
                    LoadUsers();
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) return;

            var selectedUser = (User)dgvUsers.SelectedRows[0].DataBoundItem;

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to permanently delete user '{selectedUser.UserName}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _userRepository.DeleteUser(selectedUser.Id);
                LoadUsers();
            }
        }
    }
}