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

namespace hotel
{
    public partial class booked : UserControl
    {
        public booked()
        {
            InitializeComponent();
        }
        BUS_HoaDon bHD = new BUS_HoaDon();
        private void booked_Load(object sender, EventArgs e)
        {

            bHD.bindGridView(dgv_hd);
            dgv_hd.Columns[0].HeaderText = "Mã hóa đơn";
            dgv_hd.Columns[1].HeaderText = "Tổng tiền";
            dgv_hd.Columns[2].HeaderText = "Ngày lập";
            dgv_hd.Columns[3].HeaderText = "Trạng thái";
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            bHD.bindGridViewbySearch(dgv_hd, txt_search.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            bHD.bindGridView(dgv_hd);
            dgv_hd.Columns[0].HeaderText = "Mã hóa đơn";
            dgv_hd.Columns[1].HeaderText = "Tổng tiền";
            dgv_hd.Columns[2].HeaderText = "Ngày lập";
            dgv_hd.Columns[3].HeaderText = "Trạng thái";
        }
    }
}
