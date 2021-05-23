using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.pnlLogin.Visible = false;

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            warningMessage(false);
            lblUserName.Text = txtUserName.Text;
         
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
        }

        private void Auth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

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
    }
}
