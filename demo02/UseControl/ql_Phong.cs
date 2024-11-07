using demo02.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo02.UseControl
{
    public partial class ql_Phong : UserControl
    {

        private string LoadDataString = "SELECT * FROM Phong ORDER BY Phong.tenPhong ASC";
        public ql_Phong()
        {
            InitializeComponent();
            
            loaddata(LoadDataString);
        }

        
        void loaddata(string LoadDataString)
        {
            //string query = "SELECT * FROM Phong";
            DataProvider provider = new DataProvider();
            dgvQlPhong.DataSource = provider.ExecuteQuery(LoadDataString);
        }

        private void dgvQlPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvQlPhong.Rows[e.RowIndex];

            tbIdPhong.Text = row.Cells["id"].Value.ToString();
            tbTenPhong.Text = row.Cells["tenPhong"].Value.ToString();
            cbLoaiPhong.Text = row.Cells["loaiPhong"].Value.ToString();
            tbGiaPhong.Text = row.Cells["giaPhong"].Value.ToString();
            cbTinhTrang.Text = row.Cells["tinhTrang"].Value.ToString();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            dgvQlPhong.Controls.Clear();
            string str = tbTimKiem.Text;
            string query = "SELECT * FROM dbo.Phong WHERE tenPhong LIKE '" + str + "' ";
            loaddata(query);
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            loaddata(LoadDataString);
            tbIdPhong.Clear();
            tbTenPhong.Clear();
            cbLoaiPhong.Text = null;
            tbGiaPhong.Clear();
            cbTinhTrang.Text = null;

            cbXacNhan.Checked = false;
            lbXacNhan.Visible = false;
            lbDienDayDu.Visible = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Phong (tenPhong,loaiPhong,giaPhong,tinhTrang) VALUES('" + tbTenPhong.Text + "', '" + cbLoaiPhong.Text + "', '" + tbGiaPhong.Text + "', '" + cbTinhTrang.Text + "')";

            if (tbTenPhong.Text != "" && cbLoaiPhong.Text != "" && tbGiaPhong.Text != "" && cbTinhTrang.Text != "")
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
            string query = "UPDATE Phong SET loaiPhong = '" + cbLoaiPhong.Text + "', giaPhong = '" + tbGiaPhong.Text + "', tinhTrang = '" + cbTinhTrang.Text + "' WHERE id = '" + tbIdPhong.Text + "'";

            if (tbTenPhong.Text != "" && cbLoaiPhong.Text != "" && tbGiaPhong.Text != "" && cbTinhTrang.Text != "")
            {
                if (cbXacNhan.Checked)
                {
                    DataProvider provider = new DataProvider();
                    provider.LenhSQL(query);
                    loaddata(LoadDataString);
                    //cbXacNhan.Checked = false;
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
            string query = "DELETE FROM Phong WHERE id = '" + tbIdPhong.Text + "' ";
            DataProvider provider = new DataProvider();
            provider.LenhSQL(query);
            loaddata(LoadDataString);
            cbXacNhan.Checked = false;
            btLamMoi_Click(sender, e);
        }
    }
}
