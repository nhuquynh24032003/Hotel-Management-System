using BUS;
using DTO;

namespace hotel
{
    public partial class checkin : UserControl
    {
        BUS_Phong bP = new BUS_Phong();
        public checkin()
        {
            InitializeComponent();

        }

        private void checkin_Load(object sender, EventArgs e)
        {
            bP.bindGridViewByStatus(dgv_Phong);
            dgv_Phong.Columns[0].HeaderText = "Mã Phòng";
            dgv_Phong.Columns[1].HeaderText = "Loại";
            dgv_Phong.Columns[2].HeaderText = "Số người";
            dgv_Phong.Columns[3].HeaderText = "Giá";

            tt1.Text = bP.getPhongById(1).TrangThai.ToString();
            tt2.Text = bP.getPhongById(2).TrangThai.ToString();
            tt3.Text = bP.getPhongById(3).TrangThai.ToString();
            tt4.Text = bP.getPhongById(4).TrangThai.ToString();
            tt5.Text = bP.getPhongById(5).TrangThai.ToString();
            tt6.Text = bP.getPhongById(6).TrangThai.ToString();
            tt7.Text = bP.getPhongById(7).TrangThai.ToString();
            tt8.Text = bP.getPhongById(8).TrangThai.ToString();
            tt9.Text = bP.getPhongById(9).TrangThai.ToString();
            tt10.Text = bP.getPhongById(10).TrangThai.ToString();


        }


        private void button13_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(6);
            room.ShowDialog();

        }



        private void btn_r1_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(1);
            room.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(2);
            room.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(3);
            room.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(4);
            room.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(5);
            room.ShowDialog();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(7);
            room.ShowDialog();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(8);
            room.ShowDialog();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(9);
            room.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Info_room room = new Info_room(10);
            room.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }



        private void dgv_Phong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Phong.Rows[e.RowIndex];

                // Kiểm tra rỗng sau đó mới truyền data
                int maPhong = 0;
                if (row.Cells[0].Value != null)
                    maPhong = Convert.ToInt32(row.Cells[0].Value);

                string loaiPhong = "";
                if (row.Cells[1].Value != null)
                    loaiPhong = row.Cells[1].Value.ToString();

                int soNguoi = 0;
                if (row.Cells[2].Value != null)
                    soNguoi = Convert.ToInt32(row.Cells[2].Value);

                int giaPhong = 0;
                if (row.Cells[3].Value != null)
                    giaPhong = Convert.ToInt32(row.Cells[3].Value);


                Phong selectedPhong = new Phong(maPhong, loaiPhong, soNguoi, giaPhong, false);
                customer c = new customer(maPhong);
                c.ShowDialog();
            }
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void button4_Click_1(object sender, EventArgs e)
        {
            bP.bindGridViewByStatus(dgv_Phong);
            dgv_Phong.Columns[0].HeaderText = "Mã Phòng";
            dgv_Phong.Columns[1].HeaderText = "Loại";
            dgv_Phong.Columns[2].HeaderText = "Số người";
            dgv_Phong.Columns[3].HeaderText = "Giá";

            tt1.Text = bP.getPhongById(1).TrangThai.ToString();
            tt2.Text = bP.getPhongById(2).TrangThai.ToString();
            tt3.Text = bP.getPhongById(3).TrangThai.ToString();
            tt4.Text = bP.getPhongById(4).TrangThai.ToString();
            tt5.Text = bP.getPhongById(5).TrangThai.ToString();
            tt6.Text = bP.getPhongById(6).TrangThai.ToString();
            tt7.Text = bP.getPhongById(7).TrangThai.ToString();
            tt8.Text = bP.getPhongById(8).TrangThai.ToString();
            tt9.Text = bP.getPhongById(9).TrangThai.ToString();
            tt10.Text = bP.getPhongById(10).TrangThai.ToString();
        }
    }
}
