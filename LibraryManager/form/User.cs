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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
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
        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
