using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDichVu
    {
        private int maDichVu;
        private int maPhong;
        private int thanhTien;

        public ChiTietDichVu() { }
        public ChiTietDichVu(int maDichVu, int maPhong, int thanhTien)
        {
            this.maDichVu = maDichVu;
            this.maPhong = maPhong;
            this.thanhTien = thanhTien;
        }

        public int MaDichVu { get => maDichVu; set => maDichVu = value; }
        public int MaPhong { get => maPhong; set => maPhong = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
