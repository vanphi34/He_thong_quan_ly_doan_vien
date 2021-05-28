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
    public partial class quenmk : Form
    {
        BLL.BLL_quenmk bll = new BLL.BLL_quenmk();
        public quenmk()
        {
            InitializeComponent();
        }

        private void quenmk_FormClosed(object sender, FormClosedEventArgs e)
        {
            new login().Show();
        }

        private void btnqmk_Click(object sender, EventArgs e)
        {
            string pass = bll.qmk(txtname.Text,cbbch.Text,txttrl.Text);
            if(pass != null)
            {
                txtmk.Text = pass;
                txtmk.Enabled = true;
            }
            txtname.Clear();
            txttrl.Clear();
        }
    }
}
