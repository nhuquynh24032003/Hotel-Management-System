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
using DTO;

namespace hotel
{
    public partial class addservice : Form
    {
        private int id;
        private int maDV = 0;
        public addservice(int id)
        {
            InitializeComponent();
            this.id = id;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        BUS_DichVu bDV = new BUS_DichVu();
        private void addservice_Load(object sender, EventArgs e)
        {
            bDV.bindGridView(dgv_service);
            dgv_service.Columns[0].HeaderText = "Mã DV";
            dgv_service.Columns[1].HeaderText = "Tên Dịch Vụ";
            dgv_service.Columns[2].HeaderText = "Giá";
        }
        BUS_ChiTietDichVu bCTDV = new BUS_ChiTietDichVu();
        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedCTDV != null)
            {
                if(bCTDV.demSoLuongMaDV(maDV, id)==0)
                {
                    if (bCTDV.themCTDV(selectedCTDV))
                    {
                            MessageBox.Show("Add Successfully");
                        
                    }
                    else
                    {
                        MessageBox.Show("Cannot add service");
                    }
                }
                else
                {
                    MessageBox.Show("Service was selected!");
                }
                
               
            }
            else
            {
                MessageBox.Show("You have to choose a service first");
            }

        }
        private ChiTietDichVu selectedCTDV;

        private void dgv_service_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_service.Rows[e.RowIndex];

                // Kiểm tra rỗng sau đó mới truyền data
                
                int.TryParse(row.Cells[0].Value.ToString(), out maDV);

                string tenDV = "";
                if (row.Cells[1].Value != null)
                    tenDV = row.Cells[1].Value.ToString();

                int gia = 0;
                int.TryParse(row.Cells[2].Value.ToString(), out gia);


                selectedCTDV = new ChiTietDichVu(maDV, id, gia);

            }
        }
    }
}
