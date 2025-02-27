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
    public class BUS_DichVu
    {
        DAL_DichVu dDV = new DAL_DichVu();
        public bool themDichVu(DichVu dv)
        {
            return dDV.themDichVu(dv);
        }

        public bool suaDichVu(DichVu dv)
        {
            return dDV.suaDichVu(dv);
        }

        public bool xoaDichVu(DichVu dv)
        {
            return dDV.xoaDichVu(dv);
        }

        public void bindGridView(DataGridView dataGridView)
        {
            dDV.bindGridView(dataGridView);
        }
        public void bindGridViewbySearch(DataGridView dataGridView, string name)
        {
            dDV.bindGridViewbySearch(dataGridView, name);
        }
    }
}
