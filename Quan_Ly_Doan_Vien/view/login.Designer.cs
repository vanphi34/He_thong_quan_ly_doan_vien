
namespace Quan_Ly_Doan_Vien
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblusename = new System.Windows.Forms.Label();
            this.txt_usename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.cbhtmk = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblqmk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblusename
            // 
            this.lblusename.AutoSize = true;
            this.lblusename.Location = new System.Drawing.Point(63, 37);
            this.lblusename.Name = "lblusename";
            this.lblusename.Size = new System.Drawing.Size(66, 17);
            this.lblusename.TabIndex = 0;
            this.lblusename.Text = "usename";
            // 
            // txt_usename
            // 
            this.txt_usename.Location = new System.Drawing.Point(189, 34);
            this.txt_usename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_usename.Name = "txt_usename";
            this.txt_usename.Size = new System.Drawing.Size(145, 22);
            this.txt_usename.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "password";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(189, 77);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(145, 22);
            this.txt_password.TabIndex = 101;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(95, 150);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(91, 29);
            this.btn_login.TabIndex = 102;
            this.btn_login.Text = "Login";
            this.btn_login.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // cbhtmk
            // 
            this.cbhtmk.AutoSize = true;
            this.cbhtmk.Location = new System.Drawing.Point(189, 117);
            this.cbhtmk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbhtmk.Name = "cbhtmk";
            this.cbhtmk.Size = new System.Drawing.Size(128, 21);
            this.cbhtmk.TabIndex = 103;
            this.cbhtmk.Text = "Show password";
            this.cbhtmk.UseVisualStyleBackColor = true;
            this.cbhtmk.CheckedChanged += new System.EventHandler(this.cbhtmk_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 150);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 104;
            this.button1.Text = "Close";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblqmk
            // 
            this.lblqmk.AutoSize = true;
            this.lblqmk.BackColor = System.Drawing.SystemColors.Control;
            this.lblqmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblqmk.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblqmk.Location = new System.Drawing.Point(360, 80);
            this.lblqmk.Name = "lblqmk";
            this.lblqmk.Size = new System.Drawing.Size(113, 17);
            this.lblqmk.TabIndex = 105;
            this.lblqmk.Text = "Quên mật khẩu?";
            this.lblqmk.Click += new System.EventHandler(this.lblqmk_Click);
            this.lblqmk.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 214);
            this.Controls.Add(this.lblqmk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbhtmk);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_usename);
            this.Controls.Add(this.lblusename);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusename;
        private System.Windows.Forms.TextBox txt_usename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox cbhtmk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblqmk;
    }
}

