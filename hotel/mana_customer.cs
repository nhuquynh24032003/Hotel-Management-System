using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;

namespace hotel
{
    public partial class mana_customer : UserControl
    {
        public mana_customer()
        {
            InitializeComponent();
        }
        BUS_KhachHang bKH = new BUS_KhachHang();
        private void mana_customer_Load(object sender, EventArgs e)
        {
            bKH.bindGridView(dgv_cus);
            dgv_cus.Columns[0].HeaderText = "Mã KH";
            dgv_cus.Columns[1].HeaderText = "Mã phòng";
            dgv_cus.Columns[2].HeaderText = "Họ và tên";
            dgv_cus.Columns[3].HeaderText = "Giới tính";
            dgv_cus.Columns[4].HeaderText = "Địa chỉ";
            dgv_cus.Columns[5].HeaderText = "Quê quán";
            dgv_cus.Columns[6].HeaderText = "SĐT";
            dgv_cus.Columns[7].HeaderText = "CCCD";
            dgv_cus.Columns[8].HeaderText = "Ngày đặt phòng";
            dgv_cus.Columns[9].HeaderText = "Ngày trả phòng";

        }




        private void button1_Click(object sender, EventArgs e)
        {
            bKH.bindGridViewbySearch(dgv_cus, txt_search.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bKH.bindGridView(dgv_cus);
            dgv_cus.Columns[0].HeaderText = "Mã KH";
            dgv_cus.Columns[1].HeaderText = "Mã phòng";
            dgv_cus.Columns[2].HeaderText = "Họ và tên";
            dgv_cus.Columns[3].HeaderText = "Giới tính";
            dgv_cus.Columns[4].HeaderText = "Địa chỉ";
            dgv_cus.Columns[5].HeaderText = "Quê quán";
            dgv_cus.Columns[6].HeaderText = "SĐT";
            dgv_cus.Columns[7].HeaderText = "CCCD";
            dgv_cus.Columns[8].HeaderText = "Ngày đặt phòng";
            dgv_cus.Columns[9].HeaderText = "Ngày trả phòng";
        }
    }
}
