namespace LibraryManager.form
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chboxShowPassword = new System.Windows.Forms.CheckBox();
            this.txtPasswordTwo = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPasswordOne = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.picWarning = new System.Windows.Forms.PictureBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.toolTipUser = new System.Windows.Forms.ToolTip(this.components);
            this.lblPassOne = new System.Windows.Forms.Label();
            this.lblPassTwo = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 31);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(165, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 31);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chboxShowPassword
            // 
            this.chboxShowPassword.AutoSize = true;
            this.chboxShowPassword.Location = new System.Drawing.Point(90, 157);
            this.chboxShowPassword.Name = "chboxShowPassword";
            this.chboxShowPassword.Size = new System.Drawing.Size(114, 17);
            this.chboxShowPassword.TabIndex = 9;
            this.chboxShowPassword.Text = "Показать пароль";
            this.chboxShowPassword.UseVisualStyleBackColor = true;
            this.chboxShowPassword.CheckedChanged += new System.EventHandler(this.chboxShowPassword_CheckedChanged);
            // 
            // txtPasswordTwo
            // 
            this.txtPasswordTwo.Location = new System.Drawing.Point(90, 121);
            this.txtPasswordTwo.Name = "txtPasswordTwo";
            this.txtPasswordTwo.Size = new System.Drawing.Size(198, 20);
            this.txtPasswordTwo.TabIndex = 8;
            this.toolTipUser.SetToolTip(this.txtPasswordTwo, "Повторите пароль");
            this.txtPasswordTwo.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(90, 42);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(198, 20);
            this.txtUserName.TabIndex = 7;
            this.toolTipUser.SetToolTip(this.txtUserName, "Логин");
            // 
            // txtPasswordOne
            // 
            this.txtPasswordOne.Location = new System.Drawing.Point(90, 83);
            this.txtPasswordOne.Name = "txtPasswordOne";
            this.txtPasswordOne.Size = new System.Drawing.Size(198, 20);
            this.txtPasswordOne.TabIndex = 10;
            this.toolTipUser.SetToolTip(this.txtPasswordOne, "Пароль");
            this.txtPasswordOne.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManager.Properties.Resources.admin_settings_male_50px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 61);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.picWarning);
            this.pnlLogin.Controls.Add(this.lblWarning);
            this.pnlLogin.Location = new System.Drawing.Point(72, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(216, 23);
            this.pnlLogin.TabIndex = 12;
            this.pnlLogin.Visible = false;
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
            // lblPassOne
            // 
            this.lblPassOne.AutoSize = true;
            this.lblPassOne.Location = new System.Drawing.Point(91, 64);
            this.lblPassOne.Name = "lblPassOne";
            this.lblPassOne.Size = new System.Drawing.Size(45, 13);
            this.lblPassOne.TabIndex = 13;
            this.lblPassOne.Text = "Пароль";
            // 
            // lblPassTwo
            // 
            this.lblPassTwo.AutoSize = true;
            this.lblPassTwo.Location = new System.Drawing.Point(91, 106);
            this.lblPassTwo.Name = "lblPassTwo";
            this.lblPassTwo.Size = new System.Drawing.Size(100, 13);
            this.lblPassTwo.TabIndex = 14;
            this.lblPassTwo.Text = "Повторите пароль";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(91, 26);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 15;
            this.lblLogin.Text = "Логин";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 238);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPassTwo);
            this.Controls.Add(this.lblPassOne);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPasswordOne);
            this.Controls.Add(this.chboxShowPassword);
            this.Controls.Add(this.txtPasswordTwo);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chboxShowPassword;
        private System.Windows.Forms.TextBox txtPasswordTwo;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPasswordOne;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox picWarning;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.ToolTip toolTipUser;
        private System.Windows.Forms.Label lblPassOne;
        private System.Windows.Forms.Label lblPassTwo;
        private System.Windows.Forms.Label lblLogin;
    }
}