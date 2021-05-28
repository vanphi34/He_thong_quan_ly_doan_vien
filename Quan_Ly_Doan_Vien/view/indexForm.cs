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
    public partial class indexForm : Form
    {
        Point _imageLocation = new Point(20, 4);
        Point _imgHitArea = new Point(20, 4);
        Image closeImage;
        public indexForm()
        {
            InitializeComponent();
        }

        private void indexForm_Load(object sender, EventArgs e)
        {
           
            closeImage = Properties.Resources.icons8_macos_close_25__1_;
            tcmain.Padding = new Point(20, 4);
        }

        private void tcmain_DrawItem(object sender, DrawItemEventArgs e)
        {
            Image img = new Bitmap(closeImage);
            Rectangle r = e.Bounds;
            r = this.tcmain.GetTabRect(e.Index);
            r.Offset(2, 2);
            Brush TitleBrush = new SolidBrush(Color.Black);
            Font f = this.Font;
            string title = this.tcmain.TabPages[e.Index].Text;
            e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));
            e.Graphics.DrawImage(img, new Point(r.X + (this.tcmain.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y));
        }

        private void tcmain_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tcmain.GetTabRect(tabControl.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.tcmain.GetTabRect(tabControl.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (tcmain.SelectedIndex >= 1)
            {
                if (r.Contains(p))
                {
                    TabPage tabPage = (TabPage)tabControl.TabPages[tabControl.SelectedIndex];
                    tabControl.TabPages.Remove(tabPage);
                    
                }
            }
        }

        private void mntsqlcs_Click(object sender, EventArgs e)
        {
            TabPage myTabPage = new TabPage("Quản lý cơ sở");
            qlcs h = new qlcs();
            h.MdiParent = this;
            // h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            myTabPage.Controls.Add(h);
            h.BringToFront();
            h.Show();

            tcmain.TabPages.Add(myTabPage);
            tcmain.SelectTab(tcmain.TabPages.Count - 1);

        }

        private void mntsqldv_Click(object sender, EventArgs e)
        {
            TabPage myTabPage = new TabPage("Quản lý đoàn viên");
            qldv h = new qldv();
            h.MdiParent = this;
            // h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            myTabPage.Controls.Add(h);
            h.BringToFront();
            h.Show();

            tcmain.TabPages.Add(myTabPage);
            tcmain.SelectTab(tcmain.TabPages.Count-1);
        }

        private void mntsktkl_Click(object sender, EventArgs e)
        {
            TabPage myTabPage = new TabPage("Khen thưởng kỉ luật");
            kt_kl h = new kt_kl();
            h.MdiParent = this;
            // h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            myTabPage.Controls.Add(h);
            h.BringToFront();
            h.Show();

            tcmain.TabPages.Add(myTabPage);
            tcmain.SelectTab(tcmain.TabPages.Count - 1);
        }

        private void mntsdmk_Click(object sender, EventArgs e)
        {
            TabPage myTabPage = new TabPage("Đổi mật khẩu");
            changePass h = new changePass();
            h.MdiParent = this;
            // h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            myTabPage.Controls.Add(h);
            h.BringToFront();
            h.Show();

            tcmain.TabPages.Add(myTabPage);
            tcmain.SelectTab(tcmain.TabPages.Count - 1);
        }

        

        private void mntsdx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mntsttk_Click(object sender, EventArgs e)
        {
            TabPage myTabPage = new TabPage("Tạo tài khoản");
            createAcc h = new createAcc();
            h.MdiParent = this;
            // h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            myTabPage.Controls.Add(h);
            h.BringToFront();
            h.Show();

            tcmain.TabPages.Add(myTabPage);
            tcmain.SelectTab(tcmain.TabPages.Count - 1);
        }

        private void mntsqltk_Click(object sender, EventArgs e)
        {
            TabPage myTabPage = new TabPage("Quản lý Người dùng");
            QLTK h = new QLTK();
            h.MdiParent = this;
            // h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            myTabPage.Controls.Add(h);
            h.BringToFront();
            h.Show();

            tcmain.TabPages.Add(myTabPage);
            tcmain.SelectTab(tcmain.TabPages.Count - 1);
        }

      

        private void indexForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            login a = new login();
            a.Show();
            this.Hide();
            e.Cancel = true;
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage myTabPage = new TabPage("Cập nhật thông tin");
            update_info h = new update_info();
            h.MdiParent = this;
            // h.TopLevel = false;
            h.Dock = DockStyle.Fill;
            myTabPage.Controls.Add(h);
            h.BringToFront();
            h.Show();

            tcmain.TabPages.Add(myTabPage);
            tcmain.SelectTab(tcmain.TabPages.Count - 1);
        }
    }
}
