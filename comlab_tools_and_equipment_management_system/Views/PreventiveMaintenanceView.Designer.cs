namespace ComLabManager.UI
{
    partial class PreventiveMaintenanceView
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
            dataGridView1 = new DataGridView();
            task = new DataGridViewTextBoxColumn();
            location = new DataGridViewTextBoxColumn();
            equipment = new DataGridViewTextBoxColumn();
            frequency = new DataGridViewTextBoxColumn();
            lastcompleted = new DataGridViewTextBoxColumn();
            nextdue = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            assignedto = new DataGridViewTextBoxColumn();
            buttonScheduleTask = new Button();
            buttonMarkDone = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            panel1 = new Panel();
            pnlHolder = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            pnlHolder.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(248, 249, 250);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { task, location, equipment, frequency, lastcompleted, nextdue, status, assignedto });
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(10, 10);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(938, 472);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // task
            // 
            task.FillWeight = 160F;
            task.HeaderText = "Task";
            task.MinimumWidth = 6;
            task.Name = "task";
            task.ReadOnly = true;
            // 
            // location
            // 
            location.FillWeight = 70F;
            location.HeaderText = "Location";
            location.MinimumWidth = 6;
            location.Name = "location";
            location.ReadOnly = true;
            // 
            // equipment
            // 
            equipment.FillWeight = 120F;
            equipment.HeaderText = "Equipment";
            equipment.MinimumWidth = 6;
            equipment.Name = "equipment";
            equipment.ReadOnly = true;
            // 
            // frequency
            // 
            frequency.FillWeight = 80F;
            frequency.HeaderText = "Frequency";
            frequency.MinimumWidth = 6;
            frequency.Name = "frequency";
            frequency.ReadOnly = true;
            // 
            // lastcompleted
            // 
            lastcompleted.HeaderText = "Last Completed";
            lastcompleted.MinimumWidth = 6;
            lastcompleted.Name = "lastcompleted";
            lastcompleted.ReadOnly = true;
            // 
            // nextdue
            // 
            nextdue.HeaderText = "Next Due";
            nextdue.MinimumWidth = 6;
            nextdue.Name = "nextdue";
            nextdue.ReadOnly = true;
            // 
            // status
            // 
            status.FillWeight = 80F;
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // assignedto
            // 
            assignedto.HeaderText = "Assigned To";
            assignedto.MinimumWidth = 6;
            assignedto.Name = "assignedto";
            assignedto.ReadOnly = true;
            // 
            // buttonScheduleTask
            // 
            buttonScheduleTask.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonScheduleTask.BackColor = Color.Navy;
            buttonScheduleTask.BackgroundImageLayout = ImageLayout.None;
            buttonScheduleTask.Cursor = Cursors.Hand;
            buttonScheduleTask.FlatAppearance.BorderSize = 0;
            buttonScheduleTask.FlatStyle = FlatStyle.Flat;
            buttonScheduleTask.Font = new Font("Segoe UI", 10F);
            buttonScheduleTask.ForeColor = Color.White;
            buttonScheduleTask.Location = new Point(774, 16);
            buttonScheduleTask.Margin = new Padding(4);
            buttonScheduleTask.Name = "buttonScheduleTask";
            buttonScheduleTask.Size = new Size(170, 40);
            buttonScheduleTask.TabIndex = 1;
            buttonScheduleTask.Text = "Schedule task";
            buttonScheduleTask.UseVisualStyleBackColor = false;
            buttonScheduleTask.Click += buttonScheduleTask_Click;
            // 
            // buttonMarkDone
            // 
            buttonMarkDone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMarkDone.BackColor = Color.LimeGreen;
            buttonMarkDone.Cursor = Cursors.Hand;
            buttonMarkDone.FlatAppearance.BorderSize = 0;
            buttonMarkDone.FlatStyle = FlatStyle.Flat;
            buttonMarkDone.Font = new Font("Segoe UI", 10F);
            buttonMarkDone.ForeColor = Color.White;
            buttonMarkDone.Location = new Point(594, 16);
            buttonMarkDone.Margin = new Padding(4);
            buttonMarkDone.Name = "buttonMarkDone";
            buttonMarkDone.Size = new Size(170, 40);
            buttonMarkDone.TabIndex = 2;
            buttonMarkDone.Text = "Mark Done";
            buttonMarkDone.UseVisualStyleBackColor = false;
            buttonMarkDone.Click += buttonMarkDone_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete.BackColor = Color.Firebrick;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 10F);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(414, 16);
            buttonDelete.Margin = new Padding(4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(170, 40);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEdit.BackColor = Color.SteelBlue;
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 10F);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(234, 16);
            buttonEdit.Margin = new Padding(4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(170, 40);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonMarkDone);
            panel1.Controls.Add(buttonScheduleTask);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 72);
            panel1.TabIndex = 2;
            // 
            // pnlHolder
            // 
            pnlHolder.Controls.Add(dataGridView1);
            pnlHolder.Dock = DockStyle.Fill;
            pnlHolder.Location = new Point(0, 72);
            pnlHolder.Name = "pnlHolder";
            pnlHolder.Padding = new Padding(10);
            pnlHolder.Size = new Size(958, 492);
            pnlHolder.TabIndex = 3;
            // 
            // PreventiveMaintenanceView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(pnlHolder);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "PreventiveMaintenanceView";
            Size = new Size(958, 564);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            pnlHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonScheduleTask;
        private Button buttonMarkDone;
        private Button buttonDelete;
        private Button buttonEdit;
        private DataGridViewTextBoxColumn task;
        private DataGridViewTextBoxColumn location;
        private DataGridViewTextBoxColumn equipment;
        private DataGridViewTextBoxColumn frequency;
        private DataGridViewTextBoxColumn lastcompleted;
        private DataGridViewTextBoxColumn nextdue;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn assignedto;
        private Panel panel1;
        private Panel pnlHolder;
    }
}
