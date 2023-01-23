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
    public partial class login : Sample
    {
        public login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(usernamebox.Text != "" && passwordbox.Text != "")
            {
                if(Reterival.getuserdetails(usernamebox.Text, passwordbox.Text))
                {
                    HomeScreen hs = new HomeScreen();
                    Mainclass.showindow(hs, this, Form1.ActiveForm);
                    
                }
                else
                {

                }
            }
        }

       
    }
}
