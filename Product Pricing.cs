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
    public partial class Product_Pricing : sample2
    {
        Reterival r = new Reterival();
        Updation u = new Updation();

        public Product_Pricing()
        {
            InitializeComponent();
            r.Getlist("getcatdatalist", categorydb, "Category", "ID");
        }

        private void categorydb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categorydb.SelectedIndex !=-1 && categorydb.SelectedIndex != 0)
            {
                r.ShowgetproductWRTCategory(Convert.ToInt32(categorydb.SelectedValue.ToString()), dataGridView1,prodidgv,prodgv,bpgv,finalpricegv,Discountgv,profitgv);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["profitgv"].Value != null )
                {
                    float finalbuyinprice = Convert.ToSingle(row.Cells["bpgv"].Value.ToString());
                    float profitmargin = Convert.ToSingle(row.Cells["profitgv"].Value.ToString()) / 100;
                   
                    float amounttoincrease = profitmargin * finalbuyinprice;
                    float finalsellingprice = finalbuyinprice + amounttoincrease;

                    float discount;
                    if (row.Cells["Discountgv"].Value != null)
                    {
                        discount = finalsellingprice *( Convert.ToSingle(row.Cells["Discountgv"].Value.ToString()) / 100);
                    }
                    else
                    {
                        discount = 0;
                    }
                    row.Cells["finalpricegv"].Value = finalsellingprice- discount;
                }
                else
                {
                    row.Cells["finalpricegv"].Value = null;
                    row.Cells["Discountgv"].Value = null;
                    row.Cells["profitgv"].Value = null;


                }

            }
        }

        public override void Add_Click(object sender, EventArgs e)
        {

        }

        public override void edit_Click(object sender, EventArgs e)
        {

        }

        public override void savebtn_Click(object sender, EventArgs e)
        {
            if (categorydb.SelectedIndex != -1 && categorydb.SelectedIndex != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((bool)row.Cells["selectgv"].FormattedValue == true)
                    {
                        float disc,pm,bp ,sp;
                        bp = Convert.ToSingle(row.Cells["bpgv"].Value.ToString());


                        disc = row.Cells["Discountgv"].Value == null?0:Convert.ToSingle(row.Cells["Discountgv"].Value.ToString());
                        pm = row.Cells["profitgv"].Value == null ?  0 : Convert.ToSingle(row.Cells["profitgv"].Value.ToString());


                        if(disc ==0 && pm == 0)
                        {
                            sp =bp;
                        }
                        else
                        {
                            sp = Convert.ToSingle(row.Cells["finalpricegv"].Value.ToString());
                        }
                        u.Updateproductprice(Convert.ToInt32(row.Cells["prodidgv"].Value.ToString()), bp, sp, disc, pm);                    }
                }
                Mainclass.showMSG("Product Pricing Update Successfully", "Success", "Success");
            }
        }

        public override void searchdata_TextChanged(object sender, EventArgs e)
        {

        }

        public override void View_Click(object sender, EventArgs e)
        {

        }

        private void Product_Pricing_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }
    }
}
