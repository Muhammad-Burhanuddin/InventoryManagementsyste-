using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Inventorymanagmentsystem
{
     class Mainclass
    {
        private static string s = "Data Source=BURHANPC;Initial Catalog=imsDB;Integrated Security=True;MultipleActiveResultSets=True";
        public static SqlConnection con = new SqlConnection(s);

        public static DialogResult showMSG(string msg, string heading , string type)
        {
            if (type == "Success")
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public static void showindow(Form openwind, Form closewin ,Form mdiform1)
        {
            closewin.Close();
            openwind.MdiParent = mdiform1;
            openwind.WindowState = FormWindowState.Maximized;
            openwind.Show();
        }

        public static void showindow(Form openwind, Form mdiform1)
        {     
            openwind.MdiParent = mdiform1;
            openwind.WindowState = FormWindowState.Maximized;
            openwind.Show();
        }

        public static void disable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
               if(c is TextBox) { 
                TextBox t= (TextBox)c;
                    t.Enabled= false;
                    t.Text= "" ;
                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                    dtp.Value= DateTime.Now;    
                }

            }
        }

        public static void disable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                }

            }
        }

        public static void enable_reset(Panel p)
            {
                foreach (Control c in p.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox t = (TextBox)c;
                        t.Enabled = true;
                        t.Text = "";
                    }

                    if (c is ComboBox)
                    {
                        ComboBox cb = (ComboBox)c;
                        cb.Enabled = true;
                        cb.SelectedIndex = -1;
                    }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }

            }
        }

        public static void enable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                }

            }
        }
    }
    }

