
namespace LibraryManager.form
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.txtName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.btnPicOpen = new System.Windows.Forms.Button();
            this.btnPicClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelForm = new System.Windows.Forms.Button();
            this.btnSaveForm = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(199, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 29);
            this.txtName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtName, "Название");
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(199, 84);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(250, 29);
            this.txtAuthor.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtAuthor, "Автор");
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(199, 134);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(250, 29);
            this.txtISBN.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtISBN, "ISBN");
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(199, 184);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(250, 29);
            this.txtPublisher.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtPublisher, "Publisher");
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.CustomFormat = "yyyy";
            this.dtpPublishDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpPublishDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPublishDate.Location = new System.Drawing.Point(199, 234);
            this.dtpPublishDate.MaxDate = new System.DateTime(2098, 12, 31, 0, 0, 0, 0);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.ShowUpDown = true;
            this.dtpPublishDate.Size = new System.Drawing.Size(250, 29);
            this.dtpPublishDate.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(12, 369);
            this.txtDescription.MaxLength = 3200767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(434, 159);
            this.txtDescription.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtDescription, " Описание");
            // 
            // picCover
            // 
            this.picCover.ErrorImage = null;
            this.picCover.InitialImage = null;
            this.picCover.Location = new System.Drawing.Point(3, 3);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(159, 239);
            this.picCover.TabIndex = 6;
            this.picCover.TabStop = false;
            // 
            // btnPicOpen
            // 
            this.btnPicOpen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPicOpen.Location = new System.Drawing.Point(99, 285);
            this.btnPicOpen.Name = "btnPicOpen";
            this.btnPicOpen.Size = new System.Drawing.Size(78, 35);
            this.btnPicOpen.TabIndex = 7;
            this.btnPicOpen.Text = ". . .";
            this.btnPicOpen.UseVisualStyleBackColor = true;
            // 
            // btnPicClear
            // 
            this.btnPicClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPicClear.Location = new System.Drawing.Point(12, 285);
            this.btnPicClear.Name = "btnPicClear";
            this.btnPicClear.Size = new System.Drawing.Size(78, 35);
            this.btnPicClear.TabIndex = 8;
            this.btnPicClear.Text = "Очиска";
            this.btnPicClear.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picCover);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 245);
            this.panel1.TabIndex = 9;
            // 
            // btnDelForm
            // 
            this.btnDelForm.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelForm.Location = new System.Drawing.Point(358, 534);
            this.btnDelForm.Name = "btnDelForm";
            this.btnDelForm.Size = new System.Drawing.Size(98, 35);
            this.btnDelForm.TabIndex = 12;
            this.btnDelForm.Text = "Удалить";
            this.btnDelForm.UseVisualStyleBackColor = false;
            // 
            // btnSaveForm
            // 
            this.btnSaveForm.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSaveForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveForm.Location = new System.Drawing.Point(30, 534);
            this.btnSaveForm.Name = "btnSaveForm";
            this.btnSaveForm.Size = new System.Drawing.Size(98, 35);
            this.btnSaveForm.TabIndex = 13;
            this.btnSaveForm.Text = "Сохранить";
            this.btnSaveForm.UseVisualStyleBackColor = false;
            // 
            // btnClearForm
            // 
            this.btnClearForm.BackColor = System.Drawing.Color.Orange;
            this.btnClearForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearForm.Location = new System.Drawing.Point(194, 534);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(98, 35);
            this.btnClearForm.TabIndex = 14;
            this.btnClearForm.Text = "Очистить";
            this.btnClearForm.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Издатель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Дата публикации";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Количество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(199, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Цена";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Обложка";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "Описание";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(199, 284);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(247, 29);
            this.txtAmount.TabIndex = 24;
            // 
            // txtPrice
            // 
            this.txtPrice.DecimalPlaces = 1;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(199, 334);
            this.txtPrice.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(247, 29);
            this.txtPrice.TabIndex = 25;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 581);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnSaveForm);
            this.Controls.Add(this.btnDelForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPicClear);
            this.Controls.Add(this.btnPicOpen);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dtpPublishDate);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookForm";
            this.Text = "Книга";
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.Button btnPicOpen;
        private System.Windows.Forms.Button btnPicClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelForm;
        private System.Windows.Forms.Button btnSaveForm;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.NumericUpDown txtPrice;
    }
}