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
        pnlHeader.Location = new Point(176, 0);
        pnlHeader.Margin = new Padding(2);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(766, 64);
        pnlHeader.TabIndex = 1;
        // 
        // lblPageTitle
        // 
        lblPageTitle.AutoSize = true;
        lblPageTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblPageTitle.Location = new Point(47, 14);
        lblPageTitle.Margin = new Padding(2, 0, 2, 0);
        lblPageTitle.Name = "lblPageTitle";
        lblPageTitle.Size = new Size(138, 32);
        lblPageTitle.TabIndex = 2;
        lblPageTitle.Text = "Dashboard";
        // 
        // lblCurrentUser
        // 
        lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblCurrentUser.AutoSize = true;
        lblCurrentUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblCurrentUser.ForeColor = Color.DarkGray;
        lblCurrentUser.Location = new Point(662, 21);
        lblCurrentUser.Margin = new Padding(2, 0, 2, 0);
        lblCurrentUser.Name = "lblCurrentUser";
        lblCurrentUser.Size = new Size(0, 23);
        lblCurrentUser.TabIndex = 6;
        // 
        // btnNavDashboard
        // 
        btnNavDashboard.BackColor = Color.FromArgb(30, 41, 59);
        btnNavDashboard.Dock = DockStyle.Top;
        btnNavDashboard.FlatAppearance.BorderSize = 0;
        btnNavDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
        btnNavDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
        btnNavDashboard.FlatStyle = FlatStyle.Flat;
        btnNavDashboard.ForeColor = Color.White;
        btnNavDashboard.Location = new Point(0, 95);
        btnNavDashboard.Margin = new Padding(2);
        btnNavDashboard.Name = "btnNavDashboard";
        btnNavDashboard.Padding = new Padding(12, 0, 0, 0);
        btnNavDashboard.Size = new Size(176, 36);
        btnNavDashboard.TabIndex = 0;
        btnNavDashboard.Text = "Dashboard";
        btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft;
        btnNavDashboard.UseVisualStyleBackColor = false;
        btnNavDashboard.Click += btnNavDashboard_Click;
        // 
        // btnNavEquipment
        // 
        btnNavEquipment.BackColor = Color.FromArgb(30, 41, 59);
        btnNavEquipment.Dock = DockStyle.Top;
        btnNavEquipment.FlatAppearance.BorderSize = 0;
        btnNavEquipment.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
        btnNavEquipment.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
        btnNavEquipment.FlatStyle = FlatStyle.Flat;
        btnNavEquipment.ForeColor = Color.White;
        btnNavEquipment.Location = new Point(0, 170);
        btnNavEquipment.Margin = new Padding(2);
        btnNavEquipment.Name = "btnNavEquipment";
        btnNavEquipment.Padding = new Padding(12, 0, 0, 0);
        btnNavEquipment.Size = new Size(176, 36);
        btnNavEquipment.TabIndex = 1;
        btnNavEquipment.Text = "Inventory";
        btnNavEquipment.TextAlign = ContentAlignment.MiddleLeft;
        btnNavEquipment.UseVisualStyleBackColor = false;
        btnNavEquipment.Click += btnNavEquipment_Click;
        // 
        // btnNavTickets
        // 
        btnNavTickets.BackColor = Color.FromArgb(30, 41, 59);
        btnNavTickets.Dock = DockStyle.Top;
        btnNavTickets.FlatAppearance.BorderSize = 0;
        btnNavTickets.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
        btnNavTickets.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
        btnNavTickets.FlatStyle = FlatStyle.Flat;
        btnNavTickets.ForeColor = Color.White;
        btnNavTickets.Location = new Point(0, 245);
        btnNavTickets.Margin = new Padding(2);
        btnNavTickets.Name = "btnNavTickets";
        btnNavTickets.Padding = new Padding(12, 0, 0, 0);
        btnNavTickets.Size = new Size(176, 36);
        btnNavTickets.TabIndex = 2;
        btnNavTickets.Text = "Maintenance ";
        btnNavTickets.TextAlign = ContentAlignment.MiddleLeft;
        btnNavTickets.UseVisualStyleBackColor = false;
        btnNavTickets.Click += btnNavTickets_Click;
        // 
        // btnNavSpareParts
        // 
        btnNavSpareParts.BackColor = Color.FromArgb(30, 41, 59);
        btnNavSpareParts.Dock = DockStyle.Top;
        btnNavSpareParts.FlatAppearance.BorderSize = 0;
        btnNavSpareParts.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
        btnNavSpareParts.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
        btnNavSpareParts.FlatStyle = FlatStyle.Flat;
        btnNavSpareParts.ForeColor = Color.White;
        btnNavSpareParts.Location = new Point(0, 281);
        btnNavSpareParts.Margin = new Padding(2);
        btnNavSpareParts.Name = "btnNavSpareParts";
        btnNavSpareParts.Padding = new Padding(12, 0, 0, 0);
        btnNavSpareParts.Size = new Size(176, 36);
        btnNavSpareParts.TabIndex = 3;
        btnNavSpareParts.Text = "Spare Parts";
        btnNavSpareParts.TextAlign = ContentAlignment.MiddleLeft;
        btnNavSpareParts.UseVisualStyleBackColor = false;
        btnNavSpareParts.Click += btnNavSpareParts_Click;
        // 
        // btnNavScheduler
        // 
        btnNavScheduler.BackColor = Color.FromArgb(30, 41, 59);
        btnNavScheduler.Dock = DockStyle.Top;
        btnNavScheduler.FlatAppearance.BorderSize = 0;
        btnNavScheduler.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
        btnNavScheduler.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
        btnNavScheduler.FlatStyle = FlatStyle.Flat;
        btnNavScheduler.ForeColor = Color.White;
        btnNavScheduler.Location = new Point(0, 317);
        btnNavScheduler.Margin = new Padding(2);
        btnNavScheduler.Name = "btnNavScheduler";
        btnNavScheduler.Padding = new Padding(12, 0, 0, 0);
        btnNavScheduler.Size = new Size(176, 36);
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
        btnSignOut.Location = new Point(0, 479);
        btnSignOut.Margin = new Padding(2);
        btnSignOut.Name = "btnSignOut";
        btnSignOut.Padding = new Padding(12, 0, 0, 8);
        btnSignOut.Size = new Size(176, 36);
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
        pnlLogo.Margin = new Padding(2);
        pnlLogo.Name = "pnlLogo";
        pnlLogo.Size = new Size(176, 56);
        pnlLogo.TabIndex = 5;
        // 
        // pbLogo
        // 
        pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
        pbLogo.Location = new Point(9, 10);
        pbLogo.Margin = new Padding(2);
        pbLogo.Name = "pbLogo";
        pbLogo.Size = new Size(39, 38);
        pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
        pbLogo.TabIndex = 7;
        pbLogo.TabStop = false;
        // 
        // lblLogo
        // 
        lblLogo.AutoSize = true;
        lblLogo.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblLogo.ForeColor = Color.FromArgb(148, 163, 184);
        lblLogo.Location = new Point(52, 8);
        lblLogo.Margin = new Padding(2, 0, 2, 0);
        lblLogo.Name = "lblLogo";
        lblLogo.Padding = new Padding(0, 12, 4, 8);
        lblLogo.Size = new Size(109, 39);
        lblLogo.TabIndex = 6;
        lblLogo.Text = "LABMANAGER";
        // 
        // lblMonitor
        // 
        lblMonitor.AutoSize = true;
        lblMonitor.Dock = DockStyle.Top;
        lblMonitor.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblMonitor.ForeColor = Color.FromArgb(148, 163, 184);
        lblMonitor.Location = new Point(0, 131);
        lblMonitor.Margin = new Padding(2, 0, 2, 0);
        lblMonitor.Name = "lblMonitor";
        lblMonitor.Padding = new Padding(0, 12, 4, 8);
        lblMonitor.Size = new Size(79, 39);
        lblMonitor.TabIndex = 6;
        lblMonitor.Text = "MONITOR";
        // 
        // lblAssets
        // 
        lblAssets.AutoSize = true;
        lblAssets.Dock = DockStyle.Top;
        lblAssets.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblAssets.ForeColor = Color.FromArgb(148, 163, 184);
        lblAssets.Location = new Point(0, 56);
        lblAssets.Margin = new Padding(2, 0, 2, 0);
        lblAssets.Name = "lblAssets";
        lblAssets.Padding = new Padding(0, 12, 4, 8);
        lblAssets.Size = new Size(62, 39);
        lblAssets.TabIndex = 6;
        lblAssets.Text = "ASSETS";
        // 
        // lblMaintenance
        // 
        lblMaintenance.AutoSize = true;
        lblMaintenance.Dock = DockStyle.Top;
        lblMaintenance.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblMaintenance.ForeColor = Color.FromArgb(148, 163, 184);
        lblMaintenance.Location = new Point(0, 206);
        lblMaintenance.Margin = new Padding(2, 0, 2, 0);
        lblMaintenance.Name = "lblMaintenance";
        lblMaintenance.Padding = new Padding(0, 12, 4, 8);
        lblMaintenance.Size = new Size(114, 39);
        lblMaintenance.TabIndex = 6;
        lblMaintenance.Text = "MAINTENANCE";
        // 
        // pnlSidebar
        // 
        pnlSidebar.BackColor = Color.FromArgb(30, 41, 59);
        pnlSidebar.Controls.Add(btnNavScheduler);
        pnlSidebar.Controls.Add(btnNavSpareParts);
        pnlSidebar.Controls.Add(btnNavTickets);
        pnlSidebar.Controls.Add(lblMaintenance);
        pnlSidebar.Controls.Add(btnNavEquipment);
        pnlSidebar.Controls.Add(lblMonitor);
        pnlSidebar.Controls.Add(btnNavDashboard);
        pnlSidebar.Controls.Add(lblAssets);
        pnlSidebar.Controls.Add(pnlLogo);
        pnlSidebar.Controls.Add(btnSignOut);
        pnlSidebar.Dock = DockStyle.Left;
        pnlSidebar.Location = new Point(0, 0);
        pnlSidebar.Margin = new Padding(2);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.Size = new Size(176, 515);
        pnlSidebar.TabIndex = 1;
        // 
        // pnlMainContent
        // 
        pnlMainContent.Dock = DockStyle.Fill;
        pnlMainContent.Location = new Point(176, 64);
        pnlMainContent.Margin = new Padding(2);
        pnlMainContent.Name = "pnlMainContent";
        pnlMainContent.Size = new Size(766, 451);
        pnlMainContent.TabIndex = 2;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(248, 249, 250);
        ClientSize = new Size(942, 515);
        Controls.Add(pnlMainContent);
        Controls.Add(pnlHeader);
        Controls.Add(pnlSidebar);
        Margin = new Padding(2);
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

