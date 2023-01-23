using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventorymanagmentsystem
{
    internal class Updation
    {
        public void Updateuser(int id, string name, string username, string pwd, string phone, string email, Int16 status)

        {
            try
            {
                SqlCommand cmd = new SqlCommand("updateusers", Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);

                cmd.Parameters.AddWithValue("@pwd", pwd);

                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", status);

                cmd.Parameters.AddWithValue("@id", id);

                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMSG(name + "Updated to the successfully", "Error....", "Error");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMSG(ex.Message, "Error....", "Error");
            }


        }
        public void UpdateCat(int id,string catname, Int16 status)

        {
            try
            {
                SqlCommand cmd = new SqlCommand("updatecat", Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@catname", catname);
                cmd.Parameters.AddWithValue("@inactivecat", status);
                cmd.Parameters.AddWithValue("@idcat", id);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMSG(catname + " Updated to the successfully", "Error....", "Error");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMSG(ex.Message, "Error....", "Error");
            }

        }

        public void ProducUpdate(int proid,string product, string barcode, DateTime? expiry, int catID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updateproduct", Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                cmd.Parameters.AddWithValue("@expiry", expiry);
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@proid", proid);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMSG("Updated data to the successfully", "Error....", "Error");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMSG(ex.Message, "Error....", "Error");
            }

        }



        public void UpdateSupplier(int supid,string suppliercn, string person, string phone1, string address, Int16 status, string phone2 = null, string NTN = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updatesupplier", Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@suppliername", suppliercn);
                cmd.Parameters.AddWithValue("@contactperson", person);
                cmd.Parameters.AddWithValue("@phone1", phone1);
                if (phone2 == null)
                {
                    cmd.Parameters.AddWithValue("phone2", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("phone2", phone2);
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
                cmd.Parameters.AddWithValue("@supid", supid);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMSG("Added to the successfully", "Message", "Error");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMSG(ex.Message, "Error....", "Error");
            }
        }

        public void Updateproductprice(int proid, float bp, float sp,float dis, float profitp)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updateproductprice", Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proid", proid);
                cmd.Parameters.AddWithValue("@bp", bp);
                cmd.Parameters.AddWithValue("@sp", sp);
                cmd.Parameters.AddWithValue("@dis", dis);
                cmd.Parameters.AddWithValue("@proftp", profitp);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMSG("Updated data to the successfully", "Error....", "Error");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMSG(ex.Message, "Error....", "Error");
            }

        }


        public void Updateproductprice1(int proid, float bp)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("updateproductprice1", Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proid", proid);
                cmd.Parameters.AddWithValue("@bp", bp);
                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMSG("Updated data to the successfully", "Error....", "Error");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMSG(ex.Message, "Error....", "Error");
            }

        }
    }
}
