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
    public partial class BookForm : Form
    {

        AppDbContext db;
        OpenFileDialog ofd = new OpenFileDialog();
        bool isDefaultImage = true;
        public BookForm()
        {
            InitializeComponent();
            db = new AppDbContext();
            picCover.Image = new Bitmap(Application.StartupPath + "\\Images\\default.jpg");
            isDefaultImage = true;
        }


        private void Save()
        {
            Book book = new Book();
            book.Name = txtName.Text;
            book.Author = txtAuthor.Text;
            book.Amount = Convert.ToInt32(txtAmount.Value);
            book.PublishDate = dtpPublishDate.Value;
            book.Description = txtDescription.Text;
            book.ISBN = txtISBN.Text;
            book.Publisher = txtPublisher.Text;
            book.Price = Convert.ToDecimal(txtPrice.Value);
            if (ofd.FileName != null)
            {
                book.Cover = SaveImage(ofd.FileName);
            }
            db.Books.Add(book);
            db.SaveChanges();
            this.Close();
        }
        private void btnSaveForm_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "")
            {
                Save();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
           
        }

        private void btnPicOpen_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(ofd.FileName.ToString());
                picCover.Image = new Bitmap(ofd.FileName);
                isDefaultImage = false;
            }
        }

        string SaveImage(string _imgPath)
        {

            string _fileName = Path.GetFileNameWithoutExtension(_imgPath);
            string _extension = Path.GetExtension(_imgPath);

            _fileName = _fileName.Length <= 100 ? _fileName : _fileName.Substring(0, 110);
            _fileName = _fileName + DateTime.Now.ToString("yymmssfff") + _extension;
            picCover.Image.Save(Application.StartupPath + "\\Images\\" + _fileName);
            return _fileName;
        }

        private void btnPicClear_Click(object sender, EventArgs e)
        {
               picCover.Image = new Bitmap(Application.StartupPath + "\\Images\\default.jpg");
               isDefaultImage = true;
        }
    }
}
