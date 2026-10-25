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
            txtRoom = new TextBox();
            cmbDay = new ComboBox();
            dtpStartTime = new DateTimePicker();
            dtpEndTime = new DateTimePicker();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            label1 = new Label();
            lblRoom = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).BeginInit();
            SuspendLayout();
            // 
            // dgvSchedules
            // 
            dgvSchedules.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSchedules.BorderStyle = BorderStyle.None;
            dgvSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedules.Location = new Point(372, 90);
            dgvSchedules.Name = "dgvSchedules";
            dgvSchedules.RowHeadersVisible = false;
            dgvSchedules.RowHeadersWidth = 62;
            dgvSchedules.Size = new Size(542, 411);
            dgvSchedules.TabIndex = 0;
            dgvSchedules.SelectionChanged += dgvSchedules_SelectionChanged;
            // 
            // txtInstructor
            // 
            txtInstructor.Location = new Point(21, 262);
            txtInstructor.Name = "txtInstructor";
            txtInstructor.Size = new Size(306, 31);
            txtInstructor.TabIndex = 1;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(21, 193);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(306, 31);
            txtSubject.TabIndex = 1;
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(21, 119);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(306, 31);
            txtRoom.TabIndex = 1;
            // 
            // cmbDay
            // 
            cmbDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDay.FormattingEnabled = true;
            cmbDay.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            cmbDay.Location = new Point(21, 341);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(306, 33);
            cmbDay.TabIndex = 2;
            // 
            // dtpStartTime
            // 
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(21, 433);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(135, 31);
            dtpStartTime.TabIndex = 3;
            // 
            // dtpEndTime
            // 
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.Location = new Point(201, 433);
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
            btnUpdate.Location = new Point(574, 564);
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
            btnDelete.Location = new Point(769, 564);
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
            btnAdd.Location = new Point(372, 564);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 39);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, 9);
            label1.Name = "label1";
            label1.Size = new Size(332, 48);
            label1.TabIndex = 5;
            label1.Text = "Manage Schedules";
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(21, 90);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(60, 25);
            lblRoom.TabIndex = 5;
            lblRoom.Text = "Room";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 165);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 5;
            label3.Text = "Subject";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 234);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 5;
            label4.Text = "Instructor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 313);
            label5.Name = "label5";
            label5.Size = new Size(43, 25);
            label5.TabIndex = 5;
            label5.Text = "Day";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 405);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 5;
            label6.Text = "Start Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(201, 405);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
            label7.TabIndex = 5;
            label7.Text = "End Time";
            // 
            // ManageSchedulesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 624);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblRoom);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dtpEndTime);
            Controls.Add(dtpStartTime);
            Controls.Add(cmbDay);
            Controls.Add(txtRoom);
            Controls.Add(txtSubject);
            Controls.Add(txtInstructor);
            Controls.Add(dgvSchedules);
            Name = "ManageSchedulesForm";
            Text = "ManageSchedulesForm";
            ((System.ComponentModel.ISupportInitialize)dgvSchedules).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSchedules;
        private TextBox txtInstructor;
        private TextBox txtSubject;
        private TextBox txtRoom;
        private ComboBox cmbDay;
        private DateTimePicker dtpStartTime;
        private DateTimePicker dtpEndTime;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Label label1;
        private Label lblRoom;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}