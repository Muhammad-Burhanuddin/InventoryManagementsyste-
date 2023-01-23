using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventorymanagmentsystem
{
    internal class Insertion
    {
        public void Insertuser(string name,string username, string pwd, string phone, string email,Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertusers", Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", status);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMSG(name+"added to the successfully", "Error....", "Error");
            }
            catch (Exception ex) {
                Mainclass.con.Close();
                Mainclass.showMSG(ex.Message, "Error....", "Error");
            }


        }

        public void InsertCat(string catname,  Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insertcat", Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@catname", catname);
                cmd.Parameters.AddWithValue("@inactivecat", status);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMSG(catname + "added to the successfully", "Error....", "Error");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMSG(ex.Message, "Error....", "Error");
            }


        }

        public void InsertProducts(string product, string barcode, DateTime? expiry,  int catID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertproduct", Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                cmd.Parameters.AddWithValue("@expiry", expiry);
                cmd.Parameters.AddWithValue("@catID", catID);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMSG(product + "added to the successfully", "Message", "Error");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMSG(ex.Message, "Error....", "Error");
            }

        }


        public void InsertSupplier(string suppliercn, string person, string phone1, string address, Int16 status,string phone2=null,string NTN = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertsupplier", Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@suppliername", suppliercn);
                cmd.Parameters.AddWithValue("@contactperson", person);
                cmd.Parameters.AddWithValue("@phone1", phone1);
                if(phone2== null)
                {
                    cmd.Parameters.AddWithValue("@phone2", DBNull.Value);
                }else
                {
                    cmd.Parameters.AddWithValue("@phone2", phone2);
                }

                if (NTN == null)
                {
                    cmd.Parameters.AddWithValue("@ntn", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ntn", NTN);
                }
                cmd.Parameters.AddWithValue("@addresss", address);
                cmd.Parameters.AddWithValue("@status", status);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMSG(suppliercn + "added to the successfully", "Message", "Error");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMSG(ex.Message, "Error....", "Error");
            }
        }
        private Int64 Purchase_InvoiceID;
        public Int64 InsertPurIN(DateTime date,int doneby,int suppID)
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    SqlCommand cmd = new SqlCommand("insertpurchaseinvoice", Mainclass.con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@doneby", doneby);
                    cmd.Parameters.AddWithValue("@suppID", suppID);
                    Mainclass.con.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "getlastpurchaseID";
                    cmd.Parameters.Clear();
                    Purchase_InvoiceID = Convert.ToInt64(cmd.ExecuteScalar());

                    Mainclass.con.Close();
                    sc.Complete();
                }
               
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMSG(ex.Message, "Error....", "Error");
            }
            return Purchase_InvoiceID;

        }
        int purchaseinvoicecount;

        public int insertpurchaseinovicedetials (Int64 Purchase_InvoiceID, int ProID,int quantity, float totalprioce)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertpurchaseinDetial", Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@purchaseID", Purchase_InvoiceID);
                cmd.Parameters.AddWithValue("@proID",ProID);
                cmd.Parameters.AddWithValue("@quan",quantity);
                cmd.Parameters.AddWithValue("@toPrice",totalprioce);
                Mainclass.con.Open();
                purchaseinvoicecount= cmd.ExecuteNonQuery();
                Mainclass.con.Close();

            }
            catch(Exception)
            {
                Mainclass.con.Close();  
            }
            return purchaseinvoicecount;
        }


        public void InsertPP(int proid, float buyprice)
        {
            try
            {

                    SqlCommand cmd = new SqlCommand("insertproductprice", Mainclass.con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@proid", proid);
                    cmd.Parameters.AddWithValue("@bp", buyprice);
                   
                    Mainclass.con.Open();
                    cmd.ExecuteNonQuery();
                    Mainclass.con.Close();                
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMSG(ex.Message, "Error....", "Error");
            }

        }

    }
}
