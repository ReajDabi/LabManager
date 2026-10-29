using ComLabManager.Core.Models;
using System;
using System.Drawing.Text;
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
            chkIsSuspended.Enabled = false;
            chkIsSuspended.Visible = false;

            if (chkIsSuspended != null) chkIsSuspended.Checked = false;
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkIsSuspended != null && cmbRole.SelectedItem != null)
            {

                chkIsSuspended.Enabled = cmbRole.SelectedItem.ToString() == "Student";


                if (!chkIsSuspended.Enabled)
                {
                    chkIsSuspended.Checked = false;
                }
            }
        }
        public UserModalForm(User existingUser)
        {
            InitializeComponent();
            lblModalTitle.Text = "    Edit User";
            _editingUserId = existingUser.Id;
            chkIsSuspended.Enabled = true;

            txtFirstName.Text = existingUser.FirstName;
            txtLastName.Text = existingUser.LastName;
            txtUsername.Text = existingUser.UserName;
            cmbRole.SelectedItem = existingUser.Role;

            if (chkIsSuspended != null) chkIsSuspended.Checked = existingUser.IsSuspended;

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
                Role = cmbRole.SelectedItem.ToString(),
                IsSuspended = chkIsSuspended != null && chkIsSuspended.Checked
            };

            RawPassword = txtPassword.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }



        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }
    }
}