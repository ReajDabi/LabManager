namespace ComLabManager.UI
{
    partial class AssignTechnicianForm
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
            groupBox1 = new GroupBox();
            btnAssign = new Button();
            btnCancel = new Button();
            cmbTechnician = new ComboBox();
            lblTechnician = new Label();
            lblTicket = new Label();
            lblTitle = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            //
            // groupBox1
            //
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(btnAssign);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(cmbTechnician);
            groupBox1.Controls.Add(lblTechnician);
            groupBox1.Controls.Add(lblTicket);
            groupBox1.Controls.Add(lblTitle);
            groupBox1.Location = new Point(20, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 301);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            //
            // btnAssign
            //
            btnAssign.BackColor = Color.LimeGreen;
            btnAssign.Cursor = Cursors.Hand;
            btnAssign.FlatAppearance.BorderSize = 0;
            btnAssign.FlatStyle = FlatStyle.Flat;
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(399, 235);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(111, 39);
            btnAssign.TabIndex = 5;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssign_Click;
            //
            // btnCancel
            //
            btnCancel.BackColor = SystemColors.GrayText;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(266, 235);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 39);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            //
            // cmbTechnician
            //
            cmbTechnician.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTechnician.FlatStyle = FlatStyle.Flat;
            cmbTechnician.FormattingEnabled = true;
            cmbTechnician.Location = new Point(31, 163);
            cmbTechnician.Name = "cmbTechnician";
            cmbTechnician.Size = new Size(479, 36);
            cmbTechnician.TabIndex = 3;
            //
            // lblTechnician
            //
            lblTechnician.AutoSize = true;
            lblTechnician.FlatStyle = FlatStyle.Flat;
            lblTechnician.ForeColor = Color.Black;
            lblTechnician.Location = new Point(27, 132);
            lblTechnician.Name = "lblTechnician";
            lblTechnician.Size = new Size(190, 28);
            lblTechnician.TabIndex = 2;
            lblTechnician.Text = "Assigned Technician";
            //
            // lblTicket
            //
            lblTicket.AutoEllipsis = true;
            lblTicket.FlatStyle = FlatStyle.Flat;
            lblTicket.ForeColor = Color.Black;
            lblTicket.Location = new Point(27, 80);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(483, 28);
            lblTicket.TabIndex = 1;
            lblTicket.Text = "Asset Tag";
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(27, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Assign Technician";
            //
            // AssignTechnicianForm
            //
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(582, 319);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(248, 249, 250);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AssignTechnicianForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AssignTechnicianForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblTitle;
        private Label lblTicket;
        private Label lblTechnician;
        private ComboBox cmbTechnician;
        private Button btnCancel;
        private Button btnAssign;
    }
}
