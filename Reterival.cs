using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventorymanagmentsystem
{
    internal class Reterival
    {
        public void showusers(DataGridView gv ,DataGridViewColumn usergv, DataGridViewColumn namegv, DataGridViewColumn usernamegv, DataGridViewColumn passwordgv, DataGridViewColumn phonegv, DataGridViewColumn  emailgv, DataGridViewColumn statusgv, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if(data == null)
                {
                     cmd = new SqlCommand("getusersdata", Mainclass.con);

                }
                else
                {
                     cmd = new SqlCommand("getusersdatalike", Mainclass.con);
                    cmd.Parameters.AddWithValue(data, "@data");
                }

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dataTable= new DataTable();
                da.Fill(dataTable);
                usergv.DataPropertyName= dataTable.Columns["ID"].ToString();
                namegv.DataPropertyName = dataTable.Columns["Name"].ToString();
                usernamegv.DataPropertyName = dataTable.Columns["Username"].ToString();
                passwordgv.DataPropertyName = dataTable.Columns["Password"].ToString(); 
                phonegv.DataPropertyName = dataTable.Columns["Phone"].ToString();
                emailgv.DataPropertyName = dataTable.Columns["Email"].ToString();
                statusgv.DataPropertyName = dataTable.Columns["Status"].ToString();
                gv.DataSource= dataTable;
            }
            catch (Exception)
            {

            }
        }

        public void ShowCat(DataGridView gv, DataGridViewColumn catgv, DataGridViewColumn catnamegv, DataGridViewColumn activegv)
        {
            try
            {
                SqlCommand
                    cmd = new SqlCommand("getcatdata", Mainclass.con);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                catgv.DataPropertyName = dataTable.Columns["ID"].ToString();
                catnamegv.DataPropertyName = dataTable.Columns["Category"].ToString();
                activegv.DataPropertyName = dataTable.Columns["Status"].ToString();
                gv.DataSource = dataTable;
            }
            catch (Exception)
            {
                Mainclass.showMSG("Enable to load Category", "Message", "Error...");
            }
        }

        public void Getlist(string proc,ComboBox cb, string displaymember, string valueMember)
        {
            try
            {
                cb.Items.Clear();
                cb.Items.Insert(0, "Select....");
                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, Mainclass.con);
                cmd.CommandType= System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da=new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                DataRow dr = dataTable.NewRow();
                dr.ItemArray = new object[] { 0, "Select...." };
                dataTable.Rows.InsertAt(dr,0);
                cb.DataSource= dataTable;
                cb.DisplayMember= displaymember;
                cb.ValueMember= valueMember;
            }
            catch(Exception)
            {

            }
           
        }

        public void ShowProduct(DataGridView gv, DataGridViewColumn proidgv, DataGridViewColumn pronamegv, DataGridViewColumn bargv, DataGridViewColumn expirygv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getproductdata", Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                proidgv.DataPropertyName = dataTable.Columns["Product ID"].ToString();
                pronamegv.DataPropertyName = dataTable.Columns["Product Name"].ToString();
                bargv.DataPropertyName = dataTable.Columns["Barcode"].ToString();
                expirygv.DataPropertyName = dataTable.Columns["Expiry"].ToString();
                gv.DataSource = dataTable;
            }
            catch (Exception)
            {
                Mainclass.showMSG("Enable to load Product", "Message", "Error...");
            }
        }

            public static int userId
        {
            get; private set;
        }

            public static string name
        {
            get; private set;
        }

        private static string user_name=null,pass_word=null;
        private static bool checklogin;

        public static bool getuserdetails(String username, string password)
        {
            try{
                SqlCommand cmd = new SqlCommand("getuserslogin", Mainclass.con) ;
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                Mainclass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    checklogin= true;
                    while(dr.Read())
                    {
                        userId = Convert.ToInt32(dr["ID"].ToString());
                        name = dr["Name"].ToString();
                        user_name = dr["Username"].ToString();
                        pass_word = dr["Password"].ToString();
                    }
                }
                else
                {
                    checklogin= false;
                    if(username != null || password != null)
                    {
                       if(user_name != null && pass_word ==password)
                        {
                            Mainclass.showMSG("Inalid Username", "Error", "Error");
                        }
                        else if (user_name == null && pass_word != password)
                        {
                            Mainclass.showMSG("Inalid password", "Error", "Error");
                        }
                        else if (user_name != null && pass_word != password)
                        {
                            Mainclass.showMSG("Inalid password and fUsername", "Error", "Error");
                        }
                    }
                }

                Mainclass.con.Close();


            }
            catch (Exception)
            {
                Mainclass.con.Close();
                Mainclass.showMSG("Enable to login", "Error", "Error");
            }
            return checklogin;
        }


        public void ShowSupplier(DataGridView gv, DataGridViewColumn supidgv, DataGridViewColumn supncgv, 
            DataGridViewColumn persongv, DataGridViewColumn phone1gv, DataGridViewColumn phone2gv, DataGridViewColumn addressgv, DataGridViewColumn ntngv, DataGridViewColumn activegv)
        {
            try
            {
                SqlCommand
                    cmd = new SqlCommand("getsuplierdata", Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                supidgv.DataPropertyName = dataTable.Columns["Supplier ID"].ToString();
                supncgv.DataPropertyName = dataTable.Columns[" Supplier Name"].ToString();
                persongv.DataPropertyName = dataTable.Columns["Contact Person"].ToString();
                phone1gv.DataPropertyName = dataTable.Columns["Phone1"].ToString();
                phone2gv.DataPropertyName = dataTable.Columns["Phone2"].ToString();
                addressgv.DataPropertyName = dataTable.Columns["Address"].ToString();
                ntngv.DataPropertyName = dataTable.Columns["NTN#"].ToString();
                activegv.DataPropertyName = dataTable.Columns["status"].ToString();

                gv.DataSource = dataTable;
            }
            catch (Exception)
            {
                Mainclass.showMSG("Enable to load Supplier", "Message", "Error...");
            }
        }
        private string[] productdata = new string[3];
        public string[] Getproductbarcode(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getproductbybarcode", Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode",barcode);
                Mainclass.con.Open();
                SqlDataReader dataReader= cmd.ExecuteReader();
                if(dataReader.HasRows)
                {
                    while(dataReader.Read())
                    {
                        productdata[0] = dataReader[0].ToString();
                        productdata[1] = dataReader[1].ToString();
                        productdata[2] = dataReader[2].ToString();
                    }
                }
                else
                {
                }
                Mainclass.con.Close();

            }
            catch (Exception)
            {
                Mainclass.con.Close();
              
            }
            return productdata;
        }

        public void ShowStock(DataGridView gv, DataGridViewColumn proidgv, DataGridViewColumn prongv,
            DataGridViewColumn barcodegv, DataGridViewColumn expirygv, 
            DataGridViewColumn bpgv, DataGridViewColumn spgv,DataGridViewColumn categv)
        {
            try
            {
                SqlCommand
                    cmd = new SqlCommand("getallstock", Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                proidgv.DataPropertyName = dataTable.Columns["Product ID"].ToString();
                prongv.DataPropertyName = dataTable.Columns["Product Name"].ToString();
                barcodegv.DataPropertyName = dataTable.Columns["Barcode"].ToString();
                expirygv.DataPropertyName = dataTable.Columns["Expiry Date"].ToString();
                bpgv.DataPropertyName = dataTable.Columns["Buying Price"].ToString();
                spgv.DataPropertyName = dataTable.Columns["Selling Price"].ToString();
                categv.DataPropertyName = dataTable.Columns["Category"].ToString();
                gv.DataSource = dataTable;
            }
            catch (Exception)
            {
                Mainclass.showMSG("Enable to load stock", "Message", "Error...");
            }
        }

        private bool checkPP;
        public bool checkproductprice(int proid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("checkproductpriceexit", Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proid", proid);
                Mainclass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkPP = true;
                }
                else
                {
                    checkPP= false;
                }
                Mainclass.con.Close();
            }
            catch (Exception)
            {

                
            }
            return checkPP;
        }

        public void ShowgetproductWRTCategory(int catid,DataGridView gv, DataGridViewColumn proidgv, DataGridViewColumn prongv,
           DataGridViewColumn bpgv, DataGridViewColumn spgv, DataGridViewColumn disgv,
           DataGridViewColumn profitpgv
           )
        {
            try
            {
                SqlCommand
                    cmd = new SqlCommand("getproductWRTCategory", Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@catID",catid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                proidgv.DataPropertyName = dataTable.Columns["Product ID"].ToString();
                prongv.DataPropertyName = dataTable.Columns["Products"].ToString();
                bpgv.DataPropertyName = dataTable.Columns["Buying Price"].ToString();
                spgv.DataPropertyName = dataTable.Columns["Selling Price"].ToString();
                disgv.DataPropertyName = dataTable.Columns["Discount"].ToString();
                profitpgv.DataPropertyName = dataTable.Columns["ProfitP"].ToString();

                gv.DataSource = dataTable;
            }
            catch (Exception)
            {
                Mainclass.showMSG("Enable to load Products", "Message", "Error...");
            }
        }


        private string[] productdataPI = new string[2];
        public string[] getproductbybarcodePI(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getproductbybarcodePI", Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                Mainclass.con.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        productdataPI[0] = dataReader[0].ToString();
                        productdataPI[1] = dataReader[1].ToString();
                    }
                }
                else
                {
                }
                Mainclass.con.Close();

            }
            catch (Exception)
            {
                Mainclass.con.Close();

            }
            return productdataPI;
        }

    }
}
