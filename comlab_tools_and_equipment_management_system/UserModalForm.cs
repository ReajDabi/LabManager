using ComLabManager.Core.Models;
using System;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class UserModalForm : Form
    {
        public User ProcessedUser { get; private set; }
        public string RawPassword { get; private set; }
        private readonly int? _editingUserId;

       
        public UserModalForm()
        {
            InitializeComponent();
            lblModalTitle.Text = "Add New User";
            _editingUserId = null;
        }

       
        public UserModalForm(User existingUser)
        {
            InitializeComponent();
            lblModalTitle.Text = "   Edit User";
            _editingUserId = existingUser.Id;

            txtFirstName.Text = existingUser.FirstName;
            txtLastName.Text = existingUser.LastName;
            txtUsername.Text = existingUser.UserName;
            cmbRole.SelectedItem = existingUser.Role;

            if (lblEdit != null) lblEdit.Text = "(Leave password blank to keep current password)";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            this.DialogResult = DialogResult.None;

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) || cmbRole.SelectedItem == null)
            {
                MessageBox.Show("First Name, Last Name, Username, and Role are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_editingUserId == null && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("A password is required for new users.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProcessedUser = new User
            {
                Id = _editingUserId ?? 0,
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                UserName = txtUsername.Text.Trim(),
                Role = cmbRole.SelectedItem.ToString()
            };

            RawPassword = txtPassword.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}