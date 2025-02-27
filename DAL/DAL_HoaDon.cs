using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_HoaDon : DBConnect
    {
        public void bindGridView(DataGridView dataGridView)
        {
            
            string query = "SELECT * from HoaDon";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }
        public int selectLastHD()
        {
            conn.Open();
            string query = "SELECT TOP 1 maHoaDon FROM HoaDon ORDER BY maHoaDon DESC";

            SqlCommand command = new SqlCommand(query, conn);
            int lastID = (int)command.ExecuteScalar();
            conn.Close();
            return lastID;
        }
        public int getTongTien(int id)
        {
            conn.Open();
            string query = "SELECT tongTien FROM HoaDon WHERE maHoaDon = @id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = cmd.ExecuteReader();
            int tongTien = 0;

            if (reader.Read())
            {
                tongTien = Convert.ToInt32(reader["tongTien"]);
            }

            reader.Close();
            conn.Close();

            return tongTien;
        }
        public bool themHoaDon(HoaDon hd)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.HoaDon_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@Ma_hoa_don", null);
            cmd.Parameters.AddWithValue("@Tong_tien", hd.TongTien);
            cmd.Parameters.AddWithValue("@Ngay_lap", null);
            cmd.Parameters.AddWithValue("@Trang_thai", false);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
        public bool suaHoaDon(HoaDon hd)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.HoaDon_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@Ma_hoa_don", hd.MaHoaDon);
            cmd.Parameters.AddWithValue("@Tong_tien", hd.TongTien);
            cmd.Parameters.AddWithValue("@Ngay_lap", hd.NgayLap);
            cmd.Parameters.AddWithValue("@Trang_thai", hd.TrangThai);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
        public void bindGridViewbySearch(DataGridView dataGridView, string name)
        {
            conn.Open();
            string query = "SELECT * from HoaDon where maHoaDon LIKE '%' + @name + '%' or ngayLap LIKE '%' + @name + '%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }
    }
}
