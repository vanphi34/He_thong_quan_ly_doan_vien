using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quan_Ly_Doan_Vien.view
{
    public partial class createAcc : Form
    {
        BLL.BLL_createAcc bll = new BLL.BLL_createAcc();
        public createAcc()
        {
            InitializeComponent();
        }

        private void cbhienthipass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhienthipass.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void btntao_Click(object sender, EventArgs e)
        {
            bll.add(txtname.Text, txtpass.Text, cbbphamvi.Text);
            txtname.Clear();
            txtpass.Clear();
        }
    }
}
