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
    public partial class service : UserControl
    {
        private DichVu selectedDV;
        BUS_DichVu bDV = new BUS_DichVu();
        public service()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void service_Load(object sender, EventArgs e)
        {
            bDV.bindGridView(dgv_service);
            dgv_service.Columns[0].HeaderText = "Mã DV";
            dgv_service.Columns[1].HeaderText = "Tên Dịch Vụ";
            dgv_service.Columns[2].HeaderText = "Giá";
        }

        private void dgv_service_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_service.Rows[e.RowIndex];

                // Kiểm tra rỗng sau đó mới truyền data
                int maDV = 0;
                int.TryParse(row.Cells[0].Value.ToString(), out maDV);

                string tenDV = "";
                if (row.Cells[1].Value != null)
                    tenDV = row.Cells[1].Value.ToString();


                int gia = 0;
                int.TryParse(row.Cells[2].Value.ToString(), out gia);


                selectedDV = new DichVu(maDV, tenDV, gia);
                txt_id.Text = selectedDV.MaDichVu.ToString();
                txt_name.Text = selectedDV.TenDichVu;
                txt_price.Text = selectedDV.GiaDichVu.ToString();

            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text) ||
              string.IsNullOrWhiteSpace(txt_price.Text))
            {
                MessageBox.Show("Please fill in all the required information.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DichVu dv = new DichVu(0, txt_name.Text, Convert.ToInt32(txt_price.Text));
            if (bDV.themDichVu(dv))
            {
                MessageBox.Show("Added Successfully");
                ClearForm();
                RefreshGridView();

            }
            else
            {
                MessageBox.Show("Add Failed");
            }
        }
        private void ClearForm()
        {
            txt_id.Text = string.Empty;
            txt_name.Text = string.Empty;
            txt_price.Text = string.Empty;
        }

        private void RefreshGridView()
        {
            bDV.bindGridView(dgv_service);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedDV != null)
            {
                if (bDV.xoaDichVu(selectedDV))
                {
                    MessageBox.Show("Delete Successfully");
                    dgv_service.Rows.RemoveAt(dgv_service.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("Cannot delete service");
                }
            }
            else
            {
                MessageBox.Show("You have to choose a service first");
            }
        }

        private void dgv_service_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_service.Rows[e.RowIndex];

                // Kiểm tra rỗng sau đó mới truyền data
                int maDV = 0;
                int.TryParse(row.Cells[2].Value.ToString(), out maDV);

                string tenDV = "";
                if (row.Cells[1].Value != null)
                    tenDV = row.Cells[1].Value.ToString();


                int gia = 0;
                int.TryParse(row.Cells[2].Value.ToString(), out gia);


                selectedDV = new DichVu(maDV, tenDV, gia);
                bDV.suaDichVu(selectedDV);
                dgv_service.Refresh();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bDV.bindGridViewbySearch(dgv_service, txt_search.Text);

        }
    }
}
