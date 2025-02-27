using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        private int maHoaDon;
        private int maPhong;

        public ChiTietHoaDon() { }

        public ChiTietHoaDon(int maHoaDon, int maPhong)
        {
            this.maHoaDon = maHoaDon;
            this.maPhong = maPhong;
        }

        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int MaPhong { get => maPhong; set => maPhong = value; }
    }
}
