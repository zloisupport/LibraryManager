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
    { AppDbContext db;
        public ListDelivery()
        {
          
            InitializeComponent();
            db = new AppDbContext();
            db.Deliveries.Load();
            dataGridView1.DataSource = db.Deliveries.ToList();
            Delivery delivery = new Delivery();
            //delivery.Reader.FirstName

        }
    }
}
