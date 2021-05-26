using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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

        private bool _editMode = false;
        public bool _addMode = false;
        int id = DataAccess.GetBookId;
        public BookForm()
        {
            InitializeComponent();
            db = new AppDbContext();
            picCover.Image = new Bitmap(Application.StartupPath + "\\Images\\default.jpg");
            isDefaultImage = true;
            logic();
        }



        private void logic()
        {
            if (id != null & id != 0)
            {
                //MessageBox.Show(id.ToString());
                //Reader reader = db.Readers.Find(id);
                //txtFistName.Text = reader.FirstName;
                //txtLastName.Text = reader.LastName;
                //txtPatronimicName.Text = reader.Patronimic;
                //dtpDateBirth.Value = reader.DateBith.Value;
                //txtAddress.Text = reader.Address;

                Book book = db.Books.Find(id);
                txtName.Text = book.Name;
                txtAuthor.Text = book.Author;
                txtPublisher.Text = book.ISBN;
                dtpPublishDate.Value = book.PublishDate.Value;
                txtPublisher.Text = book.Publisher;
                txtDescription.Text = book.Description;
                txtPrice.Value = book.Price.Value;
                txtAmount.Value = book.Amount.Value;
                if(book.Cover != null) { 
                    picCover.Image = new Bitmap(Application.StartupPath + "\\Images\\" + book.Cover.ToString());
                }
                else
                {
                    picCover.Image = new Bitmap(Application.StartupPath + "\\Images\\default.jpg");
                }
                _editMode = true;
            }
            else
            {
                _addMode = true;
            }
        }

        private void Save()
        {
            if (_editMode)
            {
               
                Book book = db.Books.Find(id);
                book.Name = txtName.Text;
                book.Author = txtAuthor.Text;
                book.Amount = Convert.ToInt32(txtAmount.Value);
                book.PublishDate = dtpPublishDate.Value;
                book.Description = txtDescription.Text;
                book.ISBN = txtISBN.Text;
                book.Publisher = txtPublisher.Text;
                book.Price = Convert.ToDecimal(txtPrice.Value);
                if (!isDefaultImage)
                {
                    book.Cover = SaveImage(ofd.FileName);
                }
  
                try { 
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка сохранения!");
                }
             
            }
            if (_addMode)
            {
                try
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
                catch
                {
                    MessageBox.Show("Объект не сохранен!");
                }
            }
        }

        private void btnSaveForm_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
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

        private void BookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataAccess.GetBookId = 0;
        }
    }
}
