namespace ComLabManager.UI
{
    partial class UserActivityForm
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
            lblTitle = new Label();
            dgvBorrowHistory = new DataGridView();
            dgvMaintenanceHistory = new DataGridView();
            pnlHeader = new Panel();
            label2 = new Label();
            label1 = new Label();
            pnlLeft = new Panel();
            pnlRight = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceHistory).BeginInit();
            pnlHeader.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(143, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(302, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Activity Profile";
            // 
            // dgvBorrowHistory
            // 
            dgvBorrowHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrowHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBorrowHistory.BackgroundColor = SystemColors.ButtonHighlight;
            dgvBorrowHistory.BorderStyle = BorderStyle.None;
            dgvBorrowHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowHistory.Dock = DockStyle.Fill;
            dgvBorrowHistory.Location = new Point(10, 10);
            dgvBorrowHistory.Margin = new Padding(0);
            dgvBorrowHistory.Name = "dgvBorrowHistory";
            dgvBorrowHistory.RowHeadersVisible = false;
            dgvBorrowHistory.RowHeadersWidth = 62;
            dgvBorrowHistory.Size = new Size(507, 568);
            dgvBorrowHistory.TabIndex = 1;
            // 
            // dgvMaintenanceHistory
            // 
            dgvMaintenanceHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaintenanceHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMaintenanceHistory.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMaintenanceHistory.BorderStyle = BorderStyle.None;
            dgvMaintenanceHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaintenanceHistory.Dock = DockStyle.Fill;
            dgvMaintenanceHistory.Location = new Point(10, 10);
            dgvMaintenanceHistory.Margin = new Padding(0);
            dgvMaintenanceHistory.Name = "dgvMaintenanceHistory";
            dgvMaintenanceHistory.RowHeadersVisible = false;
            dgvMaintenanceHistory.RowHeadersWidth = 62;
            dgvMaintenanceHistory.Size = new Size(506, 568);
            dgvMaintenanceHistory.TabIndex = 1;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(label2);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1059, 126);
            pnlHeader.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(546, 91);
            label2.Name = "label2";
            label2.Size = new Size(313, 32);
            label2.TabIndex = 0;
            label2.Text = "User's Maintenance History";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 91);
            label1.Name = "label1";
            label1.Size = new Size(250, 32);
            label1.TabIndex = 0;
            label1.Text = "User's Borrow History";
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(dgvBorrowHistory);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 126);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(10);
            pnlLeft.Size = new Size(527, 588);
            pnlLeft.TabIndex = 3;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(dgvMaintenanceHistory);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(533, 126);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(10);
            pnlRight.Size = new Size(526, 588);
            pnlRight.TabIndex = 4;
            // 
            // UserActivityForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 714);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Controls.Add(pnlHeader);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserActivityForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserActivityForm";
            ((System.ComponentModel.ISupportInitialize)dgvBorrowHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceHistory).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlLeft.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvBorrowHistory;
        private DataGridView dgvMaintenanceHistory;
        private Panel pnlHeader;
        private Panel pnlLeft;
        private Panel pnlRight;
        private Label label2;
        private Label label1;
    }
}