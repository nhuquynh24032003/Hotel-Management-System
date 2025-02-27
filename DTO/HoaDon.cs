using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private int maHoaDon;
        private int tongTien;
        private DateTime ngayLap;
        private bool trangThai;
        public HoaDon() { }

        public HoaDon(int maHoaDon, int tongTien, DateTime ngayLap, bool trangThai)
        {
            this.maHoaDon = maHoaDon;
            this.tongTien = tongTien;
            this.ngayLap = ngayLap;
            this.trangThai = trangThai;
        }

        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
    }
}
