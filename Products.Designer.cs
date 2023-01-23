namespace Inventorymanagmentsystem
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.productnametext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Barcodetext = new System.Windows.Forms.TextBox();
            this.Datetimelable = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.category = new System.Windows.Forms.Label();
            this.categorydb = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.proidgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pronamegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirygv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            // 
            // backbtn
            // 
            this.backbtn.FlatAppearance.BorderSize = 0;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Size = new System.Drawing.Size(1294, 51);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.categorydb);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Datetimelable);
            this.panel1.Controls.Add(this.Barcodetext);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.productnametext);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Size = new System.Drawing.Size(332, 788);
            this.panel1.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.productnametext, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            this.panel1.Controls.SetChildIndex(this.Barcodetext, 0);
            this.panel1.Controls.SetChildIndex(this.Datetimelable, 0);
            this.panel1.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.panel1.Controls.SetChildIndex(this.category, 0);
            this.panel1.Controls.SetChildIndex(this.categorydb, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Size = new System.Drawing.Size(1294, 788);
            this.panel2.Controls.SetChildIndex(this.panel5, 0);
            this.panel2.Controls.SetChildIndex(this.panel4, 0);
            this.panel2.Controls.SetChildIndex(this.dataGridView2, 0);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 51);
            this.panel4.Size = new System.Drawing.Size(1294, 43);
            // 
            // user
            // 
            this.user.Size = new System.Drawing.Size(1294, 43);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product Name";
            // 
            // productnametext
            // 
            this.productnametext.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productnametext.Location = new System.Drawing.Point(12, 208);
            this.productnametext.MaxLength = 100;
            this.productnametext.Name = "productnametext";
            this.productnametext.Size = new System.Drawing.Size(301, 30);
            this.productnametext.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Barcode";
            // 
            // Barcodetext
            // 
            this.Barcodetext.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barcodetext.Location = new System.Drawing.Point(12, 272);
            this.Barcodetext.MaxLength = 100;
            this.Barcodetext.Name = "Barcodetext";
            this.Barcodetext.Size = new System.Drawing.Size(301, 30);
            this.Barcodetext.TabIndex = 4;
            // 
            // Datetimelable
            // 
            this.Datetimelable.AutoSize = true;
            this.Datetimelable.Location = new System.Drawing.Point(7, 315);
            this.Datetimelable.Name = "Datetimelable";
            this.Datetimelable.Size = new System.Drawing.Size(100, 28);
            this.Datetimelable.TabIndex = 5;
            this.Datetimelable.Text = "Date Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 346);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(301, 30);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Location = new System.Drawing.Point(7, 379);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(92, 28);
            this.category.TabIndex = 9;
            this.category.Text = "Category";
            // 
            // categorydb
            // 
            this.categorydb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorydb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorydb.FormattingEnabled = true;
            this.categorydb.Items.AddRange(new object[] {
            "Yes ",
            "No"});
            this.categorydb.Location = new System.Drawing.Point(12, 410);
            this.categorydb.Name = "categorydb";
            this.categorydb.Size = new System.Drawing.Size(302, 31);
            this.categorydb.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proidgv,
            this.pronamegv,
            this.barcodegv,
            this.expirygv});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 94);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1294, 694);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // proidgv
            // 
            this.proidgv.HeaderText = "Product ID";
            this.proidgv.MinimumWidth = 6;
            this.proidgv.Name = "proidgv";
            this.proidgv.ReadOnly = true;
            this.proidgv.Visible = false;
            // 
            // pronamegv
            // 
            this.pronamegv.HeaderText = "Product";
            this.pronamegv.MinimumWidth = 6;
            this.pronamegv.Name = "pronamegv";
            this.pronamegv.ReadOnly = true;
            // 
            // barcodegv
            // 
            this.barcodegv.HeaderText = "Barcode";
            this.barcodegv.MinimumWidth = 6;
            this.barcodegv.Name = "barcodegv";
            this.barcodegv.ReadOnly = true;
            // 
            // expirygv
            // 
            this.expirygv.HeaderText = "Expiry Date";
            this.expirygv.MinimumWidth = 6;
            this.expirygv.Name = "expirygv";
            this.expirygv.ReadOnly = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 788);
            this.Margin = new System.Windows.Forms.Padding(8, 16, 8, 16);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox productnametext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Barcodetext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Datetimelable;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.ComboBox categorydb;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn proidgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn pronamegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirygv;
    }
}