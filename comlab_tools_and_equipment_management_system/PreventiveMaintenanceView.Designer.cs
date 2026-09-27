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
            equipment = new DataGridViewTextBoxColumn();
            frequency = new DataGridViewTextBoxColumn();
            lastcompleted = new DataGridViewTextBoxColumn();
            nextdue = new DataGridViewTextBoxColumn();
            assignedto = new DataGridViewTextBoxColumn();
            buttonScheduleTask = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(248, 249, 250);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { task, equipment, frequency, lastcompleted, nextdue, assignedto });
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(958, 474);
            dataGridView1.TabIndex = 0;
            // 
            // task
            // 
            task.HeaderText = "Task";
            task.MinimumWidth = 6;
            task.Name = "task";
            task.ReadOnly = true;
            // 
            // equipment
            // 
            equipment.HeaderText = "Equipment";
            equipment.MinimumWidth = 6;
            equipment.Name = "equipment";
            equipment.ReadOnly = true;
            // 
            // frequency
            // 
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
            // assignedto
            // 
            assignedto.HeaderText = "Assigned To";
            assignedto.MinimumWidth = 6;
            assignedto.Name = "assignedto";
            assignedto.ReadOnly = true;
            // 
            // buttonScheduleTask
            // 
            buttonScheduleTask.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonScheduleTask.BackColor = Color.Navy;
            buttonScheduleTask.BackgroundImageLayout = ImageLayout.None;
            buttonScheduleTask.Cursor = Cursors.Hand;
            buttonScheduleTask.FlatAppearance.BorderSize = 0;
            buttonScheduleTask.FlatStyle = FlatStyle.Flat;
            buttonScheduleTask.Font = new Font("Segoe UI", 10F);
            buttonScheduleTask.ForeColor = Color.White;
            buttonScheduleTask.Location = new Point(738, 480);
            buttonScheduleTask.Name = "buttonScheduleTask";
            buttonScheduleTask.Size = new Size(193, 62);
            buttonScheduleTask.TabIndex = 1;
            buttonScheduleTask.Text = "Schedule task";
            buttonScheduleTask.UseVisualStyleBackColor = false;
            buttonScheduleTask.Click += buttonScheduleTask_Click;
            // 
            // PreventiveMaintenanceView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(buttonScheduleTask);
            Controls.Add(dataGridView1);
            Name = "PreventiveMaintenanceView";
            Size = new Size(958, 564);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonScheduleTask;
        private DataGridViewTextBoxColumn task;
        private DataGridViewTextBoxColumn equipment;
        private DataGridViewTextBoxColumn frequency;
        private DataGridViewTextBoxColumn lastcompleted;
        private DataGridViewTextBoxColumn nextdue;
        private DataGridViewTextBoxColumn assignedto;
    }
}
