using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Ly_Doan_Vien.view;

namespace Quan_Ly_Doan_Vien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qlcs a = new qlcs();
            a.MdiParent = this;
            a.Dock = DockStyle.Fill;
            this.flowLayoutPanel1.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }
    }
}
