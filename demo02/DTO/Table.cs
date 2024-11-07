using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo02.DTO
{
    class Table
    {
        public Table(int id, string tenPhong, string loaiPhong, int giaPhong, string tinhTrang)
        {
            this.id = id;
            this.tenPhong = tenPhong;
            this.loaiPhong = loaiPhong;
            this.giaPhong = giaPhong;
            this.tinhTrang = tinhTrang;
        }
        private string tinhTrang;
        private int giaPhong;
        private string loaiPhong;
        private string tenPhong;
        private int id;

        public int ID { get => id; set => id = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public int GiaPhong { get => giaPhong; set => giaPhong = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
