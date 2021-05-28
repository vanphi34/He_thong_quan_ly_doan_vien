
namespace Quan_Ly_Doan_Vien.view
{
    partial class qldv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvdv = new System.Windows.Forms.DataGridView();
            this.madv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayvaodoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lltt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdhv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmadv = new System.Windows.Forms.TextBox();
            this.txttendv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtns = new System.Windows.Forms.DateTimePicker();
            this.dtnvd = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnu = new System.Windows.Forms.RadioButton();
            this.rbnam = new System.Windows.Forms.RadioButton();
            this.cbbllct = new System.Windows.Forms.ComboBox();
            this.cbbtdhv = new System.Windows.Forms.ComboBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.cbbmacs = new System.Windows.Forms.ComboBox();
            this.btnktkl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdv
            // 
            this.dgvdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madv,
            this.macs,
            this.tendv,
            this.diachi,
            this.gioitinh,
            this.ngaysinh,
            this.sdt,
            this.ngayvaodoan,
            this.lltt,
            this.tdhv});
            this.dgvdv.Location = new System.Drawing.Point(12, 294);
            this.dgvdv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvdv.Name = "dgvdv";
            this.dgvdv.RowHeadersWidth = 51;
            this.dgvdv.RowTemplate.Height = 29;
            this.dgvdv.Size = new System.Drawing.Size(770, 138);
            this.dgvdv.TabIndex = 0;
            this.dgvdv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdv_CellClick);
            // 
            // madv
            // 
            this.madv.DataPropertyName = "madv";
            this.madv.HeaderText = "Mã ĐV";
            this.madv.MinimumWidth = 6;
            this.madv.Name = "madv";
            this.madv.Width = 125;
            // 
            // macs
            // 
            this.macs.DataPropertyName = "macs";
            this.macs.HeaderText = "Mã CS";
            this.macs.MinimumWidth = 6;
            this.macs.Name = "macs";
            this.macs.Width = 125;
            // 
            // tendv
            // 
            this.tendv.DataPropertyName = "tendv";
            this.tendv.HeaderText = "Tên ĐV";
            this.tendv.MinimumWidth = 6;
            this.tendv.Name = "tendv";
            this.tendv.Width = 125;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "SDT";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 125;
            // 
            // ngayvaodoan
            // 
            this.ngayvaodoan.DataPropertyName = "ngayvaodoan";
            this.ngayvaodoan.HeaderText = "Ngày vào đoàn";
            this.ngayvaodoan.MinimumWidth = 6;
            this.ngayvaodoan.Name = "ngayvaodoan";
            this.ngayvaodoan.Width = 125;
            // 
            // lltt
            // 
            this.lltt.DataPropertyName = "llct";
            this.lltt.HeaderText = "Lý luận chính trị";
            this.lltt.MinimumWidth = 6;
            this.lltt.Name = "lltt";
            this.lltt.Width = 125;
            // 
            // tdhv
            // 
            this.tdhv.DataPropertyName = "tdhv";
            this.tdhv.HeaderText = "Trình độ học vấn";
            this.tdhv.MinimumWidth = 6;
            this.tdhv.Name = "tdhv";
            this.tdhv.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã đoàn viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã cơ sở";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên đoàn viên";
            // 
            // txtmadv
            // 
            this.txtmadv.Location = new System.Drawing.Point(171, 23);
            this.txtmadv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmadv.Name = "txtmadv";
            this.txtmadv.Size = new System.Drawing.Size(151, 22);
            this.txtmadv.TabIndex = 100;
            // 
            // txttendv
            // 
            this.txttendv.Location = new System.Drawing.Point(171, 100);
            this.txttendv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttendv.Name = "txttendv";
            this.txttendv.Size = new System.Drawing.Size(151, 22);
            this.txttendv.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Trình độ học vấn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "SDT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(380, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ngày vào đoàn";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(171, 134);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(151, 22);
            this.txtdiachi.TabIndex = 103;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(522, 62);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(151, 22);
            this.txtsdt.TabIndex = 105;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Lý luận chính tri";
            // 
            // dtns
            // 
            this.dtns.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtns.Location = new System.Drawing.Point(522, 20);
            this.dtns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtns.Name = "dtns";
            this.dtns.Size = new System.Drawing.Size(151, 22);
            this.dtns.TabIndex = 104;
            // 
            // dtnvd
            // 
            this.dtnvd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtnvd.Location = new System.Drawing.Point(522, 94);
            this.dtnvd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtnvd.Name = "dtnvd";
            this.dtnvd.Size = new System.Drawing.Size(151, 22);
            this.dtnvd.TabIndex = 106;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnu);
            this.groupBox1.Controls.Add(this.rbnam);
            this.groupBox1.Location = new System.Drawing.Point(29, 174);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(293, 49);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // rbnu
            // 
            this.rbnu.AutoSize = true;
            this.rbnu.Location = new System.Drawing.Point(211, 21);
            this.rbnu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnu.Name = "rbnu";
            this.rbnu.Size = new System.Drawing.Size(47, 21);
            this.rbnu.TabIndex = 1;
            this.rbnu.TabStop = true;
            this.rbnu.Text = "Nữ";
            this.rbnu.UseVisualStyleBackColor = true;
            // 
            // rbnam
            // 
            this.rbnam.AutoSize = true;
            this.rbnam.Location = new System.Drawing.Point(92, 21);
            this.rbnam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnam.Name = "rbnam";
            this.rbnam.Size = new System.Drawing.Size(58, 21);
            this.rbnam.TabIndex = 0;
            this.rbnam.TabStop = true;
            this.rbnam.Text = "Nam";
            this.rbnam.UseVisualStyleBackColor = true;
            // 
            // cbbllct
            // 
            this.cbbllct.FormattingEnabled = true;
            this.cbbllct.Items.AddRange(new object[] {
            "Sơ cấp",
            "Trung cấp",
            "Cao cấp"});
            this.cbbllct.Location = new System.Drawing.Point(522, 134);
            this.cbbllct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbllct.Name = "cbbllct";
            this.cbbllct.Size = new System.Drawing.Size(151, 24);
            this.cbbllct.TabIndex = 107;
            // 
            // cbbtdhv
            // 
            this.cbbtdhv.FormattingEnabled = true;
            this.cbbtdhv.Items.AddRange(new object[] {
            "Phổ thông",
            "Trung cấp",
            "Cao đẳng",
            "Đại học",
            "Cao học"});
            this.cbbtdhv.Location = new System.Drawing.Point(522, 170);
            this.cbbtdhv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbtdhv.Name = "cbbtdhv";
            this.cbbtdhv.Size = new System.Drawing.Size(151, 24);
            this.cbbtdhv.TabIndex = 108;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(29, 240);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(94, 23);
            this.btnthem.TabIndex = 15;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Enabled = false;
            this.btnsua.Location = new System.Drawing.Point(145, 240);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(94, 23);
            this.btnsua.TabIndex = 109;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Enabled = false;
            this.btnxoa.Location = new System.Drawing.Point(271, 240);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(94, 23);
            this.btnxoa.TabIndex = 110;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(404, 240);
            this.btntim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(94, 23);
            this.btntim.TabIndex = 111;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(522, 240);
            this.btnreset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(94, 23);
            this.btnreset.TabIndex = 112;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // cbbmacs
            // 
            this.cbbmacs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmacs.FormattingEnabled = true;
            this.cbbmacs.Location = new System.Drawing.Point(171, 60);
            this.cbbmacs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbmacs.Name = "cbbmacs";
            this.cbbmacs.Size = new System.Drawing.Size(151, 24);
            this.cbbmacs.TabIndex = 101;
            // 
            // btnktkl
            // 
            this.btnktkl.Enabled = false;
            this.btnktkl.Location = new System.Drawing.Point(651, 240);
            this.btnktkl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnktkl.Name = "btnktkl";
            this.btnktkl.Size = new System.Drawing.Size(106, 40);
            this.btnktkl.TabIndex = 113;
            this.btnktkl.Text = "Khen thưởng kỉ luật";
            this.btnktkl.UseVisualStyleBackColor = true;
            this.btnktkl.Click += new System.EventHandler(this.btnktkl_Click);
            // 
            // qldv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 442);
            this.Controls.Add(this.btnktkl);
            this.Controls.Add(this.cbbmacs);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.cbbtdhv);
            this.Controls.Add(this.cbbllct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtnvd);
            this.Controls.Add(this.dtns);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttendv);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtmadv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "qldv";
            this.Text = "qldv";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.qldv_FormClosed);
            this.Load += new System.EventHandler(this.qldv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmadv;
        private System.Windows.Forms.TextBox txttendv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtns;
        private System.Windows.Forms.DateTimePicker dtnvd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnu;
        private System.Windows.Forms.RadioButton rbnam;
        private System.Windows.Forms.DataGridViewTextBoxColumn madv;
        private System.Windows.Forms.DataGridViewTextBoxColumn macs;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayvaodoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn lltt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdhv;
        private System.Windows.Forms.ComboBox cbbllct;
        private System.Windows.Forms.ComboBox cbbtdhv;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.ComboBox cbbmacs;
        public System.Windows.Forms.Button btnthem;
        public System.Windows.Forms.Button btntim;
        public System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnktkl;
    }
}