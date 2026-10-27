using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class UserManagementView : UserControl
    {
        private readonly IUserRepository _userRepository;
        private readonly int _currentUserId;

        public UserManagementView(IUserRepository userRepository, int currentUserId)
        {
            InitializeComponent();
            dgvUsers.DefaultCellStyle.ForeColor = Color.Black;
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _currentUserId = currentUserId;

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
                    try
                    {
                        _userRepository.AddUser(form.ProcessedUser, form.RawPassword);
                    }
                    catch (MySqlException ex) when (ex.Number == 1062)
                    {
                        MessageBox.Show($"The username '{form.ProcessedUser.UserName}' is already taken.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while adding the user: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

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
                    try
                    {
                        _userRepository.UpdateUser(modal.ProcessedUser, modal.RawPassword);
                    }
                    catch (MySqlException ex) when (ex.Number == 1062)
                    {
                        MessageBox.Show($"The username '{modal.ProcessedUser.UserName}' is already taken.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while updating the user: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadUsers();
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) return;

            var selectedUser = (User)dgvUsers.SelectedRows[0].DataBoundItem;

            if (selectedUser.Id == _currentUserId)
            {
                MessageBox.Show("You cannot delete the account you are currently signed in with.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to permanently delete user '{selectedUser.UserName}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _userRepository.DeleteUser(selectedUser.Id);
                }
                // 1451: the user is still referenced by a maintenance ticket they reported
                catch (MySqlException ex) when (ex.Number == 1451)
                {
                    MessageBox.Show($"'{selectedUser.UserName}' has reported maintenance tickets and cannot be deleted. Suspend the account instead.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the user: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadUsers();
            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvUsers.Rows[e.RowIndex].DataBoundItem is User selectedUser)
            {

                using (UserActivityForm profileForm = new UserActivityForm(selectedUser, _userRepository))
                {
                    profileForm.ShowDialog();
                }
            }

        }
    }
}
