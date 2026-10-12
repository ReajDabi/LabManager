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
            btnAddEquipment = new Button();
            pnlFilters = new Panel();
            cmbStatusFilter = new ComboBox();
            cmbCategoryFilter = new ComboBox();
            txtSearch = new TextBox();
            pnlGridContainer = new Panel();
            dgvEquipment = new DataGridView();
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
            cmbStatusFilter.Items.AddRange(new object[] { "All Status", "Active", "High Usage", "Under Repair", "Decommissioned" });
            cmbStatusFilter.Location = new Point(565, 18);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(148, 33);
            cmbStatusFilter.TabIndex = 1;
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
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(20, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Asset Tag or Name";
            txtSearch.Size = new Size(272, 31);
            txtSearch.TabIndex = 1;
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
            AssetTag.HeaderText = "AssetTag";
            AssetTag.MinimumWidth = 8;
            AssetTag.Name = "AssetTag";
            AssetTag.Width = 118;
            // 
            // EquipmentName
            // 
            EquipmentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EquipmentName.HeaderText = "Name";
            EquipmentName.MinimumWidth = 8;
            EquipmentName.Name = "EquipmentName";
            EquipmentName.Width = 95;
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn AssetTag;
        private DataGridViewTextBoxColumn EquipmentName;
       
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn UsageCount;
    }
}
