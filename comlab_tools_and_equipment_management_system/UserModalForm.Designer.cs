namespace ComLabManager.UI
{
    partial class UserModalForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblModalTitle = new Label();
            lblPass = new Label();
            lblUsername = new Label();
            lblSRole = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cmbRole = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblEdit = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            chkIsSuspended = new CheckBox();
            SuspendLayout();
            // 
            // lblModalTitle
            // 
            lblModalTitle.AutoSize = true;
            lblModalTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModalTitle.Location = new Point(130, 30);
            lblModalTitle.Margin = new Padding(4, 0, 4, 0);
            lblModalTitle.Name = "lblModalTitle";
            lblModalTitle.Size = new Size(292, 48);
            lblModalTitle.TabIndex = 1;
            lblModalTitle.Text = "ADD NEW USER";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(287, 247);
            lblPass.Margin = new Padding(4, 0, 4, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(87, 25);
            lblPass.TabIndex = 2;
            lblPass.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(56, 243);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // lblSRole
            // 
            lblSRole.AutoSize = true;
            lblSRole.Location = new Point(57, 340);
            lblSRole.Margin = new Padding(4, 0, 4, 0);
            lblSRole.Name = "lblSRole";
            lblSRole.Size = new Size(108, 25);
            lblSRole.TabIndex = 4;
            lblSRole.Text = "System Role";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(56, 272);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(196, 31);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(287, 276);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(196, 31);
            txtPassword.TabIndex = 6;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Technician", "Student" });
            cmbRole.Location = new Point(57, 369);
            cmbRole.Margin = new Padding(4);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(195, 33);
            cmbRole.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.Green;
            btnSave.DialogResult = DialogResult.OK;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(349, 459);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 44);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Gray;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(57, 459);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 44);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblEdit
            // 
            lblEdit.AutoSize = true;
            lblEdit.Font = new Font("Segoe UI", 7F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEdit.ForeColor = SystemColors.ControlDarkDark;
            lblEdit.Location = new Point(204, 307);
            lblEdit.Margin = new Padding(4, 0, 4, 0);
            lblEdit.Name = "lblEdit";
            lblEdit.Size = new Size(0, 19);
            lblEdit.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(57, 179);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(195, 31);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(287, 179);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(199, 31);
            txtLastName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 150);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 150);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // chkIsSuspended
            // 
            chkIsSuspended.AutoSize = true;
            chkIsSuspended.Location = new Point(300, 371);
            chkIsSuspended.Name = "chkIsSuspended";
            chkIsSuspended.Size = new Size(177, 29);
            chkIsSuspended.TabIndex = 10;
            chkIsSuspended.Text = "Suspend Account";
            chkIsSuspended.UseVisualStyleBackColor = true;
            // 
            // UserModalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 539);
            Controls.Add(chkIsSuspended);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtUsername);
            Controls.Add(lblSRole);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblUsername);
            Controls.Add(lblEdit);
            Controls.Add(lblPass);
            Controls.Add(lblModalTitle);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserModalForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UserModalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblModalTitle;
        private Label lblPass;
        private Label lblUsername;
        private Label lblSRole;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cmbRole;
        private Button btnSave;
        private Button btnCancel;
        private Label lblEdit;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label1;
        private Label label2;
        private CheckBox chkIsSuspended;
    }
}