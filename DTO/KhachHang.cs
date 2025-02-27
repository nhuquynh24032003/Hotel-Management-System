using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private string maKH;
        private int maPhong;
        private string hoTen;
        private bool gioiTinh;
        private string diaChi;
        private string queQuan;
        private string sdt;
        private string cccd;
        private DateTime ngayDatPhong;
        private DateTime ngayTraphong;

        public KhachHang() { }

        public KhachHang(string maKH, int maPhong, string hoTen, bool gioiTinh, string diaChi, string queQuan, string sdt, string cccd, DateTime ngayDatPhong, DateTime ngayTraphong)
        {
            this.maKH = maKH;
            this.maPhong = maPhong;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.queQuan = queQuan;
            this.sdt = sdt;
            this.cccd = cccd;
            this.ngayDatPhong = ngayDatPhong;
            this.ngayTraphong = ngayTraphong;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public int MaPhong { get => maPhong; set => maPhong = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public DateTime NgayDatPhong { get => ngayDatPhong; set => ngayDatPhong = value; }
        public DateTime NgayTraphong { get => ngayTraphong; set => ngayTraphong = value; }
    }
}
