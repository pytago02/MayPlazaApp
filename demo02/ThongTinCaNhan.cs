using demo02.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo02
{
    public partial class ThongTinCaNhan : Form
    {
        string matKhauCu;
        public ThongTinCaNhan()
        {
            InitializeComponent();
            loadData();

        }
        void loadData()
        {
            lbTenDangNhap.Text = Login.usenameLogin;
            string connectionString = @"Data Source=DESKTOP-HI307AE;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT * FROM dbo.TaiKhoan WHERE tenDangNhap = '" + Login.usenameLogin + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tbTenDangNhap.Text = reader["tenDangNhap"].ToString();
                tbHovaTen.Text = reader["hoTen"].ToString();
                cbGioiTinh.Text = reader["gioiTinh"].ToString();
                tbDiaChi.Text = reader["diaChi"].ToString();
                tbSoDienThoai.Text = reader["sdt"].ToString();

                matKhauCu = reader["matKhau"].ToString();
            }
            connection.Close();
        }

        void lamMoi()
        {
            lbXacNhanThongTin.Visible = false;
            lbXacNhanMatKhau.Visible = false;
            lbSaiNhapLai.Visible = false;
            lbSaiMatKhau.Visible = false;

            blThanhCongTt.Visible = false;
            lbThanhCongMk.Visible = false;

            cbXacNhanThongTin.Checked = false;
            cbXacNhanMatKhau.Checked = false;
        }

        private void btThayDoiThongTin_Click(object sender, EventArgs e)
        {
            string query = "UPDATE TaiKhoan SET hoTen = '" + tbHovaTen.Text + "', gioiTinh = '" + cbGioiTinh.Text + "', diaChi = '" + tbDiaChi.Text + "', sdt = '" + tbSoDienThoai.Text + "' WHERE tenDangNhap = '" + tbTenDangNhap.Text + "'";

            if (cbXacNhanThongTin.Checked)
            {
                DataProvider provider = new DataProvider();
                provider.LenhSQL(query);
                loadData();
                lamMoi();
                blThanhCongTt.Visible=true;
            }
            else
            {
                lamMoi();
                lbXacNhanThongTin.Visible = true;
            }

        }

        private void btThayDoiMatKhau_Click(object sender, EventArgs e)
        {
            string query = "UPDATE TaiKhoan SET matKhau = '" + tbMatKhauMoi.Text + "' WHERE tenDangNhap = '" + Login.usenameLogin + "'";
            
            if (tbMatKhauHienTai.Text == matKhauCu)
            {
                if (tbMatKhauMoi.Text == tbNhapLai.Text)
                {
                    if (cbXacNhanMatKhau.Checked)
                    {
                        DataProvider provider = new DataProvider();
                        provider.LenhSQL(query);
                        loadData();
                        lamMoi();
                        lbThanhCongMk.Visible = true;
                    }
                    else
                    {
                        lamMoi();
                        cbXacNhanMatKhau.Visible = true;
                    }
                }
                else
                {
                    lamMoi();
                    lbSaiNhapLai.Visible = true;
                }
                
            }
            else
            {
                lamMoi();
                lbSaiMatKhau.Visible = true;
            }
            
        }
    }
}
