namespace ComLabManager.UI
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            imageList1 = new ImageList(components);
            lblLogin = new Label();
            pnlLogin = new Panel();
            pbLogo = new PictureBox();
            lblWU = new Label();
            lblLM = new Label();
            lblUserName = new Label();
            lblPass = new Label();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(248, 249, 250);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(752, 235);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter User Name";
            txtUsername.Size = new Size(291, 45);
            txtUsername.TabIndex = 0;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(248, 249, 250);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(752, 327);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(291, 48);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(30, 41, 59);
            btnLogin.FlatAppearance.BorderColor = Color.White;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(752, 417);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(291, 52);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "SIGN IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Black;
            lblLogin.Location = new Point(818, 97);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(153, 54);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "Sign In";
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.FromArgb(30, 41, 59);
            pnlLogin.Controls.Add(pbLogo);
            pnlLogin.Controls.Add(lblWU);
            pnlLogin.Controls.Add(lblLM);
            pnlLogin.Dock = DockStyle.Left;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(615, 644);
            pnlLogin.TabIndex = 4;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(206, 65);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(184, 173);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            // 
            // lblWU
            // 
            lblWU.AutoSize = true;
            lblWU.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWU.ForeColor = Color.White;
            lblWU.Location = new Point(153, 337);
            lblWU.Name = "lblWU";
            lblWU.Size = new Size(268, 28);
            lblWU.TabIndex = 3;
            lblWU.Text = "Computer Laboratory System";
            // 
            // lblLM
            // 
            lblLM.AutoSize = true;
            lblLM.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLM.ForeColor = Color.White;
            lblLM.Location = new Point(141, 254);
            lblLM.Name = "lblLM";
            lblLM.Size = new Size(311, 65);
            lblLM.TabIndex = 3;
            lblLM.Text = "LabManager";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(100, 116, 139);
            lblUserName.Location = new Point(745, 196);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(97, 25);
            lblUserName.TabIndex = 5;
            lblUserName.Text = "Username";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPass.ForeColor = Color.FromArgb(100, 116, 139);
            lblPass.Location = new Point(745, 294);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(92, 25);
            lblPass.TabIndex = 5;
            lblPass.Text = "Password";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 644);
            Controls.Add(lblPass);
            Controls.Add(lblUserName);
            Controls.Add(pnlLogin);
            Controls.Add(lblLogin);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private ImageList imageList1;
        private Label lblLogin;
        private Panel pnlLogin;
        private Label lblUserName;
        private Label lblPass;
        private Label lblWU;
        private Label lblLM;
        private PictureBox pbLogo;
    }
}