using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManager.form
{
    public partial class ListReaderForm : Form
    {
        public ListReaderForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DeliveryForm deliveryForm = new DeliveryForm();
            deliveryForm.ShowDialog();
        }
    }
}
