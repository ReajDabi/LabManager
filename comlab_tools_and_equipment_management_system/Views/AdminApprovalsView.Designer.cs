namespace ComLabManager.UI.Views
{
    partial class AdminApprovalsView
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
            btnApprove = new Button();
            btnDeny = new Button();
            pnlActions = new Panel();
            dgvBorrowRequests = new DataGridView();
            RequestId = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            TargetLocation = new DataGridViewTextBoxColumn();
            Purpose = new DataGridViewTextBoxColumn();
            Schedule = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            pnlPartRequests = new Panel();
            dgvPartRequests = new DataGridView();
            colPartRequestId = new DataGridViewTextBoxColumn();
            colPartTech = new DataGridViewTextBoxColumn();
            colRequestedPart = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            colPartReason = new DataGridViewTextBoxColumn();
            colParrtStatus = new DataGridViewTextBoxColumn();
            pnlBorrowRequests = new Panel();
            btnToggleBorrow = new Button();
            pnlHeader = new Panel();
            btnToggleParts = new Button();
            pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowRequests).BeginInit();
            pnlPartRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPartRequests).BeginInit();
            pnlBorrowRequests.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // btnApprove
            // 
            btnApprove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnApprove.BackColor = Color.FromArgb(25, 135, 84);
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnApprove.ForeColor = SystemColors.ButtonHighlight;
            btnApprove.Location = new Point(579, 9);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(158, 41);
            btnApprove.TabIndex = 1;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            // 
            // btnDeny
            // 
            btnDeny.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeny.BackColor = Color.FromArgb(229, 57, 69);
            btnDeny.FlatStyle = FlatStyle.Flat;
            btnDeny.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDeny.ForeColor = SystemColors.ButtonHighlight;
            btnDeny.Location = new Point(785, 9);
            btnDeny.Name = "btnDeny";
            btnDeny.Size = new Size(145, 41);
            btnDeny.TabIndex = 1;
            btnDeny.Text = "Deny";
            btnDeny.UseVisualStyleBackColor = false;
            btnDeny.Click += button2_Click;
            // 
            // pnlActions
            // 
            pnlActions.Controls.Add(btnDeny);
            pnlActions.Controls.Add(btnApprove);
            pnlActions.Dock = DockStyle.Bottom;
            pnlActions.Location = new Point(0, 504);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(958, 60);
            pnlActions.TabIndex = 2;
            // 
            // dgvBorrowRequests
            // 
            dgvBorrowRequests.BackgroundColor = SystemColors.Control;
            dgvBorrowRequests.BorderStyle = BorderStyle.None;
            dgvBorrowRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowRequests.Columns.AddRange(new DataGridViewColumn[] { RequestId, StudentName, TargetLocation, Purpose, Schedule, Status });
            dgvBorrowRequests.Dock = DockStyle.Fill;
            dgvBorrowRequests.Location = new Point(0, 0);
            dgvBorrowRequests.Name = "dgvBorrowRequests";
            dgvBorrowRequests.RowHeadersVisible = false;
            dgvBorrowRequests.RowHeadersWidth = 62;
            dgvBorrowRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowRequests.Size = new Size(958, 484);
            dgvBorrowRequests.TabIndex = 0;
            // 
            // RequestId
            // 
            RequestId.HeaderText = "RequestId";
            RequestId.MinimumWidth = 8;
            RequestId.Name = "RequestId";
            RequestId.Visible = false;
            RequestId.Width = 150;
            // 
            // StudentName
            // 
            StudentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StudentName.HeaderText = "Student Name";
            StudentName.MinimumWidth = 8;
            StudentName.Name = "StudentName";
            StudentName.Width = 161;
            // 
            // TargetLocation
            // 
            TargetLocation.HeaderText = "Target";
            TargetLocation.MinimumWidth = 8;
            TargetLocation.Name = "TargetLocation";
            TargetLocation.Width = 150;
            // 
            // Purpose
            // 
            Purpose.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Purpose.HeaderText = "Purpose";
            Purpose.MinimumWidth = 8;
            Purpose.Name = "Purpose";
            // 
            // Schedule
            // 
            Schedule.HeaderText = "Schedule";
            Schedule.MinimumWidth = 8;
            Schedule.Name = "Schedule";
            Schedule.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 150;
            // 
            // pnlPartRequests
            // 
            pnlPartRequests.Controls.Add(dgvPartRequests);
            pnlPartRequests.Dock = DockStyle.Fill;
            pnlPartRequests.Location = new Point(0, 80);
            pnlPartRequests.Name = "pnlPartRequests";
            pnlPartRequests.Size = new Size(958, 424);
            pnlPartRequests.TabIndex = 2;
            // 
            // dgvPartRequests
            // 
            dgvPartRequests.BackgroundColor = SystemColors.Control;
            dgvPartRequests.BorderStyle = BorderStyle.None;
            dgvPartRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartRequests.Columns.AddRange(new DataGridViewColumn[] { colPartRequestId, colPartTech, colRequestedPart, Quantity, colPartReason, colParrtStatus });
            dgvPartRequests.Dock = DockStyle.Fill;
            dgvPartRequests.Location = new Point(0, 0);
            dgvPartRequests.Name = "dgvPartRequests";
            dgvPartRequests.RowHeadersVisible = false;
            dgvPartRequests.RowHeadersWidth = 62;
            dgvPartRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPartRequests.Size = new Size(958, 424);
            dgvPartRequests.TabIndex = 0;
            // 
            // colPartRequestId
            // 
            colPartRequestId.HeaderText = "RequestId";
            colPartRequestId.MinimumWidth = 8;
            colPartRequestId.Name = "colPartRequestId";
            colPartRequestId.Visible = false;
            colPartRequestId.Width = 150;
            // 
            // colPartTech
            // 
            colPartTech.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colPartTech.HeaderText = "Technician";
            colPartTech.MinimumWidth = 8;
            colPartTech.Name = "colPartTech";
            colPartTech.Width = 127;
            // 
            // colRequestedPart
            // 
            colRequestedPart.HeaderText = "Requested Part";
            colRequestedPart.MinimumWidth = 8;
            colRequestedPart.Name = "colRequestedPart";
            colRequestedPart.Width = 150;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.Width = 150;
            // 
            // colPartReason
            // 
            colPartReason.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPartReason.HeaderText = "Reason";
            colPartReason.MinimumWidth = 8;
            colPartReason.Name = "colPartReason";
            // 
            // colParrtStatus
            // 
            colParrtStatus.HeaderText = "Status";
            colParrtStatus.MinimumWidth = 8;
            colParrtStatus.Name = "colParrtStatus";
            colParrtStatus.Width = 150;
            // 
            // pnlBorrowRequests
            // 
            pnlBorrowRequests.Controls.Add(dgvBorrowRequests);
            pnlBorrowRequests.Dock = DockStyle.Fill;
            pnlBorrowRequests.Location = new Point(0, 80);
            pnlBorrowRequests.Name = "pnlBorrowRequests";
            pnlBorrowRequests.Size = new Size(958, 484);
            pnlBorrowRequests.TabIndex = 1;
            // 
            // btnToggleBorrow
            // 
            btnToggleBorrow.BackColor = SystemColors.Highlight;
            btnToggleBorrow.FlatStyle = FlatStyle.Flat;
            btnToggleBorrow.ForeColor = SystemColors.ButtonFace;
            btnToggleBorrow.Location = new Point(23, 17);
            btnToggleBorrow.Name = "btnToggleBorrow";
            btnToggleBorrow.Size = new Size(180, 48);
            btnToggleBorrow.TabIndex = 1;
            btnToggleBorrow.Text = "Student Requests";
            btnToggleBorrow.UseVisualStyleBackColor = false;
            btnToggleBorrow.Click += btnToggleBorrow_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnToggleParts);
            pnlHeader.Controls.Add(btnToggleBorrow);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(958, 80);
            pnlHeader.TabIndex = 0;
            // 
            // btnToggleParts
            // 
            btnToggleParts.BackColor = Color.FromArgb(30, 41, 59);
            btnToggleParts.FlatStyle = FlatStyle.Flat;
            btnToggleParts.ForeColor = SystemColors.ButtonFace;
            btnToggleParts.Location = new Point(233, 17);
            btnToggleParts.Name = "btnToggleParts";
            btnToggleParts.Size = new Size(171, 50);
            btnToggleParts.TabIndex = 1;
            btnToggleParts.Text = "Tech Requests";
            btnToggleParts.UseVisualStyleBackColor = false;
            btnToggleParts.Click += btnToggleParts_Click;
            // 
            // AdminApprovalsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(pnlPartRequests);
            Controls.Add(pnlActions);
            Controls.Add(pnlBorrowRequests);
            Controls.Add(pnlHeader);
            Name = "AdminApprovalsView";
            Size = new Size(958, 564);
            pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBorrowRequests).EndInit();
            pnlPartRequests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPartRequests).EndInit();
            pnlBorrowRequests.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnApprove;
        private Button btnDeny;
        private Panel pnlActions;
        private DataGridView dgvBorrowRequests;
        private DataGridViewTextBoxColumn RequestId;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn TargetLocation;
        private DataGridViewTextBoxColumn Purpose;
        private DataGridViewTextBoxColumn Schedule;
        private DataGridViewTextBoxColumn Status;
        private Panel pnlPartRequests;
        private DataGridView dgvPartRequests;
        private DataGridViewTextBoxColumn colPartRequestId;
        private DataGridViewTextBoxColumn colPartTech;
        private DataGridViewTextBoxColumn colRequestedPart;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn colPartReason;
        private DataGridViewTextBoxColumn colParrtStatus;
        private Panel pnlBorrowRequests;
        private Button btnToggleBorrow;
        private Panel pnlHeader;
        private Button btnToggleParts;
    }
}
