using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dKH = new DAL_KhachHang();
        public bool themKhachHang(KhachHang kh)
        {
            return dKH.themKhachHang(kh);
        }
        public KhachHang getKhachHangById(int maPhong)
        {
            return dKH.getKhachHangById(maPhong);
        }
        public void bindGridView(DataGridView dataGridView)
        {
            dKH.bindGridView(dataGridView);
        }
        public bool xoaKhachHang(KhachHang kh)
        {
            return dKH.xoaKhachHang(kh);
        }
        public bool xoaKhachHang2(string id)
        {
            return dKH.xoaKhachHang2(id);
        }
        public void bindGridViewbySearch(DataGridView dataGridView, string name)
        {
            dKH.bindGridViewbySearch(dataGridView, name);
        }
    }
}
