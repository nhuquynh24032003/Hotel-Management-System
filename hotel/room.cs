using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class room : UserControl
    {

        BUS_Phong bP = new BUS_Phong();
        Phong selectedPhong;
        public room()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void room_Load(object sender, EventArgs e)
        {
            bP.bindGridView(dgv_Phong);
            dgv_Phong.Columns[0].HeaderText = "Mã Phòng";
            dgv_Phong.Columns[1].HeaderText = "Loại";
            dgv_Phong.Columns[2].HeaderText = "Số người";
            dgv_Phong.Columns[3].HeaderText = "Giá";
            dgv_Phong.Columns[4].HeaderText = "Trạng thái";

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*            Info_room i = new Info_room();
                        i.ShowDialog();*/
            if (selectedPhong != null)
            {
                Info_room i = new Info_room(selectedPhong.MaPhong);
                i.ShowDialog();
            }
            else
            {
                MessageBox.Show("You have to choose a room first");
            }
        }

        private void dgv_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Phong.Rows[e.RowIndex];
                int maPhong;
                if (int.TryParse(row.Cells[0].Value?.ToString(), out maPhong))
                {
                    string loaiPhong = row.Cells[1].Value?.ToString();

                    int soNguoi;
                    int.TryParse(row.Cells[2].Value?.ToString(), out soNguoi);

                    int giaPhong;
                    int.TryParse(row.Cells[3].Value?.ToString(), out giaPhong);

                    bool trangThai = false;
                    if (dgv_Phong.Rows[e.RowIndex].Cells["trangThai"].Value != null)
                        trangThai = (bool)dgv_Phong.Rows[e.RowIndex].Cells["trangThai"].Value;


                    selectedPhong = new Phong(maPhong, loaiPhong, soNguoi, giaPhong, trangThai);

                    txt_id.Text = selectedPhong.MaPhong.ToString();
                    txt_max.Text = selectedPhong.SoNguoi.ToString();
                    txt_price.Text = selectedPhong.GiaPhong.ToString();
                    cbx_type.Text = selectedPhong.LoaiPhong.ToString();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bP.bindGridViewbySearch(dgv_Phong, txt_search.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (selectedPhong != null)
            {
                if (bP.xoaPhong(selectedPhong))
                {
                    MessageBox.Show("Delete Successfully");
                    dgv_Phong.Rows.RemoveAt(dgv_Phong.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("Cannot delete room");
                }
            }
            else
            {
                MessageBox.Show("You have to choose a room first");
            }
        }

        private void dgv_Phong_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Phong.Rows[e.RowIndex];

                // Kiểm tra rỗng sau đó mới truyền data
                string loaiPhong = row.Cells[1].Value?.ToString();

                int soNguoi;
                int.TryParse(row.Cells[2].Value?.ToString(), out soNguoi);

                int giaPhong;
                int.TryParse(row.Cells[3].Value?.ToString(), out giaPhong);

                bool trangThai = false;
                if (dgv_Phong.Rows[e.RowIndex].Cells["trangThai"].Value != null)
                    trangThai = (bool)dgv_Phong.Rows[e.RowIndex].Cells["trangThai"].Value;

                selectedPhong = new Phong(selectedPhong.MaPhong, loaiPhong, soNguoi, giaPhong, trangThai);
                bP.suaPhong(selectedPhong);
                dgv_Phong.Refresh();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bP.bindGridView(dgv_Phong);
            dgv_Phong.Columns[0].HeaderText = "Mã Phòng";
            dgv_Phong.Columns[1].HeaderText = "Loại";
            dgv_Phong.Columns[2].HeaderText = "Số người";
            dgv_Phong.Columns[3].HeaderText = "Giá";
            dgv_Phong.Columns[4].HeaderText = "Trạng thái";
        }
    }
}
