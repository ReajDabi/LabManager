namespace ComLabManager.UI
{
    partial class SparePartModalForm
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
            cmbSparePart = new ComboBox();
            numQuantity = new NumericUpDown();
            txtReason = new TextBox();
            btnSubmit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCancel = new Button();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // cmbSparePart
            // 
            cmbSparePart.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSparePart.FormattingEnabled = true;
            cmbSparePart.Location = new Point(102, 153);
            cmbSparePart.Name = "cmbSparePart";
            cmbSparePart.Size = new Size(168, 33);
            cmbSparePart.TabIndex = 0;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(382, 153);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(95, 31);
            numQuantity.TabIndex = 1;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtReason
            // 
            txtReason.Location = new Point(102, 267);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(375, 125);
            txtReason.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Green;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(352, 442);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(125, 43);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(387, 123);
            label1.Name = "label1";
            label1.Size = new Size(41, 25);
            label1.TabIndex = 4;
            label1.Text = "Qty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 125);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 4;
            label2.Text = "SparePart";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 239);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 4;
            label3.Text = "Reason";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveBorder;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Location = new Point(102, 442);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 43);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(93, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(401, 54);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Request Spare Parts";
            // 
            // SparePartModalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 529);
            Controls.Add(label3);
            Controls.Add(lblTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtReason);
            Controls.Add(numQuantity);
            Controls.Add(cmbSparePart);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SparePartModalForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SparePartModalForm";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSparePart;
        private NumericUpDown numQuantity;
        private TextBox txtReason;
        private Button btnSubmit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCancel;
        private Label lblTitle;
    }
}