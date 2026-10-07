using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComLabManager.UI.Views
{
    public partial class EquipmentInventoryView : UserControl
    {
        public EquipmentInventoryView()
        {
            InitializeComponent();
        }

        private void EquipmentInventoryView_Load(object sender, EventArgs e)
        {

        }

        private void dgvEquipment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvEquipment.Rows[e.RowIndex].Cells["Status"].Value != null)
            {
                string status = dgvEquipment.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                  DataGridViewRow row = dgvEquipment.Rows[e.RowIndex];

                if (status == "High Usage")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 205); // Soft Yellow/Orange alert
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(133, 100, 4);   // Dark Warning Text
                }
                else if (status == "Under Repair")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(248, 215, 218); // Soft Red alert
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(114, 28, 36);   // Dark Danger Text
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}
