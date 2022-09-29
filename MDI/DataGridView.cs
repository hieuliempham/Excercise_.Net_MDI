using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        private int GetSelectedRow(string ID)
        {
            for (int i = 0; i < dgvNhanVien.Rows.Count; i++)
            {
                if (dgvNhanVien.Rows[i].Cells[0].Value.ToString() == ID)
                {
                    return i;
                }
            }
            return -1;
        }

        private void InsertUpdate(int selectedRow)
        {
            dgvNhanVien.Rows[selectedRow].Cells[0].Value = txtMaNV.Text;
            dgvNhanVien.Rows[selectedRow].Cells[1].Value = txtHoTen.Text;
            dgvNhanVien.Rows[selectedRow].Cells[2].Value = txtSDT.Text;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNV.Text == "" || txtHoTen.Text == "" || txtSDT.Text == "")
                    throw new Exception("Vui Lòng Nhập đầy đủ thông tin Nhân Viên!");

                int selectedRow = GetSelectedRow(txtMaNV.Text);
                if (selectedRow == -1) // thêm mới
                {
                    selectedRow = dgvNhanVien.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm dữ liệu mới Thành Công !", "Thông Báo", MessageBoxButtons.OK);
                }
                else// Cập nhật
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
