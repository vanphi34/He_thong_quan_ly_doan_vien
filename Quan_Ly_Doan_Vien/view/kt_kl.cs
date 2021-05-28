using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quan_Ly_Doan_Vien.view
{
    public partial class kt_kl : Form
    {
        private string messenger = "";
        BLL.BLL_ktkl bll = new BLL.BLL_ktkl();
        BLL.BLL_qldv blldv = new BLL.BLL_qldv();
        public kt_kl()
        {
            InitializeComponent();
        }

        public kt_kl(string mess) : this()
        {
            this.messenger = mess;
        }
        private void deleteform()
        {
            cbbkl.Text = "";
            cbbkt.Text = "";
            cbbmadv.Text = "";

        }
        private void kt_kl_Load(object sender, EventArgs e)
        {
            if(messenger.Equals(""))
            {
                dgvktkl.DataSource = bll.select_ktkl();
                cbbmadv.DataSource = blldv.select_dv();
                cbbmadv.DisplayMember = "madv";
                cbbmadv.ValueMember = "madv";
            }
            else
            {
                dgvktkl.DataSource = bll.tim(messenger);
                btnreset.Visible = false;
            }
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            bll.them(cbbmadv.Text, cbbkt.Text, cbbkl.Text);
            kt_kl_Load(sender, e);
            deleteform();
        }

        private void dgvktkl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbbmadv.Text = dgvktkl.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbbkt.Text = dgvktkl.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbbkl.Text = dgvktkl.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbbmadv.Enabled = false;
                btnsua.Enabled = true;
                btnthem.Enabled = false;
                btnxoa.Enabled = false;
                btninfo.Enabled = true;
                btnxoa.Enabled = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            deleteform();
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btninfo.Enabled = false;
            btnthem.Enabled = true;
            cbbmadv.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            bll.xoa(cbbmadv.Text);
            deleteform();
            kt_kl_Load(sender, e);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            bll.sua(cbbmadv.Text, cbbkt.Text, cbbkl.Text);
            kt_kl_Load(sender, e);
            deleteform();
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            qldv h = new qldv(cbbmadv.Text,1);
            h.FormBorderStyle = FormBorderStyle.Sizable;
            h.Show();
            h.btnthem.Visible = false;
            h.btntim.Visible = false;
            h.btnreset.Visible = false;
            this.ParentForm.Hide();
        }

        private void kt_kl_FormClosed(object sender, FormClosedEventArgs e)
        {

            login.idf.Show();
        }
    }
}
