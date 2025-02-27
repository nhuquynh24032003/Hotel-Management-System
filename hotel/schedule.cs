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
    public partial class schedule : Form
    {
        public schedule()
        {
            InitializeComponent();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
        BUS_KhachHang bKH = new BUS_KhachHang();
        BUS_Phong bP = new BUS_Phong();
        public static DateTime ngaydat;
        public static DateTime ngaytra;
        private void button1_Click(object sender, EventArgs e)
        {
            //   (ngayDat.Value)
            DateTime now = DateTime.Now.Date;
            if (ngayDat.Value.Date < now || ngayTra.Value.Date < now )
            {
                MessageBox.Show("Date selected not valid!");
                return;
            }
            if (ngayTra.Value.Date < ngayDat.Value.Date)
            {
                MessageBox.Show("Date selected not valid!");
                return;
            }
            bP.updateTrangThaiPhong0();

            KhachHang kh = new KhachHang();
            kh.NgayDatPhong = ngayDat.Value;
            ngaydat = ngayDat.Value;
            kh.NgayTraphong = ngayTra.Value;
            ngaytra = ngayTra.Value;
            bP.updateTrangThaiPhong(kh.NgayDatPhong.Date, kh.NgayTraphong.Date);
            this.Close();
        }

        private void schedule_Load(object sender, EventArgs e)
        {

        }
    }
}
