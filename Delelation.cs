using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventorymanagmentsystem
{
    class Delelation
    {
        public void deleteuser(object id, string proc, string param)

        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, Mainclass.con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, id);

                Mainclass.con.Open();
                cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                Mainclass.showMSG( "Data Deleted to the successfully", "Message", "Error");
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMSG(ex.Message, "Message", "Error");
            }


        }
    }
}
