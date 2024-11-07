using demo02.DAO;
using Guna.UI2.WinForms;
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
    public partial class nv_DatTraPhong : UserControl
    {
        public nv_DatTraPhong()
        {
            InitializeComponent();
            string query = "SELECT * FROM dbo.Phong ORDER BY Phong.tenPhong ASC ";
            string queryLoadDV = "SELECT tenDichVu AS Ten, giaDichVu AS Gia FROM dbo.DichVu WHERE idLoaiDichVu = 1";
            loadTable(query);
            loadDichVu(queryLoadDV);
        }

        void loadTable(string query)
        {
            string connectionString = @"Data Source=DESKTOP-HI307AE;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True";
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
                
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string tenPhong = reader["tenPhong"].ToString();
                string loaiPhong = reader["loaiPhong"].ToString();
                int giaPhong = Convert.ToInt32(reader["giaPhong"]);
                string tinhTrang = reader["tinhTrang"].ToString();


                Guna2Button button = new Guna2Button();
                button.Text = tenPhong + "\n"+ tinhTrang ;
                button.Tag = id;

                button.Height = 90;
                button.Width = 90;
                button.BorderRadius = 18;
                button.Font = new Font("Segoe UI",12);

                if (tinhTrang == "Trong")
                {
                    button.FillColor = Color.SeaGreen;
                }
                if (tinhTrang == "Da thue")
                {
                    button.FillColor = Color.DarkGoldenrod;
                }
                if (tinhTrang == "Sua")
                {
                    button.FillColor = Color.Crimson;
                }
  

                button.Click += (sender, e) =>
                {
                    int selectedCustomerID = (int)((Guna2Button)sender).Tag;

                    lbTenPhong.Text = "Phòng " + tenPhong;
                    lbTinhTrang.Text = tinhTrang;
                    tbLoaiPhong.Text = loaiPhong;
                    tbGiaPhong.Text = giaPhong.ToString();

                    if (tinhTrang == "Trong")
                    {
                        btDatTra.Enabled = true;
                        btDatTra.Text = "Nhận";
                    }
                    if (tinhTrang == "Da thue")
                    {
                        btDatTra.Enabled = true;
                        btDatTra.Text = "Trả";
                    }
                    if(tinhTrang == "Sua")
                    {
                        btDatTra.Enabled = false;
                    }    
                };

                fpnlDatTraPhong.Controls.Add(button);


            }

            connection.Close();
        }

        void loadDichVu(string queryLoadDV)
        {
            DataProvider provider = new DataProvider();
            dgvDichVu.DataSource = provider.ExecuteQuery(queryLoadDV);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            fpnlDatTraPhong.Controls.Clear();
            string query = "SELECT * FROM dbo.Phong WHERE tinhTrang LIKE 'Sua' ORDER BY Phong.tenPhong ASC";
            loadTable(query);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            fpnlDatTraPhong.Controls.Clear();
            string query = "SELECT * FROM dbo.Phong WHERE tinhTrang LIKE 'Da thue' ORDER BY Phong.tenPhong ASC";
            loadTable(query);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            fpnlDatTraPhong.Controls.Clear();
            string query = "SELECT * FROM dbo.Phong WHERE tinhTrang LIKE 'Trong' ORDER BY Phong.tenPhong ASC";
            loadTable(query);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            fpnlDatTraPhong.Controls.Clear();
            string query = "SELECT * FROM dbo.Phong ORDER BY Phong.tenPhong ASC ";
            loadTable(query);

            tbMaKhach.Clear();
            tbTenKhach.Clear();
            dtpNgayDat.Controls.Clear();
            dtpNgayTra.Controls.Clear();
        }

        private void btDoAn_Click(object sender, EventArgs e)
        {
            string queryLoadDV = "SELECT tenDichVu AS Ten, giaDichVu AS Gia FROM dbo.DichVu WHERE idLoaiDichVu = 1";
            loadDichVu(queryLoadDV);

        }

        private void btDoUong_Click(object sender, EventArgs e)
        {
            string queryLoadDV = "SELECT tenDichVu AS Ten, giaDichVu AS Gia FROM dbo.DichVu WHERE idLoaiDichVu = 2";
            loadDichVu(queryLoadDV);
        }

        private void btMassage_Click(object sender, EventArgs e)
        {
            string queryLoadDV = "SELECT tenDichVu AS Ten, giaDichVu AS Gia FROM dbo.DichVu WHERE idLoaiDichVu = 3";
            loadDichVu(queryLoadDV);
        }

        private void btKaraoke_Click(object sender, EventArgs e)
        {
            string queryLoadDV = "SELECT tenDichVu AS Ten, giaDichVu AS Gia FROM dbo.DichVu WHERE idLoaiDichVu = 4";
            loadDichVu(queryLoadDV);
        }

        private void btVanChuyen_Click(object sender, EventArgs e)
        {
            string queryLoadDV = "SELECT tenDichVu AS Ten, giaDichVu AS Gia FROM dbo.DichVu WHERE idLoaiDichVu = 5";
            loadDichVu(queryLoadDV);
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDichVu.Rows[e.RowIndex];

            lbTenDichVu.Text = row.Cells["ten"].Value.ToString();
            lbGiaDichVu.Text = row.Cells["gia"].Value.ToString();
        }
    }
}
