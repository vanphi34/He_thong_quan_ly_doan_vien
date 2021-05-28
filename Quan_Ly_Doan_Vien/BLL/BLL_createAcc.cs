using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace Quan_Ly_Doan_Vien.BLL
{
    class BLL_createAcc
    {
        DAL.DAL data = new DAL.DAL();
        public void add(string name, string pass, string type)
        {
            if(name.Equals("")|| pass.Equals("") || type.Equals(""))
            {
                MessageBox.Show("hãy nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    string sql = "insert into acc( name, pass, type) values ( '" + name + "','" + pass + "','" + type + "')";
                    data.truyvan(sql);
                    MessageBox.Show("Tạo tài khoản thành công.");
                }
                catch(Exception)
                {
                    MessageBox.Show("tên đăng nhập đã tồn tại. Vui lòng nhập tên khác!");
                }
                
            }
            
        }
    }
}
