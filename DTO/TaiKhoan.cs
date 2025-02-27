using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {

        private string tenTK;
        private string mk;
        private int loai;


        public TaiKhoan() { }
        public TaiKhoan(string tenTK, string mk, int loai)
        {
            this.TenTK = tenTK;
            this.Mk = mk;
            this.Loai = loai;
        }

        public string TenTK { get => tenTK; set => tenTK = value; }
        public string Mk { get => mk; set => mk = value; }
        public int Loai { get => loai; set => loai = value; }
    }
}
