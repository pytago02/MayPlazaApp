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
    public partial class nhanvien : Form
    {
        public nhanvien()
        {
            InitializeComponent();
            string usenameLogin = Login.usenameLogin;
            lbUsenameLogin.Text = usenameLogin;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            nv_DatTraPhong datTraPhong = new nv_DatTraPhong();
            datTraPhong.Show();
        }

        private void btThongTinCaNhan_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan ttcn = new ThongTinCaNhan();
            ttcn.ShowDialog();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
