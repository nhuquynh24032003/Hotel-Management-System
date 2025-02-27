using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiTietHoaDon
    {
        DAL_ChiTietHoaDon dCTHD = new DAL_ChiTietHoaDon();
        public bool themCTHD(ChiTietHoaDon cthd)
        {
            return dCTHD.themCTHD(cthd);
        }
        public bool getTrangThai(int maPhong)
        {
            return dCTHD.getTrangThai(maPhong);
        }
        public int getMaHoaDon(int maPhong)
        {
            return dCTHD.getMaHoaDon(maPhong);
        }
    }
}
