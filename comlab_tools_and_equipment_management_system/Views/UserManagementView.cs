using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace ComLabManager.UI
{
    public partial class UserManagementView : UserControl
    {
        public UserManagementView()
        {
            InitializeComponent();
        }

        //Add user button click event handler
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserModalForm form = new UserModalForm();
           if (form.ShowDialog() == DialogResult.OK)
            {
                // Execute SQL INSERT using form.EditingUserId
            }
        }






        //Delete user button click event handler
        private void btnDel_Click(object sender, EventArgs e)
        {
           /*
            int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value);
            string username = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString();*/

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to permanently delete user 'Reaj'?", // Replace 'Reaj' with the actual username variable if oks na
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // _userRepository.DeleteUser(userId);
                // RefreshGrid();
            }
        }









        //Edit user button click event handler
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            /*   int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value);
               string username = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString();
               string role = dgvUsers.SelectedRows[0].Cells["Role"].Value.ToString();
            */


            
            

            UserModalForm modal = new UserModalForm(1, "John Doe", "Admin"); //userId, username, role (i sulod rani if naka connect na sa backend)  Calls Constructor 2
            
            if (modal.ShowDialog() == DialogResult.OK)
            {
                // Execute SQL UPDATE using modal.EditingUserId
            }
        }
    }
}
