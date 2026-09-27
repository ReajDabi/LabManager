namespace ComLabManager.UI
{
    partial class CreateTicketForm
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
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(20, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 501);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(399, 415);
            button2.Name = "button2";
            button2.Size = new Size(111, 39);
            button2.TabIndex = 10;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GrayText;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(266, 415);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 9;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(299, 323);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 36);
            comboBox1.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(31, 324);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 34);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(31, 193);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(479, 61);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(31, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(479, 34);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(299, 292);
            label5.Name = "label5";
            label5.Size = new Size(149, 28);
            label5.TabIndex = 4;
            label5.Text = "Spare part used";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(31, 292);
            label4.Name = "label4";
            label4.Size = new Size(111, 28);
            label4.TabIndex = 3;
            label4.Text = "Repair Cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(27, 162);
            label3.Name = "label3";
            label3.Size = new Size(159, 28);
            label3.TabIndex = 2;
            label3.Text = "Issue Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(27, 85);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 1;
            label2.Text = "Equipment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(27, 26);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 0;
            label1.Text = "New Repair Ticket";
            // 
            // CreateTicketForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(582, 499);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(248, 249, 250);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateTicketForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateTicketForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
    }
}