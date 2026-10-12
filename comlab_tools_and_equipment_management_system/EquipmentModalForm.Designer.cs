namespace ComLabManager.UI
{
    partial class EquipmentModalForm
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
            txtAssetTag = new TextBox();
            txtEquipmentName = new TextBox();
            txtStationNumber = new TextBox();
            cmbCategory = new ComboBox();
            cmbStatus = new ComboBox();
            dtpDateAquired = new DateTimePicker();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            lblAssetTag = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // txtAssetTag
            // 
            txtAssetTag.BorderStyle = BorderStyle.FixedSingle;
            txtAssetTag.Location = new Point(72, 159);
            txtAssetTag.Multiline = true;
            txtAssetTag.Name = "txtAssetTag";
            txtAssetTag.Size = new Size(243, 31);
            txtAssetTag.TabIndex = 0;
            // 
            // txtEquipmentName
            // 
            txtEquipmentName.BorderStyle = BorderStyle.FixedSingle;
            txtEquipmentName.Location = new Point(418, 159);
            txtEquipmentName.Multiline = true;
            txtEquipmentName.Name = "txtEquipmentName";
            txtEquipmentName.Size = new Size(243, 31);
            txtEquipmentName.TabIndex = 0;
            // 
            // txtStationNumber
            // 
            txtStationNumber.BorderStyle = BorderStyle.FixedSingle;
            txtStationNumber.Location = new Point(72, 357);
            txtStationNumber.Multiline = true;
            txtStationNumber.Name = "txtStationNumber";
            txtStationNumber.Size = new Size(243, 31);
            txtStationNumber.TabIndex = 0;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(72, 253);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(243, 33);
            cmbCategory.TabIndex = 1;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(418, 253);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(243, 33);
            cmbStatus.TabIndex = 1;
            // 
            // dtpDateAquired
            // 
            dtpDateAquired.Format = DateTimePickerFormat.Short;
            dtpDateAquired.Location = new Point(418, 357);
            dtpDateAquired.Name = "dtpDateAquired";
            dtpDateAquired.Size = new Size(243, 31);
            dtpDateAquired.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkGray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(72, 446);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(174, 48);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(487, 446);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(174, 48);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 225);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 4;
            label1.Text = "Category";
            // 
            // lblAssetTag
            // 
            lblAssetTag.AutoSize = true;
            lblAssetTag.Location = new Point(77, 129);
            lblAssetTag.Name = "lblAssetTag";
            lblAssetTag.Size = new Size(87, 25);
            lblAssetTag.TabIndex = 4;
            lblAssetTag.Text = "Asset Tag";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 329);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 4;
            label3.Text = "Station Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(422, 129);
            label4.Name = "label4";
            label4.Size = new Size(150, 25);
            label4.TabIndex = 4;
            label4.Text = "Equipment Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(423, 225);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 4;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(422, 329);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 4;
            label6.Text = "Date Aquired";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(211, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(282, 48);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Add Equipment";
            // 
            // EquipmentModalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 534);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblTitle);
            Controls.Add(lblAssetTag);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(dtpDateAquired);
            Controls.Add(cmbStatus);
            Controls.Add(cmbCategory);
            Controls.Add(txtStationNumber);
            Controls.Add(txtEquipmentName);
            Controls.Add(txtAssetTag);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EquipmentModalForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EquipmentModalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAssetTag;
        private TextBox txtEquipmentName;
        private TextBox txtStationNumber;
        private ComboBox cmbCategory;
        private ComboBox cmbStatus;
        private DateTimePicker dtpDateAquired;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        private Label lblAssetTag;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblTitle;
    }
}