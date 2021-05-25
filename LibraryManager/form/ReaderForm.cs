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
    public partial class ReaderForm : Form
    {
        private bool _editMode = false;
        public bool _addMode = false;
        AppDbContext db;
        int id = DataAccess.GetReaderId;
        public ReaderForm()
        {
            InitializeComponent();
            db = new AppDbContext();
          
            if (id != null & id != 0)
            {
                MessageBox.Show(id.ToString());
                Reader reader = db.Readers.Find(id);
                txtFistName.Text = reader.FirstName;
                txtLastName.Text = reader.LastName;
                txtPatronimicName.Text = reader.Patronimic;
                dtpDateBirth.Value = reader.DateBith.Value;
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
                    reader.PhoneNumber = Convert.ToInt32(txtNumberPhone.Text);
                    DataAccess.UpdateReader(reader);
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
                    reader.PhoneNumber = Convert.ToInt32(txtNumberPhone.Text);
                    DataAccess.AddReader(reader);
                }
                catch
                {
                    MessageBox.Show("Объект не сохранен!");
                }
            }
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
    }
}
