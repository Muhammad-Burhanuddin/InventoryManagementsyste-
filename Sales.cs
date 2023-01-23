using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventorymanagmentsystem
{
    public partial class Sales : sample2
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }
        Reterival r = new Reterival();
        int productID;
        float gross;
        string[] prodARR = new string[3];
        bool productcheck;

        private void barcode_Validating(object sender, CancelEventArgs e)
        {
            if (barcode.Text != "")
            {
                prodARR = r.Getproductbarcode(barcode.Text);
                if (dataGridView1.RowCount == 0)
                {
                    dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[2]), prodARR[2]);
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["prodidgv"].Value.ToString() == prodARR[0])
                        {
                            productcheck = true;
                            break;
                          
                        }else
                        {productcheck= false;
                        }
                      
                    }
                    if (productcheck == true)
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {

                            if (row.Cells["prodidgv"].Value.ToString() == prodARR[0])
                            {

                                row.Cells["quantitygv"].Value = Convert.ToInt32(row.Cells["quantitygv"].Value.ToString()) + 1;

                                float totl = Convert.ToSingle(row.Cells["pupgv"].Value.ToString()) * Convert.ToInt32(row.Cells["quantitygv"].Value.ToString());
                                row.Cells["TotLamountgv"].Value = totl;

                            }
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[2]), prodARR[2]);

                    }
                }
               
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                   gross += Convert.ToSingle(item.Cells["TotLamountgv"].Value.ToString());
                }
                grosslabel.Text = gross.ToString();
             /*   gross = 0;
                barcode.Focus();
                barcode.Text = "";*/

              
            }
        }
    }
}
