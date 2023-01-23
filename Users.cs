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

 
    public partial class Users : sample2
    {
        int edit = 0;
        int userid;
        short stat;

        Reterival r = new Reterival();

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            Mainclass.disable_reset(panel1);
            r.showusers(dataGridView2, UserIDgv, Namesgv, Usernamegv, Passwordgv, Phonegw, Emailgw, Statusgv);

        }
        public override void searchdata_TextChanged(object sender, EventArgs e)
        {
            if (searchbox.Text == "")
            {
                r.showusers(dataGridView2, UserIDgv, Namesgv, Usernamegv, Passwordgv, Phonegw, Emailgw, Statusgv, searchbox.Text);
            }
            else
            {
                r.showusers(dataGridView2, UserIDgv, Namesgv, Usernamegv, Passwordgv, Phonegw, Emailgw, Statusgv);

            }
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
            if (statusdropdown.SelectedIndex == 0)
            {
                stat = 1;
            }
            else if (statusdropdown.SelectedIndex == 1)
            {
                stat = 0;

            }
            if (edit == 0)
            {

                i.Insertuser(namebox.Text, usernamebox.Text, password.Text, phone.Text, emailbox.Text, stat);
                r.showusers(dataGridView2, UserIDgv, Namesgv, Usernamegv, Passwordgv, Phonegw, Emailgw, Statusgv);
                Mainclass.disable_reset(panel1);
            }
            else if (edit == 1)
            {
                Updation u = new Updation();
                if (statusdropdown.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (statusdropdown.SelectedIndex == 1)
                {
                    stat = 0;
             }
                u.Updateuser(userid, namebox.Text, usernamebox.Text, password.Text, phone.Text, emailbox.Text, stat);
                r.showusers(dataGridView2, UserIDgv, Namesgv, Usernamegv, Passwordgv, Phonegw, Emailgw, Statusgv);
            }
        }
        public override void Deletebtn_Click_1(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                Delelation d = new Delelation();
                d.deleteuser(userid, "deleteuser", "@id");
                r.showusers(dataGridView2, UserIDgv, Namesgv, Usernamegv, Passwordgv, Phonegw, Emailgw, Statusgv);

            }
        }
       

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                userid = Convert.ToInt32(row.Cells["UserIDgv"].Value.ToString());
                namebox.Text = row.Cells["Namesgv"].Value.ToString();
                usernamebox.Text = row.Cells["Usernamegv"].Value.ToString();
                password.Text = row.Cells["Passwordgv"].Value.ToString();
                phone.Text = row.Cells["Phonegw"].Value.ToString();
                emailbox.Text = row.Cells["Emailgw"].Value.ToString();
                statusdropdown.SelectedItem = row.Cells["Statusgv"].Value.ToString();
                Mainclass.disable(panel1);
            }
        }

       
    }
}
