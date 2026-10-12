namespace ComLabManager.UI
{
    partial class ResolveTicketForm
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
            btnResolve = new Button();
            btnCancel = new Button();
            cmbSparePart = new ComboBox();
            lblSparePart = new Label();
            lblTicket = new Label();
            lblTitle = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            //
            // groupBox1
            //
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(btnResolve);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(cmbSparePart);
            groupBox1.Controls.Add(lblSparePart);
            groupBox1.Controls.Add(lblTicket);
            groupBox1.Controls.Add(lblTitle);
            groupBox1.Location = new Point(20, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 301);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            //
            // btnResolve
            //
            btnResolve.BackColor = Color.LimeGreen;
            btnResolve.Cursor = Cursors.Hand;
            btnResolve.FlatAppearance.BorderSize = 0;
            btnResolve.FlatStyle = FlatStyle.Flat;
            btnResolve.ForeColor = Color.White;
            btnResolve.Location = new Point(399, 235);
            btnResolve.Name = "btnResolve";
            btnResolve.Size = new Size(111, 39);
            btnResolve.TabIndex = 5;
            btnResolve.Text = "Resolve";
            btnResolve.UseVisualStyleBackColor = false;
            btnResolve.Click += btnResolve_Click;
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
            // cmbSparePart
            //
            cmbSparePart.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSparePart.FlatStyle = FlatStyle.Flat;
            cmbSparePart.FormattingEnabled = true;
            cmbSparePart.Location = new Point(31, 163);
            cmbSparePart.Name = "cmbSparePart";
            cmbSparePart.Size = new Size(479, 36);
            cmbSparePart.TabIndex = 3;
            //
            // lblSparePart
            //
            lblSparePart.AutoSize = true;
            lblSparePart.FlatStyle = FlatStyle.Flat;
            lblSparePart.ForeColor = Color.Black;
            lblSparePart.Location = new Point(27, 132);
            lblSparePart.Name = "lblSparePart";
            lblSparePart.Size = new Size(149, 28);
            lblSparePart.TabIndex = 2;
            lblSparePart.Text = "Spare part used";
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
            lblTitle.Size = new Size(180, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Resolve Ticket";
            //
            // ResolveTicketForm
            //
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(582, 319);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(248, 249, 250);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResolveTicketForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ResolveTicketForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblTitle;
        private Label lblTicket;
        private Label lblSparePart;
        private ComboBox cmbSparePart;
        private Button btnCancel;
        private Button btnResolve;
    }
}
