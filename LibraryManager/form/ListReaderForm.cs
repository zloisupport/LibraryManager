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
        private bool deliverMode = false;
        public ListReaderForm()
        {
           
            InitializeComponent();
            dgvReader.DataSource = DataAccess.GetReaders();

            if (DataAccess.GetBookId != null)
            {
                btnSelect.Text = "Выдать";
                deliverMode = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {


            if (!deliverMode) { 
            //DeliveryForm deliveryForm = new DeliveryForm();
            //deliveryForm.ShowDialog();
            if (dgvReader.SelectedRows.Count > 0)
            {
                using (AppDbContext db = new AppDbContext())
                {
                    int index = dgvReader.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dgvReader[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    DataAccess.GetReaderId = id;
                }
            }

            ReaderForm readerForm = new ReaderForm();
            readerForm.ShowDialog();
            }
            else
            {
                int index = dgvReader.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dgvReader[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                DataAccess.GetReaderId = id;
                DeliveryForm deliveryForm = new DeliveryForm();
                deliveryForm.ShowDialog();
            }



        }

        private void ListReaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataAccess.GetReaderId = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (AppDbContext db = new AppDbContext())
            {
                int index = dgvReader.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dgvReader[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Reader reader = db.Readers.Find(id);
                db.Readers.Remove(reader);
                db.SaveChanges();
                dgvReader.DataSource = DataAccess.GetReaders();
            }
        }
    }
}
