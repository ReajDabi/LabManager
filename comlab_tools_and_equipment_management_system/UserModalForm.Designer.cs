namespace ComLabManager.UI
{
    partial class UserModalForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(370, 272);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(8, 8);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 113);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 1;
            label1.Text = "Add New User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 176);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 176);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 264);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 4;
            label4.Text = "System Role";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(65, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(337, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 27);
            textBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Technician", "Student" });
            comboBox1.Location = new Point(65, 287);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 28);
            comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.LimeGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(399, 353);
            button1.Name = "button1";
            button1.Size = new Size(144, 55);
            button1.TabIndex = 8;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Gray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(234, 353);
            button2.Name = "button2";
            button2.Size = new Size(144, 55);
            button2.TabIndex = 9;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // UserModalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 499);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "UserModalForm";
            Text = "UserModalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
    }
}