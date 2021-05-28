using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Ly_Doan_Vien.BLL;
using Quan_Ly_Doan_Vien.view;
using System.Xml;

namespace Quan_Ly_Doan_Vien
{
    public partial class login : Form
    {

        public static indexForm idf = new indexForm();
        public static string account= "";
        public login()
        {
            InitializeComponent();
        }

        private void load_index_form(indexForm xx)
        {
            xx.tcmain.TabPages.Clear();
            TabPage myTabPage = new TabPage("Trang chủ");
            myTabPage.Controls.Add(new UserControl1());
            xx.tcmain.TabPages.Add(myTabPage);
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_usename.Text.Equals(""))
            {
                MessageBox.Show("Tài khoản không được bỏ trống!");
                return;
            }
            if (txt_password.Text.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được bỏ trống!");
                return;
            }
            string acc = txt_usename.Text;
            string pass = txt_password.Text;
            string sql = @"select * from acc where name = '" + acc + "' and pass = '" + pass + "'";
            
            BLL_login check = new BLL_login();
            if (check.CheckLogin(sql))
            {
                string type = check.getType(sql);
                
                account = txt_usename.Text;

                load_index_form(idf);
                idf.Show();
                

                if(!type.Equals("admin"))
                {
                    idf.admintsmn.Visible = false;
                }
                this.Owner = idf;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản mật khẩu không chính xác");
            }
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            // thần lực nên cái này nó chạy, còn application.Exit thì không
            // có lẽ lệnh này chạy ngay cả khi có 1 vài form bị hide,
            // còn applycation.Exit thì ko làm dc

            Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbhtmk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhtmk.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
           // lblqmk.ForeColor = ForeColor.ToArgb(32,90,167);
        }

        private void lblqmk_Click(object sender, EventArgs e)
        {
            quenmk a = new quenmk();
            a.Show();
            this.Hide();

        }
    }
}
