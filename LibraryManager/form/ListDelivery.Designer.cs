
namespace LibraryManager.form
{
    partial class ListDelivery
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deliveryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIssueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReturnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateIssueDataGridViewTextBoxColumn,
            this.dateReturnDataGridViewTextBoxColumn,
            this.ReaderId,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.deliveryBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // deliveryBindingSource1
            // 
            this.deliveryBindingSource1.DataSource = typeof(LibraryManager.Delivery);
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataSource = typeof(LibraryManager.Delivery);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateIssueDataGridViewTextBoxColumn
            // 
            this.dateIssueDataGridViewTextBoxColumn.DataPropertyName = "DateIssue";
            this.dateIssueDataGridViewTextBoxColumn.HeaderText = "DateIssue";
            this.dateIssueDataGridViewTextBoxColumn.Name = "dateIssueDataGridViewTextBoxColumn";
            // 
            // dateReturnDataGridViewTextBoxColumn
            // 
            this.dateReturnDataGridViewTextBoxColumn.DataPropertyName = "DateReturn";
            this.dateReturnDataGridViewTextBoxColumn.HeaderText = "DateReturn";
            this.dateReturnDataGridViewTextBoxColumn.Name = "dateReturnDataGridViewTextBoxColumn";
            // 
            // ReaderId
            // 
            this.ReaderId.DataPropertyName = "ReaderId";
            this.ReaderId.HeaderText = "ReaderId";
            this.ReaderId.Name = "ReaderId";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ReaderId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ReaderId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ListDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListDelivery";
            this.Text = "ListDelivery";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource deliveryBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIssueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReturnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReaderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}