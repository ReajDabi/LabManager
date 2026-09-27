namespace ComLabManager.UI
{
    partial class UserManagementView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btnAddUser = new Button();
            btnEditUser = new Button();
            button2 = new Button();
            dvgUsers = new DataGridView();
            userid = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            datacreated = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(btnEditUser);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 80);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(30, 17);
            label1.Name = "label1";
            label1.Size = new Size(260, 41);
            label1.TabIndex = 0;
            label1.Text = "User Mnagement";
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddUser.BackColor = Color.FromArgb(25, 135, 84);
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Location = new Point(783, 17);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(147, 41);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add New User";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // btnEditUser
            // 
            btnEditUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditUser.BackColor = Color.FromArgb(30, 41, 59);
            btnEditUser.FlatAppearance.BorderSize = 0;
            btnEditUser.FlatStyle = FlatStyle.Flat;
            btnEditUser.Location = new Point(621, 17);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(147, 41);
            btnEditUser.TabIndex = 2;
            btnEditUser.Text = "Edit / Reset";
            btnEditUser.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(229, 57, 69);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(452, 17);
            button2.Name = "button2";
            button2.Size = new Size(150, 41);
            button2.TabIndex = 3;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            // 
            // dvgUsers
            // 
            dvgUsers.AllowUserToAddRows = false;
            dvgUsers.BackgroundColor = Color.White;
            dvgUsers.BorderStyle = BorderStyle.None;
            dvgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgUsers.Columns.AddRange(new DataGridViewColumn[] { userid, username, role, datacreated });
            dvgUsers.Dock = DockStyle.Fill;
            dvgUsers.Location = new Point(0, 80);
            dvgUsers.Name = "dvgUsers";
            dvgUsers.RowHeadersVisible = false;
            dvgUsers.RowHeadersWidth = 51;
            dvgUsers.Size = new Size(958, 484);
            dvgUsers.TabIndex = 4;
            // 
            // userid
            // 
            userid.HeaderText = "UserId";
            userid.MinimumWidth = 6;
            userid.Name = "userid";
            userid.Visible = false;
            userid.Width = 125;
            // 
            // username
            // 
            username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            username.HeaderText = "Username";
            username.MinimumWidth = 6;
            username.Name = "username";
            // 
            // role
            // 
            role.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            role.HeaderText = "Role";
            role.MinimumWidth = 6;
            role.Name = "role";
            role.Width = 68;
            // 
            // datacreated
            // 
            datacreated.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datacreated.HeaderText = "Data Created";
            datacreated.MinimumWidth = 6;
            datacreated.Name = "datacreated";
            datacreated.Width = 126;
            // 
            // UserManagementView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(dvgUsers);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            Name = "UserManagementView";
            Size = new Size(958, 564);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnAddUser;
        private Button btnEditUser;
        private Button button2;
        private DataGridView dvgUsers;
        private DataGridViewTextBoxColumn userid;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn datacreated;
    }
}
