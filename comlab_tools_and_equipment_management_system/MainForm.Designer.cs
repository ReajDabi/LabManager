namespace ComLabManager.UI;
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        pnlHeader = new Panel();
        lblPageTitle = new Label();
        lblCurrentUser = new Label();
        btnNavDashboard = new Button();
        btnNavEquipment = new Button();
        btnNavTickets = new Button();
        btnNavSpareParts = new Button();
        btnNavScheduler = new Button();
        btnSignOut = new Button();
        pnlLogo = new Panel();
        pbLogo = new PictureBox();
        lblLogo = new Label();
        lblMonitor = new Label();
        lblAssets = new Label();
        lblMaintenance = new Label();
        pnlSidebar = new Panel();
        pnlMainContent = new Panel();
        pnlHeader.SuspendLayout();
        pnlLogo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
        pnlSidebar.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.White;
        pnlHeader.Controls.Add(lblPageTitle);
        pnlHeader.Controls.Add(lblCurrentUser);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(220, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(958, 80);
        pnlHeader.TabIndex = 1;
        // 
        // lblPageTitle
        // 
        lblPageTitle.AutoSize = true;
        lblPageTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblPageTitle.Location = new Point(59, 18);
        lblPageTitle.Name = "lblPageTitle";
        lblPageTitle.Size = new Size(159, 38);
        lblPageTitle.TabIndex = 2;
        lblPageTitle.Text = "Dashboard";
        // 
        // lblCurrentUser
        // 
        lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblCurrentUser.AutoSize = true;
        lblCurrentUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblCurrentUser.ForeColor = Color.DarkGray;
        lblCurrentUser.Location = new Point(827, 26);
        lblCurrentUser.Name = "lblCurrentUser";
        lblCurrentUser.Size = new Size(0, 28);
        lblCurrentUser.TabIndex = 6;
        // 
        // btnNavDashboard
        // 
        btnNavDashboard.BackColor = Color.FromArgb(30, 41, 59);
        btnNavDashboard.FlatAppearance.BorderSize = 0;
        btnNavDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
        btnNavDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
        btnNavDashboard.FlatStyle = FlatStyle.Flat;
        btnNavDashboard.ForeColor = Color.White;
        btnNavDashboard.Location = new Point(0, 122);
        btnNavDashboard.Name = "btnNavDashboard";
        btnNavDashboard.Padding = new Padding(15, 0, 0, 0);
        btnNavDashboard.Size = new Size(220, 45);
        btnNavDashboard.TabIndex = 0;
        btnNavDashboard.Text = "Dashboard";
        btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft;
        btnNavDashboard.UseVisualStyleBackColor = false;
        btnNavDashboard.Click += btnNavDashboard_Click;
        // 
        // btnNavEquipment
        // 
        btnNavEquipment.BackColor = Color.FromArgb(30, 41, 59);
        btnNavEquipment.FlatAppearance.BorderSize = 0;
        btnNavEquipment.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
        btnNavEquipment.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
        btnNavEquipment.FlatStyle = FlatStyle.Flat;
        btnNavEquipment.ForeColor = Color.White;
        btnNavEquipment.Location = new Point(0, 232);
        btnNavEquipment.Name = "btnNavEquipment";
        btnNavEquipment.Padding = new Padding(15, 0, 0, 0);
        btnNavEquipment.Size = new Size(220, 45);
        btnNavEquipment.TabIndex = 1;
        btnNavEquipment.Text = "Inventory";
        btnNavEquipment.TextAlign = ContentAlignment.MiddleLeft;
        btnNavEquipment.UseVisualStyleBackColor = false;
        btnNavEquipment.Click += btnNavEquipment_Click;
        // 
        // btnNavTickets
        // 
        btnNavTickets.BackColor = Color.FromArgb(30, 41, 59);
        btnNavTickets.FlatAppearance.BorderSize = 0;
        btnNavTickets.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
        btnNavTickets.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
        btnNavTickets.FlatStyle = FlatStyle.Flat;
        btnNavTickets.ForeColor = Color.White;
        btnNavTickets.Location = new Point(0, 335);
        btnNavTickets.Name = "btnNavTickets";
        btnNavTickets.Padding = new Padding(15, 0, 0, 0);
        btnNavTickets.Size = new Size(220, 45);
        btnNavTickets.TabIndex = 2;
        btnNavTickets.Text = "Maintenance ";
        btnNavTickets.TextAlign = ContentAlignment.MiddleLeft;
        btnNavTickets.UseVisualStyleBackColor = false;
        btnNavTickets.Click += btnNavTickets_Click;
        // 
        // btnNavSpareParts
        // 
        btnNavSpareParts.BackColor = Color.FromArgb(30, 41, 59);
        btnNavSpareParts.FlatAppearance.BorderSize = 0;
        btnNavSpareParts.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
        btnNavSpareParts.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
        btnNavSpareParts.FlatStyle = FlatStyle.Flat;
        btnNavSpareParts.ForeColor = Color.White;
        btnNavSpareParts.Location = new Point(0, 386);
        btnNavSpareParts.Name = "btnNavSpareParts";
        btnNavSpareParts.Padding = new Padding(15, 0, 0, 0);
        btnNavSpareParts.Size = new Size(220, 45);
        btnNavSpareParts.TabIndex = 3;
        btnNavSpareParts.Text = "Spare Parts";
        btnNavSpareParts.TextAlign = ContentAlignment.MiddleLeft;
        btnNavSpareParts.UseVisualStyleBackColor = false;
        btnNavSpareParts.Click += btnNavSpareParts_Click;
        // 
        // btnNavScheduler
        // 
        btnNavScheduler.BackColor = Color.FromArgb(30, 41, 59);
        btnNavScheduler.FlatAppearance.BorderSize = 0;
        btnNavScheduler.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
        btnNavScheduler.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
        btnNavScheduler.FlatStyle = FlatStyle.Flat;
        btnNavScheduler.ForeColor = Color.White;
        btnNavScheduler.Location = new Point(0, 437);
        btnNavScheduler.Name = "btnNavScheduler";
        btnNavScheduler.Padding = new Padding(15, 0, 0, 0);
        btnNavScheduler.Size = new Size(220, 45);
        btnNavScheduler.TabIndex = 4;
        btnNavScheduler.Text = "PM Scheduler";
        btnNavScheduler.TextAlign = ContentAlignment.MiddleLeft;
        btnNavScheduler.UseVisualStyleBackColor = false;
        btnNavScheduler.Click += btnNavScheduler_Click;
        // 
        // btnSignOut
        // 
        btnSignOut.BackColor = Color.FromArgb(30, 41, 59);
        btnSignOut.Dock = DockStyle.Bottom;
        btnSignOut.FlatAppearance.BorderSize = 0;
        btnSignOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
        btnSignOut.FlatAppearance.MouseOverBackColor = Color.Gray;
        btnSignOut.FlatStyle = FlatStyle.Flat;
        btnSignOut.ForeColor = Color.White;
        btnSignOut.Location = new Point(0, 599);
        btnSignOut.Name = "btnSignOut";
        btnSignOut.Padding = new Padding(15, 0, 0, 10);
        btnSignOut.Size = new Size(220, 45);
        btnSignOut.TabIndex = 4;
        btnSignOut.Text = "Sign Out";
        btnSignOut.TextAlign = ContentAlignment.MiddleLeft;
        btnSignOut.UseVisualStyleBackColor = false;
        btnSignOut.Click += btnSignOut_Click;
        // 
        // pnlLogo
        // 
        pnlLogo.BackColor = Color.FromArgb(30, 41, 59);
        pnlLogo.Controls.Add(pbLogo);
        pnlLogo.Controls.Add(lblLogo);
        pnlLogo.Dock = DockStyle.Top;
        pnlLogo.Location = new Point(0, 0);
        pnlLogo.Name = "pnlLogo";
        pnlLogo.Size = new Size(220, 70);
        pnlLogo.TabIndex = 5;
        // 
        // pbLogo
        // 
        pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
        pbLogo.Location = new Point(11, 12);
        pbLogo.Name = "pbLogo";
        pbLogo.Size = new Size(49, 48);
        pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
        pbLogo.TabIndex = 7;
        pbLogo.TabStop = false;
        // 
        // lblLogo
        // 
        lblLogo.AutoSize = true;
        lblLogo.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblLogo.ForeColor = Color.FromArgb(148, 163, 184);
        lblLogo.Location = new Point(65, 10);
        lblLogo.Name = "lblLogo";
        lblLogo.Padding = new Padding(0, 15, 5, 10);
        lblLogo.Size = new Size(124, 46);
        lblLogo.TabIndex = 6;
        lblLogo.Text = "LABMANAGER";
        // 
        // lblMonitor
        // 
        lblMonitor.AutoSize = true;
        lblMonitor.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblMonitor.ForeColor = Color.FromArgb(148, 163, 184);
        lblMonitor.Location = new Point(6, 73);
        lblMonitor.Name = "lblMonitor";
        lblMonitor.Padding = new Padding(0, 15, 5, 10);
        lblMonitor.Size = new Size(90, 46);
        lblMonitor.TabIndex = 6;
        lblMonitor.Text = "MONITOR";
        // 
        // lblAssets
        // 
        lblAssets.AutoSize = true;
        lblAssets.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblAssets.ForeColor = Color.FromArgb(148, 163, 184);
        lblAssets.Location = new Point(6, 174);
        lblAssets.Name = "lblAssets";
        lblAssets.Padding = new Padding(0, 15, 5, 10);
        lblAssets.Size = new Size(71, 46);
        lblAssets.TabIndex = 6;
        lblAssets.Text = "ASSETS";
        // 
        // lblMaintenance
        // 
        lblMaintenance.AutoSize = true;
        lblMaintenance.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblMaintenance.ForeColor = Color.FromArgb(148, 163, 184);
        lblMaintenance.Location = new Point(6, 280);
        lblMaintenance.Name = "lblMaintenance";
        lblMaintenance.Padding = new Padding(0, 15, 5, 10);
        lblMaintenance.Size = new Size(133, 46);
        lblMaintenance.TabIndex = 6;
        lblMaintenance.Text = "MAINTENANCE";
        // 
        // pnlSidebar
        // 
        pnlSidebar.BackColor = Color.FromArgb(30, 41, 59);
        pnlSidebar.Controls.Add(lblMaintenance);
        pnlSidebar.Controls.Add(lblAssets);
        pnlSidebar.Controls.Add(lblMonitor);
        pnlSidebar.Controls.Add(pnlLogo);
        pnlSidebar.Controls.Add(btnSignOut);
        pnlSidebar.Controls.Add(btnNavScheduler);
        pnlSidebar.Controls.Add(btnNavSpareParts);
        pnlSidebar.Controls.Add(btnNavTickets);
        pnlSidebar.Controls.Add(btnNavEquipment);
        pnlSidebar.Controls.Add(btnNavDashboard);
        pnlSidebar.Dock = DockStyle.Left;
        pnlSidebar.Location = new Point(0, 0);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.Size = new Size(220, 644);
        pnlSidebar.TabIndex = 1;
        // 
        // pnlMainContent
        // 
        pnlMainContent.Dock = DockStyle.Fill;
        pnlMainContent.Location = new Point(220, 80);
        pnlMainContent.Name = "pnlMainContent";
        pnlMainContent.Size = new Size(958, 564);
        pnlMainContent.TabIndex = 2;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(248, 249, 250);
        ClientSize = new Size(1178, 644);
        Controls.Add(pnlMainContent);
        Controls.Add(pnlHeader);
        Controls.Add(pnlSidebar);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "LabManager-Computer Laboratory System";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlLogo.ResumeLayout(false);
        pnlLogo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
        pnlSidebar.ResumeLayout(false);
        pnlSidebar.PerformLayout();
        ResumeLayout(false);
    }


    #endregion
    private Panel pnlHeader;
    private Label lblPageTitle;
    private Label lblCurrentUser;
    private Button btnNavDashboard;
    private Button btnNavEquipment;
    private Button btnNavTickets;
    private Button btnNavSpareParts;
    private Button btnNavScheduler;
    private Button btnSignOut;
    private Panel pnlLogo;
    private Label lblLogo;
    private Label lblMonitor;
    private Label lblAssets;
    private Label lblMaintenance;
    private Panel pnlSidebar;
    private Panel pnlMainContent;
    private PictureBox pbLogo;
}

