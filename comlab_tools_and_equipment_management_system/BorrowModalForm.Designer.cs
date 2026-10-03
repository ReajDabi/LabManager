namespace ComLabManager.UI
{
    partial class BorrowModalForm
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
            cmbScope = new ComboBox();
            cmbItem = new ComboBox();
            textBox1 = new TextBox();
            lblTitle = new Label();
            lblScope = new Label();
            lblItem = new Label();
            lblPurpose = new Label();
            dtpRequestedDate = new DateTimePicker();
            lblDate = new Label();
            lblStartTime = new Label();
            dtpStartTime = new DateTimePicker();
            lblEndTime = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // cmbScope
            // 
            cmbScope.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbScope.FormattingEnabled = true;
            cmbScope.Items.AddRange(new object[] { "Borrow Entire Room", "Borrow ComLab PC", "Borrow Lab Equipment" });
            cmbScope.Location = new Point(75, 133);
            cmbScope.Name = "cmbScope";
            cmbScope.Size = new Size(233, 33);
            cmbScope.TabIndex = 0;
            // 
            // cmbItem
            // 
            cmbItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItem.FormattingEnabled = true;
            cmbItem.Items.AddRange(new object[] { "Borrow Entire Room", "Borrow ComLab PC", "Borrow Lab Equipment" });
            cmbItem.Location = new Point(75, 217);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(233, 33);
            cmbItem.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(357, 133);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 382);
            textBox1.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(220, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(337, 48);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Borrow Equipment";
            // 
            // lblScope
            // 
            lblScope.AutoSize = true;
            lblScope.Location = new Point(79, 103);
            lblScope.Name = "lblScope";
            lblScope.Size = new Size(65, 25);
            lblScope.TabIndex = 3;
            lblScope.Text = "Scope:";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(75, 187);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(52, 25);
            lblItem.TabIndex = 3;
            lblItem.Text = "Item:";
            // 
            // lblPurpose
            // 
            lblPurpose.AutoSize = true;
            lblPurpose.Location = new Point(357, 105);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(190, 25);
            lblPurpose.TabIndex = 3;
            lblPurpose.Text = "Purpose of Borrowing:";
            // 
            // dtpRequestedDate
            // 
            dtpRequestedDate.Format = DateTimePickerFormat.Short;
            dtpRequestedDate.Location = new Point(75, 301);
            dtpRequestedDate.Name = "dtpRequestedDate";
            dtpRequestedDate.Size = new Size(230, 31);
            dtpRequestedDate.TabIndex = 4;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(79, 271);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(120, 25);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date Needed:";
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Location = new Point(75, 365);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(95, 25);
            lblStartTime.TabIndex = 3;
            lblStartTime.Text = "Start Time:";
            // 
            // dtpStartTime
            // 
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(75, 393);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(230, 31);
            dtpStartTime.TabIndex = 4;
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Location = new Point(75, 456);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(89, 25);
            lblEndTime.TabIndex = 3;
            lblEndTime.Text = "End Time:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(75, 484);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(230, 31);
            dateTimePicker1.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(25, 135, 84);
            btnSubmit.DialogResult = DialogResult.OK;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(561, 592);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(159, 50);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit Request";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(148, 163, 184);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(357, 592);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(159, 50);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel\r\n";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // BorrowModalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 665);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(dateTimePicker1);
            Controls.Add(dtpStartTime);
            Controls.Add(dtpRequestedDate);
            Controls.Add(lblEndTime);
            Controls.Add(lblItem);
            Controls.Add(lblStartTime);
            Controls.Add(lblDate);
            Controls.Add(lblPurpose);
            Controls.Add(lblScope);
            Controls.Add(lblTitle);
            Controls.Add(textBox1);
            Controls.Add(cmbItem);
            Controls.Add(cmbScope);
            Name = "BorrowModalForm";
            Text = "BorrowModalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbScope;
        private ComboBox cmbItem;
        private TextBox textBox1;
        private Label lblTitle;
        private Label lblScope;
        private Label lblItem;
        private Label lblPurpose;
        private DateTimePicker dtpRequestedDate;
        private Label lblDate;
        private Label lblStartTime;
        private DateTimePicker dtpStartTime;
        private Label lblEndTime;
        private DateTimePicker dateTimePicker1;
        private Button btnSubmit;
        private Button btnCancel;
    }
}