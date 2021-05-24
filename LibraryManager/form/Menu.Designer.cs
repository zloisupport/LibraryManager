
namespace LibraryManager.form
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BookMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.читателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBookDelivery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReader = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListReader = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.BookMenuStrip,
            this.читателиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmExit,
            this.настройкиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // BookMenuStrip
            // 
            this.BookMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddBook,
            this.tsmListBook,
            this.tsmBookDelivery});
            this.BookMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookMenuStrip.Name = "BookMenuStrip";
            this.BookMenuStrip.Size = new System.Drawing.Size(64, 25);
            this.BookMenuStrip.Text = "Книги";
            // 
            // читателиToolStripMenuItem
            // 
            this.читателиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmReader,
            this.tsmListReader});
            this.читателиToolStripMenuItem.Name = "читателиToolStripMenuItem";
            this.читателиToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.читателиToolStripMenuItem.Text = "Читатель";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.оToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.оПрограммеToolStripMenuItem.Text = "Помощь";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.dgvBook);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 363);
            this.panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(376, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 20);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(73, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(284, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AutoGenerateColumns = false;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn});
            this.dgvBook.DataSource = this.bookBindingSource;
            this.dgvBook.Location = new System.Drawing.Point(3, 54);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.Size = new System.Drawing.Size(577, 306);
            this.dgvBook.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Издатель";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(LibraryManager.Book);
            // 
            // tsmExit
            // 
            this.tsmExit.Image = global::LibraryManager.Properties.Resources.exit_15px;
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(157, 26);
            this.tsmExit.Text = "Выйти";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUser});
            this.настройкиToolStripMenuItem.Image = global::LibraryManager.Properties.Resources.settings_15px;
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // tsmUser
            // 
            this.tsmUser.Name = "tsmUser";
            this.tsmUser.Size = new System.Drawing.Size(179, 26);
            this.tsmUser.Text = "Пользователь";
            this.tsmUser.Click += new System.EventHandler(this.tsmUser_Click);
            // 
            // tsmAddBook
            // 
            this.tsmAddBook.Image = global::LibraryManager.Properties.Resources.icons8_book_reading_16;
            this.tsmAddBook.Name = "tsmAddBook";
            this.tsmAddBook.Size = new System.Drawing.Size(180, 26);
            this.tsmAddBook.Text = "Добавить";
            this.tsmAddBook.Click += new System.EventHandler(this.tsmAddBook_Click);
            // 
            // tsmListBook
            // 
            this.tsmListBook.Image = global::LibraryManager.Properties.Resources.course_15px;
            this.tsmListBook.Name = "tsmListBook";
            this.tsmListBook.Size = new System.Drawing.Size(180, 26);
            this.tsmListBook.Text = "Список";
            this.tsmListBook.Click += new System.EventHandler(this.tsmListBook_Click_1);
            // 
            // tsmBookDelivery
            // 
            this.tsmBookDelivery.Image = global::LibraryManager.Properties.Resources.icons8_parcel_16;
            this.tsmBookDelivery.Name = "tsmBookDelivery";
            this.tsmBookDelivery.Size = new System.Drawing.Size(180, 26);
            this.tsmBookDelivery.Text = "Выдача";
            this.tsmBookDelivery.Click += new System.EventHandler(this.tsmBookDelivery_Click);
            // 
            // tsmReader
            // 
            this.tsmReader.Image = global::LibraryManager.Properties.Resources.add_user_male_15px;
            this.tsmReader.Name = "tsmReader";
            this.tsmReader.Size = new System.Drawing.Size(149, 26);
            this.tsmReader.Text = "Добавить";
            this.tsmReader.Click += new System.EventHandler(this.tsmReader_Click);
            // 
            // tsmListReader
            // 
            this.tsmListReader.Image = global::LibraryManager.Properties.Resources.address_book_2_15px;
            this.tsmListReader.Name = "tsmListReader";
            this.tsmListReader.Size = new System.Drawing.Size(149, 26);
            this.tsmListReader.Text = "Список";
            this.tsmListReader.Click += new System.EventHandler(this.tsmListBook_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Image = global::LibraryManager.Properties.Resources.update_left_rotation_15px;
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Image = global::LibraryManager.Properties.Resources.help_15px;
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.помощьToolStripMenuItem.Text = "Справка";
            // 
            // оToolStripMenuItem
            // 
            this.оToolStripMenuItem.Image = global::LibraryManager.Properties.Resources.info_15px;
            this.оToolStripMenuItem.Name = "оToolStripMenuItem";
            this.оToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.оToolStripMenuItem.Text = "О программе";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmUser;
        private System.Windows.Forms.ToolStripMenuItem BookMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem читателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAddBook;
        private System.Windows.Forms.ToolStripMenuItem tsmReader;
        private System.Windows.Forms.ToolStripMenuItem tsmListBook;
        private System.Windows.Forms.ToolStripMenuItem tsmListReader;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem tsmBookDelivery;
    }
}