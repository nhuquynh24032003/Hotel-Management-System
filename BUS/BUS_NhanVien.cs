using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dNV = new DAL_NhanVien();
        public bool themNhanVien(NhanVien nv)
        {
            return dNV.themNhanVien(nv);
        }

        public bool suaNhanVien(NhanVien nv)
        {
            return dNV.suaNhanVien(nv);
        }

        public bool xoaNhanVien(NhanVien nv)
        {
            return dNV.xoaNhanVien(nv);
        }

        public void bindGridView(DataGridView dataGridView)
        {
            dNV.bindGridView(dataGridView);
        }

        public void bindGridViewbySearch(DataGridView dataGridView, string name)
        {
            dNV.bindGridViewbySearch(dataGridView, name);
        }
    }
}
