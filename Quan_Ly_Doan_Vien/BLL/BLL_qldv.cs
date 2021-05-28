using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace Quan_Ly_Doan_Vien.BLL
{
    class BLL_qldv
    {
        DAL.DAL data = new DAL.DAL();

        public DataTable select_dv()
        {
            return data.gettb("select * from doan_vien");
        }

        public Boolean them(string madv, string macs, string tendv, string diachi, string gioitinh, string ngaysinh, string sdt, string ngayvaodoan, string llct, string tdhv)
        {
            if (madv.Equals("") || macs.Equals("") || tendv.Equals("") || diachi.Equals("") || gioitinh.Equals("") || ngaysinh.Equals("") || sdt.Equals("") || ngayvaodoan.Equals("")|| llct.Equals("")|| tdhv.Equals(""))
            {
                MessageBox.Show("Hãy nhập đầy đủthông tin.");
                return false;
            }
            else
            {
                try
                {
                    string sql = "insert into doan_vien values ('" + madv + "','" + macs + "', N'" + tendv +"','"+ngaysinh+"',N'"+gioitinh+"',N'"+diachi+"','"+sdt+"','"+ngayvaodoan+"',N'"+llct+"',N'"+tdhv+ "')";
                    data.truyvan(sql);
                    return true;
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã đoàn viên đã tồn tại");
                    return false;
                }
            }
        }

        public void xoa(string madv)
        {
            string sql = "exec del_doanvien '"+madv+"'";
            data.truyvan(sql);
        }

        public void sua(string madv, string macs, string tendv, string diachi, string gioitinh, DateTime ngaysinh, string sdt, DateTime ngayvaodoan, string llct, string tdhv)
        {
            if (madv == "")
            {
                MessageBox.Show("hãy chọn cơ sở cần sửa!!");
            }
            else
            {
                string sql = "update doan_vien set macs='" + macs +"', tendv = N'"+tendv + "', ngaysinh = '" + ngaysinh.ToString("yyyy/MM/dd") + "', gioitinh = N'" + gioitinh +"', diachi = N'" +diachi+"', sdt = '"+sdt+"', ngayvaodoan = '"+ ngayvaodoan.ToString("yyyy/MM/dd")+"', llct = N'"+llct+"', tdhv = N'"+tdhv+ "' where madv = '" + madv + "'";
                data.truyvan(sql);
            }
        }

        public DataTable tim(string tendv, string macs)
        {
            if (tendv.Equals("") && macs.Equals(""))
            {
                MessageBox.Show("Hãy nhập tên đoàn viên hoặc mã cơ sở cần tìm!");
                return select_dv();
            }
            else
            {
                string sql = "select * from doan_vien where tendv = N'" + tendv + "' or macs = N'"+macs+"'";
                return data.gettb(sql);

            }
        }
        public DataTable timma(string madv)
        {
            
            string sql = "select * from doan_vien where madv = '" + madv + "'";
            return data.gettb(sql);
        }
        public DataTable loc_cs(string macs)
        {
            string sql = "select * from doan_vien where macs = '" + macs + "'";
            return data.gettb(sql);
        }
    }
}
