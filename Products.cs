using System;
using System.Windows.Forms;

namespace Inventorymanagmentsystem
{
    public partial class Products : sample2
    {
        int edit = 0;
        int procesID;
        public Products()
        {
            InitializeComponent();
        }

         Reterival r = new Reterival();
        private void Products_Load(object sender, EventArgs e)
        {
            Mainclass.disable_reset(panel1);
            r.Getlist("getcatdatalist", categorydb, "Category", "ID");
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

            if (edit == 0)
            {

                i.InsertProducts(productnametext.Text, Barcodetext.Text, dateTimePicker1.Value, Convert.ToInt32(categorydb.SelectedValue));
                r.ShowProduct(dataGridView2, proidgv, pronamegv, barcodegv, expirygv);
                Mainclass.disable_reset(panel1);
            } 
            else if (edit == 1)
            {
                Updation u = new Updation();
                u.ProducUpdate(procesID, productnametext.Text, Barcodetext.Text,dateTimePicker1.Value, Convert.ToInt32(categorydb.SelectedValue));
                r.ShowProduct(dataGridView2, proidgv, pronamegv, barcodegv, expirygv);

                //  r.ShowProduct(dataGridView2, proidgv, pronamegv, barcodegv, pricegv, expirygv, catidgv, catnamegv);
            }
        }
        public override void searchdata_TextChanged(object sender, EventArgs e)
        {

        }

        public override void Deletebtn_Click_1(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                Delelation d = new Delelation();
                d.deleteuser(procesID, "deleteproduct", "@proid");
                r.ShowProduct(dataGridView2, proidgv, pronamegv, barcodegv, expirygv);

            }

        }

        public override void View_Click(object sender, EventArgs e)
        {
            r.ShowProduct(dataGridView2, proidgv, pronamegv, barcodegv, expirygv);

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                procesID = Convert.ToInt32(row.Cells["proidgv"].Value.ToString());
                productnametext.Text = row.Cells["pronamegv"].Value.ToString();
                Barcodetext.Text = row.Cells["barcodegv"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["expirygv"].Value.ToString());
//categorydb.SelectedValue = row.Cells["catidgv"].Value.ToString();
                Mainclass.disable(panel1);
            }
        }
    }
}
