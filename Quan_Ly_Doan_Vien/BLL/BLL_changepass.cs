using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace Quan_Ly_Doan_Vien.BLL
{
    class BLL_changepass
    {
        DAL.DAL data = new DAL.DAL();

        public void change(string old_pass, string new_pass, string confirm_pass)
        {
                string getpass = "select pass from acc where name ='" + login.account + "'";
                DataTable pass = data.gettb(getpass);
                string a = pass.Rows[0].ItemArray.GetValue(0).ToString();
                if (!a.Equals(old_pass))
                {
                    MessageBox.Show("lll");
                }
                else
                {
                    if (!new_pass.Equals(confirm_pass))
                    {
                        MessageBox.Show("xác nhận mật khẩu không chính xác!");
                    }
                    else
                    {
                        string sql = "update acc set pass = '" + new_pass + "' where name = '" + login.account + "'";
                        data.truyvan(sql);
                        MessageBox.Show("Đổi mật khẩu thành công.");
                    }

                    
                }
        }
    }
}
