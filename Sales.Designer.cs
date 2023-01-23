namespace Inventorymanagmentsystem
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.grosslabel = new System.Windows.Forms.Label();
            this.grossamount = new System.Windows.Forms.Label();
            this.prodidgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitygv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotLamountgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.panel5.Size = new System.Drawing.Size(1227, 51);
            
            // panel1
            // 
            this.panel1.Controls.Add(this.barcode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Size = new System.Drawing.Size(332, 788);
            this.panel1.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.barcode, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Size = new System.Drawing.Size(1227, 788);
            this.panel2.Controls.SetChildIndex(this.panel4, 0);
            this.panel2.Controls.SetChildIndex(this.panel5, 0);
            this.panel2.Controls.SetChildIndex(this.dataGridView1, 0);
            this.panel2.Controls.SetChildIndex(this.panel7, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1227, 43);
            // 
            // user
            // 
            this.user.Size = new System.Drawing.Size(1227, 43);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Barcode";
            // 
            // barcode
            // 
            this.barcode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode.Location = new System.Drawing.Point(18, 133);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(288, 30);
            this.barcode.TabIndex = 2;
            this.barcode.Validating += new System.ComponentModel.CancelEventHandler(this.barcode_Validating);
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
            this.prodidgv,
            this.prodgv,
            this.quantitygv,
            this.pupgv,
            this.TotLamountgv});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1227, 635);
            this.dataGridView1.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tableLayoutPanel3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 729);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1227, 59);
            this.panel7.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.grosslabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.grossamount, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1227, 59);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // grosslabel
            // 
            this.grosslabel.AutoSize = true;
            this.grosslabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grosslabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grosslabel.Location = new System.Drawing.Point(616, 0);
            this.grosslabel.Name = "grosslabel";
            this.grosslabel.Size = new System.Drawing.Size(608, 59);
            this.grosslabel.TabIndex = 14;
            this.grosslabel.Text = "00.0";
            this.grosslabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grossamount
            // 
            this.grossamount.AutoSize = true;
            this.grossamount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grossamount.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossamount.Location = new System.Drawing.Point(3, 0);
            this.grossamount.Name = "grossamount";
            this.grossamount.Size = new System.Drawing.Size(607, 59);
            this.grossamount.TabIndex = 13;
            this.grossamount.Text = "Gross Amount";
            this.grossamount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prodidgv
            // 
            this.prodidgv.HeaderText = "Product ID";
            this.prodidgv.MinimumWidth = 6;
            this.prodidgv.Name = "prodidgv";
            this.prodidgv.ReadOnly = true;
            this.prodidgv.Visible = false;
            // 
            // prodgv
            // 
            this.prodgv.HeaderText = "Product";
            this.prodgv.MinimumWidth = 6;
            this.prodgv.Name = "prodgv";
            this.prodgv.ReadOnly = true;
            // 
            // quantitygv
            // 
            this.quantitygv.HeaderText = "Quantity";
            this.quantitygv.MinimumWidth = 6;
            this.quantitygv.Name = "quantitygv";
            this.quantitygv.ReadOnly = true;
            // 
            // pupgv
            // 
            this.pupgv.HeaderText = "Per Unit Price";
            this.pupgv.MinimumWidth = 6;
            this.pupgv.Name = "pupgv";
            this.pupgv.ReadOnly = true;
            // 
            // TotLamountgv
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.TotLamountgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.TotLamountgv.HeaderText = "Total Amount";
            this.TotLamountgv.MinimumWidth = 6;
            this.TotLamountgv.Name = "TotLamountgv";
            this.TotLamountgv.ReadOnly = true;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 788);
            this.Margin = new System.Windows.Forms.Padding(8, 16, 8, 16);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox barcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label grosslabel;
        private System.Windows.Forms.Label grossamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitygv;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotLamountgv;
    }
}