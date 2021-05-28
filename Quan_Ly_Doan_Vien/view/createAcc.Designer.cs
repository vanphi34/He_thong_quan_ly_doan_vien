
namespace Quan_Ly_Doan_Vien.view
{
    partial class createAcc
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btntao = new System.Windows.Forms.Button();
            this.cbhienthipass = new System.Windows.Forms.CheckBox();
            this.cbbphamvi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phạm vi";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(215, 63);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(163, 27);
            this.txtname.TabIndex = 1;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(215, 108);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(163, 27);
            this.txtpass.TabIndex = 2;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // btntao
            // 
            this.btntao.Location = new System.Drawing.Point(240, 258);
            this.btntao.Name = "btntao";
            this.btntao.Size = new System.Drawing.Size(94, 29);
            this.btntao.TabIndex = 4;
            this.btntao.Text = "Tạo";
            this.btntao.UseVisualStyleBackColor = true;
            this.btntao.Click += new System.EventHandler(this.btntao_Click);
            // 
            // cbhienthipass
            // 
            this.cbhienthipass.AutoSize = true;
            this.cbhienthipass.Location = new System.Drawing.Point(215, 203);
            this.cbhienthipass.Name = "cbhienthipass";
            this.cbhienthipass.Size = new System.Drawing.Size(148, 24);
            this.cbhienthipass.TabIndex = 5;
            this.cbhienthipass.Text = "Hiển thị mật khẩu";
            this.cbhienthipass.UseVisualStyleBackColor = true;
            this.cbhienthipass.CheckedChanged += new System.EventHandler(this.cbhienthipass_CheckedChanged);
            // 
            // cbbphamvi
            // 
            this.cbbphamvi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbphamvi.FormattingEnabled = true;
            this.cbbphamvi.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.cbbphamvi.Location = new System.Drawing.Point(215, 146);
            this.cbbphamvi.Name = "cbbphamvi";
            this.cbbphamvi.Size = new System.Drawing.Size(163, 28);
            this.cbbphamvi.TabIndex = 6;
            // 
            // createAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 353);
            this.Controls.Add(this.cbbphamvi);
            this.Controls.Add(this.cbhienthipass);
            this.Controls.Add(this.btntao);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "createAcc";
            this.Text = "createAcc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btntao;
        private System.Windows.Forms.CheckBox cbhienthipass;
        private System.Windows.Forms.ComboBox cbbphamvi;
    }
}