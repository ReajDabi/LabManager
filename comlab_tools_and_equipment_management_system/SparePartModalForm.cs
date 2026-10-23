using ComLabManager.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class SparePartModalForm : Form
    {
        private readonly int _techId;
        public SparePartRequest ProcessedRequest { get; private set; }
        public SparePartModalForm(int techId, IEnumerable<SparePart> availableParts)
        {
            InitializeComponent();
            _techId = techId;

            
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            PopulatePartsDropdown(availableParts);
        }
        private void PopulatePartsDropdown(IEnumerable<SparePart> parts)
        {
            cmbSparePart.DataSource = parts.ToList();

            cmbSparePart.DisplayMember = "Name";
            cmbSparePart.ValueMember = "Id";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbSparePart.SelectedValue == null || string.IsNullOrWhiteSpace(txtReason.Text) || numQuantity.Value <= 0)
            {
                MessageBox.Show("Please select a part, enter a valid quantity, and provide a reason.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            ProcessedRequest = new SparePartRequest
            {
                TechId = _techId,
                RequestPartId = (int)cmbSparePart.SelectedValue,
                Quantity = (int)numQuantity.Value,
                Reason = txtReason.Text,
                Status = "Pending",
                RequestDate = DateTime.Now
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
