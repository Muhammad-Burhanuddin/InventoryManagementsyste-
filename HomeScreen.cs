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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            user.Text = Reterival.name;
            Form1.logoutolStripMenuItem.Enabled = true;
        }

   
        private void users_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            Mainclass.showindow(users, this, Form1.ActiveForm);
        }

        private void Productbtn_Click(object sender, EventArgs e)
        {
            Products users = new Products();
            Mainclass.showindow(users, this, Form1.ActiveForm);
        }

        private void catogorybtn_Click(object sender, EventArgs e)
        {
            Catogery users = new Catogery();
            Mainclass.showindow(users, this, Form1.ActiveForm);
        }

        private void supplier_Click(object sender, EventArgs e)
        {
            Supplier supp = new Supplier();
            Mainclass.showindow(supp, this, Form1.ActiveForm);
        }

        private void purchasebtn_Click(object sender, EventArgs e)
        {
          Purchase_Invoice pi = new Purchase_Invoice();
            Mainclass.showindow(pi, this, Form1.ActiveForm);
        }

        private void stockbtn_Click(object sender, EventArgs e)
        {
            Stock pi = new Stock();
            Mainclass.showindow(pi, this, Form1.ActiveForm);
        }

        private void salebtn_Click(object sender, EventArgs e)
        {
            Sales pi = new Sales();
            Mainclass.showindow(pi, this, Form1.ActiveForm);
        }

        private void productprice_Click(object sender, EventArgs e)
        {
            Product_Pricing pp = new Product_Pricing();
            Mainclass.showindow(pp, this, Form1.ActiveForm);
        }
    }
}
