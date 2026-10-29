namespace ComLabManager.UI
{
    partial class ScheduleTaskForm
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
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            comboBoxFrequency = new ComboBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBoxLocation = new ComboBox();
            label7 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            //
            // groupBox1
            //
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBoxFrequency);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBoxLocation);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Cursor = Cursors.Hand;
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(679, 525);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            //
            // button2
            //
            button2.BackColor = Color.Gray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(37, 450);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(138, 40);
            button2.TabIndex = 9;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            //
            // button1
            //
            button1.BackColor = Color.LimeGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(489, 450);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(146, 40);
            button1.TabIndex = 8;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            //
            // comboBox1
            //
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(401, 299);
            comboBox1.Margin = new Padding(4, 4, 4, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(234, 33);
            comboBox1.TabIndex = 6;
            //
            // label6
            //
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(398, 266);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 28);
            label6.TabIndex = 10;
            label6.Text = "Assign To";
            //
            // dateTimePicker1
            //
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(37, 385);
            dateTimePicker1.Margin = new Padding(4, 4, 4, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(312, 31);
            dateTimePicker1.TabIndex = 7;
            //
            // label5
            //
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(33, 352);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(141, 28);
            label5.TabIndex = 11;
            label5.Text = "Next Due Date";
            //
            // comboBoxFrequency
            //
            comboBoxFrequency.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFrequency.FormattingEnabled = true;
            comboBoxFrequency.Location = new Point(37, 299);
            comboBoxFrequency.Margin = new Padding(4, 4, 4, 4);
            comboBoxFrequency.Name = "comboBoxFrequency";
            comboBoxFrequency.Size = new Size(312, 33);
            comboBoxFrequency.TabIndex = 5;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(34, 266);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 12;
            label4.Text = "Frequency";
            //
            // textBox2
            //
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(401, 213);
            textBox2.Margin = new Padding(4, 4, 4, 4);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Asset tag (optional)";
            textBox2.Size = new Size(234, 31);
            textBox2.TabIndex = 4;
            textBox2.Leave += textBox2_Leave;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(398, 180);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 13;
            label3.Text = "Equipment";
            //
            // comboBoxLocation
            //
            comboBoxLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLocation.FormattingEnabled = true;
            comboBoxLocation.Location = new Point(37, 213);
            comboBoxLocation.Margin = new Padding(4, 4, 4, 4);
            comboBoxLocation.Name = "comboBoxLocation";
            comboBoxLocation.Size = new Size(312, 33);
            comboBoxLocation.TabIndex = 3;
            //
            // label7
            //
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(33, 180);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 14;
            label7.Text = "Location";
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(32, 94);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 28);
            label2.TabIndex = 15;
            label2.Text = "Task";
            //
            // textBox1
            //
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(37, 127);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.MaxLength = 100;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(598, 31);
            textBox1.TabIndex = 2;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 1;
            label1.Text = "Schedule Task";
            //
            // ScheduleTaskForm
            //
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 555);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ScheduleTaskForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Schedule Task";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ComboBox comboBoxFrequency;
        private Label label4;
        private TextBox textBox2;
        private Button button2;
        private ComboBox comboBoxLocation;
        private Label label7;
    }
}
