namespace SeatBooking
{
    partial class logfrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.UserIDtxt = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.pwdtxt = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.UserIdlbl = new System.Windows.Forms.Label();
            this.pwdlbl = new System.Windows.Forms.Label();
            this.logbtn = new TX.Framework.WindowUI.Controls.TXButton();
            this.exitbtn = new TX.Framework.WindowUI.Controls.TXButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserIDtxt
            // 
            this.UserIDtxt.BackColor = System.Drawing.Color.Transparent;
            this.UserIDtxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.UserIDtxt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserIDtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UserIDtxt.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.UserIDtxt.Image = null;
            this.UserIDtxt.ImageSize = new System.Drawing.Size(0, 0);
            this.UserIDtxt.Location = new System.Drawing.Point(254, 224);
            this.UserIDtxt.Name = "UserIDtxt";
            this.UserIDtxt.Padding = new System.Windows.Forms.Padding(2);
            this.UserIDtxt.PasswordChar = '\0';
            this.UserIDtxt.Required = false;
            this.UserIDtxt.Size = new System.Drawing.Size(282, 25);
            this.UserIDtxt.TabIndex = 0;
            // 
            // pwdtxt
            // 
            this.pwdtxt.BackColor = System.Drawing.Color.Transparent;
            this.pwdtxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.pwdtxt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pwdtxt.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.pwdtxt.Image = null;
            this.pwdtxt.ImageSize = new System.Drawing.Size(0, 0);
            this.pwdtxt.Location = new System.Drawing.Point(254, 283);
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.Padding = new System.Windows.Forms.Padding(2);
            this.pwdtxt.PasswordChar = '*';
            this.pwdtxt.Required = false;
            this.pwdtxt.Size = new System.Drawing.Size(282, 25);
            this.pwdtxt.TabIndex = 1;
            // 
            // UserIdlbl
            // 
            this.UserIdlbl.AutoSize = true;
            this.UserIdlbl.Location = new System.Drawing.Point(184, 234);
            this.UserIdlbl.Name = "UserIdlbl";
            this.UserIdlbl.Size = new System.Drawing.Size(45, 15);
            this.UserIdlbl.TabIndex = 2;
            this.UserIdlbl.Text = "学号:";
            // 
            // pwdlbl
            // 
            this.pwdlbl.AutoSize = true;
            this.pwdlbl.Location = new System.Drawing.Point(184, 293);
            this.pwdlbl.Name = "pwdlbl";
            this.pwdlbl.Size = new System.Drawing.Size(45, 15);
            this.pwdlbl.TabIndex = 3;
            this.pwdlbl.Text = "密码:";
            // 
            // logbtn
            // 
            this.logbtn.Image = null;
            this.logbtn.Location = new System.Drawing.Point(224, 369);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(100, 28);
            this.logbtn.TabIndex = 4;
            this.logbtn.Text = "登录";
            this.logbtn.UseVisualStyleBackColor = true;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Image = null;
            this.exitbtn.Location = new System.Drawing.Point(436, 369);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(100, 28);
            this.exitbtn.TabIndex = 5;
            this.exitbtn.Text = "退出";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(254, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 164);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // logfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 426);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.logbtn);
            this.Controls.Add(this.pwdlbl);
            this.Controls.Add(this.UserIdlbl);
            this.Controls.Add(this.pwdtxt);
            this.Controls.Add(this.UserIDtxt);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(200, 50);
            this.Name = "logfrm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TX.Framework.WindowUI.Controls.TXTextBox UserIDtxt;
        private TX.Framework.WindowUI.Controls.TXTextBox pwdtxt;
        private System.Windows.Forms.Label UserIdlbl;
        private System.Windows.Forms.Label pwdlbl;
        private TX.Framework.WindowUI.Controls.TXButton logbtn;
        private TX.Framework.WindowUI.Controls.TXButton exitbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

