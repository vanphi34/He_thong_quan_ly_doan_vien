using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quan_Ly_Doan_Vien.view
{
    public partial class changePass : Form
    {
        BLL.BLL_changepass b = new BLL.BLL_changepass();
        public changePass()
        {
            InitializeComponent();
        }

        private void btnchangepass_Click(object sender, EventArgs e)
        {
            b.change(textBox1.Text, textBox2.Text, textBox3.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
