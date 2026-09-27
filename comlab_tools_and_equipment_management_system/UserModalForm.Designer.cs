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
            groupBox1 = new GroupBox();
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
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(462, 340);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(10, 10);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lblModalTitle
            // 
            lblModalTitle.AutoSize = true;
            lblModalTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModalTitle.Location = new Point(138, 35);
            lblModalTitle.Margin = new Padding(4, 0, 4, 0);
            lblModalTitle.Name = "lblModalTitle";
            lblModalTitle.Size = new Size(204, 38);
            lblModalTitle.TabIndex = 1;
            lblModalTitle.Text = "Add New User";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(65, 214);
            lblPass.Margin = new Padding(4, 0, 4, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(87, 25);
            lblPass.TabIndex = 2;
            lblPass.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(65, 119);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // lblSRole
            // 
            lblSRole.AutoSize = true;
            lblSRole.Location = new Point(65, 325);
            lblSRole.Margin = new Padding(4, 0, 4, 0);
            lblSRole.Name = "lblSRole";
            lblSRole.Size = new Size(108, 25);
            lblSRole.TabIndex = 4;
            lblSRole.Text = "System Role";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(65, 148);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(351, 31);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(65, 244);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(351, 31);
            txtPassword.TabIndex = 6;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Technician", "Student" });
            cmbRole.Location = new Point(65, 355);
            cmbRole.Margin = new Padding(4);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(351, 33);
            cmbRole.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.LimeGreen;
            btnSave.DialogResult = DialogResult.OK;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(279, 442);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 44);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Gray;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(65, 442);
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
            lblEdit.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEdit.ForeColor = SystemColors.ControlDarkDark;
            lblEdit.Location = new Point(79, 278);
            lblEdit.Margin = new Padding(4, 0, 4, 0);
            lblEdit.Name = "lblEdit";
            lblEdit.Size = new Size(0, 25);
            lblEdit.TabIndex = 2;
            // 
            // UserModalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 528);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblSRole);
            Controls.Add(lblUsername);
            Controls.Add(lblEdit);
            Controls.Add(lblPass);
            Controls.Add(lblModalTitle);
            Controls.Add(groupBox1);
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

        private GroupBox groupBox1;
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
    }
}