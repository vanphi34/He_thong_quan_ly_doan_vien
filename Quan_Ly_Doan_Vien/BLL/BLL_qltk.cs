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
    class BLL_qltk
    {
        DAL.DAL data = new DAL.DAL();


        public DataTable select_acc()
        {
            return data.gettb("select name , type from acc");
        }
        public void sua(string name, string type)
        {
            string sql = "update acc set type = N'" + type + "' where name = N'" + name + "'";
            data.truyvan(sql);
            MessageBox.Show("Thay đổi thông tin thành công");
        }
        public void xoa(string name)
        {
            string sql = "delete from acc where name = N'" + name + "'";
            data.truyvan(sql);
            
        }
    }
}
