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
            dgvSpareParts = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            minus = new DataGridViewButtonColumn();
            plus = new DataGridViewButtonColumn();
            restock = new DataGridViewTextBoxColumn();
            restockminus = new DataGridViewButtonColumn();
            restockplus = new DataGridViewButtonColumn();
            filterBanner = new ComLabManager.UI.Views.Controls.FilterBanner();
            buttonAddSparePart = new Button();
            buttonDelete = new Button();
            pnlActionBar = new Panel();
            btnRequestPart = new Button();
            pnlSpareHolder = new Panel();
            pnlHolder = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvSpareParts).BeginInit();
            pnlActionBar.SuspendLayout();
            pnlHolder.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSpareParts
            // 
            dgvSpareParts.AllowUserToAddRows = false;
            dgvSpareParts.AllowUserToDeleteRows = false;
            dgvSpareParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSpareParts.BackgroundColor = Color.FromArgb(248, 249, 250);
            dgvSpareParts.BorderStyle = BorderStyle.None;
            dgvSpareParts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSpareParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSpareParts.Columns.AddRange(new DataGridViewColumn[] { colName, category, colQuantity, minus, plus, restock, restockminus, restockplus });
            dgvSpareParts.Dock = DockStyle.Fill;
            dgvSpareParts.Location = new Point(10, 10);
            dgvSpareParts.Margin = new Padding(4);
            dgvSpareParts.Name = "dgvSpareParts";
            dgvSpareParts.RowHeadersVisible = false;
            dgvSpareParts.RowHeadersWidth = 51;
            dgvSpareParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSpareParts.Size = new Size(938, 448);
            dgvSpareParts.TabIndex = 0;
            dgvSpareParts.CellContentClick += dgvSpareParts_CellContentClick;
            dgvSpareParts.CellEndEdit += dgvSpareParts_CellEndEdit;
            dgvSpareParts.CellFormatting += dgvSpareParts_CellFormatting;
            dgvSpareParts.CurrentCellChanged += dgvSpareParts_CurrentCellDirtyStateChanged;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.FillWeight = 188.396683F;
            colName.HeaderText = "Spare Part Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            // 
            // category
            // 
            category.DataPropertyName = "Category";
            category.FillWeight = 153.706024F;
            category.HeaderText = "Category";
            category.MinimumWidth = 6;
            category.Name = "category";
            // 
            // colQuantity
            // 
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.FillWeight = 153.706024F;
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.Resizable = DataGridViewTriState.True;
            // 
            // minus
            // 
            minus.FillWeight = 23.34265F;
            minus.HeaderText = "";
            minus.MinimumWidth = 2;
            minus.Name = "minus";
            minus.Text = "-";
            minus.UseColumnTextForButtonValue = true;
            // 
            // plus
            // 
            plus.FillWeight = 22.7077866F;
            plus.HeaderText = "";
            plus.MinimumWidth = 2;
            plus.Name = "plus";
            plus.Text = "+";
            plus.UseColumnTextForButtonValue = true;
            // 
            // restock
            // 
            restock.DataPropertyName = "RestockLevel";
            restock.FillWeight = 153.706024F;
            restock.HeaderText = "Restock";
            restock.MinimumWidth = 6;
            restock.Name = "restock";
            // 
            // restockminus
            // 
            restockminus.FillWeight = 24.0641747F;
            restockminus.HeaderText = "";
            restockminus.MinimumWidth = 2;
            restockminus.Name = "restockminus";
            restockminus.Text = "-";
            restockminus.UseColumnTextForButtonValue = true;
            // 
            // restockplus
            // 
            restockplus.FillWeight = 26.6647167F;
            restockplus.HeaderText = "";
            restockplus.MinimumWidth = 2;
            restockplus.Name = "restockplus";
            restockplus.Text = "+";
            restockplus.UseColumnTextForButtonValue = true;
            // 
            // filterBanner
            // 
            filterBanner.BackColor = Color.FromArgb(255, 243, 205);
            filterBanner.Dock = DockStyle.Top;
            filterBanner.Location = new Point(0, 62);
            filterBanner.Name = "filterBanner";
            filterBanner.Size = new Size(958, 34);
            filterBanner.TabIndex = 1;
            filterBanner.Visible = false;
            // 
            // buttonAddSparePart
            // 
            buttonAddSparePart.Anchor = AnchorStyles.Right;
            buttonAddSparePart.BackColor = Color.Green;
            buttonAddSparePart.FlatAppearance.BorderSize = 0;
            buttonAddSparePart.FlatStyle = FlatStyle.Flat;
            buttonAddSparePart.ForeColor = Color.White;
            buttonAddSparePart.Location = new Point(770, 10);
            buttonAddSparePart.Margin = new Padding(4);
            buttonAddSparePart.Name = "buttonAddSparePart";
            buttonAddSparePart.Size = new Size(167, 42);
            buttonAddSparePart.TabIndex = 1;
            buttonAddSparePart.Text = "Add Spare Part";
            buttonAddSparePart.UseVisualStyleBackColor = false;
            buttonAddSparePart.Click += buttonAddSparePart_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Right;
            buttonDelete.BackColor = Color.Red;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(558, 10);
            buttonDelete.Margin = new Padding(4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(177, 42);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete Spare Part";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // pnlActionBar
            // 
            pnlActionBar.Controls.Add(buttonAddSparePart);
            pnlActionBar.Controls.Add(btnRequestPart);
            pnlActionBar.Controls.Add(buttonDelete);
            pnlActionBar.Dock = DockStyle.Top;
            pnlActionBar.Location = new Point(0, 0);
            pnlActionBar.Name = "pnlActionBar";
            pnlActionBar.Size = new Size(958, 62);
            pnlActionBar.TabIndex = 3;
            // 
            // btnRequestPart
            // 
            btnRequestPart.Anchor = AnchorStyles.Right;
            btnRequestPart.BackColor = Color.Navy;
            btnRequestPart.FlatAppearance.BorderSize = 0;
            btnRequestPart.FlatStyle = FlatStyle.Flat;
            btnRequestPart.ForeColor = Color.White;
            btnRequestPart.Location = new Point(770, 10);
            btnRequestPart.Margin = new Padding(4);
            btnRequestPart.Name = "btnRequestPart";
            btnRequestPart.Size = new Size(167, 42);
            btnRequestPart.TabIndex = 2;
            btnRequestPart.Text = "Request Part";
            btnRequestPart.UseVisualStyleBackColor = false;
            btnRequestPart.Click += btnRequestPart_Click;
            // 
            // pnlSpareHolder
            // 
            pnlSpareHolder.Dock = DockStyle.Fill;
            pnlSpareHolder.Location = new Point(0, 62);
            pnlSpareHolder.Name = "pnlSpareHolder";
            pnlSpareHolder.Padding = new Padding(10);
            pnlSpareHolder.Size = new Size(958, 502);
            pnlSpareHolder.TabIndex = 4;
            // 
            // pnlHolder
            // 
            pnlHolder.Controls.Add(dgvSpareParts);
            pnlHolder.Dock = DockStyle.Fill;
            pnlHolder.Location = new Point(0, 96);
            pnlHolder.Name = "pnlHolder";
            pnlHolder.Padding = new Padding(10);
            pnlHolder.Size = new Size(958, 468);
            pnlHolder.TabIndex = 3;
            // 
            // SparePartsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(pnlHolder);
            Controls.Add(filterBanner);
            Controls.Add(pnlActionBar);
            Cursor = Cursors.Hand;
            Margin = new Padding(4);
            Name = "SparePartsView";
            Size = new Size(958, 564);
            ((System.ComponentModel.ISupportInitialize)dgvSpareParts).EndInit();
            pnlActionBar.ResumeLayout(false);
            pnlHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSpareParts;
        private Views.Controls.FilterBanner filterBanner;
        private Button buttonAddSparePart;
        private Button buttonDelete;
        private Panel pnlActionBar;
        private Button btnRequestPart;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewButtonColumn minus;
        private DataGridViewButtonColumn plus;
        private DataGridViewTextBoxColumn restock;
        private DataGridViewButtonColumn restockminus;
        private DataGridViewButtonColumn restockplus;
        private Panel pnlSpareHolder;
        private Panel pnlHolder;
    }
}
