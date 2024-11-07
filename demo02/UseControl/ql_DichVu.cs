using demo02.DAO;
using System;
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
    public partial class ql_DichVu : UserControl
    {
        string LoadDataString = "SELECT * FROM DichVu ORDER BY idLoaiDichVu ASC";

        public ql_DichVu()
        {
            InitializeComponent();
            loaddata(LoadDataString);

        }

        void loaddata(string LoadDataString)
        {
            DataProvider provider = new DataProvider();
            dgvQlDichVu.DataSource = provider.ExecuteQuery(LoadDataString);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dgvQlDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvQlDichVu.Rows[e.RowIndex];

            tbIdDichVu.Text = row.Cells["id"].Value.ToString();
            tbTenDichVu.Text = row.Cells["tenDichVu"].Value.ToString();
            tbLoaiDichVu.Text = row.Cells["idLoaiDichVu"].Value.ToString();
            tbGiaDichVu.Text = row.Cells["giaDichVu"].Value.ToString();
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            loaddata(LoadDataString);
            tbIdDichVu.Clear();
            tbTenDichVu.Clear();
            tbLoaiDichVu.Text = null;
            tbGiaDichVu.Clear();

            cbXacNhan.Checked = false;
            lbXacNhan.Visible = false;
            lbDienDayDu.Visible = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO DichVu (tenDichVu,idLoaiDichVu,giaDichVu) VALUES('" + tbTenDichVu.Text + "', '" + tbLoaiDichVu.Text + "', '" + tbGiaDichVu.Text + "')";

            if (tbTenDichVu.Text != "" && tbLoaiDichVu.Text != "" && tbGiaDichVu.Text != "" )
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

            string query = "UPDATE DichVu SET tenDichVu = '" + tbTenDichVu.Text + "', idLoaiDichVu = '" + tbLoaiDichVu.Text + "', giaDichVu = '" + tbGiaDichVu.Text + "' WHERE id = '" + tbIdDichVu.Text + "'";

            if (tbTenDichVu.Text != "" && tbLoaiDichVu.Text != "" && tbGiaDichVu.Text != "")
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
            string query = "DELETE FROM DichVu WHERE id = '" + tbIdDichVu.Text + "' ";
            DataProvider provider = new DataProvider();
            provider.LenhSQL(query);
            loaddata(LoadDataString);
            cbXacNhan.Checked = false;
            btLamMoi_Click(sender, e);
        }

        private void btDoAn_Click(object sender, EventArgs e)
        {
            string queryLoadDV = "SELECT tenDichVu AS Ten, giaDichVu AS Gia FROM dbo.DichVu WHERE idLoaiDichVu = 1";
            loaddata(queryLoadDV);
        }

        private void btDoUong_Click(object sender, EventArgs e)
        {
            string queryLoadDV = "SELECT tenDichVu AS Ten, giaDichVu AS Gia FROM dbo.DichVu WHERE idLoaiDichVu = 2";
            loaddata(queryLoadDV);
        }

        private void btMassage_Click(object sender, EventArgs e)
        {
            string queryLoadDV = "SELECT tenDichVu AS Ten, giaDichVu AS Gia FROM dbo.DichVu WHERE idLoaiDichVu = 3";
            loaddata(queryLoadDV);
        }

        private void btKaraoke_Click(object sender, EventArgs e)
        {
            string queryLoadDV = "SELECT tenDichVu AS Ten, giaDichVu AS Gia FROM dbo.DichVu WHERE idLoaiDichVu = 4";
            loaddata(queryLoadDV);
        }

        private void btVanChuyen_Click(object sender, EventArgs e)
        {
            string queryLoadDV = "SELECT tenDichVu AS Ten, giaDichVu AS Gia FROM dbo.DichVu WHERE idLoaiDichVu = 5";
            loaddata(queryLoadDV);
        }
    }
}
