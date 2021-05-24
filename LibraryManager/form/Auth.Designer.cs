namespace LibraryManager
{
    partial class Auth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.picWarning = new System.Windows.Forms.PictureBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.LBL_LOGIN = new System.Windows.Forms.Label();
            this.LBL_APPNAME = new System.Windows.Forms.Label();
            this.chboxShowPassword = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlLogin);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.LBL_LOGIN);
            this.panel1.Controls.Add(this.LBL_APPNAME);
            this.panel1.Controls.Add(this.chboxShowPassword);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.picUser);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 255);
            this.panel1.TabIndex = 0;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.picWarning);
            this.pnlLogin.Controls.Add(this.lblWarning);
            this.pnlLogin.Location = new System.Drawing.Point(85, 70);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(216, 23);
            this.pnlLogin.TabIndex = 9;
            // 
            // picWarning
            // 
            this.picWarning.Image = global::LibraryManager.Properties.Resources.warnin;
            this.picWarning.Location = new System.Drawing.Point(9, 0);
            this.picWarning.Name = "picWarning";
            this.picWarning.Size = new System.Drawing.Size(15, 15);
            this.picWarning.TabIndex = 1;
            this.picWarning.TabStop = false;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.IndianRed;
            this.lblWarning.Location = new System.Drawing.Point(30, 2);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(175, 13);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "Неправильный логин или пароль";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblUserName.Location = new System.Drawing.Point(115, 54);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 13);
            this.lblUserName.TabIndex = 8;
            // 
            // LBL_LOGIN
            // 
            this.LBL_LOGIN.AutoSize = true;
            this.LBL_LOGIN.Location = new System.Drawing.Point(17, 54);
            this.LBL_LOGIN.Name = "LBL_LOGIN";
            this.LBL_LOGIN.Size = new System.Drawing.Size(92, 13);
            this.LBL_LOGIN.TabIndex = 7;
            this.LBL_LOGIN.Text = "Войти в аккаунт:";
            // 
            // LBL_APPNAME
            // 
            this.LBL_APPNAME.AutoSize = true;
            this.LBL_APPNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_APPNAME.Location = new System.Drawing.Point(20, 18);
            this.LBL_APPNAME.Name = "LBL_APPNAME";
            this.LBL_APPNAME.Size = new System.Drawing.Size(131, 25);
            this.LBL_APPNAME.TabIndex = 6;
            this.LBL_APPNAME.Text = "Библиотека";
            // 
            // chboxShowPassword
            // 
            this.chboxShowPassword.AutoSize = true;
            this.chboxShowPassword.Location = new System.Drawing.Point(85, 171);
            this.chboxShowPassword.Name = "chboxShowPassword";
            this.chboxShowPassword.Size = new System.Drawing.Size(114, 17);
            this.chboxShowPassword.TabIndex = 5;
            this.chboxShowPassword.Text = "Показать пароль";
            this.chboxShowPassword.UseVisualStyleBackColor = true;
            this.chboxShowPassword.CheckedChanged += new System.EventHandler(this.chboxShowPassword_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(20, 211);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 31);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picUser
            // 
            this.picUser.Image = global::LibraryManager.Properties.Resources.user_500px;
            this.picUser.Location = new System.Drawing.Point(4, 85);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(75, 75);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 2;
            this.picUser.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(85, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(198, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(85, 99);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(198, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 278);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Auth";
            this.Text = "Авторизация";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Auth_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chboxShowPassword;
        private System.Windows.Forms.Label LBL_LOGIN;
        private System.Windows.Forms.Label LBL_APPNAME;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.PictureBox picWarning;
    }
}

