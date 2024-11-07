using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02.DAO
{
    public class DataProvider
    {
        private string str = @"Data Source=DESKTOP-HI307AE;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True";

        public static object Instance { get; internal set; }

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                conn.Close();
            }

            return data;
        }


        public void LenhSQL(string query)
        {

            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(str);

            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
    
}
