
namespace Quan_Ly_Doan_Vien.view
{
    partial class quenmk
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
            this.txttrl = new System.Windows.Forms.TextBox();
            this.btnqmk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.cbbch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Câu trả lời";
            // 
            // txttrl
            // 
            this.txttrl.Location = new System.Drawing.Point(309, 228);
            this.txttrl.Name = "txttrl";
            this.txttrl.Size = new System.Drawing.Size(180, 22);
            this.txttrl.TabIndex = 2;
            // 
            // btnqmk
            // 
            this.btnqmk.Location = new System.Drawing.Point(276, 339);
            this.btnqmk.Name = "btnqmk";
            this.btnqmk.Size = new System.Drawing.Size(84, 26);
            this.btnqmk.TabIndex = 3;
            this.btnqmk.Text = "Xác nhận";
            this.btnqmk.UseVisualStyleBackColor = true;
            this.btnqmk.Click += new System.EventHandler(this.btnqmk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Câu hỏi bảo mật";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên TK";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(309, 77);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(180, 22);
            this.txtname.TabIndex = 6;
            // 
            // cbbch
            // 
            this.cbbch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbch.FormattingEnabled = true;
            this.cbbch.Items.AddRange(new object[] {
            "Tên vật nuôi đầu tiên",
            "Tên giáo viên đầu tiên",
            "Tên thời thơ ấu của bạn",
            "Tên bạn thân nhất của bạn",
            "Tên ny của bạn"});
            this.cbbch.Location = new System.Drawing.Point(309, 151);
            this.cbbch.Name = "cbbch";
            this.cbbch.Size = new System.Drawing.Size(180, 24);
            this.cbbch.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mật khẩu";
            // 
            // txtmk
            // 
            this.txtmk.Enabled = false;
            this.txtmk.Location = new System.Drawing.Point(309, 280);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(180, 22);
            this.txtmk.TabIndex = 9;
            // 
            // quenmk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 426);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbch);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnqmk);
            this.Controls.Add(this.txttrl);
            this.Controls.Add(this.label1);
            this.Name = "quenmk";
            this.Text = "quenmk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.quenmk_FormClosed);
            this.Load += new System.EventHandler(this.quenmk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttrl;
        private System.Windows.Forms.Button btnqmk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cbbch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmk;
    }
}