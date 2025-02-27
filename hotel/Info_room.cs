using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace hotel
{
    public partial class Info_room : Form
    {
        private int id;
        public static string maKH;
        public static int room;

        private int sum = 0;
        private int tongtien = 0;
        BUS_Phong bP = new BUS_Phong();
        BUS_KhachHang bKH = new BUS_KhachHang();
        BUS_ChiTietHoaDon bCTHD = new BUS_ChiTietHoaDon();
        private int mahd;

        public Info_room(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mahd = bCTHD.getMaHoaDon(id);
            pay p = new pay(mahd);
            p.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addservice a = new addservice(id);
            a.ShowDialog();
        }
        BUS_ChiTietDichVu bCTDV = new BUS_ChiTietDichVu();
        private bool trangthai;
        private void Info_room_Load(object sender, EventArgs e)
        {
            Phong phong = bP.getPhongById(id);

            txt_roomID.Text = phong.MaPhong.ToString();
            room = phong.MaPhong;
            txt_roomType.Text = phong.LoaiPhong;
            txt_roomMax.Text = phong.SoNguoi.ToString();
            txt_roomPrice.Text = phong.GiaPhong.ToString();
            txt_roomStatus.Text = phong.TrangThai.ToString();

            KhachHang kh = bKH.getKhachHangById(id);
            if (phong.TrangThai == true)
            {
                idKH.Text = kh.MaKH;
                maKH = kh.MaKH;
                nameKH.Text = kh.HoTen.ToString();
                gtKH.Text = kh.GioiTinh.ToString();
                dcKH.Text = kh.DiaChi.ToString();
                phoneKH.Text = kh.Sdt.ToString();

                ngaydat.Text = kh.NgayDatPhong.ToString("dd/MM/yyyy");
                ngaytra.Text = kh.NgayTraphong.ToString("dd/MM/yyyy");
                TimeSpan duration = kh.NgayTraphong.Subtract(kh.NgayDatPhong);
                int soNgay = duration.Days + 1;
                trangthai = bCTHD.getTrangThai(id);
                tt.Text = trangthai.ToString();
                button1.Enabled = true;


                bCTDV.bindGridView(dgv_ctdv, id);
                dgv_ctdv.Columns[0].HeaderText = "Mã DV";
                dgv_ctdv.Columns[1].HeaderText = "Mã Phòng";
                dgv_ctdv.Columns[2].HeaderText = "Tiền";

                sum = 0; // Làm mới giá trị của biến "sum"

                foreach (DataGridViewRow row in dgv_ctdv.Rows)
                {
                    if (row.Cells["thanhTien"].Value != null) // Kiểm tra giá trị của ô "Gia"
                    {
                        sum += Convert.ToInt32(row.Cells["thanhTien"].Value);
                    }
                }
                tongdv.Text = sum.ToString();
                int tienPhong = soNgay * phong.GiaPhong;
                
                if(kh.NgayTraphong>DateTime.Now && trangthai == false)
                {
                    TimeSpan duration2 = (DateTime.Now).Subtract(kh.NgayTraphong);
                    int soNgay2 = duration2.Days;
                    tongtien = tienPhong + sum + (tienPhong * soNgay2 * 2);
                }
                else
                {
                    tongtien = tienPhong + sum;
                }
                tonghd.Text = tongtien.ToString();

            }
        }
        private HoaDon nHD;
        BUS_HoaDon bHD = new BUS_HoaDon();
        private void button4_Click(object sender, EventArgs e)
        {
            Phong phong = bP.getPhongById(id);

            txt_roomID.Text = phong.MaPhong.ToString();
            txt_roomType.Text = phong.LoaiPhong;
            txt_roomMax.Text = phong.SoNguoi.ToString();
            txt_roomPrice.Text = phong.GiaPhong.ToString();
            txt_roomStatus.Text = phong.TrangThai.ToString();
            KhachHang kh = bKH.getKhachHangById(id);
            if (phong.TrangThai == true)
            {
                idKH.Text = kh.MaKH.ToString();
                nameKH.Text = kh.HoTen.ToString();
                gtKH.Text = kh.GioiTinh.ToString();
                dcKH.Text = kh.DiaChi.ToString();
                phoneKH.Text = kh.Sdt.ToString();
                ngaydat.Text = kh.NgayDatPhong.ToString("dd/MM/yyyy");
                ngaytra.Text = kh.NgayTraphong.ToString("dd/MM/yyyy");
                button1.Enabled = true;
                TimeSpan duration = kh.NgayTraphong.Subtract(kh.NgayDatPhong);
                int soNgay = duration.Days + 1;
                trangthai = bCTHD.getTrangThai(id);
                tt.Text = trangthai.ToString();
                bCTDV.bindGridView(dgv_ctdv, id);
                dgv_ctdv.Columns[0].HeaderText = "Mã DV";
                dgv_ctdv.Columns[1].HeaderText = "Mã Phòng";
                dgv_ctdv.Columns[2].HeaderText = "Tiền";


                // Assuming the name of your DataGridView is dataGridView1

                // Giả sử tên của DataGridView của bạn là dataGridView1


                sum = 0; // Làm mới giá trị của biến "sum"

                foreach (DataGridViewRow row in dgv_ctdv.Rows)
                {
                    if (row.Cells["thanhTien"].Value != null) // Kiểm tra giá trị của ô "Gia"
                    {
                        sum += Convert.ToInt32(row.Cells["thanhTien"].Value);
                    }
                }
                tongdv.Text = sum.ToString();
                int tienPhong = soNgay * phong.GiaPhong;
                tongtien = tienPhong + sum;
                // Kết quả sẽ được lưu trong biến 'sum'
                TimeSpan duration2 = (DateTime.Now).Subtract(kh.NgayTraphong);
                int soNgay2 = duration2.Days;
                if (soNgay2>0)
                {
                   
                    tongtien = tienPhong + sum + (tienPhong * soNgay2 * 2);
                }
                else
                {
                    tongtien = tienPhong + sum;
                }
                tonghd.Text = tongtien.ToString();


                nHD = new HoaDon(bCTHD.getMaHoaDon(id), tongtien, DateTime.Now, false);
                bHD.suaHoaDon(nHD);
                // The result will be stored in the variable 'sum'
            }
        }
     

    }
}
