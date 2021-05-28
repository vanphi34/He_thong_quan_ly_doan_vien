
namespace Quan_Ly_Doan_Vien.view
{
    partial class kt_kl
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvktkl = new System.Windows.Forms.DataGridView();
            this.madv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khenthuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiluat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbmadv = new System.Windows.Forms.ComboBox();
            this.cbbkt = new System.Windows.Forms.ComboBox();
            this.cbbkl = new System.Windows.Forms.ComboBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btninfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvktkl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đoàn viên";
            // 
            // dgvktkl
            // 
            this.dgvktkl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvktkl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madv,
            this.khenthuong,
            this.kiluat});
            this.dgvktkl.Location = new System.Drawing.Point(12, 306);
            this.dgvktkl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvktkl.Name = "dgvktkl";
            this.dgvktkl.RowHeadersWidth = 51;
            this.dgvktkl.RowTemplate.Height = 29;
            this.dgvktkl.Size = new System.Drawing.Size(755, 150);
            this.dgvktkl.TabIndex = 1;
            this.dgvktkl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvktkl_CellClick);
            // 
            // madv
            // 
            this.madv.DataPropertyName = "madv";
            this.madv.HeaderText = "Mã Đoàn Viên";
            this.madv.MinimumWidth = 6;
            this.madv.Name = "madv";
            this.madv.Width = 200;
            // 
            // khenthuong
            // 
            this.khenthuong.DataPropertyName = "khenthuong";
            this.khenthuong.HeaderText = "Khen thưởng";
            this.khenthuong.MinimumWidth = 6;
            this.khenthuong.Name = "khenthuong";
            this.khenthuong.Width = 250;
            // 
            // kiluat
            // 
            this.kiluat.DataPropertyName = "kiluat";
            this.kiluat.HeaderText = "Kỉ luật";
            this.kiluat.MinimumWidth = 6;
            this.kiluat.Name = "kiluat";
            this.kiluat.Width = 250;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khen thưởng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kỉ luật";
            // 
            // cbbmadv
            // 
            this.cbbmadv.FormattingEnabled = true;
            this.cbbmadv.Location = new System.Drawing.Point(236, 59);
            this.cbbmadv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbmadv.Name = "cbbmadv";
            this.cbbmadv.Size = new System.Drawing.Size(174, 24);
            this.cbbmadv.TabIndex = 4;
            // 
            // cbbkt
            // 
            this.cbbkt.FormattingEnabled = true;
            this.cbbkt.Location = new System.Drawing.Point(236, 106);
            this.cbbkt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbkt.Name = "cbbkt";
            this.cbbkt.Size = new System.Drawing.Size(174, 24);
            this.cbbkt.TabIndex = 5;
            // 
            // cbbkl
            // 
            this.cbbkl.FormattingEnabled = true;
            this.cbbkl.Location = new System.Drawing.Point(236, 150);
            this.cbbkl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbkl.Name = "cbbkl";
            this.cbbkl.Size = new System.Drawing.Size(174, 24);
            this.cbbkl.TabIndex = 6;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(577, 56);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(94, 23);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Enabled = false;
            this.btnsua.Location = new System.Drawing.Point(577, 98);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(94, 23);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Enabled = false;
            this.btnxoa.Location = new System.Drawing.Point(577, 150);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(94, 23);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(577, 200);
            this.btnreset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(94, 23);
            this.btnreset.TabIndex = 10;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btninfo
            // 
            this.btninfo.Enabled = false;
            this.btninfo.Location = new System.Drawing.Point(577, 238);
            this.btninfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(94, 51);
            this.btninfo.TabIndex = 11;
            this.btninfo.Text = "Thông tin đoàn viên";
            this.btninfo.UseVisualStyleBackColor = true;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // kt_kl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 442);
            this.Controls.Add(this.btninfo);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.cbbkl);
            this.Controls.Add(this.cbbkt);
            this.Controls.Add(this.cbbmadv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvktkl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "kt_kl";
            this.Text = "kt_kl";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.kt_kl_FormClosed);
            this.Load += new System.EventHandler(this.kt_kl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvktkl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvktkl;
        private System.Windows.Forms.DataGridViewTextBoxColumn madv;
        private System.Windows.Forms.DataGridViewTextBoxColumn khenthuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiluat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbkt;
        private System.Windows.Forms.ComboBox cbbkl;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.ComboBox cbbmadv;
        public System.Windows.Forms.Button btnthem;
        public System.Windows.Forms.Button btninfo;
    }
}