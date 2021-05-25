using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManager.form
{
    public partial class MainMenu : Form
    {
        AppDbContext db;
      
        public MainMenu()
        {
          
            InitializeComponent();
            db = new AppDbContext();
            try
            {

          
            dgvBook.DataSource=DataAccess.GetBooks();
            }
            catch
            {

            }
        }


      

        private void tsmAddBook_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.ShowDialog();

        }

        private void tsmReader_Click(object sender, EventArgs e)
        {
            ReaderForm readerForm = new ReaderForm();
            readerForm.ShowDialog();
        }

        private void tsmUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
        }



        private void tsmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmListBook_Click(object sender, EventArgs e)
        {
            ListReaderForm listReaderForm = new ListReaderForm();
            listReaderForm.ShowDialog();
        }

        private void tsmListBook_Click_1(object sender, EventArgs e)
        {
            ListBookForm listBookForm = new ListBookForm();
            listBookForm.ShowDialog();
        }

        private void tsmBookDelivery_Click(object sender, EventArgs e)
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
          
            ListReaderForm listReaderForm = new ListReaderForm();
            listReaderForm.ShowDialog();

        }

        private void tsmHelp_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("UserGuide.chm");
                psi.UseShellExecute = true;
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при открытии файла!\n Код ошибки: 37", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void MainMenu_Activated(object sender, EventArgs e)
        {
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (var ctx = new AppDbContext())
            {
                if (txtSearch.Text != "") { 
                dgvBook.DataSource = (
                    from x in ctx.Books
                    where x.Name.ToLower().Contains(this.txtSearch.Text.ToLower().Trim())
                    select x).ToList<Book>();
                }
                else
                {
                    dgvBook.DataSource = DataAccess.GetBooks();
                }
            }
        }

        private void tsmDeliveryList_Click(object sender, EventArgs e)
        {
            ListDelivery listDelivery = new ListDelivery();
            listDelivery.ShowDialog();
        }
    }
}
