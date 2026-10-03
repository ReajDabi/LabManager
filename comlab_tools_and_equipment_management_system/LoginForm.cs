using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComlabManager.Core.Interfaces;
using ComLabManager.Core.Models;


namespace ComLabManager.UI
{
    public partial class LoginForm : Form
    {
        private readonly IUserRepository _userRepository;

        public User AuthenticatedUser { get; private set; }
        public LoginForm(IUserRepository userRepository)

        {

            InitializeComponent();
            _userRepository = userRepository;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please enter both username and password.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var user = _userRepository.AuthenticateUser(txtUsername.Text, txtPassword.Text);

                if (user == null)
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    return;

                }
                AuthenticatedUser = user;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                e.SuppressKeyPress = true;

               
                txtPassword.Focus();
            }
        }
    }
}
