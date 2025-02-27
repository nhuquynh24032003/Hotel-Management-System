using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_DichVu : DBConnect
    {
        public bool themDichVu(DichVu dv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.DichVu_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@Ma_DV", null);
            cmd.Parameters.AddWithValue("@Ten_DV", dv.TenDichVu);
            cmd.Parameters.AddWithValue("@Gia_DV", dv.GiaDichVu);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public bool suaDichVu(DichVu dv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.DichVu_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@Ma_DV", dv.MaDichVu);
            cmd.Parameters.AddWithValue("@Ten_DV", dv.TenDichVu);
            cmd.Parameters.AddWithValue("@Gia_DV", dv.GiaDichVu);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public bool xoaDichVu(DichVu dv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.DichVu_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@Ma_DV", dv.MaDichVu);

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
            string query = "SELECT * from DichVu";
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
            string query = "SELECT * from DichVu where maDichVu LIKE '%' + @name + '%' or tenDichVu LIKE '%' + @name + '%'";
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
