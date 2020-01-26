namespace SeatBooking.forms
{
    partial class userfrm
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
            this.txGroupBox1 = new TX.Framework.WindowUI.Controls.TXGroupBox();
            this.UseDateCmbx = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.UseDatelbl = new System.Windows.Forms.Label();
            this.SeatNOCmbx = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.SeatNOlbl = new System.Windows.Forms.Label();
            this.DurationCmbx = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.StarttimeCmbx = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.starttimelbl = new System.Windows.Forms.Label();
            this.durationlbl = new System.Windows.Forms.Label();
            this.RoomNamelbl = new System.Windows.Forms.Label();
            this.RoomNOCmbx = new TX.Framework.WindowUI.Controls.TXComboBox();
            this.Bookingbtn = new TX.Framework.WindowUI.Controls.TXButton();
            this.txButton2 = new TX.Framework.WindowUI.Controls.TXButton();
            this.txGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txGroupBox1
            // 
            this.txGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.txGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txGroupBox1.CaptionColor = System.Drawing.Color.Black;
            this.txGroupBox1.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.txGroupBox1.Controls.Add(this.UseDateCmbx);
            this.txGroupBox1.Controls.Add(this.UseDatelbl);
            this.txGroupBox1.Controls.Add(this.SeatNOCmbx);
            this.txGroupBox1.Controls.Add(this.SeatNOlbl);
            this.txGroupBox1.Controls.Add(this.DurationCmbx);
            this.txGroupBox1.Controls.Add(this.StarttimeCmbx);
            this.txGroupBox1.Controls.Add(this.starttimelbl);
            this.txGroupBox1.Controls.Add(this.durationlbl);
            this.txGroupBox1.Controls.Add(this.RoomNamelbl);
            this.txGroupBox1.Controls.Add(this.RoomNOCmbx);
            this.txGroupBox1.Location = new System.Drawing.Point(23, 39);
            this.txGroupBox1.Name = "txGroupBox1";
            this.txGroupBox1.Size = new System.Drawing.Size(621, 324);
            this.txGroupBox1.TabIndex = 0;
            this.txGroupBox1.TabStop = false;
            this.txGroupBox1.Text = "空间预约";
            this.txGroupBox1.TextMargin = 6;
            // 
            // UseDateCmbx
            // 
            this.UseDateCmbx.FormattingEnabled = true;
            this.UseDateCmbx.Location = new System.Drawing.Point(150, 100);
            this.UseDateCmbx.Name = "UseDateCmbx";
            this.UseDateCmbx.Size = new System.Drawing.Size(288, 23);
            this.UseDateCmbx.TabIndex = 11;
            // 
            // UseDatelbl
            // 
            this.UseDatelbl.AutoSize = true;
            this.UseDatelbl.Location = new System.Drawing.Point(48, 101);
            this.UseDatelbl.Name = "UseDatelbl";
            this.UseDatelbl.Size = new System.Drawing.Size(67, 15);
            this.UseDatelbl.TabIndex = 10;
            this.UseDatelbl.Text = "使用日期";
            // 
            // SeatNOCmbx
            // 
            this.SeatNOCmbx.FormattingEnabled = true;
            this.SeatNOCmbx.Location = new System.Drawing.Point(150, 280);
            this.SeatNOCmbx.Name = "SeatNOCmbx";
            this.SeatNOCmbx.Size = new System.Drawing.Size(288, 23);
            this.SeatNOCmbx.TabIndex = 9;
            this.SeatNOCmbx.SelectedIndexChanged += new System.EventHandler(this.SeatNOCmbx_SelectedIndexChanged);
            // 
            // SeatNOlbl
            // 
            this.SeatNOlbl.AutoSize = true;
            this.SeatNOlbl.Location = new System.Drawing.Point(45, 284);
            this.SeatNOlbl.Name = "SeatNOlbl";
            this.SeatNOlbl.Size = new System.Drawing.Size(52, 15);
            this.SeatNOlbl.TabIndex = 8;
            this.SeatNOlbl.Text = "座位号";
            // 
            // DurationCmbx
            // 
            this.DurationCmbx.FormattingEnabled = true;
            this.DurationCmbx.Location = new System.Drawing.Point(150, 220);
            this.DurationCmbx.Name = "DurationCmbx";
            this.DurationCmbx.Size = new System.Drawing.Size(288, 23);
            this.DurationCmbx.TabIndex = 6;
            this.DurationCmbx.SelectedIndexChanged += new System.EventHandler(this.DurationCmbx_SelectedIndexChanged);
            // 
            // StarttimeCmbx
            // 
            this.StarttimeCmbx.FormattingEnabled = true;
            this.StarttimeCmbx.Location = new System.Drawing.Point(150, 160);
            this.StarttimeCmbx.Name = "StarttimeCmbx";
            this.StarttimeCmbx.Size = new System.Drawing.Size(288, 23);
            this.StarttimeCmbx.TabIndex = 5;
            this.StarttimeCmbx.SelectedIndexChanged += new System.EventHandler(this.StarttimeCmbx_SelectedIndexChanged);
            // 
            // starttimelbl
            // 
            this.starttimelbl.AutoSize = true;
            this.starttimelbl.Location = new System.Drawing.Point(45, 162);
            this.starttimelbl.Name = "starttimelbl";
            this.starttimelbl.Size = new System.Drawing.Size(67, 15);
            this.starttimelbl.TabIndex = 3;
            this.starttimelbl.Text = "开始时间";
            // 
            // durationlbl
            // 
            this.durationlbl.AutoSize = true;
            this.durationlbl.Location = new System.Drawing.Point(45, 223);
            this.durationlbl.Name = "durationlbl";
            this.durationlbl.Size = new System.Drawing.Size(67, 15);
            this.durationlbl.TabIndex = 2;
            this.durationlbl.Text = "使用时长";
            // 
            // RoomNamelbl
            // 
            this.RoomNamelbl.AutoSize = true;
            this.RoomNamelbl.Location = new System.Drawing.Point(45, 40);
            this.RoomNamelbl.Name = "RoomNamelbl";
            this.RoomNamelbl.Size = new System.Drawing.Size(52, 15);
            this.RoomNamelbl.TabIndex = 1;
            this.RoomNamelbl.Text = "自习室";
            // 
            // RoomNOCmbx
            // 
            this.RoomNOCmbx.FormattingEnabled = true;
            this.RoomNOCmbx.Items.AddRange(new object[] {
            "二楼北自习室(202)",
            "二楼南自习室(201)",
            "三楼南自习室(301)",
            "三楼北自习室(302)"});
            this.RoomNOCmbx.Location = new System.Drawing.Point(150, 40);
            this.RoomNOCmbx.Name = "RoomNOCmbx";
            this.RoomNOCmbx.Size = new System.Drawing.Size(288, 23);
            this.RoomNOCmbx.TabIndex = 0;
            this.RoomNOCmbx.SelectedIndexChanged += new System.EventHandler(this.RoomNOCmbx_SelectedIndexChanged);
            // 
            // Bookingbtn
            // 
            this.Bookingbtn.Image = null;
            this.Bookingbtn.Location = new System.Drawing.Point(125, 369);
            this.Bookingbtn.Name = "Bookingbtn";
            this.Bookingbtn.Size = new System.Drawing.Size(100, 28);
            this.Bookingbtn.TabIndex = 1;
            this.Bookingbtn.Text = "定时预约";
            this.Bookingbtn.UseVisualStyleBackColor = true;
            this.Bookingbtn.Click += new System.EventHandler(this.Bookingbtn_Click);
            // 
            // txButton2
            // 
            this.txButton2.Image = null;
            this.txButton2.Location = new System.Drawing.Point(361, 368);
            this.txButton2.Name = "txButton2";
            this.txButton2.Size = new System.Drawing.Size(100, 28);
            this.txButton2.TabIndex = 2;
            this.txButton2.Text = "取消";
            this.txButton2.UseVisualStyleBackColor = true;
            // 
            // userfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 407);
            this.Controls.Add(this.txButton2);
            this.Controls.Add(this.Bookingbtn);
            this.Controls.Add(this.txGroupBox1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(300, 50);
            this.Name = "userfrm";
            this.Text = "用户界面";
            this.Load += new System.EventHandler(this.userfrm_Load);
            this.txGroupBox1.ResumeLayout(false);
            this.txGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TX.Framework.WindowUI.Controls.TXGroupBox txGroupBox1;
        private TX.Framework.WindowUI.Controls.TXComboBox DurationCmbx;
        private TX.Framework.WindowUI.Controls.TXComboBox StarttimeCmbx;
        private System.Windows.Forms.Label starttimelbl;
        private System.Windows.Forms.Label durationlbl;
        private System.Windows.Forms.Label RoomNamelbl;
        private TX.Framework.WindowUI.Controls.TXComboBox RoomNOCmbx;
        private TX.Framework.WindowUI.Controls.TXButton Bookingbtn;
        private TX.Framework.WindowUI.Controls.TXButton txButton2;
        private System.Windows.Forms.Label SeatNOlbl;
        private TX.Framework.WindowUI.Controls.TXComboBox SeatNOCmbx;
        private TX.Framework.WindowUI.Controls.TXComboBox UseDateCmbx;
        private System.Windows.Forms.Label UseDatelbl;
    }
}