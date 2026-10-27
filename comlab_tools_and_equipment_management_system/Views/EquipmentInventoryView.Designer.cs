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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            btnDeleteEquipment = new Button();
            btnEditEquipment = new Button();
            btnAddEquipment = new Button();
            pnlFilters = new Panel();
            cmbStatusFilter = new ComboBox();
            cmbCategoryFilter = new ComboBox();
            txtSearch = new TextBox();
            pnlGridContainer = new Panel();
            dgvEquipment = new DataGridView();
            filterBanner = new Controls.FilterBanner();
            Id = new DataGridViewTextBoxColumn();
            AssetTag = new DataGridViewTextBoxColumn();
            EquipmentName = new DataGridViewTextBoxColumn();
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
            pnlHeader.Controls.Add(btnDeleteEquipment);
            pnlHeader.Controls.Add(btnEditEquipment);
            pnlHeader.Controls.Add(btnAddEquipment);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(958, 80);
            pnlHeader.TabIndex = 0;
            // 
            // btnDeleteEquipment
            // 
            btnDeleteEquipment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteEquipment.BackColor = Color.FromArgb(220, 53, 69);
            btnDeleteEquipment.FlatStyle = FlatStyle.Flat;
            btnDeleteEquipment.ForeColor = SystemColors.ButtonHighlight;
            btnDeleteEquipment.Location = new Point(452, 20);
            btnDeleteEquipment.Name = "btnDeleteEquipment";
            btnDeleteEquipment.Size = new Size(104, 43);
            btnDeleteEquipment.TabIndex = 0;
            btnDeleteEquipment.Text = "Delete";
            btnDeleteEquipment.UseVisualStyleBackColor = false;
            btnDeleteEquipment.Click += btnDeleteEquipment_Click;
            // 
            // btnEditEquipment
            // 
            btnEditEquipment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditEquipment.BackColor = Color.FromArgb(13, 110, 253);
            btnEditEquipment.FlatStyle = FlatStyle.Flat;
            btnEditEquipment.ForeColor = SystemColors.ButtonHighlight;
            btnEditEquipment.Location = new Point(599, 20);
            btnEditEquipment.Name = "btnEditEquipment";
            btnEditEquipment.Size = new Size(118, 43);
            btnEditEquipment.TabIndex = 0;
            btnEditEquipment.Text = "Edit";
            btnEditEquipment.UseVisualStyleBackColor = false;
            btnEditEquipment.Click += btnEditEquipment_Click;
            // 
            // btnAddEquipment
            // 
            btnAddEquipment.Anchor = AnchorStyles.Right;
            btnAddEquipment.BackColor = Color.FromArgb(25, 135, 84);
            btnAddEquipment.FlatStyle = FlatStyle.Flat;
            btnAddEquipment.ForeColor = SystemColors.ButtonHighlight;
            btnAddEquipment.Location = new Point(760, 20);
            btnAddEquipment.Name = "btnAddEquipment";
            btnAddEquipment.Size = new Size(177, 43);
            btnAddEquipment.TabIndex = 0;
            btnAddEquipment.Text = "+ Add Equipment";
            btnAddEquipment.UseVisualStyleBackColor = false;
            btnAddEquipment.Click += btnAddEquipment_Click;
            // 
            // pnlFilters
            // 
            pnlFilters.BackColor = Color.FromArgb(224, 224, 224);
            pnlFilters.Controls.Add(cmbStatusFilter);
            pnlFilters.Controls.Add(cmbCategoryFilter);
            pnlFilters.Controls.Add(txtSearch);
            pnlFilters.Dock = DockStyle.Top;
            pnlFilters.Location = new Point(0, 80);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(958, 80);
            pnlFilters.TabIndex = 1;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "All Statuses", "Available", "Active", "In Use", "Under Repair", "Decommissioned" });
            cmbStatusFilter.Location = new Point(565, 18);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(148, 33);
            cmbStatusFilter.TabIndex = 1;
            cmbStatusFilter.SelectedIndexChanged += cmbStatusFilter_SelectedIndexChanged;
            // 
            // cmbCategoryFilter
            // 
            cmbCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoryFilter.FormattingEnabled = true;
            cmbCategoryFilter.Items.AddRange(new object[] { "All Categories", "System Unit", "Monitor", "Peripheral", "Tool" });
            cmbCategoryFilter.Location = new Point(343, 20);
            cmbCategoryFilter.Name = "cmbCategoryFilter";
            cmbCategoryFilter.Size = new Size(148, 33);
            cmbCategoryFilter.TabIndex = 1;
            cmbCategoryFilter.SelectedIndexChanged += cmbCategoryFilter_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(20, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Asset Tag or Name";
            txtSearch.Size = new Size(272, 31);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.Controls.Add(dgvEquipment);
            pnlGridContainer.Controls.Add(filterBanner);
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
            dgvEquipment.Columns.AddRange(new DataGridViewColumn[] { Id, AssetTag, EquipmentName, Category, Status, Location, UsageCount });
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
            AssetTag.DataPropertyName = "AssetTag";
            AssetTag.HeaderText = "AssetTag";
            AssetTag.MinimumWidth = 8;
            AssetTag.Name = "AssetTag";
            AssetTag.Width = 118;
            // 
            // EquipmentName
            // 
            EquipmentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EquipmentName.DataPropertyName = "Name";
            EquipmentName.HeaderText = "Name";
            EquipmentName.MinimumWidth = 8;
            EquipmentName.Name = "EquipmentName";
            EquipmentName.Width = 95;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Category";
            Category.MinimumWidth = 8;
            Category.Name = "Category";
            Category.Width = 120;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 96;
            // 
            // Location
            // 
            Location.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Location.DataPropertyName = "StationNumber";
            Location.HeaderText = "Location";
            Location.MinimumWidth = 8;
            Location.Name = "Location";
            Location.Width = 115;
            // 
            // UsageCount
            // 
            UsageCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            UsageCount.DataPropertyName = "UsageCount";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UsageCount.DefaultCellStyle = dataGridViewCellStyle1;
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
        private ComboBox cmbStatusFilter;
        private Panel pnlGridContainer;
        private DataGridView dgvEquipment;
        private Controls.FilterBanner filterBanner;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn AssetTag;
        private DataGridViewTextBoxColumn EquipmentName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn UsageCount;
        private Button btnDeleteEquipment;
        private Button btnEditEquipment;
    }
}
