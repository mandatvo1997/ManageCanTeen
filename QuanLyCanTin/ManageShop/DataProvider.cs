using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManageShop
{
    public class DataProvider
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-00VPBT66;Initial Catalog=QuanLyCanTin;Integrated Security=True");

        public static DataTable ExecuteQuery(string query, object[] values = null)
        {
            DataTable dt = new DataTable();

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            if (values != null)
            {
                string[] listpara = query.Split(' ');
                int i = 0;
                foreach (string para in listpara)
                {
                    if (para.Contains('@'))
                    {
                        cmd.Parameters.AddWithValue(para, values[i++]);
                    }
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public static int ExecuteNonQuery(string query, object[] values = null)
        {
            int data = 0;


            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            if (values != null)
            {
                string[] listpara = query.Split(' ');
                int i = 0;
                foreach (string para in listpara)
                {
                    if (para.Contains('@'))
                    {
                        cmd.Parameters.AddWithValue(para, values[i++]);
                    }
                }
            }
            data = cmd.ExecuteNonQuery();
            con.Close();
            return data;
        }
    }
}
