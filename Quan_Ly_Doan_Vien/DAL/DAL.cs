using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Quan_Ly_Doan_Vien.DAL
{
    class DAL
    {
        string stcn = ConfigurationManager.ConnectionStrings["mykey"].ConnectionString;

        SqlConnection GetConnection()
        {
            return new SqlConnection(stcn);
        }

       

        public DataTable gettb(string sql)
        {
            SqlConnection cn = GetConnection();

            DataTable tb = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(sql, cn);

            ad.Fill(tb);

            return tb;
        }
        
        public void truyvan(string sql)
        {
            SqlConnection cn = GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();

            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
