using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_2
{
    public partial class Form1 : Form
    {
        string[] dsKhoa = { "CNTT", "QTKD", "CN Ô Tô", "Khách Sạn Nhà Hàng" };
        int rowChoose = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double diemtb;
                if (tbName.Text.Length <= 1)
                {
                    throw new Exception("Tên Sinh Viên Phải có ít nhất 1 ký tự");
                }
                if (mtbMaSV.Text.Length <= 9)
                {
                    throw new Exception("Mã Sinh Viên Phải đủ 10 ký tự");
                }
                if (!double.TryParse(tbDiem.Text, out diemtb))
                {
                    throw new Exception("Vui Lòng Nhập điểm");
                }
                string masv = mtbMaSV.Text;
                string name = tbName.Text;
                string diem = tbDiem.Text;
                string khoa = cbKhoa.Text;
                datagvDS.Rows.Add(masv, name, diem, khoa);
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadKhoa();
        }
        private void loadKhoa()
        {
           cbKhoa.DataSource= dsKhoa;
            cbKhoa.SelectedItem=0;
        }

        private void datagvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1|| e.RowIndex >= datagvDS.Rows.Count-1)
                {
                    throw new Exception("Vui Lòng chọn Sinh Viên");
                }
                rowChoose=e.RowIndex;
                mtbMaSV.Text = datagvDS.Rows[rowChoose].Cells["MaSV"].Value.ToString();
                tbName.Text = datagvDS.Rows[rowChoose].Cells["dtName"].Value.ToString();
                tbDiem.Text = datagvDS.Rows[rowChoose].Cells["dtDiem"].Value.ToString();
                cbKhoa.Text = datagvDS.Rows[rowChoose].Cells["dtKhoa"].Value.ToString();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                mtbMaSV.ReadOnly = true;
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowChoose == -1 || rowChoose >= datagvDS.Rows.Count - 1)
                {
                    throw new Exception("Vui Lòng chọn Sinh Viên");
                }
                datagvDS.Rows[rowChoose].Cells["dtName"].Value = tbName.Text;
                datagvDS.Rows[rowChoose].Cells["dtDiem"].Value = tbDiem.Text;
                datagvDS.Rows[rowChoose].Cells["dtKhoa"].Value = cbKhoa.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowChoose == -1 || rowChoose >= datagvDS.Rows.Count - 1)
                {
                    throw new Exception("Vui Lòng chọn Sinh Viên");
                }
                datagvDS.Rows.RemoveAt(rowChoose);
                rowChoose = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn Thoát Không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
