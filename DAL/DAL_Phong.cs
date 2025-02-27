using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_Phong : DBConnect
    {
        public void bindGridViewByStatus(DataGridView dataGridView)
        {
            conn.Open();
            string query = "SELECT maPhong, loaiPhong, soNguoi, giaPhong FROM Phong WHERE trangThai = 0";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            conn.Close();
        }
        public void bindGridView(DataGridView dataGridView)
        {
            conn.Open();
            string query = "SELECT * FROM Phong";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            conn.Close();
        }
        public Phong getPhongById(int maPhong)
        {
            conn.Open();
            string query = "SELECT * FROM Phong WHERE maPhong = @MaPhong";
            Phong phong = null;

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaPhong", maPhong);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                phong = new Phong();
                phong.MaPhong = Convert.ToInt32(reader["maPhong"]);
                phong.LoaiPhong = reader["loaiPhong"].ToString();
                phong.SoNguoi = Convert.ToInt32(reader["soNguoi"]);
                phong.GiaPhong = Convert.ToInt32(reader["giaPhong"]);
                phong.TrangThai = Convert.ToBoolean(reader["trangThai"]);
            }

            reader.Close();
            conn.Close();

            return phong;
        }
        public int getGiaPhong(int maPhong)
        {
            conn.Open();
            string query = "SELECT giaPhong FROM Phong WHERE maPhong = @MaPhong";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaPhong", maPhong);

            SqlDataReader reader = cmd.ExecuteReader();
            int giaPhong = 0;

            if (reader.Read())
            {
                giaPhong = Convert.ToInt32(reader["giaPhong"]);
            }

            reader.Close();
            conn.Close();

            return giaPhong;
        }
        public void bindGridViewbySearch(DataGridView dataGridView, string name)
        {
            conn.Open();
            string query = "SELECT * from Phong where maPhong LIKE '%' + @name + '%' OR loaiPhong LIKE '%' + @name + '%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }
      
        public void updateTrangThaiPhong0()
        {
            conn.Open();
            string query = "UPDATE Phong SET trangThai = 0 WHERE trangThai = 1";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void updateTrangThaiPhong1(int id)
        {
            conn.Open();
            string query = "UPDATE Phong SET trangThai = 1 WHERE maPhong = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void updateTrangThaiPhong2(int id)
        {
            conn.Open();
            string query = "UPDATE Phong SET trangThai = 0 WHERE maPhong = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void updateTrangThaiPhong(DateTime ngayDat, DateTime ngayTra)
        {
            conn.Open();
            string query = "UPDATE Phong SET trangThai = 1 WHERE maPhong IN (" +
                "SELECT maPhong FROM KhachHang WHERE (ngayDatPhong <= @NgayTra AND ngayTraPhong >= @NgayDat) " +
                "OR (ngayDatPhong >= @NgayDat AND ngayDatPhong <= @NgayTra))";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@NgayDat", ngayDat);
            cmd.Parameters.AddWithValue("@NgayTra", ngayTra);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public bool themPhong(Phong phong)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.Phong_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@Ma_phong", null);
            cmd.Parameters.AddWithValue("@Loai_phong", phong.LoaiPhong);
            cmd.Parameters.AddWithValue("@So_nguoi", phong.SoNguoi);
            cmd.Parameters.AddWithValue("@Gia_phong", phong.GiaPhong);
            cmd.Parameters.AddWithValue("@Trang_thai", phong.TrangThai);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
        public bool suaPhong(Phong phong)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.Phong_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@Ma_phong", phong.MaPhong);
            cmd.Parameters.AddWithValue("@Loai_phong", phong.LoaiPhong);
            cmd.Parameters.AddWithValue("@So_nguoi", phong.SoNguoi);
            cmd.Parameters.AddWithValue("@Gia_phong", phong.GiaPhong);
            cmd.Parameters.AddWithValue("@Trang_thai", phong.TrangThai);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool xoaPhong(Phong phong)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.Phong_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@Ma_phong", phong.MaPhong);
            cmd.Parameters.AddWithValue("@Loai_phong", phong.LoaiPhong);
            cmd.Parameters.AddWithValue("@So_nguoi", phong.SoNguoi);
            cmd.Parameters.AddWithValue("@Gia_phong", phong.GiaPhong);
            cmd.Parameters.AddWithValue("@Trang_thai", phong.TrangThai);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
    }
}
