namespace demo02
{
    partial class Login
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
            this.btDangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.tbTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbSaiTaiKhoan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbVaiTro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btDangNhap
            // 
            this.btDangNhap.Animated = true;
            this.btDangNhap.AutoRoundedCorners = true;
            this.btDangNhap.BorderRadius = 17;
            this.btDangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btDangNhap.ForeColor = System.Drawing.Color.White;
            this.btDangNhap.Location = new System.Drawing.Point(523, 270);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(123, 36);
            this.btDangNhap.TabIndex = 0;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.Animated = true;
            this.tbTaiKhoan.AutoRoundedCorners = true;
            this.tbTaiKhoan.BackColor = System.Drawing.Color.White;
            this.tbTaiKhoan.BorderRadius = 17;
            this.tbTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTaiKhoan.DefaultText = "nhanvien";
            this.tbTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTaiKhoan.FillColor = System.Drawing.SystemColors.Control;
            this.tbTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTaiKhoan.Location = new System.Drawing.Point(491, 140);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.PasswordChar = '\0';
            this.tbTaiKhoan.PlaceholderText = "Tài khoản";
            this.tbTaiKhoan.SelectedText = "";
            this.tbTaiKhoan.Size = new System.Drawing.Size(200, 36);
            this.tbTaiKhoan.TabIndex = 1;
            this.tbTaiKhoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTaiKhoan_KeyDown);
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Animated = true;
            this.tbMatKhau.AutoRoundedCorners = true;
            this.tbMatKhau.BorderRadius = 17;
            this.tbMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMatKhau.DefaultText = "123";
            this.tbMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMatKhau.FillColor = System.Drawing.SystemColors.Control;
            this.tbMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMatKhau.Location = new System.Drawing.Point(491, 182);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.PasswordChar = '●';
            this.tbMatKhau.PlaceholderText = "Mật khẩu";
            this.tbMatKhau.SelectedText = "";
            this.tbMatKhau.Size = new System.Drawing.Size(200, 36);
            this.tbMatKhau.TabIndex = 2;
            this.tbMatKhau.UseSystemPasswordChar = true;
            this.tbMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMatKhau_KeyDown);
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.guna2CheckBox1.Location = new System.Drawing.Point(491, 234);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(95, 17);
            this.guna2CheckBox1.TabIndex = 3;
            this.guna2CheckBox1.Text = "Hiện mật khẩu";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(523, 72);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(148, 39);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Đăng Nhập";
            // 
            // lbSaiTaiKhoan
            // 
            this.lbSaiTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lbSaiTaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.lbSaiTaiKhoan.Location = new System.Drawing.Point(464, 338);
            this.lbSaiTaiKhoan.Name = "lbSaiTaiKhoan";
            this.lbSaiTaiKhoan.Size = new System.Drawing.Size(253, 15);
            this.lbSaiTaiKhoan.TabIndex = 7;
            this.lbSaiTaiKhoan.Text = "Thông tin tài khoản hoặc mật khẩu không chính xác";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::demo02.Properties.Resources.LOGO_TRANG;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(28, 41);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(383, 358);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.Location = new System.Drawing.Point(25, 9);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(35, 13);
            this.lbTenDangNhap.TabIndex = 8;
            this.lbTenDangNhap.Text = "label1";
            this.lbTenDangNhap.Visible = false;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(25, 41);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(35, 13);
            this.lbMatKhau.TabIndex = 9;
            this.lbMatKhau.Text = "label1";
            this.lbMatKhau.Visible = false;
            // 
            // lbVaiTro
            // 
            this.lbVaiTro.AutoSize = true;
            this.lbVaiTro.Location = new System.Drawing.Point(25, 72);
            this.lbVaiTro.Name = "lbVaiTro";
            this.lbVaiTro.Size = new System.Drawing.Size(35, 13);
            this.lbVaiTro.TabIndex = 10;
            this.lbVaiTro.Text = "label1";
            this.lbVaiTro.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lbVaiTro);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbTenDangNhap);
            this.Controls.Add(this.lbSaiTaiKhoan);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2CheckBox1);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.tbTaiKhoan);
            this.Controls.Add(this.btDangNhap);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btDangNhap;
        private Guna.UI2.WinForms.Guna2TextBox tbTaiKhoan;
        private Guna.UI2.WinForms.Guna2TextBox tbMatKhau;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbSaiTaiKhoan;
        private System.Windows.Forms.Label lbTenDangNhap;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbVaiTro;
    }
}

