namespace demo02
{
    partial class nhanvien
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btThongTinCaNhan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.nv_DatTraPhong1 = new demo02.UseControl.nv_DatTraPhong();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbUsenameLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 50);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(21, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(161, 22);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Quản Lý Khách Sạn";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.LightGray;
            this.guna2Panel2.Controls.Add(this.btDangXuat);
            this.guna2Panel2.Controls.Add(this.btThongTinCaNhan);
            this.guna2Panel2.Controls.Add(this.guna2Button2);
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 50);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(200, 961);
            this.guna2Panel2.TabIndex = 1;
            // 
            // btDangXuat
            // 
            this.btDangXuat.Animated = true;
            this.btDangXuat.AutoRoundedCorners = true;
            this.btDangXuat.BorderRadius = 13;
            this.btDangXuat.DefaultAutoSize = true;
            this.btDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDangXuat.FillColor = System.Drawing.Color.Red;
            this.btDangXuat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangXuat.ForeColor = System.Drawing.Color.White;
            this.btDangXuat.Location = new System.Drawing.Point(49, 921);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(90, 28);
            this.btDangXuat.TabIndex = 3;
            this.btDangXuat.Text = "Đăng xuất";
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
            // 
            // btThongTinCaNhan
            // 
            this.btThongTinCaNhan.Animated = true;
            this.btThongTinCaNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btThongTinCaNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btThongTinCaNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btThongTinCaNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btThongTinCaNhan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btThongTinCaNhan.ForeColor = System.Drawing.Color.White;
            this.btThongTinCaNhan.Location = new System.Drawing.Point(12, 109);
            this.btThongTinCaNhan.Name = "btThongTinCaNhan";
            this.btThongTinCaNhan.Size = new System.Drawing.Size(180, 40);
            this.btThongTinCaNhan.TabIndex = 2;
            this.btThongTinCaNhan.Text = "Thông tin cá nhân";
            this.btThongTinCaNhan.Click += new System.EventHandler(this.btThongTinCaNhan_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(12, 63);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 40);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "Thông tin khách hàng";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(12, 17);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 40);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Đặt / Trả Phòng";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.nv_DatTraPhong1);
            this.guna2Panel3.Location = new System.Drawing.Point(206, 50);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1698, 961);
            this.guna2Panel3.TabIndex = 2;
            // 
            // nv_DatTraPhong1
            // 
            this.nv_DatTraPhong1.Location = new System.Drawing.Point(0, 0);
            this.nv_DatTraPhong1.Name = "nv_DatTraPhong1";
            this.nv_DatTraPhong1.Size = new System.Drawing.Size(1698, 961);
            this.nv_DatTraPhong1.TabIndex = 0;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.guna2Panel4.Controls.Add(this.lbUsenameLogin);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel4.Location = new System.Drawing.Point(206, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1698, 50);
            this.guna2Panel4.TabIndex = 1;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(690, 3);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(246, 46);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "May Plaza Hotel";
            // 
            // lbUsenameLogin
            // 
            this.lbUsenameLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbUsenameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsenameLogin.ForeColor = System.Drawing.Color.White;
            this.lbUsenameLogin.Location = new System.Drawing.Point(1519, 12);
            this.lbUsenameLogin.Name = "lbUsenameLogin";
            this.lbUsenameLogin.Size = new System.Drawing.Size(120, 22);
            this.lbUsenameLogin.TabIndex = 1;
            this.lbUsenameLogin.Text = "usenameLogin";
            // 
            // nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1011);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "nhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button btThongTinCaNhan;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btDangXuat;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private UseControl.nv_DatTraPhong nv_DatTraPhong1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbUsenameLogin;
    }
}