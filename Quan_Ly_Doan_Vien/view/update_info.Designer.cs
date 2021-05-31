
namespace Quan_Ly_Doan_Vien.view
{
    partial class update_info
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txttraloi = new System.Windows.Forms.TextBox();
            this.cbbcauhoi = new System.Windows.Forms.ComboBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtxacnhan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Câu hỏi bảo mật";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Câu trả lời";
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(328, 82);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(252, 22);
            this.txtname.TabIndex = 5;
            // 
            // txttraloi
            // 
            this.txttraloi.Location = new System.Drawing.Point(328, 184);
            this.txttraloi.Name = "txttraloi";
            this.txttraloi.Size = new System.Drawing.Size(252, 22);
            this.txttraloi.TabIndex = 8;
            // 
            // cbbcauhoi
            // 
            this.cbbcauhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbcauhoi.FormattingEnabled = true;
            this.cbbcauhoi.Items.AddRange(new object[] {
            "Tên vật nuôi đầu tiên",
            "Tên giáo viên đầu tiên",
            "Tên thời thơ ấu của bạn",
            "Tên bạn thân nhất của bạn",
            "Tên ny của bạn"});
            this.cbbcauhoi.Location = new System.Drawing.Point(328, 133);
            this.cbbcauhoi.Name = "cbbcauhoi";
            this.cbbcauhoi.Size = new System.Drawing.Size(252, 24);
            this.cbbcauhoi.TabIndex = 9;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(328, 285);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(102, 29);
            this.btnsua.TabIndex = 10;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Xác nhận mật khẩu";
            // 
            // txtxacnhan
            // 
            this.txtxacnhan.Location = new System.Drawing.Point(328, 227);
            this.txtxacnhan.Name = "txtxacnhan";
            this.txtxacnhan.Size = new System.Drawing.Size(252, 22);
            this.txtxacnhan.TabIndex = 12;
            // 
            // update_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 367);
            this.Controls.Add(this.txtxacnhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.cbbcauhoi);
            this.Controls.Add(this.txttraloi);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "update_info";
            this.Text = "update_info";
            this.Load += new System.EventHandler(this.update_info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttraloi;
        private System.Windows.Forms.ComboBox cbbcauhoi;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtxacnhan;
    }
}