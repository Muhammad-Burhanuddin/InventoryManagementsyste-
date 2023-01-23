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
    public partial class sample2 : Sample
    {
        public sample2()
        {
            InitializeComponent();
        }

        private  void sample2_Load(object sender, EventArgs e)
        {

        }
        public virtual void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public virtual void Add_Click(object sender, EventArgs e)
        {

        }

        public virtual void edit_Click(object sender, EventArgs e)
        {

        }

        public virtual void savebtn_Click(object sender, EventArgs e)
        {
        }
        
        public virtual void searchdata_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void View_Click(object sender, EventArgs e)
        {

         
        }
        public virtual void Deletebtn_Click_1(object sender, EventArgs e)
        {

        }

        private void backbt_Click(object sender, EventArgs e)
        {
            HomeScreen hm = new HomeScreen();
            Mainclass.showindow(hm, this, Form1.ActiveForm);
        }
    }
}
