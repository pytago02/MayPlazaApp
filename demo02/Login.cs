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
using System.Xml;

namespace demo02
{
    public partial class Login : Form
    {
        public static string usenameLogin;
        public Login()
        {
            InitializeComponent();
            lbSaiTaiKhoan.Visible = false;


        }

        private void loadLogin()
        {
            tbTaiKhoan.Clear();
            tbMatKhau.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (tbTaiKhoan.Text != "" && tbMatKhau.Text != "")
            {
                string connectionString = @"Data Source=DESKTOP-HI307AE;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True";
                string query = "SELECT * FROM dbo.TaiKhoan WHERE tenDangNhap = '"+tbTaiKhoan.Text+"'";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    lbTenDangNhap.Text = reader["tenDangNhap"].ToString();
                    lbMatKhau.Text = reader["matKhau"].ToString();
                    lbVaiTro.Text = reader["vaiTro"].ToString();
                }
                connection.Close();

                if (tbTaiKhoan.Text == lbTenDangNhap.Text && tbMatKhau.Text == lbMatKhau.Text)
                {
                    if (lbVaiTro.Text == "Quan ly")
                    {
                        usenameLogin = tbTaiKhoan.Text;
                        loadLogin();
                        this.Hide();

                        quanly ql = new quanly();
                        ql.ShowDialog();
                        this.Show();
                        
                    }
                    if (lbVaiTro.Text == "Nhan vien")
                    {
                        usenameLogin = tbTaiKhoan.Text;
                        loadLogin();
                        this.Hide();

                        nhanvien nv = new nhanvien();
                        nv.ShowDialog();
                        this.Show();
                        
                    }

                }
                else
                {
                    lbSaiTaiKhoan.Visible = true;
                    tbMatKhau.Clear();
                }
            }
            else
            {
                lbSaiTaiKhoan.Visible = true;
                tbMatKhau.Clear();
            }


            
        }

        private void tbTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btDangNhap.PerformClick();
            }
        }

        private void tbMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btDangNhap.PerformClick();
            }
        }

        
    }
}
