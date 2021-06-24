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
    public partial class ReaderForm : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        private bool _editMode = false;
        public bool _addMode = false;
        bool isDefaultImage = true;
        AppDbContext db;
        int id = DataAccess.GetReaderId;

        public ReaderForm()
        {
            InitializeComponent();
            db = new AppDbContext();
          
            if (id != null & id != 0)
            {
                Reader reader = db.Readers.Find(id);
                txtFistName.Text = reader.FirstName;
                txtLastName.Text = reader.LastName;
                txtPatronimicName.Text = reader.Patronimic;
                dtpDateBirth.Value = reader.DateBith.Value;
                if (reader.Photo!=null) picCover.Image = new Bitmap(Application.StartupPath + "\\Images\\" + reader.Photo.ToString());
                txtAddress.Text = reader.Address;
                try
                {
                    txtNumberPhone.Text = reader.PhoneNumber.Value.ToString();
                }
                catch { }
                _editMode = true;
            }
            else { _addMode = true; }
        }


        private void btnPicOpen_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
               
                 picCover.Image = new Bitmap(ofd.FileName);
                isDefaultImage = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (_editMode)
            {
                try
                {
                    Reader reader = db.Readers.Find(id);
                    reader.FirstName = txtFistName.Text;
                    reader.LastName = txtLastName.Text;
                    reader.Patronimic = txtPatronimicName.Text;
                    reader.DateBith = dtpDateBirth.Value;
                    reader.Address = txtAddress.Text;
                    if (!isDefaultImage) { 
                         reader.Photo = SaveImage(ofd.FileName);
                    }
                    reader.PhoneNumber = Convert.ToInt32(txtNumberPhone.Text);
                    db.Entry(reader).State = EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show("Объект обновлен");
                }
                catch
                {
                    MessageBox.Show("Объект не обновлен");
                }
            }

            if (_addMode)
            {
                try
                {
                    Reader reader = new Reader();
                    reader.FirstName = txtFistName.Text;
                    reader.LastName = txtLastName.Text;
                    reader.Patronimic = txtPatronimicName.Text;
                    reader.DateBith = dtpDateBirth.Value;
                    reader.Address = txtAddress.Text;
                    if (!isDefaultImage)
                    {
                        reader.Photo = SaveImage(ofd.FileName);
                    }
                    reader.PhoneNumber = Convert.ToInt32(txtNumberPhone.Text);
                    DataAccess.AddReader(reader);
                    MessageBox.Show("Объект добавлен");
                }
                catch
                {
                    MessageBox.Show("Объект не сохранен!");
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            Reader reader = db.Readers.Find(id);
            db.Readers.Remove(reader);
            db.SaveChanges();

            MessageBox.Show("Удалено");
            this.Close();
            //
            //  DataAccess.DeleteReader(reader);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPicClear_Click(object sender, EventArgs e)
        {
            picCover.Image = null;
        }
    }
}
