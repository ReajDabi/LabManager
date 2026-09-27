namespace ComLabManager.UI
{
    partial class DashboardView
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
            pnlCardEquipment = new Panel();
            lblTEC = new Label();
            lblTEquipment = new Label();
            panel1 = new Panel();
            lblIURC = new Label();
            lblIUR = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            pnlAnalytics = new Panel();
            pnlDecommissioned = new Panel();
            pnlRepair = new Panel();
            pnlActive = new Panel();
            lblDeccomissioned = new Label();
            lblUnderRepair = new Label();
            lblActive = new Label();
            lblChartTitle = new Label();
            panel3 = new Panel();
            dgvRecentTickets = new DataGridView();
            Ticket = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pnlCardEquipment.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlAnalytics.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentTickets).BeginInit();
            SuspendLayout();
            // 
            // pnlCardEquipment
            // 
            pnlCardEquipment.BackColor = Color.WhiteSmoke;
            pnlCardEquipment.Controls.Add(lblTEC);
            pnlCardEquipment.Controls.Add(lblTEquipment);
            pnlCardEquipment.Location = new Point(35, 29);
            pnlCardEquipment.Name = "pnlCardEquipment";
            pnlCardEquipment.Size = new Size(280, 120);
            pnlCardEquipment.TabIndex = 0;
            // 
            // lblTEC
            // 
            lblTEC.AutoSize = true;
            lblTEC.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTEC.ForeColor = Color.FromArgb(30, 41, 59);
            lblTEC.Location = new Point(77, 8);
            lblTEC.Name = "lblTEC";
            lblTEC.Size = new Size(128, 74);
            lblTEC.TabIndex = 0;
            lblTEC.Text = "142";
            // 
            // lblTEquipment
            // 
            lblTEquipment.AutoSize = true;
            lblTEquipment.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTEquipment.ForeColor = Color.FromArgb(148, 163, 184);
            lblTEquipment.Location = new Point(55, 80);
            lblTEquipment.Name = "lblTEquipment";
            lblTEquipment.Size = new Size(167, 28);
            lblTEquipment.TabIndex = 0;
            lblTEquipment.Text = "Total Equipment";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblIURC);
            panel1.Controls.Add(lblIUR);
            panel1.Location = new Point(335, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 120);
            panel1.TabIndex = 0;
            // 
            // lblIURC
            // 
            lblIURC.AutoSize = true;
            lblIURC.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIURC.ForeColor = Color.FromArgb(229, 57, 69);
            lblIURC.Location = new Point(109, 8);
            lblIURC.Name = "lblIURC";
            lblIURC.Size = new Size(64, 74);
            lblIURC.TabIndex = 0;
            lblIURC.Text = "8";
            // 
            // lblIUR
            // 
            lblIUR.AutoSize = true;
            lblIUR.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIUR.ForeColor = Color.FromArgb(148, 163, 184);
            lblIUR.Location = new Point(48, 81);
            lblIUR.Name = "lblIUR";
            lblIUR.Size = new Size(194, 28);
            lblIUR.TabIndex = 0;
            lblIUR.Text = "Items Under Repair";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(635, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 120);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(234, 179, 8);
            label3.Location = new Point(88, 8);
            label3.Name = "label3";
            label3.Size = new Size(96, 74);
            label3.TabIndex = 0;
            label3.Text = "12";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(148, 163, 184);
            label4.Location = new Point(55, 80);
            label4.Name = "label4";
            label4.Size = new Size(164, 28);
            label4.TabIndex = 0;
            label4.Text = "Low Spare Parts";
            // 
            // pnlAnalytics
            // 
            pnlAnalytics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlAnalytics.BackColor = Color.WhiteSmoke;
            pnlAnalytics.Controls.Add(pnlDecommissioned);
            pnlAnalytics.Controls.Add(pnlRepair);
            pnlAnalytics.Controls.Add(pnlActive);
            pnlAnalytics.Controls.Add(lblDeccomissioned);
            pnlAnalytics.Controls.Add(lblUnderRepair);
            pnlAnalytics.Controls.Add(lblActive);
            pnlAnalytics.Controls.Add(lblChartTitle);
            pnlAnalytics.Location = new Point(35, 179);
            pnlAnalytics.Name = "pnlAnalytics";
            pnlAnalytics.Size = new Size(550, 360);
            pnlAnalytics.TabIndex = 2;
            // 
            // pnlDecommissioned
            // 
            pnlDecommissioned.BackColor = Color.FromArgb(148, 163, 184);
            pnlDecommissioned.Location = new Point(170, 271);
            pnlDecommissioned.Name = "pnlDecommissioned";
            pnlDecommissioned.Size = new Size(119, 25);
            pnlDecommissioned.TabIndex = 3;
            // 
            // pnlRepair
            // 
            pnlRepair.BackColor = Color.FromArgb(229, 57, 69);
            pnlRepair.Location = new Point(170, 185);
            pnlRepair.Name = "pnlRepair";
            pnlRepair.Size = new Size(69, 25);
            pnlRepair.TabIndex = 3;
            // 
            // pnlActive
            // 
            pnlActive.BackColor = Color.FromArgb(25, 135, 84);
            pnlActive.Location = new Point(170, 109);
            pnlActive.Name = "pnlActive";
            pnlActive.Size = new Size(344, 25);
            pnlActive.TabIndex = 2;
            // 
            // lblDeccomissioned
            // 
            lblDeccomissioned.AutoSize = true;
            lblDeccomissioned.Location = new Point(14, 271);
            lblDeccomissioned.Name = "lblDeccomissioned";
            lblDeccomissioned.Size = new Size(150, 25);
            lblDeccomissioned.TabIndex = 1;
            lblDeccomissioned.Text = "Decommissioned";
            // 
            // lblUnderRepair
            // 
            lblUnderRepair.AutoSize = true;
            lblUnderRepair.Location = new Point(14, 185);
            lblUnderRepair.Name = "lblUnderRepair";
            lblUnderRepair.Size = new Size(114, 25);
            lblUnderRepair.TabIndex = 1;
            lblUnderRepair.Text = "Under Repair";
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Location = new Point(14, 109);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(60, 25);
            lblActive.TabIndex = 1;
            lblActive.Text = "Active";
            // 
            // lblChartTitle
            // 
            lblChartTitle.AutoSize = true;
            lblChartTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChartTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblChartTitle.Location = new Point(14, 24);
            lblChartTitle.Name = "lblChartTitle";
            lblChartTitle.Size = new Size(328, 32);
            lblChartTitle.TabIndex = 0;
            lblChartTitle.Text = "Equipment Status Overview";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dgvRecentTickets);
            panel3.Location = new Point(607, 226);
            panel3.Name = "panel3";
            panel3.Size = new Size(308, 313);
            panel3.TabIndex = 3;
            // 
            // dgvRecentTickets
            // 
            dgvRecentTickets.BackgroundColor = Color.White;
            dgvRecentTickets.BorderStyle = BorderStyle.None;
            dgvRecentTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentTickets.Columns.AddRange(new DataGridViewColumn[] { Ticket, Status });
            dgvRecentTickets.Dock = DockStyle.Fill;
            dgvRecentTickets.Location = new Point(0, 0);
            dgvRecentTickets.Name = "dgvRecentTickets";
            dgvRecentTickets.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRecentTickets.RowHeadersVisible = false;
            dgvRecentTickets.RowHeadersWidth = 62;
            dgvRecentTickets.Size = new Size(308, 313);
            dgvRecentTickets.TabIndex = 1;
            // 
            // Ticket
            // 
            Ticket.HeaderText = "Ticket/Issue";
            Ticket.MinimumWidth = 8;
            Ticket.Name = "Ticket";
            Ticket.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 155;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(635, 179);
            label1.Name = "label1";
            label1.Size = new Size(246, 32);
            label1.TabIndex = 0;
            label1.Text = "Recent Maintenance";
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(pnlAnalytics);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlCardEquipment);
            Name = "DashboardView";
            Size = new Size(958, 564);
            pnlCardEquipment.ResumeLayout(false);
            pnlCardEquipment.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlAnalytics.ResumeLayout(false);
            pnlAnalytics.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecentTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCardEquipment;
        private Label lblTEC;
        private Label lblTEquipment;
        private Panel panel1;
        private Label lblIURC;
        private Label lblIUR;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Panel pnlAnalytics;
        private Label lblChartTitle;
        private Label lblDeccomissioned;
        private Label lblUnderRepair;
        private Label lblActive;
        private Panel panel3;
        private DataGridView dgvRecentTickets;
        private Label label1;
        private DataGridViewTextBoxColumn Ticket;
        private DataGridViewTextBoxColumn Status;
        private Panel pnlDecommissioned;
        private Panel pnlRepair;
        private Panel panel4;
        private Panel pnlActive;
    }
}
