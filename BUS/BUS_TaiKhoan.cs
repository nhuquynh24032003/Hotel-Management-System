using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dTK = new DAL_TaiKhoan();
        public bool checkLogin(string username, string pass)
        {
            return dTK.checkLogin(username, pass);
        }

    }
}
