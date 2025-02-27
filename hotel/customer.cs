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
using static System.Net.Mime.MediaTypeNames;

namespace hotel
{
    public partial class customer : Form
    {
        private string mp;
        public customer(int maPhong)
        {
            mp = maPhong.ToString();
            InitializeComponent();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
        }
        BUS_KhachHang bKH = new BUS_KhachHang();
        BUS_Phong bP  = new BUS_Phong();
        BUS_HoaDon bHD = new BUS_HoaDon();
        BUS_ChiTietHoaDon bCTHD = new BUS_ChiTietHoaDon();
        private HoaDon aHD;
        private ChiTietHoaDon aCTHD;
        int tien = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            /*            this.Close();
                        Info_room i = new Info_room();
                        i.ShowDialog();*/


            if (string.IsNullOrWhiteSpace(txt_ten.Text) ||
                string.IsNullOrWhiteSpace(txt_diachi.Text) ||
                string.IsNullOrWhiteSpace(txt_quequan.Text) ||
                string.IsNullOrWhiteSpace(txt_cccd.Text) ||
                string.IsNullOrWhiteSpace(txt_sdt.Text))


            {
                MessageBox.Show("Please fill in all the required information.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!cb_male.Checked && !cb_female.Checked)
            {
                MessageBox.Show("Please select a gender.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            KhachHang kh = new KhachHang(null, Convert.ToInt32(mp), txt_ten.Text, cb_male.Checked, txt_diachi.Text, txt_quequan.Text, txt_sdt.Text, txt_cccd.Text, schedule.ngaydat, schedule.ngaytra);

            if (bKH.themKhachHang(kh))
            {
                MessageBox.Show("Added Successfully");
                bP.updateTrangThaiPhong1(Convert.ToInt32(mp));
                TimeSpan duration = schedule.ngaytra.Subtract(schedule.ngaydat);
                int soNgay = duration.Days + 1;
                tien = bP.getGiaPhong(Convert.ToInt32(mp)) * soNgay;
                aHD = new HoaDon(0, tien, DateTime.Now, false);
                bHD.themHoaDon(aHD);

                aCTHD = new ChiTietHoaDon(bHD.selectLastHD(), Convert.ToInt32(mp));
                bCTHD.themCTHD(aCTHD);
                this.Close();
                Info_room i = new Info_room(Convert.ToInt32(mp));
                i.ShowDialog();

            }
            else
            {
                MessageBox.Show("Add Failed");
            }

        }

        private void customer_Load_1(object sender, EventArgs e)
        {
            txt_room.Text = mp;
            ngaydat.Text = schedule.ngaydat.ToString("dd/MM/yyyy");
            ngaytra.Text = schedule.ngaytra.ToString("dd/MM/yyyy");

        }
    }
}
