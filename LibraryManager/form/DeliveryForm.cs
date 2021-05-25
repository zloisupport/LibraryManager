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
    public partial class DeliveryForm : Form
    {
        public DeliveryForm()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using(AppDbContext db =new AppDbContext())
            {
                Delivery delivery = new Delivery();
                delivery.BookId = DataAccess.GetBookId;
                delivery.ReaderId = DataAccess.GetReaderId;
                delivery.DateIssue = dateTimePicker1.Value;
                delivery.DateReturn = dateTimePicker2.Value;
                db.Deliveries.Add(delivery);
                db.SaveChanges();
            }
        }
    }
}
