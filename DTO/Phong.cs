using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phong
    {
        private int maPhong;
        private string loaiPhong;
        private int soNguoi;
        private int giaPhong;
        private bool trangThai;

        public Phong() { }
        public Phong(int maPhong, string loaiPhong, int soNguoi, int giaPhong, bool trangThai)
        {
            this.maPhong = maPhong;
            this.loaiPhong = loaiPhong;
            this.soNguoi = soNguoi;
            this.giaPhong = giaPhong;
            this.trangThai = trangThai;
        }

        public int MaPhong { get => maPhong; set => maPhong = value; }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public int SoNguoi { get => soNguoi; set => soNguoi = value; }
        public int GiaPhong { get => giaPhong; set => giaPhong = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}
