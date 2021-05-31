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
    class BLL_update_info
    {
        DAL.DAL data = new DAL.DAL();

        public void change(string name, string pass, string cauhoi, string trl)
        {

            String sqlcheck = "select * from acc where name = '" + name + "' and pass = '" + pass + "'";
            DataTable check = data.gettb(sqlcheck);
            if(pass.Equals("") || cauhoi.Equals("") || trl.Equals(""))
            {
                MessageBox.Show("Hãy nhập đủ thông tin.");
            }
            else if (check.Rows.Count > 0)
            {
                string sql = "update acc set cauhoi = N'" + cauhoi + "' , trl = N'" + trl + "' where name = '" + name + "'";
                data.truyvan(sql);
                MessageBox.Show("sửa thông tin thành công.");
            }
            else
            {
                MessageBox.Show("hãy nhập đúng mật khẩu.");
            }
        }
    }
}
