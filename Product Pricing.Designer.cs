namespace Inventorymanagmentsystem
{
    partial class Product_Pricing
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
            this.categorydb = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectgv = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prodidgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bpgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discountgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalpricegv = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel5.Size = new System.Drawing.Size(1143, 51);
            
            this.panel1.Controls.Add(this.categorydb);
            this.panel1.Controls.Add(this.category);
            this.panel1.Size = new System.Drawing.Size(332, 788);
            this.panel1.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.Controls.SetChildIndex(this.category, 0);
            this.panel1.Controls.SetChildIndex(this.categorydb, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Size = new System.Drawing.Size(1143, 788);
            this.panel2.Controls.SetChildIndex(this.panel4, 0);
            this.panel2.Controls.SetChildIndex(this.panel5, 0);
            this.panel2.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1143, 43);
            // 
            // user
            // 
            this.user.Size = new System.Drawing.Size(1143, 43);
            // 
            // categorydb
            // 
            this.categorydb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorydb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorydb.FormattingEnabled = true;
            this.categorydb.Items.AddRange(new object[] {
            "Yes ",
            "No"});
            this.categorydb.Location = new System.Drawing.Point(17, 125);
            this.categorydb.Name = "categorydb";
            this.categorydb.Size = new System.Drawing.Size(302, 31);
            this.categorydb.TabIndex = 12;
            this.categorydb.SelectedIndexChanged += new System.EventHandler(this.categorydb_SelectedIndexChanged);
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Location = new System.Drawing.Point(12, 94);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(92, 28);
            this.category.TabIndex = 11;
            this.category.Text = "Category";
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
            this.selectgv,
            this.prodidgv,
            this.prodgv,
            this.bpgv,
            this.profitgv,
            this.Discountgv,
            this.finalpricegv});
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
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 694);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // selectgv
            // 
            this.selectgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.selectgv.FalseValue = "0";
            this.selectgv.HeaderText = "";
            this.selectgv.MinimumWidth = 6;
            this.selectgv.Name = "selectgv";
            this.selectgv.TrueValue = "1";
            this.selectgv.Width = 6;
            // 
            // prodidgv
            // 
            this.prodidgv.HeaderText = "Product ID";
            this.prodidgv.MinimumWidth = 6;
            this.prodidgv.Name = "prodidgv";
            this.prodidgv.Visible = false;
            // 
            // prodgv
            // 
            this.prodgv.HeaderText = "Product";
            this.prodgv.MinimumWidth = 6;
            this.prodgv.Name = "prodgv";
            // 
            // bpgv
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.bpgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.bpgv.HeaderText = "Buying Price";
            this.bpgv.MinimumWidth = 6;
            this.bpgv.Name = "bpgv";
            // 
            // profitgv
            // 
            this.profitgv.HeaderText = "Profit Margin %";
            this.profitgv.MinimumWidth = 6;
            this.profitgv.Name = "profitgv";
            // 
            // Discountgv
            // 
            this.Discountgv.HeaderText = "Discount %";
            this.Discountgv.MinimumWidth = 6;
            this.Discountgv.Name = "Discountgv";
            // 
            // finalpricegv
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.finalpricegv.DefaultCellStyle = dataGridViewCellStyle3;
            this.finalpricegv.HeaderText = "Final Selling Price";
            this.finalpricegv.MinimumWidth = 6;
            this.finalpricegv.Name = "finalpricegv";
            // 
            // Product_Pricing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 788);
            this.Margin = new System.Windows.Forms.Padding(8, 16, 8, 16);
            this.Name = "Product_Pricing";
            this.Text = "Product_Pricing";
            this.Load += new System.EventHandler(this.Product_Pricing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox categorydb;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn bpgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discountgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalpricegv;
    }
}