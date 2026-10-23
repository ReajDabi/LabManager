namespace ComLabManager.UI
{
    partial class AddSparePartForm
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
            label1 = new Label();
            button1 = new Button();
            txtName = new TextBox();
            label2 = new Label();
            button2 = new Button();
            txtCategory = new TextBox();
            label3 = new Label();
            numQuantity = new NumericUpDown();
            numRestock = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRestock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(309, 54);
            label1.TabIndex = 0;
            label1.Text = "Add Spare Part";
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(264, 501);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(135, 47);
            button1.TabIndex = 1;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Cursor = Cursors.Hand;
            txtName.Location = new Point(49, 165);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(322, 31);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(54, 133);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 28);
            label2.TabIndex = 3;
            label2.Text = "Equipment Name";
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.DialogResult = DialogResult.Cancel;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(31, 501);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(135, 47);
            button2.TabIndex = 6;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtCategory
            // 
            txtCategory.BorderStyle = BorderStyle.FixedSingle;
            txtCategory.Cursor = Cursors.Hand;
            txtCategory.Location = new Point(49, 252);
            txtCategory.Margin = new Padding(4);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(324, 31);
            txtCategory.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(53, 220);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 3;
            label3.Text = "Category";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(51, 350);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(124, 31);
            numQuantity.TabIndex = 7;
            // 
            // numRestock
            // 
            numRestock.Location = new Point(249, 350);
            numRestock.Name = "numRestock";
            numRestock.Size = new Size(124, 31);
            numRestock.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(55, 317);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(253, 317);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(128, 28);
            label5.TabIndex = 3;
            label5.Text = "Restock Level";
            // 
            // AddSparePartForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 585);
            Controls.Add(numRestock);
            Controls.Add(numQuantity);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCategory);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddSparePartForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddSparePartForm";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRestock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox txtName;
        private Label label2;
        private Button button2;
        private TextBox txtCategory;
        private Label label3;
        private NumericUpDown numQuantity;
        private NumericUpDown numRestock;
        private Label label4;
        private Label label5;
    }
}