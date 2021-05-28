
namespace Quan_Ly_Doan_Vien.view
{
    partial class qlcs
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
            this.dgvcs = new System.Windows.Forms.DataGridView();
            this.macs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmacs = new System.Windows.Forms.TextBox();
            this.txttencs = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.btnDSDV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcs
            // 
            this.dgvcs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macs,
            this.tencs,
            this.diachi});
            this.dgvcs.Location = new System.Drawing.Point(12, 268);
            this.dgvcs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvcs.Name = "dgvcs";
            this.dgvcs.RowHeadersWidth = 51;
            this.dgvcs.RowTemplate.Height = 29;
            this.dgvcs.Size = new System.Drawing.Size(758, 149);
            this.dgvcs.TabIndex = 0;
            this.dgvcs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcs_CellClick);
            // 
            // macs
            // 
            this.macs.DataPropertyName = "macs";
            this.macs.HeaderText = "Mã cơ sở";
            this.macs.MinimumWidth = 6;
            this.macs.Name = "macs";
            this.macs.Width = 200;
            // 
            // tencs
            // 
            this.tencs.DataPropertyName = "tencs";
            this.tencs.HeaderText = "Tên cơ sở";
            this.tencs.MinimumWidth = 6;
            this.tencs.Name = "tencs";
            this.tencs.Width = 250;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã cơ sở";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên cơ sở";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ";
            // 
            // txtmacs
            // 
            this.txtmacs.Location = new System.Drawing.Point(233, 44);
            this.txtmacs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmacs.Name = "txtmacs";
            this.txtmacs.Size = new System.Drawing.Size(199, 22);
            this.txtmacs.TabIndex = 4;
            // 
            // txttencs
            // 
            this.txttencs.Location = new System.Drawing.Point(233, 82);
            this.txttencs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttencs.Name = "txttencs";
            this.txttencs.Size = new System.Drawing.Size(199, 22);
            this.txttencs.TabIndex = 5;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(233, 122);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(199, 22);
            this.txtdiachi.TabIndex = 6;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(578, 34);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(116, 23);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Enabled = false;
            this.btnsua.Location = new System.Drawing.Point(578, 87);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(116, 23);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Enabled = false;
            this.btnxoa.Location = new System.Drawing.Point(578, 144);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(116, 23);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(390, 190);
            this.btnreset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(94, 23);
            this.btnreset.TabIndex = 10;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(118, 190);
            this.btntim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(94, 23);
            this.btntim.TabIndex = 11;
            this.btntim.Text = "tìm kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnDSDV
            // 
            this.btnDSDV.Location = new System.Drawing.Point(578, 190);
            this.btnDSDV.Name = "btnDSDV";
            this.btnDSDV.Size = new System.Drawing.Size(116, 23);
            this.btnDSDV.TabIndex = 12;
            this.btnDSDV.Text = "Danh sách ĐV";
            this.btnDSDV.UseVisualStyleBackColor = true;
            this.btnDSDV.Click += new System.EventHandler(this.btnDSDV_Click);
            // 
            // qlcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 426);
            this.Controls.Add(this.btnDSDV);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttencs);
            this.Controls.Add(this.txtmacs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvcs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "qlcs";
            this.Load += new System.EventHandler(this.qlcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmacs;
        private System.Windows.Forms.TextBox txttencs;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.DataGridViewTextBoxColumn macs;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencs;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.Button btnDSDV;
    }
}