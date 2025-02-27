using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dHD = new DAL_HoaDon();
        public bool themHoaDon(HoaDon hd)
        {
            return dHD.themHoaDon(hd);
        }
        public int selectLastHD()
        {
            return dHD.selectLastHD();
        }
        public void bindGridView(DataGridView dataGridView)
        {
            dHD.bindGridView(dataGridView);
        }
        public bool suaHoaDon(HoaDon hd)
        {
            return dHD.suaHoaDon(hd);
        }
        public int getTongTien(int id)
        {
            return dHD.getTongTien(id);
        }
        public void bindGridViewbySearch(DataGridView dataGridView, string name)
        {
            dHD.bindGridViewbySearch(dataGridView, name);
        }
    }
}
