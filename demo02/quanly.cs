using demo02.UseControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo02
{
    public partial class quanly : Form
    {
        public quanly()
        {
            InitializeComponent();
            resetButton();
        }

        

        private void resetButton()
        {
            btQlPhong.FillColor = Color.SteelBlue;
            btQlDichVu.FillColor = Color.SteelBlue;
            btQlNhanVien.FillColor = Color.SteelBlue;
            btQlKhachHang.FillColor = Color.SteelBlue;
            btThongKe.FillColor = Color.SteelBlue;
            btThongTinCaNhan.FillColor = Color.SteelBlue;

            ql_ThongKe1.Visible = false;
            ql_Phong1.Visible = false;
            ql_DichVu1.Visible = false;
            ql_NhanVien1.Visible = false;
        }

        private void btThongTinCaNhan_Click(object sender, EventArgs e)
        {
            resetButton();
            btThongTinCaNhan.FillColor = Color.LightPink;

            ThongTinCaNhan ttcn = new ThongTinCaNhan();
            ttcn.ShowDialog();

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            resetButton();
            btThongKe.FillColor = Color.LightPink;

            ql_ThongKe1.Visible = true;
        }

        private void btQlPhong_Click(object sender, EventArgs e)
        {
            resetButton();
            btQlPhong.FillColor = Color.LightPink;

            ql_Phong1.Visible = true;
        }

        private void btQlDichVu_Click(object sender, EventArgs e)
        {
            resetButton();
            btQlDichVu.FillColor = Color.LightPink;

            ql_DichVu1.Visible = true;
        }

        private void btQlNhanVien_Click(object sender, EventArgs e)
        {
            resetButton();
            btQlNhanVien.FillColor = Color.LightPink;

            ql_NhanVien1.Visible = true;
        }
    }
}
