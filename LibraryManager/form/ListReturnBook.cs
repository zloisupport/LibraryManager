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
    public partial class ListReturnBook : Form
    {

        AppDbContext db;
        public ListReturnBook()
        {

            InitializeComponent();
            db = new AppDbContext();
            dataGridView1.DataSource = db.BookReturns.ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
