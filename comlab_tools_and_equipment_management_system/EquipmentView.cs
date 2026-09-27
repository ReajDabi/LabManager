using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class EquipmentView : UserControl
    {
        public EquipmentView()
        {
            InitializeComponent();
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            using (EquipmentForm form = new EquipmentForm())
            {
                form.ShowDialog();
            }
        }
    }
}
