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
    public partial class pay : Form
    {
        private int mahd;
        private HoaDon nHD;
        private KhachHang kh;
        public pay(int mahd)
        {
            InitializeComponent();
            this.mahd = mahd;

        }
        BUS_HoaDon bHD = new BUS_HoaDon();
        private void pay_Load(object sender, EventArgs e)
        {
            txt_id.Text = mahd.ToString();
            tong.Text = bHD.getTongTien(mahd).ToString();
            ngaytra.Text = DateTime.Now.ToString();
            maKH.Text = Info_room.maKH;

        }
        BUS_KhachHang bKH = new BUS_KhachHang();
        BUS_Phong bP = new BUS_Phong();
        BUS_ChiTietDichVu bCTDV = new BUS_ChiTietDichVu();
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you agree to make the payment?", "Payment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Select form of payment!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Thực hiện các thao tác khác ở đây nếu giá trị của ComboBox không phải là null

                    MessageBox.Show("Payment successful!");
                    nHD = new HoaDon(mahd, bHD.getTongTien(mahd), DateTime.Now, true);
                    bHD.suaHoaDon(nHD);
                    bKH.xoaKhachHang2(Info_room.maKH);
                    bP.updateTrangThaiPhong2(Info_room.room);
                    bCTDV.xoaCTDV(Info_room.room);
                    this.Close();
                }
            }

            
        }
    }
}
