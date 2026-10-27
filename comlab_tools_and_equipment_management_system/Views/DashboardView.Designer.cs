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
            cardActiveAssets = new Views.Controls.KpiCard();
            cardHighUsage = new Views.Controls.KpiCard();
            cardPendingApprovals = new Views.Controls.KpiCard();
            cardDamaged = new Views.Controls.KpiCard();
            cardLowStock = new Views.Controls.KpiCard();
            cardActiveBorrowers = new Views.Controls.KpiCard();
            cardOverdue = new Views.Controls.KpiCard();
            cardUpcomingPM = new Views.Controls.KpiCard();
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
            pnlMetrics.Location = new Point(0, 80);
            pnlMetrics.Name = "pnlMetrics";
            pnlMetrics.Padding = new Padding(10, 0, 10, 0);
            pnlMetrics.Size = new Size(958, 250);
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
            tblCards.Location = new Point(10, 0);
            tblCards.Name = "tblCards";
            tblCards.RowCount = 2;
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCards.Size = new Size(938, 250);
            tblCards.TabIndex = 0;
            //
            // cardActiveAssets
            //
            cardActiveAssets.AccentColor = SystemColors.Highlight;
            cardActiveAssets.Dock = DockStyle.Fill;
            cardActiveAssets.Name = "cardActiveAssets";
            cardActiveAssets.TabIndex = 0;
            cardActiveAssets.Title = "Total Active Assets";
            cardActiveAssets.Click += Card_Click;
            //
            // cardHighUsage
            //
            cardHighUsage.AccentColor = Color.FromArgb(255, 193, 7);
            cardHighUsage.Dock = DockStyle.Fill;
            cardHighUsage.Name = "cardHighUsage";
            cardHighUsage.TabIndex = 1;
            cardHighUsage.Title = "High Usage Flags";
            cardHighUsage.Click += Card_Click;
            //
            // cardPendingApprovals
            //
            cardPendingApprovals.AccentColor = Color.FromArgb(30, 41, 59);
            cardPendingApprovals.Dock = DockStyle.Fill;
            cardPendingApprovals.Name = "cardPendingApprovals";
            cardPendingApprovals.TabIndex = 2;
            cardPendingApprovals.Title = "Pending Approvals";
            cardPendingApprovals.Click += Card_Click;
            //
            // cardUpcomingPM
            //
            cardUpcomingPM.AccentColor = Color.FromArgb(25, 135, 84);
            cardUpcomingPM.Dock = DockStyle.Fill;
            cardUpcomingPM.Name = "cardUpcomingPM";
            cardUpcomingPM.TabIndex = 3;
            cardUpcomingPM.Title = "Upcoming PM Tasks";
            cardUpcomingPM.Click += Card_Click;
            //
            // cardDamaged
            //
            cardDamaged.AccentColor = Color.DarkOrange;
            cardDamaged.Dock = DockStyle.Fill;
            cardDamaged.Name = "cardDamaged";
            cardDamaged.TabIndex = 4;
            cardDamaged.Title = "Damaged Equipment";
            cardDamaged.Click += Card_Click;
            //
            // cardLowStock
            //
            cardLowStock.AccentColor = Color.IndianRed;
            cardLowStock.Dock = DockStyle.Fill;
            cardLowStock.Name = "cardLowStock";
            cardLowStock.TabIndex = 5;
            cardLowStock.Title = "Low Stock Alerts";
            cardLowStock.Click += Card_Click;
            //
            // cardActiveBorrowers
            //
            cardActiveBorrowers.AccentColor = Color.SteelBlue;
            cardActiveBorrowers.Dock = DockStyle.Fill;
            cardActiveBorrowers.Name = "cardActiveBorrowers";
            cardActiveBorrowers.TabIndex = 6;
            cardActiveBorrowers.Title = "Active Borrowers";
            cardActiveBorrowers.Click += Card_Click;
            //
            // cardOverdue
            //
            cardOverdue.AccentColor = Color.FromArgb(220, 53, 69);
            cardOverdue.Dock = DockStyle.Fill;
            cardOverdue.Name = "cardOverdue";
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
            lblDate.Location = new Point(819, 12);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(133, 28);
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
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(958, 80);
            pnlHeader.TabIndex = 1;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(309, 48);
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
            pnlGridContainer.Location = new Point(0, 330);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(20);
            pnlGridContainer.Size = new Size(958, 234);
            pnlGridContainer.TabIndex = 2;
            //
            // btnManageSchedules
            //
            btnManageSchedules.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnManageSchedules.BackColor = Color.Navy;
            btnManageSchedules.FlatAppearance.BorderSize = 0;
            btnManageSchedules.FlatStyle = FlatStyle.Flat;
            btnManageSchedules.ForeColor = SystemColors.ButtonHighlight;
            btnManageSchedules.Location = new Point(738, 5);
            btnManageSchedules.Name = "btnManageSchedules";
            btnManageSchedules.Size = new Size(197, 39);
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
            dgvActionItems.Location = new Point(20, 52);
            dgvActionItems.Name = "dgvActionItems";
            dgvActionItems.ReadOnly = true;
            dgvActionItems.RowHeadersVisible = false;
            dgvActionItems.RowHeadersWidth = 62;
            dgvActionItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActionItems.Size = new Size(918, 162);
            dgvActionItems.TabIndex = 1;
            //
            // lblGridTitle
            //
            lblGridTitle.AutoSize = true;
            lblGridTitle.BackColor = Color.Transparent;
            lblGridTitle.Dock = DockStyle.Top;
            lblGridTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGridTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblGridTitle.Location = new Point(20, 20);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(358, 32);
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlMetrics);
            Controls.Add(pnlHeader);
            Name = "DashboardView";
            Size = new Size(958, 564);
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
