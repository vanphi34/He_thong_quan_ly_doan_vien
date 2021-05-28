using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quan_Ly_Doan_Vien.view
{
    public partial class qldv : Form
    {
        private string messenger = "";
        int a;
        BLL.BLL_qldv bll = new BLL.BLL_qldv();
        BLL.BLL_qlcs bllcs = new BLL.BLL_qlcs();
        BLL.BLL_ktkl bllktkl = new BLL.BLL_ktkl();
        public qldv()
        {
            InitializeComponent();
        }

        public qldv(string mess , int a) : this(){
            messenger = mess;
            this.a = a;
        }

        private void deleteform()
        {
            txtmadv.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();
            txttendv.Clear();
            rbnam.Checked = false;
            rbnu.Checked = false;
            cbbllct.Text = "";
            cbbmacs.Text = "";
            cbbtdhv.Text = "";
            dtns.Text = "";
            dtnvd.Text = "";
        }

        private void dgvdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtmadv.Text = dgvdv.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbbmacs.Text = dgvdv.Rows[e.RowIndex].Cells[1].Value.ToString();
                txttendv.Text = dgvdv.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtdiachi.Text = dgvdv.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (dgvdv.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("nam"))
                    rbnam.Checked = true;
                if (dgvdv.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("nữ"))
                    rbnu.Checked = true;
                dtns.Text = dgvdv.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtsdt.Text = dgvdv.Rows[e.RowIndex].Cells[6].Value.ToString();
                dtnvd.Text = dgvdv.Rows[e.RowIndex].Cells[7].Value.ToString();
                cbbllct.Text = dgvdv.Rows[e.RowIndex].Cells[8].Value.ToString();
                cbbtdhv.Text = dgvdv.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtmadv.Enabled = false;
                btnthem.Enabled = false;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btnktkl.Enabled = true;

            }
            catch(Exception exx)
            {
                MessageBox.Show(exx.Message);
            }

        }

        private void qldv_Load(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                dgvdv.DataSource = bll.select_dv();
                cbbmacs.DataSource = bllcs.select_cs();
                cbbmacs.DisplayMember = "macs";
                cbbmacs.ValueMember = "macs";
            }
            else if(a == 1)
            {
                btnktkl.Visible = false;
                dgvdv.DataSource = bll.timma(messenger);
                cbbmacs.DataSource = bllcs.select_cs();
                cbbmacs.DisplayMember = "macs";
                cbbmacs.ValueMember = "macs";
                //xu ly doan nay 
                
                /*txtmadv.Text = dgvdv.Rows[0].Cells[0].Value.ToString();
                cbbmacs.Text = dgvdv.Rows[0].Cells[1].Value.ToString();
                txttendv.Text = dgvdv.Rows[0].Cells[2].Value.ToString();
                txtdiachi.Text = dgvdv.Rows[0].Cells[5].Value.ToString();
                if (dgvdv.Rows[0].Cells[4].Value.ToString().Equals("nam"))
                    rbnam.Checked = true;
                if (dgvdv.Rows[0].Cells[4].Value.ToString().Equals("nữ"))
                    rbnu.Checked = true;

                dtns.Text = dgvdv.Rows[0].Cells[3].Value.ToString();
                txtsdt.Text = dgvdv.Rows[0].Cells[6].Value.ToString();
                dtnvd.Text = dgvdv.Rows[0].Cells[7].Value.ToString();
                cbbllct.Text = dgvdv.Rows[0].Cells[8].Value.ToString();
                cbbtdhv.Text = dgvdv.Rows[0].Cells[9].Value.ToString();*/
            }
            else
            {
                dgvdv.DataSource = bll.loc_cs(messenger);
                cbbmacs.Text = messenger;
                btnktkl.Visible = false;
                btnthem.Visible = false;
                btntim.Visible = false;
            }
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (rbnam.Checked)
            {
                gt = "nam";
            }
            if (rbnu.Checked)
            {
                gt = "nữ";
            }
            if (bll.them(txtmadv.Text, cbbmacs.Text, txttendv.Text, txtdiachi.Text, gt, dtns.Value.ToString(), txtsdt.Text, dtnvd.Value.ToString(), cbbllct.Text, cbbtdhv.Text))
            {
                qldv_Load(sender, e);
                deleteform();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            bll.xoa(txtmadv.Text);
            qldv_Load(sender, e);
            deleteform();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            deleteform();
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            txtmadv.Enabled = true;
            btnktkl.Enabled = false;
            qldv_Load(sender, e);

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (rbnam.Checked)
                gt = "nam";
            if (rbnu.Checked)
                gt = "nữ";
            bll.sua(txtmadv.Text, cbbmacs.Text, txttendv.Text, txtdiachi.Text, gt, dtns.Value, txtsdt.Text, dtnvd.Value, cbbllct.Text, cbbtdhv.Text);
            qldv_Load(sender, e);
            deleteform();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
           dgvdv.DataSource =  bll.tim(txttendv.Text,cbbmacs.Text);
        }

        private void qldv_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            login.idf.Show();
            
        }

        private void btnktkl_Click(object sender, EventArgs e)
        {
            if (bllktkl.check(txtmadv.Text))
            {
                kt_kl c = new kt_kl(txtmadv.Text);
                c.Show();
                c.FormBorderStyle = FormBorderStyle.Sizable;
                c.btninfo.Visible = false;
                c.btnthem.Visible = false;
                this.ParentForm.Hide();
            }
            else
            {
                MessageBox.Show("Đoàn viên này không có khen thưởng, kỉ luật!");
            }
            
        }
    }
}
