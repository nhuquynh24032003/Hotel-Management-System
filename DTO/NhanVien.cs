using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string maNV;
        private string hoTen;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string cccd;
        private string sdt;


        public NhanVien() { }
        public NhanVien(string maNV, string hoTen, DateTime ngaySinh, bool gioiTinh, string cccd, string sdt)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.cccd = cccd;
            this.sdt = sdt;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
