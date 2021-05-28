using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace Quan_Ly_Doan_Vien.BLL
{
    class BLL_ktkl
    {
        DAL.DAL data = new DAL.DAL();

        public DataTable select_ktkl()
        {
            return data.gettb("select * from kt_kl");
        }

        public void them(string madv, string khenthuong, string kiluat)
        {
            if(madv.Length.Equals("") || (khenthuong.Equals("") && kiluat.Equals("")))
            {
                MessageBox.Show("Hãy nhập thông tin!");
            }
            else
            {
                try
                {
                    string sql = "insert into kt_kl values ('" + madv + "','" + khenthuong + "','" + kiluat + "')";
                    data.truyvan(sql);

                }
                catch (Exception)
                {
                    MessageBox.Show("đoàn viên đã có trong danh sách");
                }
            }
        }

        public void xoa(string madv)
        {
            string sql = "delete from kt_kl where madv = '" + madv + "'";
            data.truyvan(sql);
        }

        public void sua(string madv, string kt, string kl)
        {
            if (madv == "")
            {
                MessageBox.Show("hãy chọn mục cần sửa!!");
            }
            else
            {
                string sql = "update kt_kl set  khenthuong = N'" + kt + "', kiluat= N'" + kl + "' where madv = '" + madv + "'";
                data.truyvan(sql);
            }
        }

        public DataTable tim(string madv)
        {
            string sql1 = "select * from kt_kl where madv = '" + madv + "'";
            return data.gettb(sql1);
        }

        public Boolean check( string madv)
        {
            string sql = "select * from kt_kl where madv = '" + madv + "'";
            DataTable nga = data.gettb(sql);
            if (nga.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
