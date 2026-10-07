namespace ComLabManager.UI.Views
{
    partial class EquipmentInventoryView
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            btnAddEquipment = new Button();
            pnlFilters = new Panel();
            cmbCategoryFilter = new ComboBox();
            txtSearch = new TextBox();
            button1 = new Button();
            cmbStatusFilter = new ComboBox();
            pnlGridContainer = new Panel();
            dgvEquipment = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            AssetTag = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            UsageCount = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlFilters.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnAddEquipment);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(958, 80);
            pnlHeader.TabIndex = 0;
            // 
            // btnAddEquipment
            // 
            btnAddEquipment.Anchor = AnchorStyles.Right;
            btnAddEquipment.BackColor = Color.FromArgb(25, 135, 84);
            btnAddEquipment.FlatStyle = FlatStyle.Flat;
            btnAddEquipment.Location = new Point(760, 20);
            btnAddEquipment.Name = "btnAddEquipment";
            btnAddEquipment.Size = new Size(177, 43);
            btnAddEquipment.TabIndex = 0;
            btnAddEquipment.Text = "+ Add Equipment";
            btnAddEquipment.UseVisualStyleBackColor = false;
            // 
            // pnlFilters
            // 
            pnlFilters.Controls.Add(cmbStatusFilter);
            pnlFilters.Controls.Add(cmbCategoryFilter);
            pnlFilters.Controls.Add(txtSearch);
            pnlFilters.Controls.Add(button1);
            pnlFilters.Dock = DockStyle.Top;
            pnlFilters.Location = new Point(0, 80);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(958, 80);
            pnlFilters.TabIndex = 1;
            // 
            // cmbCategoryFilter
            // 
            cmbCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoryFilter.FormattingEnabled = true;
            cmbCategoryFilter.Items.AddRange(new object[] { "All Categories", "System Unit", "Monitor", "Peripheral", "Tool" });
            cmbCategoryFilter.Location = new Point(397, 18);
            cmbCategoryFilter.Name = "cmbCategoryFilter";
            cmbCategoryFilter.Size = new Size(148, 33);
            cmbCategoryFilter.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(46, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Asset Tag or Name";
            txtSearch.Size = new Size(272, 31);
            txtSearch.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(25, 135, 84);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1518, 10);
            button1.Name = "button1";
            button1.Size = new Size(177, 43);
            button1.TabIndex = 0;
            button1.Text = "+ Add Equipment";
            button1.UseVisualStyleBackColor = false;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "All Status", "Active", "High Usage", "Under Repair", "Decommissioned" });
            cmbStatusFilter.Location = new Point(602, 20);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(148, 33);
            cmbStatusFilter.TabIndex = 1;
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.Controls.Add(dgvEquipment);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(0, 160);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(20);
            pnlGridContainer.Size = new Size(958, 404);
            pnlGridContainer.TabIndex = 2;
            // 
            // dgvEquipment
            // 
            dgvEquipment.BackgroundColor = SystemColors.ButtonHighlight;
            dgvEquipment.BorderStyle = BorderStyle.None;
            dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipment.Columns.AddRange(new DataGridViewColumn[] { Id, AssetTag, Name, Category, Status, Location, UsageCount });
            dgvEquipment.Dock = DockStyle.Fill;
            dgvEquipment.Location = new Point(20, 20);
            dgvEquipment.Name = "dgvEquipment";
            dgvEquipment.RowHeadersVisible = false;
            dgvEquipment.RowHeadersWidth = 62;
            dgvEquipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipment.Size = new Size(918, 364);
            dgvEquipment.TabIndex = 0;
            dgvEquipment.CellFormatting += dgvEquipment_CellFormatting;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 150;
            // 
            // AssetTag
            // 
            AssetTag.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AssetTag.HeaderText = "AssetTag";
            AssetTag.MinimumWidth = 8;
            AssetTag.Name = "AssetTag";
            AssetTag.Width = 118;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Name.HeaderText = "Name";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.Width = 95;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Category.HeaderText = "Category";
            Category.MinimumWidth = 8;
            Category.Name = "Category";
            Category.Width = 120;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 96;
            // 
            // Location
            // 
            Location.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Location.HeaderText = "Location";
            Location.MinimumWidth = 8;
            Location.Name = "Location";
            Location.Width = 115;
            // 
            // UsageCount
            // 
            UsageCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UsageCount.DefaultCellStyle = dataGridViewCellStyle2;
            UsageCount.HeaderText = "Usage Count";
            UsageCount.MinimumWidth = 8;
            UsageCount.Name = "UsageCount";
            UsageCount.Width = 150;
            // 
            // EquipmentInventoryView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlFilters);
            Controls.Add(pnlHeader);
            Name = "EquipmentInventoryView";
            Size = new Size(958, 564);
            Load += EquipmentInventoryView_Load;
            pnlHeader.ResumeLayout(false);
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Button btnAddEquipment;
        private Panel pnlFilters;
        private ComboBox cmbCategoryFilter;
        private TextBox txtSearch;
        private Button button1;
        private ComboBox cmbStatusFilter;
        private Panel pnlGridContainer;
        private DataGridView dgvEquipment;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn AssetTag;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn UsageCount;
    }
}
