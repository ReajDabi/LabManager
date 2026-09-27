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
            lblUM = new Label();
            btnDel = new Button();
            btnAddUser = new Button();
            btnEditUser = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            dvgUsers = new DataGridView();
            userid = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            datacreated = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgUsers).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblUM);
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
            // lblUM
            // 
            lblUM.AutoSize = true;
            lblUM.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUM.ForeColor = Color.FromArgb(30, 41, 59);
            lblUM.Location = new Point(38, 21);
            lblUM.Margin = new Padding(4, 0, 4, 0);
            lblUM.Name = "lblUM";
            lblUM.Size = new Size(328, 48);
            lblUM.TabIndex = 0;
            lblUM.Text = "User Management";
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
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // dvgUsers
            // 
            dvgUsers.AllowUserToAddRows = false;
            dvgUsers.BackgroundColor = Color.White;
            dvgUsers.BorderStyle = BorderStyle.None;
            dvgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgUsers.Columns.AddRange(new DataGridViewColumn[] { userid, username, role, datacreated });
            dvgUsers.Dock = DockStyle.Fill;
            dvgUsers.Location = new Point(0, 100);
            dvgUsers.Margin = new Padding(4);
            dvgUsers.Name = "dvgUsers";
            dvgUsers.RowHeadersVisible = false;
            dvgUsers.RowHeadersWidth = 51;
            dvgUsers.Size = new Size(958, 464);
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
            Controls.Add(dvgUsers);
            Controls.Add(pnlHeader);
            ForeColor = SystemColors.Control;
            Margin = new Padding(4);
            Name = "UserManagementView";
            Size = new Size(958, 564);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblUM;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnAddUser;
        private Button btnEditUser;
        private Button btnDel;
        private DataGridView dvgUsers;
        private DataGridViewTextBoxColumn userid;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn datacreated;
    }
}
