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
            cmbRoomFilter = new ComboBox();
            btnToggleSchedule = new Button();
            btnToggleBorrow = new Button();
            btnNewRequest = new Button();
            pnlSchedules = new Panel();
            dgvSchedules = new DataGridView();
            pnlBorrow = new Panel();
            dgvMyRequests = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlSchedules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
            pnlBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyRequests).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(cmbRoomFilter);
            pnlHeader.Controls.Add(btnToggleSchedule);
            pnlHeader.Controls.Add(btnToggleBorrow);
            pnlHeader.Controls.Add(btnNewRequest);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(959, 80);
            pnlHeader.TabIndex = 0;
            // 
            // cmbRoomFilter
            // 
            cmbRoomFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbRoomFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomFilter.FormattingEnabled = true;
            cmbRoomFilter.Location = new Point(723, 17);
            cmbRoomFilter.Name = "cmbRoomFilter";
            cmbRoomFilter.Size = new Size(207, 33);
            cmbRoomFilter.TabIndex = 0;
            cmbRoomFilter.SelectedIndexChanged += cmbRoomFilter_SelectedIndexChanged;
            // 
            // btnToggleSchedule
            // 
            btnToggleSchedule.BackColor = SystemColors.Highlight;
            btnToggleSchedule.FlatStyle = FlatStyle.Flat;
            btnToggleSchedule.ForeColor = SystemColors.ButtonFace;
            btnToggleSchedule.Location = new Point(26, 12);
            btnToggleSchedule.Name = "btnToggleSchedule";
            btnToggleSchedule.Size = new Size(164, 50);
            btnToggleSchedule.TabIndex = 2;
            btnToggleSchedule.Text = "ComLab Schedule";
            btnToggleSchedule.UseVisualStyleBackColor = false;
            btnToggleSchedule.Click += btnToggleSchedule_Click;
            // 
            // btnToggleBorrow
            // 
            btnToggleBorrow.BackColor = Color.FromArgb(30, 41, 59);
            btnToggleBorrow.FlatStyle = FlatStyle.Flat;
            btnToggleBorrow.ForeColor = SystemColors.ButtonFace;
            btnToggleBorrow.Location = new Point(186, 12);
            btnToggleBorrow.Name = "btnToggleBorrow";
            btnToggleBorrow.Size = new Size(214, 50);
            btnToggleBorrow.TabIndex = 2;
            btnToggleBorrow.Text = "My Borrow Requests";
            btnToggleBorrow.UseVisualStyleBackColor = false;
            btnToggleBorrow.Click += btnToggleBorrow_Click;
            // 
            // btnNewRequest
            // 
            btnNewRequest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewRequest.BackColor = Color.Green;
            btnNewRequest.FlatStyle = FlatStyle.Flat;
            btnNewRequest.ForeColor = SystemColors.ButtonFace;
            btnNewRequest.Location = new Point(707, 10);
            btnNewRequest.Margin = new Padding(4, 5, 4, 5);
            btnNewRequest.Name = "btnNewRequest";
            btnNewRequest.Size = new Size(223, 45);
            btnNewRequest.TabIndex = 3;
            btnNewRequest.Text = "+ New Borrow Request\r\n";
            btnNewRequest.UseVisualStyleBackColor = false;
            btnNewRequest.Click += btnNewRequest_Click;
            // 
            // pnlSchedules
            // 
            pnlSchedules.Controls.Add(dgvSchedules);
            pnlSchedules.Dock = DockStyle.Fill;
            pnlSchedules.Location = new Point(0, 80);
            pnlSchedules.Name = "pnlSchedules";
            pnlSchedules.Padding = new Padding(10);
            pnlSchedules.Size = new Size(959, 483);
            pnlSchedules.TabIndex = 1;
            // 
            // dgvSchedules
            // 
            dgvSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedules.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSchedules.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSchedules.BorderStyle = BorderStyle.None;
            dgvSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedules.Dock = DockStyle.Fill;
            dgvSchedules.Location = new Point(10, 10);
            dgvSchedules.Name = "dgvSchedules";
            dgvSchedules.ReadOnly = true;
            dgvSchedules.RowHeadersVisible = false;
            dgvSchedules.RowHeadersWidth = 62;
            dgvSchedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedules.Size = new Size(939, 463);
            dgvSchedules.TabIndex = 1;
            dgvSchedules.CellFormatting += dgvSchedules_CellFormatting;
            // 
            // pnlBorrow
            // 
            pnlBorrow.Controls.Add(dgvMyRequests);
            pnlBorrow.Dock = DockStyle.Fill;
            pnlBorrow.Location = new Point(0, 80);
            pnlBorrow.Name = "pnlBorrow";
            pnlBorrow.Padding = new Padding(10);
            pnlBorrow.Size = new Size(959, 483);
            pnlBorrow.TabIndex = 4;
            // 
            // dgvMyRequests
            // 
            dgvMyRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyRequests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMyRequests.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMyRequests.BorderStyle = BorderStyle.None;
            dgvMyRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyRequests.Dock = DockStyle.Fill;
            dgvMyRequests.Location = new Point(10, 10);
            dgvMyRequests.Name = "dgvMyRequests";
            dgvMyRequests.ReadOnly = true;
            dgvMyRequests.RowHeadersVisible = false;
            dgvMyRequests.RowHeadersWidth = 62;
            dgvMyRequests.Size = new Size(939, 463);
            dgvMyRequests.TabIndex = 4;
            dgvMyRequests.CellFormatting += dgvMyRequests_CellFormatting;
            // 
            // StudentDashboardView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(pnlSchedules);
            Controls.Add(pnlBorrow);
            Controls.Add(pnlHeader);
            Name = "StudentDashboardView";
            Size = new Size(959, 563);
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
        private ComboBox cmbRoomFilter;
        private Panel pnlBorrow;
        private Button btnNewRequest;
        private DataGridView dgvMyRequests;
        private Button btnToggleSchedule;
    }
}
