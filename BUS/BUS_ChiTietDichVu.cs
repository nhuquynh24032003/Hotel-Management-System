using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_ChiTietDichVu
    {
        DAL_ChiTietDichVu dCTDV = new DAL_ChiTietDichVu();
        public bool themCTDV(ChiTietDichVu ctdv)
        {
            return dCTDV.themCTDV(ctdv);
        }
        public bool xoaCTDV(int maPhong)
        {
            return dCTDV.xoaCTDV(maPhong);
        }
        public void bindGridView(DataGridView dataGridView, int id)
        {
            dCTDV.bindGridView(dataGridView, id);
        }
        public int demSoLuongMaDV(int maDV,int id)
        {
            return dCTDV.demSoLuongMaDV(maDV, id);
        }
    }
}
