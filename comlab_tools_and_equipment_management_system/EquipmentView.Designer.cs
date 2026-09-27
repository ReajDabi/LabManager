namespace ComLabManager.UI
{
    partial class EquipmentView
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
            dgvEquipment = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            SerialNumber = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            DateAcquired = new DataGridViewTextBoxColumn();
            pnlActionToolbar = new Panel();
            btnAddEquipment = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).BeginInit();
            pnlActionToolbar.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEquipment
            // 
            dgvEquipment.AllowUserToAddRows = false;
            dgvEquipment.AllowUserToDeleteRows = false;
            dgvEquipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipment.BackgroundColor = Color.FromArgb(248, 249, 250);
            dgvEquipment.BorderStyle = BorderStyle.None;
            dgvEquipment.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipment.Columns.AddRange(new DataGridViewColumn[] { Id, colName, SerialNumber, Category, Status, Location, DateAcquired });
            dgvEquipment.Dock = DockStyle.Fill;
            dgvEquipment.Location = new Point(0, 60);
            dgvEquipment.Name = "dgvEquipment";
            dgvEquipment.ReadOnly = true;
            dgvEquipment.RowHeadersVisible = false;
            dgvEquipment.RowHeadersWidth = 62;
            dgvEquipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipment.Size = new Size(958, 504);
            dgvEquipment.TabIndex = 3;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // colName
            // 
            colName.HeaderText = "Equipment Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // SerialNumber
            // 
            SerialNumber.HeaderText = "Serial Number";
            SerialNumber.MinimumWidth = 8;
            SerialNumber.Name = "SerialNumber";
            SerialNumber.ReadOnly = true;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 8;
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Location
            // 
            Location.HeaderText = "Location";
            Location.MinimumWidth = 8;
            Location.Name = "Location";
            Location.ReadOnly = true;
            // 
            // DateAcquired
            // 
            DateAcquired.HeaderText = "Date Acquired";
            DateAcquired.MinimumWidth = 8;
            DateAcquired.Name = "DateAcquired";
            DateAcquired.ReadOnly = true;
            // 
            // pnlActionToolbar
            // 
            pnlActionToolbar.Controls.Add(btnAddEquipment);
            pnlActionToolbar.Controls.Add(btnSearch);
            pnlActionToolbar.Controls.Add(txtSearch);
            pnlActionToolbar.Dock = DockStyle.Top;
            pnlActionToolbar.Location = new Point(0, 0);
            pnlActionToolbar.Name = "pnlActionToolbar";
            pnlActionToolbar.Size = new Size(958, 60);
            pnlActionToolbar.TabIndex = 2;
            // 
            // btnAddEquipment
            // 
            btnAddEquipment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddEquipment.BackColor = Color.FromArgb(25, 135, 84);
            btnAddEquipment.FlatAppearance.BorderSize = 0;
            btnAddEquipment.FlatStyle = FlatStyle.Flat;
            btnAddEquipment.ForeColor = Color.White;
            btnAddEquipment.Location = new Point(736, 15);
            btnAddEquipment.Name = "btnAddEquipment";
            btnAddEquipment.Size = new Size(197, 34);
            btnAddEquipment.TabIndex = 3;
            btnAddEquipment.Text = "+ Add Equipment";
            btnAddEquipment.UseVisualStyleBackColor = false;
            btnAddEquipment.Click += btnAddEquipment_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(30, 41, 59);
            btnSearch.FlatAppearance.BorderColor = Color.White;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 23, 42);
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 65, 85);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(328, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(9, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 34);
            txtSearch.TabIndex = 0;
            // 
            // EquipmentView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(dgvEquipment);
            Controls.Add(pnlActionToolbar);
            Name = "EquipmentView";
            Size = new Size(958, 564);
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).EndInit();
            pnlActionToolbar.ResumeLayout(false);
            pnlActionToolbar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEquipment;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn SerialNumber;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn DateAcquired;
        private Panel pnlActionToolbar;
        private Button btnAddEquipment;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}
