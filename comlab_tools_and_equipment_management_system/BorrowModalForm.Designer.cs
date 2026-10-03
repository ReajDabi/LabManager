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
            SuspendLayout();
            // 
            // cmbScope
            // 
            cmbScope.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbScope.FormattingEnabled = true;
            cmbScope.Items.AddRange(new object[] { "Borrow Entire Room", "Borrow ComLab PC", "Borrow Lab Equipment" });
            cmbScope.Location = new Point(64, 52);
            cmbScope.Name = "cmbScope";
            cmbScope.Size = new Size(216, 33);
            cmbScope.TabIndex = 0;
            // 
            // cmbItem
            // 
            cmbItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItem.FormattingEnabled = true;
            cmbItem.Items.AddRange(new object[] { "Borrow Entire Room", "Borrow ComLab PC", "Borrow Lab Equipment" });
            cmbItem.Location = new Point(64, 138);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(216, 33);
            cmbItem.TabIndex = 0;
            // 
            // BorrowModalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbItem);
            Controls.Add(cmbScope);
            Name = "BorrowModalForm";
            Text = "BorrowModalForm";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbScope;
        private ComboBox cmbItem;
    }
}