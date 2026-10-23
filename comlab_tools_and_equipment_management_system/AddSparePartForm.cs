using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using System;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class AddSparePartForm : Form
    {
        private readonly IMaintenanceRepository _maintenanceRepo;

        public AddSparePartForm(IMaintenanceRepository maintenanceRepo)
        {
            InitializeComponent();
            _maintenanceRepo = maintenanceRepo ?? throw new ArgumentNullException(nameof(maintenanceRepo));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Name and Category are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newPart = new SparePart
            {
                Name = txtName.Text.Trim(),
                Category = txtCategory.Text.Trim(),
                Quantity = (int)numQuantity.Value,
                RestockLevel = (int)numRestock.Value
            };

            _maintenanceRepo.AddSparePart(newPart);
            MessageBox.Show("Spare part added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}