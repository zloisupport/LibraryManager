using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Windows.Forms;

namespace LibraryManager.form
{

    public partial class UserForm : Form
    {
        AppDbContext db;
        public string name;
        int id = 1;
        public UserForm()
        {
            InitializeComponent();
            db = new AppDbContext();
            db.Users.Load();


            User user = db.Users.Find(id);
            if(user.Id ==0)
            {
                user.Name = "root";
                user.Password = "root";
                db.Users.Add(user);
                db.SaveChanges();
            }
            else
            {
                txtUserName.Text = user.Name;
                name = user.Name;
            }
           
        }


        private void chboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxShowPassword.Checked)
            {
                txtPasswordOne.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
                txtPasswordTwo.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else

            {
                txtPasswordTwo.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
                txtPasswordOne.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkCorrectPassword()
        {

        }

        private void Save()
        {
            User user = db.Users.Find(id);

            if (user.Id != id)
            {
                db.Users.Add(new User
                {
                    Name = txtUserName.Text,
                    Password = txtPasswordTwo.Text
                });
                db.SaveChanges();
            }
            else
            {
                user.Name = txtUserName.Text;
                user.Password = txtPasswordTwo.Text;
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Информация обновлена");
            }
        }


        public static bool IsStringEmpty(string myString)
        {
            if (myString == null)
                return true;
            myString = myString.Trim();
            return myString == String.Empty || myString.Length == 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


          
            var i1 = IsStringEmpty(txtPasswordOne.Text);
            var i2 = IsStringEmpty(txtPasswordTwo.Text);
            if (i1 || i2 == true)
            {
                pnlLogin.Visible = true;
            }
            else
            {
                Save();
            }
           
        }
    }
}
