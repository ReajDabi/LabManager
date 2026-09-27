namespace ComLabManager.UI
{
    partial class SparePartsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            euipmentname = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            minus = new DataGridViewButtonColumn();
            plus = new DataGridViewButtonColumn();
            restock = new DataGridViewTextBoxColumn();
            restockminus = new DataGridViewButtonColumn();
            restockplus = new DataGridViewButtonColumn();
            unitprice = new DataGridViewTextBoxColumn();
            buttonAddSparePart = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(248, 249, 250);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { euipmentname, category, quantity, minus, plus, restock, restockminus, restockplus, unitprice });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(958, 474);
            dataGridView1.TabIndex = 0;
            // 
            // euipmentname
            // 
            euipmentname.FillWeight = 188.396683F;
            euipmentname.HeaderText = "Equipment Name";
            euipmentname.MinimumWidth = 6;
            euipmentname.Name = "euipmentname";
            euipmentname.ReadOnly = true;
            // 
            // category
            // 
            category.FillWeight = 153.706024F;
            category.HeaderText = "Category";
            category.MinimumWidth = 6;
            category.Name = "category";
            category.ReadOnly = true;
            // 
            // quantity
            // 
            quantity.FillWeight = 153.706024F;
            quantity.HeaderText = "Quantity";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            quantity.Resizable = DataGridViewTriState.True;
            // 
            // minus
            // 
            minus.FillWeight = 23.34265F;
            minus.HeaderText = "";
            minus.MinimumWidth = 2;
            minus.Name = "minus";
            minus.ReadOnly = true;
            minus.Text = "-";
            minus.UseColumnTextForButtonValue = true;
            // 
            // plus
            // 
            plus.FillWeight = 22.7077866F;
            plus.HeaderText = "";
            plus.MinimumWidth = 2;
            plus.Name = "plus";
            plus.ReadOnly = true;
            plus.Text = "+";
            plus.UseColumnTextForButtonValue = true;
            // 
            // restock
            // 
            restock.FillWeight = 153.706024F;
            restock.HeaderText = "Restock";
            restock.MinimumWidth = 6;
            restock.Name = "restock";
            restock.ReadOnly = true;
            // 
            // restockminus
            // 
            restockminus.FillWeight = 24.0641747F;
            restockminus.HeaderText = "";
            restockminus.MinimumWidth = 2;
            restockminus.Name = "restockminus";
            restockminus.ReadOnly = true;
            restockminus.Text = "-";
            restockminus.UseColumnTextForButtonValue = true;
            // 
            // restockplus
            // 
            restockplus.FillWeight = 26.6647167F;
            restockplus.HeaderText = "";
            restockplus.MinimumWidth = 2;
            restockplus.Name = "restockplus";
            restockplus.ReadOnly = true;
            restockplus.Text = "+";
            restockplus.UseColumnTextForButtonValue = true;
            // 
            // unitprice
            // 
            unitprice.FillWeight = 153.706024F;
            unitprice.HeaderText = "Unit Price";
            unitprice.MinimumWidth = 6;
            unitprice.Name = "unitprice";
            unitprice.ReadOnly = true;
            // 
            // buttonAddSparePart
            // 
            buttonAddSparePart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAddSparePart.BackColor = Color.Navy;
            buttonAddSparePart.FlatAppearance.BorderSize = 0;
            buttonAddSparePart.FlatStyle = FlatStyle.Flat;
            buttonAddSparePart.ForeColor = Color.White;
            buttonAddSparePart.Location = new Point(741, 480);
            buttonAddSparePart.Name = "buttonAddSparePart";
            buttonAddSparePart.Size = new Size(193, 62);
            buttonAddSparePart.TabIndex = 1;
            buttonAddSparePart.Text = "Add Spare Part";
            buttonAddSparePart.UseVisualStyleBackColor = false;
            buttonAddSparePart.Click += buttonAddSparePart_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelete.BackColor = Color.Red;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(527, 480);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(193, 62);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete Spare Part";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // SparePartsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAddSparePart);
            Controls.Add(dataGridView1);
            Cursor = Cursors.Hand;
            Name = "SparePartsView";
            Size = new Size(958, 564);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn euipmentname;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewButtonColumn minus;
        private DataGridViewButtonColumn plus;
        private DataGridViewTextBoxColumn restock;
        private DataGridViewButtonColumn restockminus;
        private DataGridViewButtonColumn restockplus;
        private DataGridViewTextBoxColumn unitprice;
        private Button buttonAddSparePart;
        private Button buttonDelete;
    }
}
