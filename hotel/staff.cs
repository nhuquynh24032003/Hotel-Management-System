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
    public partial class staff : UserControl
    {
        BUS_NhanVien bNV = new BUS_NhanVien();
        private NhanVien selectedNV;
        public staff()
        {
            InitializeComponent();
        }

        private void ck_male_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_male.Checked)
            {
                ck_female.Checked = false;
            }
        }

        private void ck_female_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_female.Checked)
            {
                ck_male.Checked = false;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void staff_Load(object sender, EventArgs e)
        {
            bNV.bindGridView(dgv_emp);
            dgv_emp.Columns[0].HeaderText = "Mã NV";
            dgv_emp.Columns[1].HeaderText = "Họ và tên";
            dgv_emp.Columns[2].HeaderText = "Ngày sinh";
            dgv_emp.Columns[3].HeaderText = "Giới tính";
            dgv_emp.Columns[4].HeaderText = "CCCD";
            dgv_emp.Columns[5].HeaderText = "SĐT";
        }

        private void dgv_emp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_emp.Rows[e.RowIndex];

                // Kiểm tra rỗng sau đó mới truyền data
                string maNV = "";
                if (row.Cells[0].Value != null)
                    maNV = row.Cells[0].Value.ToString();

                string tenNV = "";
                if (row.Cells[1].Value != null)
                    tenNV = row.Cells[1].Value.ToString();

                DateTime ngaySinh = DateTime.MinValue;
                DateTime.TryParse(row.Cells[2].Value.ToString(), out ngaySinh);

                bool gioiTinh = false;
                bool.TryParse(row.Cells[3].Value.ToString(), out gioiTinh);

                string cccd = "";
                if (row.Cells[4].Value != null)
                    cccd = row.Cells[4].Value.ToString();

                string sdt = "";
                if (row.Cells[5].Value != null)
                    sdt = row.Cells[5].Value.ToString();

                selectedNV = new NhanVien(maNV, tenNV, ngaySinh, gioiTinh, cccd, sdt);
                txt_id.Text = selectedNV.MaNV;
                txt_name.Text = selectedNV.HoTen;
                date_dob.Value = selectedNV.NgaySinh;
                txt_idCard.Text = selectedNV.Cccd;
                txt_phone.Text = selectedNV.Sdt;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedNV != null)
            {
                if (bNV.xoaNhanVien(selectedNV))
                {
                    MessageBox.Show("Delete employee successfully");
                    dgv_emp.Rows.RemoveAt(dgv_emp.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("Cannot delete the employee, try again");
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_name.Text) ||
                string.IsNullOrWhiteSpace(txt_idCard.Text) ||
                string.IsNullOrWhiteSpace(txt_phone.Text))
            {
                MessageBox.Show("Please fill in all the required information.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!ck_male.Checked && !ck_female.Checked)
            {
                MessageBox.Show("Please select a gender.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NhanVien nv = new NhanVien(null, txt_name.Text, date_dob.Value, ck_male.Checked, txt_idCard.Text, txt_phone.Text);
            if (bNV.themNhanVien(nv))
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
            date_dob.Value = DateTime.Now;
            txt_idCard.Text = string.Empty;
            txt_phone.Text = string.Empty;
            ck_male.Checked = false;
            ck_female.Checked = false;
        }

        private void RefreshGridView()
        {
            bNV.bindGridView(dgv_emp);
        }

        private void dgv_emp_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_emp.Rows[e.RowIndex];

                // Kiểm tra rỗng sau đó mới truyền data
                string maNV = "";
                if (row.Cells[0].Value != null)
                    maNV = row.Cells[0].Value.ToString();

                string tenNV = "";
                if (row.Cells[1].Value != null)
                    tenNV = row.Cells[1].Value.ToString();

                DateTime ngaySinh = DateTime.MinValue;
                DateTime.TryParse(row.Cells[2].Value.ToString(), out ngaySinh);

                bool gioiTinh = false;
                bool.TryParse(row.Cells[3].Value.ToString(), out gioiTinh);

                string cccd = "";
                if (row.Cells[4].Value != null)
                    cccd = row.Cells[4].Value.ToString();

                string sdt = "";
                if (row.Cells[5].Value != null)
                    sdt = row.Cells[5].Value.ToString();

                NhanVien updatedNV = new NhanVien(maNV, tenNV, ngaySinh, gioiTinh, cccd, sdt);
                bNV.suaNhanVien(updatedNV);

                // Refresh
                dgv_emp.Refresh();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bNV.bindGridViewbySearch(dgv_emp, txt_search.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bNV.bindGridViewbySearch(dgv_emp, txt_search.Text);

        }
    }
}
