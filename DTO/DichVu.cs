using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVu
    {
        private int maDichVu;
        private string tenDichVu;
        private int giaDichVu;

        public DichVu() { }

        public DichVu(int maDichVu, string tenDichVu, int giaDichVu)
        {
            this.maDichVu = maDichVu;
            this.tenDichVu = tenDichVu;
            this.giaDichVu = giaDichVu;
        }

        public int MaDichVu { get => maDichVu; set => maDichVu = value; }
        public string TenDichVu { get => tenDichVu; set => tenDichVu = value; }
        public int GiaDichVu { get => giaDichVu; set => giaDichVu = value; }
    }
}
