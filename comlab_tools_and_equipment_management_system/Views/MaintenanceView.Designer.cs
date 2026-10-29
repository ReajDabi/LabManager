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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            buttonCreateTicket = new Button();
            buttonResolve = new Button();
            buttonStartRepair = new Button();
            buttonAssign = new Button();
            dataGridView1 = new DataGridView();
            ticket = new DataGridViewTextBoxColumn();
            assettag = new DataGridViewTextBoxColumn();
            equipment = new DataGridViewTextBoxColumn();
            issue = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            sparepart = new DataGridViewTextBoxColumn();
            technician = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            pnnlHolder = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            pnnlHolder.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCreateTicket
            // 
            buttonCreateTicket.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCreateTicket.BackColor = Color.Navy;
            buttonCreateTicket.FlatStyle = FlatStyle.Flat;
            buttonCreateTicket.ForeColor = SystemColors.ControlLight;
            buttonCreateTicket.Location = new Point(801, 9);
            buttonCreateTicket.Name = "buttonCreateTicket";
            buttonCreateTicket.Size = new Size(138, 39);
            buttonCreateTicket.TabIndex = 0;
            buttonCreateTicket.Text = "Create Ticket";
            buttonCreateTicket.UseVisualStyleBackColor = false;
            buttonCreateTicket.Click += buttonCreateTicket_Click;
            // 
            // buttonResolve
            // 
            buttonResolve.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonResolve.BackColor = Color.LimeGreen;
            buttonResolve.Cursor = Cursors.Hand;
            buttonResolve.FlatStyle = FlatStyle.Flat;
            buttonResolve.ForeColor = Color.White;
            buttonResolve.Location = new Point(651, 9);
            buttonResolve.Name = "buttonResolve";
            buttonResolve.Size = new Size(138, 39);
            buttonResolve.TabIndex = 2;
            buttonResolve.Text = "Resolve";
            buttonResolve.UseVisualStyleBackColor = false;
            buttonResolve.Click += buttonResolve_Click;
            // 
            // buttonStartRepair
            // 
            buttonStartRepair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonStartRepair.BackColor = Color.DarkOrange;
            buttonStartRepair.Cursor = Cursors.Hand;
            buttonStartRepair.FlatStyle = FlatStyle.Flat;
            buttonStartRepair.ForeColor = Color.White;
            buttonStartRepair.Location = new Point(501, 9);
            buttonStartRepair.Name = "buttonStartRepair";
            buttonStartRepair.Size = new Size(138, 39);
            buttonStartRepair.TabIndex = 1;
            buttonStartRepair.Text = "Start Repair";
            buttonStartRepair.UseVisualStyleBackColor = false;
            buttonStartRepair.Click += buttonStartRepair_Click;
            // 
            // buttonAssign
            // 
            buttonAssign.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAssign.BackColor = Color.SteelBlue;
            buttonAssign.Cursor = Cursors.Hand;
            buttonAssign.FlatStyle = FlatStyle.Flat;
            buttonAssign.ForeColor = Color.White;
            buttonAssign.Location = new Point(351, 9);
            buttonAssign.Name = "buttonAssign";
            buttonAssign.Size = new Size(138, 39);
            buttonAssign.TabIndex = 3;
            buttonAssign.Text = "Assign";
            buttonAssign.UseVisualStyleBackColor = false;
            buttonAssign.Click += buttonAssign_Click;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ticket, assettag, equipment, issue, status, sparepart, technician });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(10, 10);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(938, 484);
            dataGridView1.TabIndex = 1;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // ticket
            // 
            ticket.FillWeight = 60F;
            ticket.HeaderText = "Ticket";
            ticket.MinimumWidth = 6;
            ticket.Name = "ticket";
            ticket.ReadOnly = true;
            // 
            // assettag
            // 
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            assettag.DefaultCellStyle = dataGridViewCellStyle2;
            assettag.HeaderText = "Asset Tag";
            assettag.MinimumWidth = 6;
            assettag.Name = "assettag";
            assettag.ReadOnly = true;
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
            issue.FillWeight = 160F;
            issue.HeaderText = "Issue";
            issue.MinimumWidth = 6;
            issue.Name = "issue";
            issue.ReadOnly = true;
            // 
            // status
            // 
            status.FillWeight = 80F;
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // sparepart
            // 
            sparepart.HeaderText = "Spare Part Used";
            sparepart.MinimumWidth = 6;
            sparepart.Name = "sparepart";
            sparepart.ReadOnly = true;
            // 
            // technician
            // 
            technician.HeaderText = "Assigned Technician";
            technician.MinimumWidth = 6;
            technician.Name = "technician";
            technician.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonAssign);
            panel1.Controls.Add(buttonStartRepair);
            panel1.Controls.Add(buttonResolve);
            panel1.Controls.Add(buttonCreateTicket);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 60);
            panel1.TabIndex = 2;
            // 
            // pnnlHolder
            // 
            pnnlHolder.Controls.Add(dataGridView1);
            pnnlHolder.Dock = DockStyle.Fill;
            pnnlHolder.Location = new Point(0, 60);
            pnnlHolder.Name = "pnnlHolder";
            pnnlHolder.Padding = new Padding(10);
            pnnlHolder.Size = new Size(958, 504);
            pnnlHolder.TabIndex = 3;
            // 
            // MaintenanceView
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pnnlHolder);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 10F);
            Name = "MaintenanceView";
            Size = new Size(958, 564);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            pnnlHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCreateTicket;
        private Button buttonResolve;
        private Button buttonStartRepair;
        private Button buttonAssign;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ticket;
        private DataGridViewTextBoxColumn assettag;
        private DataGridViewTextBoxColumn equipment;
        private DataGridViewTextBoxColumn issue;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn sparepart;
        private Panel panel1;
        private DataGridViewTextBoxColumn technician;
        private Panel pnnlHolder;
    }
}
