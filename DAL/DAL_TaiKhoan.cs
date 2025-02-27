using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoan : DBConnect
    {

        public bool checkLogin(string username, string pass)
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE tenTK=@username AND mk=@pass";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pass", pass);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            if (count > 0)
            {
                return true;
            }

            return false;
        }


    }
}
