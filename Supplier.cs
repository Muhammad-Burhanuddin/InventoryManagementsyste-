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
    public partial class Supplier : sample2
    {
        int edit = 0;
        int supplierid;
        short stat;

        Reterival r = new Reterival();

        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            Mainclass.disable_reset(panel1);
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
            if (suppliercombax.SelectedIndex == 0)
            {
                stat = 1;
            }
            else if (suppliercombax.SelectedIndex == 1)
            {
                stat = 0;

            }
            if (edit == 0)
            {
                if(phone2text.Text == "" && NTNtext.Text != "")
                {
                    i.InsertSupplier(Suppliernametext.Text, ContactPersiontext.Text, phone1text.Text, Addresstext.Text, stat, null, NTNtext.Text);
                }
                else if (phone2text.Text != "" && NTNtext.Text == "")
                {
                    i.InsertSupplier(Suppliernametext.Text, ContactPersiontext.Text, phone1text.Text, Addresstext.Text, stat, phone2text.Text, null);
                }
                else if (phone2text.Text == "" && NTNtext.Text == "")
                {
                    i.InsertSupplier(Suppliernametext.Text, ContactPersiontext.Text, phone1text.Text, Addresstext.Text, stat, null, null);
                }else
                {
                    i.InsertSupplier(Suppliernametext.Text, ContactPersiontext.Text, phone1text.Text, Addresstext.Text, stat, phone1text.Text, NTNtext.Text);
                }


                r.ShowSupplier(dataGridView2, supIDgv, suppliernamegv, conpersongv, phone1gv, phone2gv, addressgv, ntngv, Statusgv);
                Mainclass.disable_reset(panel1);
            }
            else if (edit == 1)
            {
                Updation u = new Updation();

                if (suppliercombax.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (suppliercombax.SelectedIndex == 1)
                {
                    stat = 0;

                }
                if (phone2text.Text == "" && NTNtext.Text != "")
                {
                    u.UpdateSupplier(supplierid, Suppliernametext.Text, ContactPersiontext.Text, phone1text.Text, Addresstext.Text, stat, null, NTNtext.Text);
                }
                else if (phone2text.Text != "" && NTNtext.Text == "")
                {
                    u.UpdateSupplier(supplierid, Suppliernametext.Text, ContactPersiontext.Text, phone1text.Text, Addresstext.Text, stat, phone2text.Text,null);
                }
                else if (phone2text.Text == "" && NTNtext.Text == "")
                {
                    u.UpdateSupplier(supplierid, Suppliernametext.Text, ContactPersiontext.Text, phone1text.Text, Addresstext.Text, stat, null, null);
                }
                else
                {
                    u.UpdateSupplier(supplierid, Suppliernametext.Text, ContactPersiontext.Text, phone1text.Text, Addresstext.Text, stat, phone2text.Text, NTNtext.Text);
                }
            }
        }

        public override void searchdata_TextChanged(object sender, EventArgs e)
        {

        }

        public override void View_Click(object sender, EventArgs e)
        {
            r.ShowSupplier(dataGridView2, supIDgv, suppliernamegv, conpersongv, phone1gv, phone2gv, addressgv, ntngv, Statusgv);
        }


        public override void Deletebtn_Click_1(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                Delelation d = new Delelation();
                d.deleteuser(supplierid, "deletesupplier", "@supid");
                r.ShowSupplier(dataGridView2, supIDgv, suppliernamegv, conpersongv, phone1gv, phone2gv, addressgv, ntngv, Statusgv);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2_CellClick(sender, e, phone1text);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e, System.Windows.Forms.TextBox phone1text)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                supplierid = Convert.ToInt32(row.Cells["supIDgv"].Value.ToString());
                Suppliernametext.Text = row.Cells["suppliernamegv"].Value.ToString();
                ContactPersiontext.Text = row.Cells["conpersongv"].Value.ToString();
                phone1text.Text = row.Cells["phone1gv"].Value.ToString();
                phone2text.Text = row.Cells["phone2gv"].Value.ToString();
                Addresstext.Text = row.Cells["addressgv"].Value.ToString();
                NTNtext.Text = row.Cells["ntngv"].Value.ToString();
                suppliercombax.SelectedItem = row.Cells["Statusgv"].Value.ToString();

                Mainclass.disable(panel1);
            }
        }
    }
}
