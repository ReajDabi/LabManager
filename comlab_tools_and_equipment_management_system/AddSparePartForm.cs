using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class AddSparePartForm : Form
    {
        private readonly ISparePartRepository _sparePartRepo;

        public AddSparePartForm(ISparePartRepository sparePartRepo)
        {
            InitializeComponent();
            _sparePartRepo = sparePartRepo ?? throw new ArgumentNullException(nameof(sparePartRepo));
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

            try
            {
                _sparePartRepo.AddSparePart(newPart);
                MessageBox.Show("Spare part added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show($"A spare part named '{newPart.Name}' already exists.", "Duplicate Spare Part", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the spare part: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}