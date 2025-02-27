using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_NhanVien : DBConnect
    {
        public bool themNhanVien(NhanVien nv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.NhanVien_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@Ma_NV", null);
            cmd.Parameters.AddWithValue("@HoTen_NV", nv.HoTen);
            cmd.Parameters.AddWithValue("@Nam_sinh ", nv.NgaySinh);
            cmd.Parameters.AddWithValue("@Gioi_tinh", nv.GioiTinh);
            cmd.Parameters.AddWithValue("@CCCD", nv.Cccd);
            cmd.Parameters.AddWithValue("@sdt", nv.Sdt);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public bool suaNhanVien(NhanVien nv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.NhanVien_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@Ma_NV", nv.MaNV);
            cmd.Parameters.AddWithValue("@HoTen_NV", nv.HoTen);
            cmd.Parameters.AddWithValue("@Nam_sinh ", nv.NgaySinh);
            cmd.Parameters.AddWithValue("@Gioi_tinh", nv.GioiTinh);
            cmd.Parameters.AddWithValue("@CCCD", nv.Cccd);
            cmd.Parameters.AddWithValue("@sdt", nv.Sdt);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool xoaNhanVien(NhanVien nv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.NhanVien_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@Ma_NV", nv.MaNV);
            cmd.Parameters.AddWithValue("@HoTen_NV", nv.HoTen);
            cmd.Parameters.AddWithValue("@Nam_sinh ", nv.NgaySinh);
            cmd.Parameters.AddWithValue("@Gioi_tinh", nv.GioiTinh);
            cmd.Parameters.AddWithValue("@CCCD", nv.Cccd);
            cmd.Parameters.AddWithValue("@sdt", nv.Sdt);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public void bindGridView(DataGridView dataGridView)
        {
            conn.Open();
            string query = "SELECT * from NhanVien";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }

        public void bindGridViewbySearch(DataGridView dataGridView, string name)
        {
            conn.Open();
            string query = "SELECT * from NhanVien where maNV LIKE '%' + @name + '%' or hoTen LIKE '%' + @name + '%'";
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
