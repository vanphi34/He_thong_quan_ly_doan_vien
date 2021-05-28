using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Quan_Ly_Doan_Vien.BLL
{
    class BLL_quenmk
    {
        DAL.DAL data = new DAL.DAL();
        public string qmk(string name, string cauhoi, string trl)
        {
            string sql = "select * from acc where name = N'" + name + "' and cauhoi = N'" + cauhoi + "' and trl = N'" + trl + "'";
            DataTable pass = data.gettb(sql);
            if (pass.Rows.Count > 0)
            {
                return pass.Rows[0].ItemArray.GetValue(0).ToString();
            }
            else
            {
                MessageBox.Show("hãy nhập đúng thông tin.");
                return null;
            }
        }

    }
}
