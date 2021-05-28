using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Doan_Vien.view
{
    public partial class update_info : Form
    {
        BLL.BLL_update_info bll = new BLL.BLL_update_info();
        public update_info()
        {
            InitializeComponent();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string name = login.account;
            bll.change(name, txtxacnhan.Text, cbbcauhoi.Text, txttraloi.Text);
            
            txttraloi.Clear();
            txtxacnhan.Clear();

            
        }

        private void update_info_Load(object sender, EventArgs e)
        {
            txtname.Text = login.account;
        }
    }
}
