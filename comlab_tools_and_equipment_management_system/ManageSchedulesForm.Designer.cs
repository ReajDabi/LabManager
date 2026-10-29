namespace ComLabManager.UI
{
    partial class ManageSchedulesForm
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
            dgvSchedules = new DataGridView();
            txtInstructor = new TextBox();
            txtSubject = new TextBox();
            cmbDay = new ComboBox();
            dtpStartTime = new DateTimePicker();
            dtpEndTime = new DateTimePicker();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            lblTitle = new Label();
            lblRoom = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pnlData = new Panel();
            pnlFillups = new Panel();
            cmbRoom = new ComboBox();
            pnlAction = new Panel();
            pnlHeader = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
            pnlData.SuspendLayout();
            pnlFillups.SuspendLayout();
            pnlAction.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSchedules
            // 
            dgvSchedules.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSchedules.BorderStyle = BorderStyle.None;
            dgvSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedules.Dock = DockStyle.Fill;
            dgvSchedules.Location = new Point(0, 0);
            dgvSchedules.Name = "dgvSchedules";
            dgvSchedules.RowHeadersVisible = false;
            dgvSchedules.RowHeadersWidth = 62;
            dgvSchedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedules.Size = new Size(603, 478);
            dgvSchedules.TabIndex = 0;
            dgvSchedules.SelectionChanged += dgvSchedules_SelectionChanged;
            // 
            // txtInstructor
            // 
            txtInstructor.Location = new Point(18, 202);
            txtInstructor.Name = "txtInstructor";
            txtInstructor.Size = new Size(306, 31);
            txtInstructor.TabIndex = 1;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(18, 133);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(306, 31);
            txtSubject.TabIndex = 1;
            // 
            // cmbDay
            // 
            cmbDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDay.FormattingEnabled = true;
            cmbDay.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            cmbDay.Location = new Point(18, 281);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(306, 33);
            cmbDay.TabIndex = 2;
            // 
            // dtpStartTime
            // 
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(18, 373);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(135, 31);
            dtpStartTime.TabIndex = 3;
            // 
            // dtpEndTime
            // 
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.Location = new Point(198, 373);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(135, 31);
            dtpEndTime.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.Navy;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(576, 23);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(145, 39);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(771, 23);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 39);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.BackColor = Color.Green;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(374, 23);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 39);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(288, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(332, 48);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Manage Schedules";
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(18, 30);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(60, 25);
            lblRoom.TabIndex = 5;
            lblRoom.Text = "Room";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 105);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 5;
            label3.Text = "Subject";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 174);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 5;
            label4.Text = "Instructor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 253);
            label5.Name = "label5";
            label5.Size = new Size(43, 25);
            label5.TabIndex = 5;
            label5.Text = "Day";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 345);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 5;
            label6.Text = "Start Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(198, 345);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
            label7.TabIndex = 5;
            label7.Text = "End Time";
            // 
            // pnlData
            // 
            pnlData.Controls.Add(dgvSchedules);
            pnlData.Dock = DockStyle.Fill;
            pnlData.Location = new Point(336, 72);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(603, 478);
            pnlData.TabIndex = 6;
            // 
            // pnlFillups
            // 
            pnlFillups.Controls.Add(label7);
            pnlFillups.Controls.Add(label6);
            pnlFillups.Controls.Add(label5);
            pnlFillups.Controls.Add(label4);
            pnlFillups.Controls.Add(label3);
            pnlFillups.Controls.Add(lblRoom);
            pnlFillups.Controls.Add(dtpEndTime);
            pnlFillups.Controls.Add(dtpStartTime);
            pnlFillups.Controls.Add(cmbRoom);
            pnlFillups.Controls.Add(cmbDay);
            pnlFillups.Controls.Add(txtSubject);
            pnlFillups.Controls.Add(txtInstructor);
            pnlFillups.Dock = DockStyle.Left;
            pnlFillups.Location = new Point(0, 72);
            pnlFillups.Name = "pnlFillups";
            pnlFillups.Size = new Size(336, 478);
            pnlFillups.TabIndex = 7;
            // 
            // cmbRoom
            // 
            cmbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(18, 58);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(306, 33);
            cmbRoom.TabIndex = 2;
            // 
            // pnlAction
            // 
            pnlAction.Controls.Add(btnAdd);
            pnlAction.Controls.Add(btnDelete);
            pnlAction.Controls.Add(btnUpdate);
            pnlAction.Dock = DockStyle.Bottom;
            pnlAction.Location = new Point(0, 550);
            pnlAction.Name = "pnlAction";
            pnlAction.Size = new Size(939, 74);
            pnlAction.TabIndex = 8;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(939, 72);
            pnlHeader.TabIndex = 9;
            // 
            // ManageSchedulesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 624);
            Controls.Add(pnlData);
            Controls.Add(pnlFillups);
            Controls.Add(pnlHeader);
            Controls.Add(pnlAction);
            Name = "ManageSchedulesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageSchedulesForm";
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).EndInit();
            pnlData.ResumeLayout(false);
            pnlFillups.ResumeLayout(false);
            pnlFillups.PerformLayout();
            pnlAction.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSchedules;
        private TextBox txtInstructor;
        private TextBox txtSubject;
        private ComboBox cmbDay;
        private DateTimePicker dtpStartTime;
        private DateTimePicker dtpEndTime;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Label lblTitle;
        private Label lblRoom;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel pnlData;
        private Panel pnlFillups;
        private Panel pnlAction;
        private Panel pnlHeader;
        private ComboBox cmbRoom;
    }
}