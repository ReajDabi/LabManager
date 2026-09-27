using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class SparePartsView : UserControl
    {
        public SparePartsView()
        {
            InitializeComponent();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteSparePartForm deletesparepartform = new DeleteSparePartForm();
            deletesparepartform.ShowDialog();
        }

        private void buttonAddSparePart_Click(object sender, EventArgs e)
        {
            AddSparePartForm addsparepartform = new AddSparePartForm();
            addsparepartform.ShowDialog();
        }
    }
}
