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
    public class DAL_ChiTietDichVu : DBConnect
    {
        public bool themCTDV(ChiTietDichVu ctdv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.ChiTietDichVu_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@Ma_dich_vu", ctdv.MaDichVu);
            cmd.Parameters.AddWithValue("@Ma_phong", ctdv.MaPhong);
            cmd.Parameters.AddWithValue("@Thanh_tien", ctdv.ThanhTien);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
        public bool xoaCTDV(int id)
        {
            conn.Open();
            string query = "DELETE FROM ChiTietDichVu WHERE maPhong = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);


            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
        public void bindGridView(DataGridView dataGridView, int id)
        {
            conn.Open();
            string query = "SELECT * from ChiTietDichVu WHERE maPhong = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@id", id);

            DataTable dt = new DataTable();
            dv.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }

        public int demSoLuongMaDV(int maDV, int id)
        {
            int count = 0;
            conn.Open();
            string query = "SELECT COUNT(maDichVu) FROM ChiTietDichVu WHERE maDichVu = @maDV AND maPhong = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@maDV", maDV);
            cmd.Parameters.AddWithValue("@id", id);
            count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count;
        }
    }
}
