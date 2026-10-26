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
            pnlMetrics = new Panel();
            pnlCardPM = new Panel();
            pnlAccentPM = new Panel();
            lblValuePM = new Label();
            lblTitlePM = new Label();
            pnlCardBorrows = new Panel();
            pnlAccentBorrows = new Panel();
            lblValueBorrows = new Label();
            lblTitleBorrows = new Label();
            pnlCardUsage = new Panel();
            pnlAccentUsage = new Panel();
            lblValueUsage = new Label();
            lblTitleUsage = new Label();
            pnlCardEq = new Panel();
            lblValueEq = new Label();
            lblTitleEq = new Label();
            pnlAccentEq = new Panel();
            lblDate = new Label();
            pnlHeader = new Panel();
            label1 = new Label();
            pnlGridContainer = new Panel();
            btnManageSchedules = new Button();
            dgvActionItems = new DataGridView();
            lblGridTitle = new Label();
            pnlMetrics.SuspendLayout();
            pnlCardPM.SuspendLayout();
            pnlCardBorrows.SuspendLayout();
            pnlCardUsage.SuspendLayout();
            pnlCardEq.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActionItems).BeginInit();
            SuspendLayout();
            // 
            // pnlMetrics
            // 
            pnlMetrics.BackColor = Color.WhiteSmoke;
            pnlMetrics.Controls.Add(pnlCardPM);
            pnlMetrics.Controls.Add(pnlCardBorrows);
            pnlMetrics.Controls.Add(pnlCardUsage);
            pnlMetrics.Controls.Add(pnlCardEq);
            pnlMetrics.Dock = DockStyle.Top;
            pnlMetrics.Location = new Point(0, 80);
            pnlMetrics.Name = "pnlMetrics";
            pnlMetrics.Padding = new Padding(10);
            pnlMetrics.Size = new Size(958, 130);
            pnlMetrics.TabIndex = 0;
            // 
            // pnlCardPM
            // 
            pnlCardPM.BackColor = Color.White;
            pnlCardPM.Controls.Add(pnlAccentPM);
            pnlCardPM.Controls.Add(lblValuePM);
            pnlCardPM.Controls.Add(lblTitlePM);
            pnlCardPM.Dock = DockStyle.Left;
            pnlCardPM.Location = new Point(655, 10);
            pnlCardPM.Name = "pnlCardPM";
            pnlCardPM.Size = new Size(215, 110);
            pnlCardPM.TabIndex = 0;
            // 
            // pnlAccentPM
            // 
            pnlAccentPM.BackColor = Color.FromArgb(25, 135, 84);
            pnlAccentPM.Dock = DockStyle.Left;
            pnlAccentPM.Location = new Point(0, 0);
            pnlAccentPM.Name = "pnlAccentPM";
            pnlAccentPM.Size = new Size(5, 110);
            pnlAccentPM.TabIndex = 9;
            // 
            // lblValuePM
            // 
            lblValuePM.AutoSize = true;
            lblValuePM.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValuePM.Location = new Point(87, 7);
            lblValuePM.Name = "lblValuePM";
            lblValuePM.Size = new Size(56, 65);
            lblValuePM.TabIndex = 7;
            lblValuePM.Text = "0";
            // 
            // lblTitlePM
            // 
            lblTitlePM.AutoSize = true;
            lblTitlePM.Location = new Point(27, 72);
            lblTitlePM.Name = "lblTitlePM";
            lblTitlePM.Size = new Size(172, 25);
            lblTitlePM.TabIndex = 8;
            lblTitlePM.Text = "Upcoming PM Tasks";
            // 
            // pnlCardBorrows
            // 
            pnlCardBorrows.BackColor = Color.White;
            pnlCardBorrows.Controls.Add(pnlAccentBorrows);
            pnlCardBorrows.Controls.Add(lblValueBorrows);
            pnlCardBorrows.Controls.Add(lblTitleBorrows);
            pnlCardBorrows.Dock = DockStyle.Left;
            pnlCardBorrows.Location = new Point(440, 10);
            pnlCardBorrows.Name = "pnlCardBorrows";
            pnlCardBorrows.Size = new Size(215, 110);
            pnlCardBorrows.TabIndex = 0;
            // 
            // pnlAccentBorrows
            // 
            pnlAccentBorrows.BackColor = Color.FromArgb(30, 41, 59);
            pnlAccentBorrows.Dock = DockStyle.Left;
            pnlAccentBorrows.Location = new Point(0, 0);
            pnlAccentBorrows.Name = "pnlAccentBorrows";
            pnlAccentBorrows.Size = new Size(5, 110);
            pnlAccentBorrows.TabIndex = 6;
            // 
            // lblValueBorrows
            // 
            lblValueBorrows.AutoSize = true;
            lblValueBorrows.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValueBorrows.Location = new Point(86, 7);
            lblValueBorrows.Name = "lblValueBorrows";
            lblValueBorrows.Size = new Size(56, 65);
            lblValueBorrows.TabIndex = 4;
            lblValueBorrows.Text = "0";
            // 
            // lblTitleBorrows
            // 
            lblTitleBorrows.AutoSize = true;
            lblTitleBorrows.Location = new Point(21, 72);
            lblTitleBorrows.Name = "lblTitleBorrows";
            lblTitleBorrows.Size = new Size(181, 25);
            lblTitleBorrows.TabIndex = 5;
            lblTitleBorrows.Text = "Pending Borrow Reqs";
            // 
            // pnlCardUsage
            // 
            pnlCardUsage.BackColor = Color.White;
            pnlCardUsage.Controls.Add(pnlAccentUsage);
            pnlCardUsage.Controls.Add(lblValueUsage);
            pnlCardUsage.Controls.Add(lblTitleUsage);
            pnlCardUsage.Dock = DockStyle.Left;
            pnlCardUsage.Location = new Point(225, 10);
            pnlCardUsage.Name = "pnlCardUsage";
            pnlCardUsage.Size = new Size(215, 110);
            pnlCardUsage.TabIndex = 0;
            // 
            // pnlAccentUsage
            // 
            pnlAccentUsage.BackColor = Color.FromArgb(255, 193, 7);
            pnlAccentUsage.Dock = DockStyle.Left;
            pnlAccentUsage.Location = new Point(0, 0);
            pnlAccentUsage.Name = "pnlAccentUsage";
            pnlAccentUsage.Size = new Size(5, 110);
            pnlAccentUsage.TabIndex = 3;
            // 
            // lblValueUsage
            // 
            lblValueUsage.AutoSize = true;
            lblValueUsage.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValueUsage.Location = new Point(85, 7);
            lblValueUsage.Name = "lblValueUsage";
            lblValueUsage.Size = new Size(56, 65);
            lblValueUsage.TabIndex = 2;
            lblValueUsage.Text = "0";
            // 
            // lblTitleUsage
            // 
            lblTitleUsage.AutoSize = true;
            lblTitleUsage.Location = new Point(33, 72);
            lblTitleUsage.Name = "lblTitleUsage";
            lblTitleUsage.Size = new Size(150, 25);
            lblTitleUsage.TabIndex = 2;
            lblTitleUsage.Text = "High Usage Flags";
            // 
            // pnlCardEq
            // 
            pnlCardEq.BackColor = Color.White;
            pnlCardEq.Controls.Add(lblValueEq);
            pnlCardEq.Controls.Add(lblTitleEq);
            pnlCardEq.Controls.Add(pnlAccentEq);
            pnlCardEq.Dock = DockStyle.Left;
            pnlCardEq.Location = new Point(10, 10);
            pnlCardEq.Name = "pnlCardEq";
            pnlCardEq.Size = new Size(215, 110);
            pnlCardEq.TabIndex = 0;
            // 
            // lblValueEq
            // 
            lblValueEq.AutoSize = true;
            lblValueEq.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValueEq.Location = new Point(81, 7);
            lblValueEq.Name = "lblValueEq";
            lblValueEq.Size = new Size(56, 65);
            lblValueEq.TabIndex = 2;
            lblValueEq.Text = "0";
            // 
            // lblTitleEq
            // 
            lblTitleEq.AutoSize = true;
            lblTitleEq.Location = new Point(29, 72);
            lblTitleEq.Name = "lblTitleEq";
            lblTitleEq.Size = new Size(158, 25);
            lblTitleEq.TabIndex = 2;
            lblTitleEq.Text = "Total Active Assets";
            // 
            // pnlAccentEq
            // 
            pnlAccentEq.BackColor = SystemColors.Highlight;
            pnlAccentEq.Dock = DockStyle.Left;
            pnlAccentEq.Location = new Point(0, 0);
            pnlAccentEq.Name = "pnlAccentEq";
            pnlAccentEq.Size = new Size(5, 110);
            pnlAccentEq.TabIndex = 0;
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
            pnlGridContainer.Location = new Point(0, 210);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(20);
            pnlGridContainer.Size = new Size(958, 354);
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
            dgvActionItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActionItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvActionItems.BackgroundColor = Color.White;
            dgvActionItems.BorderStyle = BorderStyle.None;
            dgvActionItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActionItems.Dock = DockStyle.Fill;
            dgvActionItems.Location = new Point(20, 52);
            dgvActionItems.Name = "dgvActionItems";
            dgvActionItems.RowHeadersVisible = false;
            dgvActionItems.RowHeadersWidth = 62;
            dgvActionItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActionItems.Size = new Size(918, 282);
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
            pnlCardPM.ResumeLayout(false);
            pnlCardPM.PerformLayout();
            pnlCardBorrows.ResumeLayout(false);
            pnlCardBorrows.PerformLayout();
            pnlCardUsage.ResumeLayout(false);
            pnlCardUsage.PerformLayout();
            pnlCardEq.ResumeLayout(false);
            pnlCardEq.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlGridContainer.ResumeLayout(false);
            pnlGridContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActionItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMetrics;
        private Label lblDate;
        private Panel pnlCardEq;
        private Panel pnlHeader;
        private Panel pnlGridContainer;
        private Label lblGridTitle;
        private Panel pnlCardUsage;
        private Label label1;
        private Panel pnlCardPM;
        private Panel pnlCardBorrows;
        private Label lblValueEq;
        private Label lblTitleEq;
        private Panel pnlAccentEq;
        private Panel pnlAccentUsage;
        private Label lblValueUsage;
        private Label lblTitleUsage;
        private Panel pnlAccentBorrows;
        private Label lblValueBorrows;
        private Label lblTitleBorrows;
        private Panel pnlAccentPM;
        private Label lblValuePM;
        private Label lblTitlePM;
        private DataGridView dgvActionItems;
        private Button btnManageSchedules;
    }
}
