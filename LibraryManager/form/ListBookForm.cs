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
    public partial class ListBookForm : Form
    {
        
        public ListBookForm()
        {
            InitializeComponent();
            LoadBookList();

        }

        private void LoadBookList()
        {
            using(AppDbContext db = new AppDbContext()) {
            db.Books.Load();
            dgvBook.DataSource = db.Books.ToList();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvBook.SelectedRows.Count > 0)
            {
                using (AppDbContext db = new AppDbContext())
                {
                    int index = dgvBook.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dgvBook[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    DataAccess.GetBookId = id;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите удалить данную запись", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dgvBook.SelectedRows.Count > 0)
                {
                    using (AppDbContext db = new AppDbContext())
                    {
                        int index = dgvBook.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dgvBook[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;

                        Book book = db.Books.Find(id);
                        db.Books.Remove(book);
                        db.SaveChanges();

                        MessageBox.Show("Объект удален");
                        LoadBookList();
                    }
                }
            }
        }
    }
}
