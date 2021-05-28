using System;
using System.Collections.Generic;
using System.Text;
using Quan_Ly_Doan_Vien.DAL;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace Quan_Ly_Doan_Vien.BLL
{
    class BLL_login
    {
        DAL.DAL data = new DAL.DAL();

        public bool CheckLogin(string sql)
        {
            DataTable check = new DataTable();
            check = data.gettb(sql);
            if (check.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string getType(string sql)
        {
            DataTable check = new DataTable();
            check = data.gettb(sql);
            return check.Rows[0].ItemArray.GetValue(2).ToString();
        }
    }
}
