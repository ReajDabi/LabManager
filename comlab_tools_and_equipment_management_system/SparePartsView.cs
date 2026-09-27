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
    }
}
