using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class Auth : Form
    {
        AppDbContext db;
        public Auth()
        {

            InitializeComponent();
            this.MaximizeBox = false;
            this.pnlLogin.Visible = false;
            db = new AppDbContext();
            db.Users.Load();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            warningMessage(false);
            lblUserName.Text = txtUserName.Text;

        }



        private void AuthLogic()
        {
            var userName = db.Users.Where(i => i.Name == this.txtUserName.Text).FirstOrDefault();
            if (userName == null)
            {
                warningMessage(true);
            }
            else if (txtUserName.Text == userName.Name || txtPassword.Text == userName.Password)
            {
                form.MainMenu menu = new form.MainMenu();
                this.Hide();
                menu.ShowDialog();
                this.Close(); 
            }
        }
        private void warningMessage(bool s)
        {
            _ = s == true ? pnlLogin.Visible = true : pnlLogin.Visible = false;



        }

        private void chboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == "")
            {
                warningMessage(true);
            }
            AuthLogic();
        }

        private void Auth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AuthLogic();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AuthLogic();
            }
        }
    }
}
