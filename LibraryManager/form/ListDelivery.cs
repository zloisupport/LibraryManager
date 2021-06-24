using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManager.form
{
    public partial class ListDelivery : Form
    {
        AppDbContext db;
        public ListDelivery()
        {

            InitializeComponent();
            db = new AppDbContext();
            db.Deliveries.Load();
            dataGridView1.DataSource = db.Deliveries.ToList();

            //delivery.Reader.FirstName

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (AppDbContext db = new AppDbContext())
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    Delivery delivery = db.Deliveries.Find(id);
                    BookReturn bookReturn = new BookReturn();
                    db.Deliveries.Remove(delivery);
                    bookReturn.BookId = delivery.BookId;
                    bookReturn.ReaderId = delivery.ReaderId;
                    bookReturn.DateReturn = DateTime.Now;
                    db.BookReturns.Add(bookReturn);
                    db.SaveChanges();
                    // dataGridView1.DataSource = db.Deliveries.ToList();
                    dataGridView1.DataSource = DataAccess.GetDeliveries();
                
                }
          
            }


            //using (var ctx = new AppDbContext())
            //{
            //    if (txtSearch.Text != "")
            //    {
            //        dgvBook.DataSource = (
            //            from x in ctx.Books
            //            where x.Name.ToLower().Contains(this.txtSearch.Text.ToLower().Trim())
            //            select x).ToList<Book>();
            //    }
            //}
        }
    }
}
