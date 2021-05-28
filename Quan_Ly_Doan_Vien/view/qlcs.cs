using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quan_Ly_Doan_Vien.view
{
    public partial class qlcs : Form
    {
        BLL.BLL_qlcs bll = new BLL.BLL_qlcs();
        public qlcs()
        {
            InitializeComponent();
        }

        private void delete_form()
        {
            txtdiachi.Clear();
            txtmacs.Clear();
            txttencs.Clear();
        }


        private void qlcs_Load(object sender, EventArgs e)
        {
            dgvcs.DataSource = bll.select_cs();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            bll.them(txtmacs.Text, txttencs.Text, txtdiachi.Text);
            qlcs_Load(sender, e);
            delete_form();
        }

        private void dgvcs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtmacs.Text = dgvcs.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttencs.Text = dgvcs.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtdiachi.Text = dgvcs.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtmacs.Enabled = false;
                btnthem.Enabled = false;
                btnxoa.Enabled = true;
                btnsua.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            delete_form();
            txtmacs.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            dgvcs.DataSource = bll.select_cs();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            bll.xoa(txtmacs.Text);
            dgvcs.DataSource = bll.select_cs();
            btnreset_Click(sender,e);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            bll.sua(txtmacs.Text, txttencs.Text, txtdiachi.Text);
            dgvcs.DataSource = bll.select_cs();
            btnreset_Click(sender, e);
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            dgvcs.DataSource = bll.tim(txttencs.Text);
            delete_form();
        }

        private void btnDSDV_Click(object sender, EventArgs e)
        {
            qldv x = new qldv(txtmacs.Text,2);
            x.FormBorderStyle = FormBorderStyle.Sizable;
            x.Show();
            this.ParentForm.Hide();
        }
    }
}
