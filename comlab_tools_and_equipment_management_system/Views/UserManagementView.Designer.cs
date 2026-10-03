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
            pnlHeader = new Panel();
            btnDel = new Button();
            btnAddUser = new Button();
            btnEditUser = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            dgvUsers = new DataGridView();
            userid = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            datacreated = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnDel);
            pnlHeader.Controls.Add(btnAddUser);
            pnlHeader.Controls.Add(btnEditUser);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(958, 100);
            pnlHeader.TabIndex = 0;
            // 
            // btnDel
            // 
            btnDel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDel.BackColor = Color.FromArgb(229, 57, 69);
            btnDel.FlatAppearance.BorderSize = 0;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Location = new Point(508, 34);
            btnDel.Margin = new Padding(4);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(125, 38);
            btnDel.TabIndex = 3;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddUser.BackColor = Color.FromArgb(25, 135, 84);
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Location = new Point(798, 34);
            btnAddUser.Margin = new Padding(4);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(125, 38);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add New User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditUser.BackColor = Color.FromArgb(30, 41, 59);
            btnEditUser.FlatAppearance.BorderSize = 0;
            btnEditUser.FlatStyle = FlatStyle.Flat;
            btnEditUser.Location = new Point(651, 34);
            btnEditUser.Margin = new Padding(4);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(125, 38);
            btnEditUser.TabIndex = 2;
            btnEditUser.Text = "Edit / Reset";
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { userid, username, role, datacreated });
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(0, 100);
            dgvUsers.Margin = new Padding(4);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(958, 464);
            dgvUsers.TabIndex = 4;
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
            role.Width = 82;
            // 
            // datacreated
            // 
            datacreated.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datacreated.HeaderText = "Data Created";
            datacreated.MinimumWidth = 6;
            datacreated.Name = "datacreated";
            datacreated.Width = 151;
            // 
            // UserManagementView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(dgvUsers);
            Controls.Add(pnlHeader);
            ForeColor = SystemColors.Control;
            Margin = new Padding(4);
            Name = "UserManagementView";
            Size = new Size(958, 564);
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnAddUser;
        private Button btnEditUser;
        private Button btnDel;
        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn userid;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn datacreated;
    }
}
