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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
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
            ListReaderForm listReaderForm = new ListReaderForm();
            listReaderForm.ShowDialog();

        }
    }
}
