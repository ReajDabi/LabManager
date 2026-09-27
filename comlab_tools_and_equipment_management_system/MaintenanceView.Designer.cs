namespace ComLabManager.UI
{
    partial class MaintenanceView
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
            buttonCreateTicket = new Button();
            dataGridView1 = new DataGridView();
            ticket = new DataGridViewTextBoxColumn();
            equipment = new DataGridViewTextBoxColumn();
            issue = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            cost = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonCreateTicket
            // 
            buttonCreateTicket.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCreateTicket.BackColor = Color.Navy;
            buttonCreateTicket.Cursor = Cursors.NoMove2D;
            buttonCreateTicket.FlatStyle = FlatStyle.Flat;
            buttonCreateTicket.ForeColor = SystemColors.ControlLight;
            buttonCreateTicket.Location = new Point(789, 10);
            buttonCreateTicket.Name = "buttonCreateTicket";
            buttonCreateTicket.Size = new Size(153, 44);
            buttonCreateTicket.TabIndex = 0;
            buttonCreateTicket.Text = "Create Ticket";
            buttonCreateTicket.UseVisualStyleBackColor = false;
            buttonCreateTicket.Click += buttonCreateTicket_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(248, 249, 250);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ticket, equipment, issue, status, cost });
            dataGridView1.Location = new Point(-3, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(958, 497);
            dataGridView1.TabIndex = 1;
            // 
            // ticket
            // 
            ticket.HeaderText = "Ticket";
            ticket.MinimumWidth = 6;
            ticket.Name = "ticket";
            ticket.ReadOnly = true;
            // 
            // equipment
            // 
            equipment.HeaderText = "Equipment";
            equipment.MinimumWidth = 6;
            equipment.Name = "equipment";
            equipment.ReadOnly = true;
            // 
            // issue
            // 
            issue.HeaderText = "Issue";
            issue.MinimumWidth = 6;
            issue.Name = "issue";
            issue.ReadOnly = true;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // cost
            // 
            cost.HeaderText = "Cost";
            cost.MinimumWidth = 6;
            cost.Name = "cost";
            cost.ReadOnly = true;
            // 
            // MaintenanceView
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(buttonCreateTicket);
            Controls.Add(dataGridView1);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 10F);
            Name = "MaintenanceView";
            Size = new Size(958, 564);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCreateTicket;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ticket;
        private DataGridViewTextBoxColumn equipment;
        private DataGridViewTextBoxColumn issue;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn cost;
    }
}
