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
    
    public partial class QLTK : Form
    {
        BLL.BLL_qltk bll = new BLL.BLL_qltk();
        public QLTK()
        {
            InitializeComponent();
        }

        private void QLTK_Load(object sender, EventArgs e)
        {
            dgvacc.DataSource = bll.select_acc();
        }

        private void dgvacc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname.Text = dgvacc.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttype.Text = dgvacc.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txttype.Clear();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            bll.sua(txtname.Text, txttype.Text);
            btnreset_Click(sender, e);
            QLTK_Load(sender, e);

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            bll.xoa(txtname.Text);
            btnreset_Click(sender, e);
            QLTK_Load(sender, e);
        }
    }
}
