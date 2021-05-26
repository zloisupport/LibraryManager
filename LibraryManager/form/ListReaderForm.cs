using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            if (DataAccess.GetBookId != 0)
            {
                deliverMode = true;
                btnSelect.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelivery.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {



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

        private void ListReaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите удалить данную запись", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (AppDbContext db = new AppDbContext())
                {
                    try
                    {
                        int index = dgvReader.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dgvReader[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;

                        Reader reader = db.Readers.Find(id);
                        db.Readers.Remove(reader);
                        //  new Bitmap(Application.StartupPath + "\\Images\\" + reader.Photo.ToString());
                        if (reader.Photo != null)
                        {
                            if (File.Exists(Application.StartupPath + "\\Images\\" + reader.Photo.ToString()))
                            {
                                File.Delete(Application.StartupPath + "\\Images\\" + reader.Photo.ToString());
                            }
                        }

                        db.SaveChanges();
                        dgvReader.DataSource = DataAccess.GetReaders();
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {

            if (deliverMode)
            {
                int index = dgvReader.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dgvReader[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                DataAccess.GetReaderId = id;
                DeliveryForm deliveryForm = new DeliveryForm();
                deliveryForm.ShowDialog();
                btnSelect.Enabled = false;
            }
        }

        private void ListReaderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataAccess.GetReaderId = 0;
            DataAccess.GetBookId = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (var ctx = new AppDbContext())
            {
                if (txtSearch.Text != "")
                {
                    dgvReader.DataSource = (
                        from x in ctx.Readers
                        where x.FirstName.ToLower().Contains(this.txtSearch.Text.ToLower().Trim())
                        select x).ToList<Reader>();
                }
                else
                {
                    dgvReader.DataSource = DataAccess.GetBooks();
                }
            }
        }
    }
}
