using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventorymanagmentsystem
{
    public partial class Catogery : sample2
    {
        int edit = 0;
        int catid;
        short stat;
        Reterival r =new Reterival();

        public Catogery()
        {
            InitializeComponent();
        }

        private void Catogery_Load(object sender, EventArgs e)
        {
            Mainclass.disable(panel1);

        }

        public override void searchdata_TextChanged(object sender, EventArgs e)
        {

        }

        public override void Add_Click(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.enable_reset(panel1);
        }

        public override void edit_Click(object sender, EventArgs e)
        {
            edit = 1;
            Mainclass.enable(panel1);
        }

        public override void savebtn_Click(object sender, EventArgs e)
        {
            Insertion i = new Insertion();
            if (activecatdb.SelectedIndex == 0)
            {
                stat = 1;
            }
            else if (activecatdb.SelectedIndex == 1)
            {
                stat = 0;

            }
            if (edit == 0)
            {

                i.InsertCat(Categorytext.Text, stat);
                r.ShowCat(dataGridView2, UserIDgw, Namegw, statusgw);
                Mainclass.disable_reset(panel1);
            }
            else if (edit == 1)
            {
                Updation u = new Updation();
                if (activecatdb.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (activecatdb.SelectedIndex == 1)
                {
                    stat = 0;

                }
                u.UpdateCat(catid, Categorytext.Text, stat);
                r.ShowCat(dataGridView2, UserIDgw, Namegw, statusgw);
            }
        }
        public override void View_Click(object sender, EventArgs e)
        {
            r.ShowCat(dataGridView2, UserIDgw, Namegw, statusgw);

        }
        public override void Deletebtn_Click_1(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                Delelation d = new Delelation();
                d.deleteuser(catid, "deletecat", "@idcat");
                r.ShowCat(dataGridView2, UserIDgw, Namegw, statusgw);

            }
        }
       
        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                catid = Convert.ToInt32(row.Cells["UserIDgw"].Value.ToString());
                Categorytext.Text = row.Cells["Namegw"].Value.ToString();
                activecatdb.SelectedItem = row.Cells["statusgw"].Value.ToString();
                Mainclass.disable(panel1);
            }
        }
    }
}
