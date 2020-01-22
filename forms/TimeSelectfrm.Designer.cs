namespace StudyingApp.forms
{
    partial class TimeSelectfrm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Datelbl = new System.Windows.Forms.Label();
            this.Bookingbtn = new TX.Framework.WindowUI.Controls.TXButton();
            this.Cancelbtn = new TX.Framework.WindowUI.Controls.TXButton();
            this.hour = new System.Windows.Forms.Label();
            this.minute = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.Hour_selCmbx = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.Minute_selCmbx = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.Second_selCmbx = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.txGroupBox1 = new TX.Framework.WindowUI.Controls.TXGroupBox();
            this.NowBookingbtn = new TX.Framework.WindowUI.Controls.TXButton();
            this.txGroupBox2 = new TX.Framework.WindowUI.Controls.TXGroupBox();
            this.TimeCounttxt = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.txGroupBox1.SuspendLayout();
            this.txGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 25);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Location = new System.Drawing.Point(24, 53);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(37, 15);
            this.Datelbl.TabIndex = 1;
            this.Datelbl.Text = "日期";
            // 
            // Bookingbtn
            // 
            this.Bookingbtn.Image = null;
            this.Bookingbtn.Location = new System.Drawing.Point(179, 260);
            this.Bookingbtn.Name = "Bookingbtn";
            this.Bookingbtn.Size = new System.Drawing.Size(100, 28);
            this.Bookingbtn.TabIndex = 2;
            this.Bookingbtn.Text = "确定";
            this.Bookingbtn.UseVisualStyleBackColor = true;
            this.Bookingbtn.Click += new System.EventHandler(this.Bookingbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Image = null;
            this.Cancelbtn.Location = new System.Drawing.Point(330, 260);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(100, 28);
            this.Cancelbtn.TabIndex = 3;
            this.Cancelbtn.Text = "取消";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.Location = new System.Drawing.Point(24, 102);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(22, 15);
            this.hour.TabIndex = 4;
            this.hour.Text = "时";
            // 
            // minute
            // 
            this.minute.AutoSize = true;
            this.minute.Location = new System.Drawing.Point(24, 151);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(22, 15);
            this.minute.TabIndex = 5;
            this.minute.Text = "分";
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Location = new System.Drawing.Point(24, 200);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(22, 15);
            this.second.TabIndex = 6;
            this.second.Text = "秒";
            // 
            // Hour_selCmbx
            // 
            this.Hour_selCmbx.FormattingEnabled = true;
            this.Hour_selCmbx.Location = new System.Drawing.Point(99, 96);
            this.Hour_selCmbx.Name = "Hour_selCmbx";
            this.Hour_selCmbx.Size = new System.Drawing.Size(192, 23);
            this.Hour_selCmbx.TabIndex = 7;
            // 
            // Minute_selCmbx
            // 
            this.Minute_selCmbx.FormattingEnabled = true;
            this.Minute_selCmbx.Location = new System.Drawing.Point(99, 147);
            this.Minute_selCmbx.Name = "Minute_selCmbx";
            this.Minute_selCmbx.Size = new System.Drawing.Size(192, 23);
            this.Minute_selCmbx.TabIndex = 8;
            // 
            // Second_selCmbx
            // 
            this.Second_selCmbx.FormattingEnabled = true;
            this.Second_selCmbx.Location = new System.Drawing.Point(99, 197);
            this.Second_selCmbx.Name = "Second_selCmbx";
            this.Second_selCmbx.Size = new System.Drawing.Size(192, 23);
            this.Second_selCmbx.TabIndex = 9;
            // 
            // txGroupBox1
            // 
            this.txGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.txGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txGroupBox1.CaptionColor = System.Drawing.Color.Black;
            this.txGroupBox1.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.txGroupBox1.Controls.Add(this.NowBookingbtn);
            this.txGroupBox1.Controls.Add(this.dateTimePicker1);
            this.txGroupBox1.Controls.Add(this.Bookingbtn);
            this.txGroupBox1.Controls.Add(this.Cancelbtn);
            this.txGroupBox1.Controls.Add(this.Second_selCmbx);
            this.txGroupBox1.Controls.Add(this.Datelbl);
            this.txGroupBox1.Controls.Add(this.second);
            this.txGroupBox1.Controls.Add(this.Minute_selCmbx);
            this.txGroupBox1.Controls.Add(this.Hour_selCmbx);
            this.txGroupBox1.Controls.Add(this.hour);
            this.txGroupBox1.Controls.Add(this.minute);
            this.txGroupBox1.Location = new System.Drawing.Point(36, 47);
            this.txGroupBox1.Name = "txGroupBox1";
            this.txGroupBox1.Size = new System.Drawing.Size(605, 306);
            this.txGroupBox1.TabIndex = 10;
            this.txGroupBox1.TabStop = false;
            this.txGroupBox1.Text = "选择时间";
            this.txGroupBox1.TextMargin = 6;
            // 
            // NowBookingbtn
            // 
            this.NowBookingbtn.Image = null;
            this.NowBookingbtn.Location = new System.Drawing.Point(27, 260);
            this.NowBookingbtn.Name = "NowBookingbtn";
            this.NowBookingbtn.Size = new System.Drawing.Size(110, 28);
            this.NowBookingbtn.TabIndex = 10;
            this.NowBookingbtn.Text = "当前时间预约";
            this.NowBookingbtn.UseVisualStyleBackColor = true;
            this.NowBookingbtn.Click += new System.EventHandler(this.NowBookingbtn_Click);
            // 
            // txGroupBox2
            // 
            this.txGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.txGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txGroupBox2.CaptionColor = System.Drawing.Color.Black;
            this.txGroupBox2.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.txGroupBox2.Controls.Add(this.TimeCounttxt);
            this.txGroupBox2.Location = new System.Drawing.Point(36, 360);
            this.txGroupBox2.Name = "txGroupBox2";
            this.txGroupBox2.Size = new System.Drawing.Size(605, 73);
            this.txGroupBox2.TabIndex = 11;
            this.txGroupBox2.TabStop = false;
            this.txGroupBox2.Text = "倒计时";
            this.txGroupBox2.TextMargin = 6;
            // 
            // TimeCounttxt
            // 
            this.TimeCounttxt.BackColor = System.Drawing.Color.Transparent;
            this.TimeCounttxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.TimeCounttxt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeCounttxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TimeCounttxt.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.TimeCounttxt.Image = null;
            this.TimeCounttxt.ImageSize = new System.Drawing.Size(0, 0);
            this.TimeCounttxt.Location = new System.Drawing.Point(27, 24);
            this.TimeCounttxt.Name = "TimeCounttxt";
            this.TimeCounttxt.Padding = new System.Windows.Forms.Padding(2);
            this.TimeCounttxt.PasswordChar = '\0';
            this.TimeCounttxt.Required = false;
            this.TimeCounttxt.Size = new System.Drawing.Size(456, 25);
            this.TimeCounttxt.TabIndex = 0;
            // 
            // TimeSelectfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 448);
            this.Controls.Add(this.txGroupBox2);
            this.Controls.Add(this.txGroupBox1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(400, 50);
            this.Name = "TimeSelectfrm";
            this.Text = "选择预约时间";
            this.Load += new System.EventHandler(this.TimeSelectfrm_Load);
            this.txGroupBox1.ResumeLayout(false);
            this.txGroupBox1.PerformLayout();
            this.txGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Datelbl;
        private TX.Framework.WindowUI.Controls.TXButton Bookingbtn;
        private TX.Framework.WindowUI.Controls.TXButton Cancelbtn;
        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.Label minute;
        private System.Windows.Forms.Label second;
        private TX.Framework.WindowUI.Controls.TXComboBox Hour_selCmbx;
        private TX.Framework.WindowUI.Controls.TXComboBox Minute_selCmbx;
        private TX.Framework.WindowUI.Controls.TXComboBox Second_selCmbx;
        private TX.Framework.WindowUI.Controls.TXGroupBox txGroupBox1;
        private TX.Framework.WindowUI.Controls.TXGroupBox txGroupBox2;
        private TX.Framework.WindowUI.Controls.TXTextBox TimeCounttxt;
        private TX.Framework.WindowUI.Controls.TXButton NowBookingbtn;
    }
}