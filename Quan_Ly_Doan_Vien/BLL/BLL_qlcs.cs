using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Quan_Ly_Doan_Vien.BLL
{
    class BLL_qlcs
    {
        DAL.DAL data = new DAL.DAL();

        public DataTable select_cs()
        {
            string sql = "select * from info_co_so_doan";
            return data.gettb(sql);
        }
       
        public void them(string macs, string tencs, string diachi)
        {
            if(macs.Equals("") || tencs.Equals("") || diachi.Equals(""))
            {
                MessageBox.Show("hãy nhập đầy đủ thông tin!");
            }
            else
            {
                try
                {
                    string sql = "insert into info_co_so_doan values ('" + macs + "', N'" + tencs + "', N'" + diachi + "')";
                    data.truyvan(sql);
                }
                catch(Exception e)
                {
                    MessageBox.Show("đã tồn tại mã cơ sở");
                }
                
            }
            
        }

        public void xoa(string macs)
        {
            string sql = "exec del_coso '"+macs+"'";
            data.truyvan(sql);
        }

        public void sua(string macs, string tencs, string diachi)
        {
            if (macs == "")
            {
                MessageBox.Show("hãy chọn cơ sở cần sửa!!");
            }
            else
            {
                string sql = "update info_co_so_doan set tencs='" + tencs + "', diachi= '" + diachi + "' where macs = '" + macs + "'";
                data.truyvan(sql);
            }
        }

        public DataTable tim(string tencs)
        {
            if (tencs.Equals(""))
            {
                MessageBox.Show("hãy nhập tên cơ sở cần tìm");
                return select_cs();
            }
            else
            {
                string sql = "select * from info_co_so_doan where tencs='" + tencs + "'";
                return data.gettb(sql);
            }
        }

    }
}
