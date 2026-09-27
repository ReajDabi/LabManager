using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class UserModalForm : Form
    {
       
        public int? EditingUserId { get; private set; }

        
        public UserModalForm()
        {
            InitializeComponent();
            lblModalTitle.Text = "Add New User";
            EditingUserId = null;
        }

        
        public UserModalForm(int userId, string username, string currentRole)
        {
            InitializeComponent();

            lblModalTitle.Text = "     Edit User";
            EditingUserId = userId;

          
            txtUsername.Text = username;
            cmbRole.SelectedItem = currentRole;

            lblEdit.Text = "(Leave password blank to keep current password)";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
