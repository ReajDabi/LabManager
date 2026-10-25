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
            cmbEquipmentName = new ComboBox();
            txtPurpose = new TextBox();
            lblTitle = new Label();
            lblScope = new Label();
            lblItem = new Label();
            lblPurpose = new Label();
            dtpRequestedDate = new DateTimePicker();
            lblDate = new Label();
            lblStartTime = new Label();
            dtpStartTime = new DateTimePicker();
            lblEndTime = new Label();
            dtpEndTime = new DateTimePicker();
            btnSubmit = new Button();
            btnCancel = new Button();
            cmbAssetTag = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbScope
            // 
            cmbScope.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbScope.FormattingEnabled = true;
            cmbScope.Location = new Point(75, 133);
            cmbScope.Name = "cmbScope";
            cmbScope.Size = new Size(233, 33);
            cmbScope.TabIndex = 0;
            cmbScope.SelectedIndexChanged += cmbScope_SelectedIndexChanged;
            // 
            // cmbEquipmentName
            // 
            cmbEquipmentName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbEquipmentName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbEquipmentName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEquipmentName.FormattingEnabled = true;
            cmbEquipmentName.Location = new Point(75, 217);
            cmbEquipmentName.Name = "cmbEquipmentName";
            cmbEquipmentName.Size = new Size(233, 33);
            cmbEquipmentName.TabIndex = 0;
            cmbEquipmentName.SelectedIndexChanged += cmbEquipmentName_SelectedIndexChanged;
            // 
            // txtPurpose
            // 
            txtPurpose.BorderStyle = BorderStyle.FixedSingle;
            txtPurpose.Location = new Point(357, 133);
            txtPurpose.Multiline = true;
            txtPurpose.Name = "txtPurpose";
            txtPurpose.Size = new Size(363, 464);
            txtPurpose.TabIndex = 1;
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
            dtpRequestedDate.Location = new Point(75, 383);
            dtpRequestedDate.Name = "dtpRequestedDate";
            dtpRequestedDate.Size = new Size(230, 31);
            dtpRequestedDate.TabIndex = 4;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(75, 355);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(120, 25);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date Needed:";
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Location = new Point(79, 447);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(95, 25);
            lblStartTime.TabIndex = 3;
            lblStartTime.Text = "Start Time:";
            // 
            // dtpStartTime
            // 
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(75, 475);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(230, 31);
            dtpStartTime.TabIndex = 4;
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Location = new Point(78, 538);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(89, 25);
            lblEndTime.TabIndex = 3;
            lblEndTime.Text = "End Time:";
            // 
            // dtpEndTime
            // 
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.Location = new Point(75, 566);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(230, 31);
            dtpEndTime.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(25, 135, 84);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(561, 663);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(159, 50);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit Request";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(148, 163, 184);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(357, 663);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(159, 50);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel\r\n";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbAssetTag
            // 
            cmbAssetTag.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbAssetTag.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbAssetTag.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAssetTag.FormattingEnabled = true;
            cmbAssetTag.Location = new Point(75, 298);
            cmbAssetTag.Name = "cmbAssetTag";
            cmbAssetTag.Size = new Size(233, 33);
            cmbAssetTag.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 268);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 3;
            label1.Text = "Asset Tag:";
            // 
            // BorrowModalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 725);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(dtpEndTime);
            Controls.Add(dtpStartTime);
            Controls.Add(dtpRequestedDate);
            Controls.Add(lblEndTime);
            Controls.Add(label1);
            Controls.Add(lblItem);
            Controls.Add(lblStartTime);
            Controls.Add(lblDate);
            Controls.Add(lblPurpose);
            Controls.Add(lblScope);
            Controls.Add(lblTitle);
            Controls.Add(txtPurpose);
            Controls.Add(cmbAssetTag);
            Controls.Add(cmbEquipmentName);
            Controls.Add(cmbScope);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BorrowModalForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BorrowModalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbScope;
        private ComboBox cmbEquipmentName;
        private TextBox txtPurpose;
        private Label lblTitle;
        private Label lblScope;
        private Label lblItem;
        private Label lblPurpose;
        private DateTimePicker dtpRequestedDate;
        private Label lblDate;
        private Label lblStartTime;
        private DateTimePicker dtpStartTime;
        private Label lblEndTime;
        private DateTimePicker dtpEndTime;
        private Button btnSubmit;
        private Button btnCancel;
        private ComboBox cmbAssetTag;
        private Label label1;
    }
}