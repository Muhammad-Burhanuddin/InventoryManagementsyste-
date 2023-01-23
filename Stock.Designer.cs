namespace Inventorymanagmentsystem
{
    partial class Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proidgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prondgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirygv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bpgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel5.Size = new System.Drawing.Size(1110, 51);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(332, 788);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Size = new System.Drawing.Size(1110, 788);
            this.panel2.Controls.SetChildIndex(this.panel4, 0);
            this.panel2.Controls.SetChildIndex(this.panel5, 0);
            this.panel2.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1110, 43);
            // 
            // user
            // 
            this.user.Size = new System.Drawing.Size(1110, 43);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proidgv,
            this.prondgv,
            this.barcodegv,
            this.expirygv,
            this.bpgv,
            this.spgv,
            this.categgv});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1110, 694);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // proidgv
            // 
            this.proidgv.HeaderText = "Product ID";
            this.proidgv.MinimumWidth = 6;
            this.proidgv.Name = "proidgv";
            this.proidgv.ReadOnly = true;
            this.proidgv.Visible = false;
            // 
            // prondgv
            // 
            this.prondgv.HeaderText = "Product";
            this.prondgv.MinimumWidth = 6;
            this.prondgv.Name = "prondgv";
            this.prondgv.ReadOnly = true;
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
            // bpgv
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.bpgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.bpgv.HeaderText = "Buying Price";
            this.bpgv.MinimumWidth = 6;
            this.bpgv.Name = "bpgv";
            this.bpgv.ReadOnly = true;
            // 
            // spgv
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.spgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.spgv.HeaderText = "Selling Price";
            this.spgv.MinimumWidth = 6;
            this.spgv.Name = "spgv";
            this.spgv.ReadOnly = true;
            // 
            // categgv
            // 
            this.categgv.HeaderText = "Category";
            this.categgv.MinimumWidth = 6;
            this.categgv.Name = "categgv";
            this.categgv.ReadOnly = true;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 788);
            this.Margin = new System.Windows.Forms.Padding(8, 16, 8, 16);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proidgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn prondgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodegv;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirygv;
        private System.Windows.Forms.DataGridViewTextBoxColumn bpgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn spgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn categgv;
    }
}