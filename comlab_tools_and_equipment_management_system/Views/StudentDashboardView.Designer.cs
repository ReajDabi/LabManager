namespace ComLabManager.UI.Views
{
    partial class StudentDashboardView
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
            pnlHeader = new Panel();
            btnToggleSchedule = new Button();
            btnToggleBorrow = new Button();
            pnlSchedules = new Panel();
            cmbLabFilter = new ComboBox();
            dgvSchedules = new DataGridView();
            Subject = new DataGridViewTextBoxColumn();
            Instructor = new DataGridViewTextBoxColumn();
            StartTime = new DataGridViewTextBoxColumn();
            EndTime = new DataGridViewTextBoxColumn();
            pnlBorrow = new Panel();
            btnNewRequest = new Button();
            dgvMyRequests = new DataGridView();
            Target = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlSchedules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
            pnlBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyRequests).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnNewRequest);
            pnlHeader.Controls.Add(btnToggleSchedule);
            pnlHeader.Controls.Add(btnToggleBorrow);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2, 2, 2, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(671, 48);
            pnlHeader.TabIndex = 0;
            // 
            // btnToggleSchedule
            // 
            btnToggleSchedule.BackColor = SystemColors.Highlight;
            btnToggleSchedule.FlatStyle = FlatStyle.Flat;
            btnToggleSchedule.ForeColor = SystemColors.ButtonFace;
            btnToggleSchedule.Location = new Point(18, 7);
            btnToggleSchedule.Margin = new Padding(2, 2, 2, 2);
            btnToggleSchedule.Name = "btnToggleSchedule";
            btnToggleSchedule.Size = new Size(115, 30);
            btnToggleSchedule.TabIndex = 2;
            btnToggleSchedule.Text = "My Schedule";
            btnToggleSchedule.UseVisualStyleBackColor = false;
            btnToggleSchedule.Click += btnToggleSchedule_Click;
            // 
            // btnToggleBorrow
            // 
            btnToggleBorrow.BackColor = Color.FromArgb(30, 41, 59);
            btnToggleBorrow.FlatStyle = FlatStyle.Flat;
            btnToggleBorrow.ForeColor = SystemColors.ButtonFace;
            btnToggleBorrow.Location = new Point(130, 7);
            btnToggleBorrow.Margin = new Padding(2, 2, 2, 2);
            btnToggleBorrow.Name = "btnToggleBorrow";
            btnToggleBorrow.Size = new Size(150, 30);
            btnToggleBorrow.TabIndex = 2;
            btnToggleBorrow.Text = "My Borrow Requests";
            btnToggleBorrow.UseVisualStyleBackColor = false;
            btnToggleBorrow.Click += btnToggleBorrow_Click;
            // 
            // pnlSchedules
            // 
            pnlSchedules.Controls.Add(cmbLabFilter);
            pnlSchedules.Controls.Add(dgvSchedules);
            pnlSchedules.Dock = DockStyle.Fill;
            pnlSchedules.Location = new Point(0, 48);
            pnlSchedules.Margin = new Padding(2, 2, 2, 2);
            pnlSchedules.Name = "pnlSchedules";
            pnlSchedules.Size = new Size(671, 290);
            pnlSchedules.TabIndex = 1;
            // 
            // cmbLabFilter
            // 
            cmbLabFilter.FormattingEnabled = true;
            cmbLabFilter.Location = new Point(514, 10);
            cmbLabFilter.Margin = new Padding(2, 2, 2, 2);
            cmbLabFilter.Name = "cmbLabFilter";
            cmbLabFilter.Size = new Size(146, 23);
            cmbLabFilter.TabIndex = 0;
            // 
            // dgvSchedules
            // 
            dgvSchedules.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSchedules.BorderStyle = BorderStyle.None;
            dgvSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedules.Columns.AddRange(new DataGridViewColumn[] { Subject, Instructor, StartTime, EndTime });
            dgvSchedules.Location = new Point(0, 0);
            dgvSchedules.Margin = new Padding(2, 2, 2, 2);
            dgvSchedules.Name = "dgvSchedules";
            dgvSchedules.RowHeadersVisible = false;
            dgvSchedules.RowHeadersWidth = 62;
            dgvSchedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedules.Size = new Size(671, 269);
            dgvSchedules.TabIndex = 1;
            // 
            // Subject
            // 
            Subject.HeaderText = "Subject";
            Subject.MinimumWidth = 8;
            Subject.Name = "Subject";
            Subject.Width = 150;
            // 
            // Instructor
            // 
            Instructor.HeaderText = "Instructor";
            Instructor.MinimumWidth = 8;
            Instructor.Name = "Instructor";
            Instructor.Width = 150;
            // 
            // StartTime
            // 
            StartTime.HeaderText = "Start Time";
            StartTime.MinimumWidth = 8;
            StartTime.Name = "StartTime";
            StartTime.Width = 150;
            // 
            // EndTime
            // 
            EndTime.HeaderText = "End Time";
            EndTime.MinimumWidth = 8;
            EndTime.Name = "EndTime";
            EndTime.Width = 150;
            // 
            // pnlBorrow
            // 
            pnlBorrow.Controls.Add(dgvMyRequests);
            pnlBorrow.Dock = DockStyle.Fill;
            pnlBorrow.Location = new Point(0, 48);
            pnlBorrow.Margin = new Padding(2, 2, 2, 2);
            pnlBorrow.Name = "pnlBorrow";
            pnlBorrow.Size = new Size(671, 290);
            pnlBorrow.TabIndex = 4;
            // 
            // btnNewRequest
            // 
            btnNewRequest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewRequest.BackColor = Color.Green;
            btnNewRequest.FlatStyle = FlatStyle.Flat;
            btnNewRequest.ForeColor = SystemColors.ButtonFace;
            btnNewRequest.Location = new Point(708, 17);
            btnNewRequest.Name = "btnNewRequest";
            btnNewRequest.Size = new Size(233, 41);
            btnNewRequest.TabIndex = 3;
            btnNewRequest.Text = "+ New Borrow Request\r\n";
            btnNewRequest.UseVisualStyleBackColor = false;
            btnNewRequest.Click += btnNewRequest_Click;
            // 
            // dgvMyRequests
            // 
            dgvMyRequests.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMyRequests.BorderStyle = BorderStyle.None;
            dgvMyRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyRequests.Columns.AddRange(new DataGridViewColumn[] { Target, Date, Time, Status });
            dgvMyRequests.Location = new Point(0, 0);
            dgvMyRequests.Margin = new Padding(2, 2, 2, 2);
            dgvMyRequests.Name = "dgvMyRequests";
            dgvMyRequests.RowHeadersVisible = false;
            dgvMyRequests.RowHeadersWidth = 62;
            dgvMyRequests.Size = new Size(671, 290);
            dgvMyRequests.TabIndex = 4;
            // 
            // Target
            // 
            Target.HeaderText = "Target";
            Target.MinimumWidth = 8;
            Target.Name = "Target";
            Target.Width = 150;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.Width = 150;
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.MinimumWidth = 8;
            Time.Name = "Time";
            Time.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 150;
            // 
            // StudentDashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(pnlBorrow);
            Controls.Add(pnlSchedules);
            Controls.Add(pnlHeader);
            Margin = new Padding(2, 2, 2, 2);
            Name = "StudentDashboardView";
            Size = new Size(671, 338);
            pnlHeader.ResumeLayout(false);
            pnlSchedules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).EndInit();
            pnlBorrow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMyRequests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Button btnToggleBorrow;
        private Panel pnlSchedules;
        private DataGridView dgvSchedules;
        private ComboBox cmbLabFilter;
        private Panel pnlBorrow;
        private Button btnNewRequest;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn Instructor;
        private DataGridViewTextBoxColumn StartTime;
        private DataGridViewTextBoxColumn EndTime;
        private DataGridView dgvMyRequests;
        private DataGridViewTextBoxColumn Target;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Status;
        private Button btnToggleSchedule;
    }
}
