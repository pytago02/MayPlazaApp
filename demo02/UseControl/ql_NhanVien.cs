using demo02.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo02.UseControl
{
    public partial class ql_NhanVien : UserControl
    {
        string LoadDataString = "SELECT * FROM TaiKhoan ORDER BY vaiTro DESC";
        public ql_NhanVien()
        {
            InitializeComponent();
            loaddata(LoadDataString);
        }

        void loaddata(string LoadDataString)
        {
            DataProvider provider = new DataProvider();
            dgvQlTaiKhoan.DataSource = provider.ExecuteQuery(LoadDataString);
        }


        private void dgvQlTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvQlTaiKhoan.CurrentRow.Index;
            tbTenDangNhap.Text = dgvQlTaiKhoan.Rows[i].Cells[0].Value.ToString();
            tbMatKhau.Text = dgvQlTaiKhoan.Rows[i].Cells[1].Value.ToString();
            tbHoTen.Text = dgvQlTaiKhoan.Rows[i].Cells[2].Value.ToString();
            cbGioiTinh.Text = dgvQlTaiKhoan.Rows[i].Cells[3].Value.ToString();
            tbDiaChi.Text = dgvQlTaiKhoan.Rows[i].Cells[4].Value.ToString();
            tbSoDienThoai.Text = dgvQlTaiKhoan.Rows[i].Cells[5].Value.ToString();
            cbVaiTro.Text = dgvQlTaiKhoan.Rows[i].Cells[6].Value.ToString();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.TaiKhoan WHERE tenDangNhap LIKE '" + tbTimKiem.Text + "' ";
            DataProvider provider = new DataProvider();
            provider.LenhSQL(query);
            loaddata(LoadDataString);
        }

        private void dgvQlTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvQlTaiKhoan.Rows[e.RowIndex];

            tbTenDangNhap.Text = row.Cells["tenDangNhap"].Value.ToString();
            tbMatKhau.Text = row.Cells["matKhau"].Value.ToString();
            tbHoTen.Text = row.Cells["hoTen"].Value.ToString();
            cbGioiTinh.Text = row.Cells["gioiTinh"].Value.ToString();
            tbDiaChi.Text = row.Cells["diaChi"].Value.ToString();
            tbSoDienThoai.Text = row.Cells["sdt"].Value.ToString();
            cbVaiTro.Text = row.Cells["vaiTro"].Value.ToString();
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            loaddata(LoadDataString);
            tbTenDangNhap.Clear();
            tbMatKhau.Clear();
            tbHoTen.Clear();
            cbGioiTinh.Text = null;
            tbDiaChi.Clear();
            tbSoDienThoai.Clear();
            cbVaiTro.Text = null;

            cbXacNhan.Checked = false;
            lbXacNhan.Visible = false;
            lbDienDayDu.Visible = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO TaiKhoan VALUES('" + tbTenDangNhap.Text + "', '" + tbMatKhau.Text + "', '" + tbHoTen.Text + "', '"+cbGioiTinh.Text+"', '"+tbDiaChi.Text +"', '"+tbSoDienThoai.Text+"', '"+cbVaiTro.Text +"')";

            if (tbTenDangNhap.Text != "" && tbMatKhau.Text != "" && tbHoTen.Text != "" && cbGioiTinh.Text != "" && tbDiaChi.Text != "" && tbSoDienThoai.Text != "" && cbVaiTro.Text != "")
            {
                if (cbXacNhan.Checked)
                {
                    DataProvider provider = new DataProvider();
                    provider.LenhSQL(query);
                    loaddata(LoadDataString);
                    cbXacNhan.Checked = false;
                    btLamMoi_Click(sender, e);
                }
                else
                {
                    lbXacNhan.Visible = true;
                }
            }
            else
            {
                lbDienDayDu.Visible = true;
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE TaiKhoan SET matKhau = '" + tbMatKhau.Text + "', hoTen = '" + tbHoTen.Text + "', gioiTinh = '" + cbGioiTinh.Text + "', diaChi = '"+cbGioiTinh.Text+"', sdt = '"+tbSoDienThoai.Text+"', vaiTro = '"+cbVaiTro.Text+"'  WHERE tenDangNhap = '" + tbTenDangNhap.Text + "'";

            if (tbTenDangNhap.Text != "" && tbMatKhau.Text != "" && tbHoTen.Text != "" && cbGioiTinh.Text != "" && tbDiaChi.Text != "" && tbSoDienThoai.Text != "" && cbVaiTro.Text != "")
            {
                if (cbXacNhan.Checked)
                {
                    DataProvider provider = new DataProvider();
                    provider.LenhSQL(query);
                    loaddata(LoadDataString);
                    cbXacNhan.Checked = false;
                    btLamMoi_Click(sender, e);
                }
                else
                {
                    lbXacNhan.Visible = true;
                }
            }
            else
            {
                lbDienDayDu.Visible = true;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM TaiKhoan WHERE TenDangNhap = '" + tbTenDangNhap.Text + "' ";
            DataProvider provider = new DataProvider();
            provider.LenhSQL(query);
            loaddata(LoadDataString);
            cbXacNhan.Checked = false;
            btLamMoi_Click(sender, e);
        }
    }
}
