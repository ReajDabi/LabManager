namespace ComLabManager.UI
{
    partial class DashboardView
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
            components = new System.ComponentModel.Container();
            pnlMetrics = new Panel();
            tblCards = new TableLayoutPanel();
            cardActiveAssets = new ComLabManager.UI.Views.Controls.KpiCard();
            cardHighUsage = new ComLabManager.UI.Views.Controls.KpiCard();
            cardPendingApprovals = new ComLabManager.UI.Views.Controls.KpiCard();
            cardUpcomingPM = new ComLabManager.UI.Views.Controls.KpiCard();
            cardDamaged = new ComLabManager.UI.Views.Controls.KpiCard();
            cardLowStock = new ComLabManager.UI.Views.Controls.KpiCard();
            cardActiveBorrowers = new ComLabManager.UI.Views.Controls.KpiCard();
            cardOverdue = new ComLabManager.UI.Views.Controls.KpiCard();
            lblDate = new Label();
            pnlHeader = new Panel();
            label1 = new Label();
            pnlGridContainer = new Panel();
            btnManageSchedules = new Button();
            dgvActionItems = new DataGridView();
            lblGridTitle = new Label();
            refreshTimer = new System.Windows.Forms.Timer(components);
            pnlMetrics.SuspendLayout();
            tblCards.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActionItems).BeginInit();
            SuspendLayout();
            // 
            // pnlMetrics
            // 
            pnlMetrics.BackColor = Color.WhiteSmoke;
            pnlMetrics.Controls.Add(tblCards);
            pnlMetrics.Dock = DockStyle.Top;
            pnlMetrics.Location = new Point(0, 64);
            pnlMetrics.Margin = new Padding(2);
            pnlMetrics.Name = "pnlMetrics";
            pnlMetrics.Padding = new Padding(8, 0, 8, 0);
            pnlMetrics.Size = new Size(766, 200);
            pnlMetrics.TabIndex = 0;
            // 
            // tblCards
            // 
            tblCards.ColumnCount = 4;
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCards.Controls.Add(cardActiveAssets, 0, 0);
            tblCards.Controls.Add(cardHighUsage, 1, 0);
            tblCards.Controls.Add(cardPendingApprovals, 2, 0);
            tblCards.Controls.Add(cardUpcomingPM, 3, 0);
            tblCards.Controls.Add(cardDamaged, 0, 1);
            tblCards.Controls.Add(cardLowStock, 1, 1);
            tblCards.Controls.Add(cardActiveBorrowers, 2, 1);
            tblCards.Controls.Add(cardOverdue, 3, 1);
            tblCards.Dock = DockStyle.Fill;
            tblCards.Location = new Point(8, 0);
            tblCards.Margin = new Padding(2);
            tblCards.Name = "tblCards";
            tblCards.RowCount = 2;
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCards.Size = new Size(750, 200);
            tblCards.TabIndex = 0;
            // 
            // cardActiveAssets
            // 
            cardActiveAssets.AccentColor = SystemColors.Highlight;
            cardActiveAssets.BackColor = Color.White;
            cardActiveAssets.Dock = DockStyle.Fill;
            cardActiveAssets.Location = new Point(5, 5);
            cardActiveAssets.Margin = new Padding(5);
            cardActiveAssets.Name = "cardActiveAssets";
            cardActiveAssets.Size = new Size(177, 90);
            cardActiveAssets.TabIndex = 0;
            cardActiveAssets.Title = "Total Active Assets";
            cardActiveAssets.Click += Card_Click;
            // 
            // cardHighUsage
            // 
            cardHighUsage.AccentColor = Color.FromArgb(255, 193, 7);
            cardHighUsage.BackColor = Color.White;
            cardHighUsage.Dock = DockStyle.Fill;
            cardHighUsage.Location = new Point(192, 5);
            cardHighUsage.Margin = new Padding(5);
            cardHighUsage.Name = "cardHighUsage";
            cardHighUsage.Size = new Size(177, 90);
            cardHighUsage.TabIndex = 1;
            cardHighUsage.Title = "High Usage Flags";
            cardHighUsage.Click += Card_Click;
            // 
            // cardPendingApprovals
            // 
            cardPendingApprovals.AccentColor = Color.FromArgb(30, 41, 59);
            cardPendingApprovals.BackColor = Color.White;
            cardPendingApprovals.Dock = DockStyle.Fill;
            cardPendingApprovals.Location = new Point(379, 5);
            cardPendingApprovals.Margin = new Padding(5);
            cardPendingApprovals.Name = "cardPendingApprovals";
            cardPendingApprovals.Size = new Size(177, 90);
            cardPendingApprovals.TabIndex = 2;
            cardPendingApprovals.Title = "Pending Approvals";
            cardPendingApprovals.Click += Card_Click;
            // 
            // cardUpcomingPM
            // 
            cardUpcomingPM.AccentColor = Color.FromArgb(25, 135, 84);
            cardUpcomingPM.BackColor = Color.White;
            cardUpcomingPM.Dock = DockStyle.Fill;
            cardUpcomingPM.Location = new Point(566, 5);
            cardUpcomingPM.Margin = new Padding(5);
            cardUpcomingPM.Name = "cardUpcomingPM";
            cardUpcomingPM.Size = new Size(179, 90);
            cardUpcomingPM.TabIndex = 3;
            cardUpcomingPM.Title = "Upcoming PM Tasks";
            cardUpcomingPM.Click += Card_Click;
            // 
            // cardDamaged
            // 
            cardDamaged.AccentColor = Color.DarkOrange;
            cardDamaged.BackColor = Color.White;
            cardDamaged.Dock = DockStyle.Fill;
            cardDamaged.Location = new Point(5, 105);
            cardDamaged.Margin = new Padding(5);
            cardDamaged.Name = "cardDamaged";
            cardDamaged.Size = new Size(177, 90);
            cardDamaged.TabIndex = 4;
            cardDamaged.Title = "Damaged Equipment";
            cardDamaged.Click += Card_Click;
            // 
            // cardLowStock
            // 
            cardLowStock.AccentColor = Color.IndianRed;
            cardLowStock.BackColor = Color.White;
            cardLowStock.Dock = DockStyle.Fill;
            cardLowStock.Location = new Point(192, 105);
            cardLowStock.Margin = new Padding(5);
            cardLowStock.Name = "cardLowStock";
            cardLowStock.Size = new Size(177, 90);
            cardLowStock.TabIndex = 5;
            cardLowStock.Title = "Low Stock Alerts";
            cardLowStock.Click += Card_Click;
            // 
            // cardActiveBorrowers
            // 
            cardActiveBorrowers.AccentColor = Color.SteelBlue;
            cardActiveBorrowers.BackColor = Color.White;
            cardActiveBorrowers.Dock = DockStyle.Fill;
            cardActiveBorrowers.Location = new Point(379, 105);
            cardActiveBorrowers.Margin = new Padding(5);
            cardActiveBorrowers.Name = "cardActiveBorrowers";
            cardActiveBorrowers.Size = new Size(177, 90);
            cardActiveBorrowers.TabIndex = 6;
            cardActiveBorrowers.Title = "Active Borrowers";
            cardActiveBorrowers.Click += Card_Click;
            // 
            // cardOverdue
            // 
            cardOverdue.AccentColor = Color.FromArgb(220, 53, 69);
            cardOverdue.BackColor = Color.White;
            cardOverdue.Dock = DockStyle.Fill;
            cardOverdue.Location = new Point(566, 105);
            cardOverdue.Margin = new Padding(5);
            cardOverdue.Name = "cardOverdue";
            cardOverdue.Size = new Size(179, 90);
            cardOverdue.TabIndex = 7;
            cardOverdue.Title = "Overdue Items";
            cardOverdue.Click += Card_Click;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(30, 41, 59);
            lblDate.Location = new Point(574, 25);
            lblDate.Margin = new Padding(2, 0, 2, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(111, 23);
            lblDate.TabIndex = 0;
            lblDate.Text = "Today's Date";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.WhiteSmoke;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(lblDate);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(766, 64);
            pnlHeader.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(12, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(259, 41);
            label1.TabIndex = 0;
            label1.Text = "System Overview";
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.BackColor = Color.WhiteSmoke;
            pnlGridContainer.Controls.Add(btnManageSchedules);
            pnlGridContainer.Controls.Add(dgvActionItems);
            pnlGridContainer.Controls.Add(lblGridTitle);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(0, 264);
            pnlGridContainer.Margin = new Padding(2);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(16);
            pnlGridContainer.Size = new Size(766, 187);
            pnlGridContainer.TabIndex = 2;
            // 
            // btnManageSchedules
            // 
            btnManageSchedules.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnManageSchedules.BackColor = Color.Navy;
            btnManageSchedules.FlatAppearance.BorderSize = 0;
            btnManageSchedules.FlatStyle = FlatStyle.Flat;
            btnManageSchedules.ForeColor = SystemColors.ButtonHighlight;
            btnManageSchedules.Location = new Point(590, 4);
            btnManageSchedules.Margin = new Padding(2);
            btnManageSchedules.Name = "btnManageSchedules";
            btnManageSchedules.Size = new Size(158, 31);
            btnManageSchedules.TabIndex = 1;
            btnManageSchedules.Text = "ManageSchedules";
            btnManageSchedules.UseVisualStyleBackColor = false;
            btnManageSchedules.Click += btnManageSchedules_Click;
            // 
            // dgvActionItems
            // 
            dgvActionItems.AllowUserToAddRows = false;
            dgvActionItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActionItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvActionItems.BackgroundColor = Color.White;
            dgvActionItems.BorderStyle = BorderStyle.None;
            dgvActionItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActionItems.Dock = DockStyle.Fill;
            dgvActionItems.Location = new Point(16, 44);
            dgvActionItems.Margin = new Padding(2);
            dgvActionItems.Name = "dgvActionItems";
            dgvActionItems.ReadOnly = true;
            dgvActionItems.RowHeadersVisible = false;
            dgvActionItems.RowHeadersWidth = 62;
            dgvActionItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActionItems.Size = new Size(734, 127);
            dgvActionItems.TabIndex = 1;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.BackColor = Color.Transparent;
            lblGridTitle.Dock = DockStyle.Top;
            lblGridTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGridTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblGridTitle.Location = new Point(16, 16);
            lblGridTitle.Margin = new Padding(2, 0, 2, 0);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(298, 28);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "Requires Immediate Attention";
            // 
            // refreshTimer
            // 
            refreshTimer.Interval = 60000;
            refreshTimer.Tick += refreshTimer_Tick;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlMetrics);
            Controls.Add(pnlHeader);
            Margin = new Padding(2);
            Name = "DashboardView";
            Size = new Size(766, 451);
            pnlMetrics.ResumeLayout(false);
            tblCards.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlGridContainer.ResumeLayout(false);
            pnlGridContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActionItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMetrics;
        private TableLayoutPanel tblCards;
        private Views.Controls.KpiCard cardActiveAssets;
        private Views.Controls.KpiCard cardHighUsage;
        private Views.Controls.KpiCard cardPendingApprovals;
        private Views.Controls.KpiCard cardUpcomingPM;
        private Views.Controls.KpiCard cardDamaged;
        private Views.Controls.KpiCard cardLowStock;
        private Views.Controls.KpiCard cardActiveBorrowers;
        private Views.Controls.KpiCard cardOverdue;
        private Label lblDate;
        private Panel pnlHeader;
        private Panel pnlGridContainer;
        private Label lblGridTitle;
        private Label label1;
        private DataGridView dgvActionItems;
        private Button btnManageSchedules;
        private System.Windows.Forms.Timer refreshTimer;
    }
}
