using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventorymanagmentsystem
{
    public partial class Purchase_Invoice : sample2
    {
        public Purchase_Invoice()
        {
            InitializeComponent();
        }
        Reterival r = new Reterival();
        Updation u = new Updation();    
        int productID;
        float gt;
            Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        private void Purchase_Invoice_Load(object sender, EventArgs e)
        {
            r.Getlist("getsupplierlist",Ssupplierdb , " Suuplier Name", "Supplier ID");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        string[] prodARR = new string[3];
        private void Barcodetext_TextChanged(object sender, EventArgs e)
        {
            if(Barcodetext.Text != "")
            {
                prodARR= r.getproductbybarcodePI(Barcodetext.Text);
                productID = Convert.ToInt32(prodARR[0]);
                Prodducttext.Text = prodARR[1];
                Prodducttext.Enabled= false;
            }
            else
            {
                productID= 0; 
                Prodducttext.Text = "";
                PuPtext.Text = "";
                Array.Clear(prodARR, 0, prodARR.Length);
            }
        }

        private void Squantitytext_TextChanged(object sender, EventArgs e)
        {
            if(Squantitytext.Text!= "") {
                if(rg.Match(Squantitytext.Text).Success)
                {
                    float quant, price, total;
                    quant = Convert.ToSingle(Squantitytext.Text);
                    price = Convert.ToSingle(PuPtext.Text);
                    total= quant*price;
                    totalamount.Text =total.ToString("##########.##");
                }
                else
                {
                    Squantitytext.SelectAll();  
                }

            }
            else
            {
                totalamount.Text = "0.00";
            }
        }

        private void Addtocartbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(productID, Prodducttext.Text, Squantitytext.Text, PuPtext.Text, totalamount.Text);
            gt += Convert.ToSingle(totalamount.Text);
            Grosslabl.Text =gt.ToString();
            productID = 0;
            Prodducttext.Text = "";
            PuPtext.Text = "";
            Barcodetext.Text = "";
            PuPtext.Text = "";
            Array.Clear(prodARR, 0, prodARR.Length);

        }

   
        int co;
        public override void savebtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                Int64 purchaseinvoiceID;
                Insertion i = new Insertion();
               purchaseinvoiceID= i.InsertPurIN(DateTime.Today, Reterival.userId, Convert.ToInt32(Ssupplierdb.SelectedValue));
               
                foreach(DataGridViewRow row in dataGridView1.Rows) 
                {
                   co= i.insertpurchaseinovicedetials(purchaseinvoiceID, Convert.ToInt32(row.Cells["prodidgv"].Value.ToString()), Convert.ToInt32(row.Cells["quantitygv"].Value.ToString()), Convert.ToSingle(row.Cells["TotLamountgv"].Value.ToString() ));
                    if (r.checkproductprice(Convert.ToInt32(row.Cells["prodidgv"].Value.ToString())))
                    {
                       u.Updateproductprice1(Convert.ToInt32(row.Cells["prodidgv"].Value.ToString()), Convert.ToSingle(row.Cells["pupgv"].Value.ToString()));
                    }
                    else
                    {
                        i.InsertPP(Convert.ToInt32(row.Cells["prodidgv"].Value.ToString()), Convert.ToSingle(row.Cells["pupgv"].Value.ToString()));
                    }

                }
                if(co> 0)
                {
                    Mainclass.showMSG("Purchase Invoice created Successfully.", "Success", "Success");     
                }else
                {
                    Mainclass.showMSG("Unable to create Invoice.", "Error", "Error");

                }
            }
        }

        private void PuPtext_TextChanged(object sender, EventArgs e)
        {
          /*  if(PuPtext.Text != "")
            {
                if(rg.Match(PuPtext.Text).Success) {
                    PuPtext.Text = "";
                    PuPtext.Focus();
                }
            }*/
        }
    }
}
