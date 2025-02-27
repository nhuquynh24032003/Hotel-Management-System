using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL 
{
    public class DAL_ChiTietHoaDon : DBConnect
    {
        public bool themCTHD(ChiTietHoaDon cthd)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.ChiTietHoaDon_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@Ma_hoa_don", cthd.MaHoaDon);
            cmd.Parameters.AddWithValue("@Ma_phong", cthd.MaPhong);
 

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
        public bool getTrangThai(int maPhong)
        {
            conn.Open();
            string query = "SELECT HoaDon.trangThai FROM HoaDon INNER JOIN ChiTietHoaDon ON HoaDon.maHoaDon = ChiTietHoaDon.maHoaDon WHERE ChiTietHoaDon.maPhong = @MaPhong";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaPhong", maPhong);

            SqlDataReader reader = cmd.ExecuteReader();
            bool trangThai = false;

            if (reader.Read())
            {
                trangThai = Convert.ToBoolean(reader["trangThai"]);
            }

            reader.Close();
            conn.Close();

            return trangThai;
        }
        public int getMaHoaDon(int maPhong)
        {
            conn.Open();
            string query = "SELECT HoaDon.maHoaDon FROM HoaDon INNER JOIN ChiTietHoaDon ON HoaDon.maHoaDon = ChiTietHoaDon.maHoaDon WHERE ChiTietHoaDon.maPhong = @MaPhong";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaPhong", maPhong);

            SqlDataReader reader = cmd.ExecuteReader();
            int maHoaDon = 0;

            if (reader.Read())
            {
                maHoaDon = Convert.ToInt32(reader["maHoaDon"]);
            }

            reader.Close();
            conn.Close();

            return maHoaDon;
        }
    }
  
}

