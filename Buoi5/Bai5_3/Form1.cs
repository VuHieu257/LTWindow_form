using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai5_3
{
    public partial class Form1 : Form
    {
         string[] dsLoai = { "Coffee","Trà Hoa Quả","Nước Ngọt","Giặt Sấy"};
         string[] dsDV = {"Ly","Cái", "Lon", "Bộ Đồ" };
        int rowChoose = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSP();
        }
        private void loadSP()
        {
            cbbLoaisp.DataSource = dsLoai;
            cbbLoaisp.SelectedIndex = 0;
            cbbDV.DataSource = dsDV;
            cbbDV.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double diemtb;
                if (txtbName.Text.Length <= 1)
                {
                    throw new Exception("Tên Sản Phẩm Phải có ít nhất 1 ký tự");
                }
                if (txtbMaSP.Text.Length <= 1)
                {
                    throw new Exception("Mã Sản Phẩm phải có ít nhất 1 ký tự");
                }
                if (!double.TryParse(txtbCount.Text, out diemtb))
                {
                    throw new Exception("Vui Lòng Nhập Số Lượng");
                }
                if (!double.TryParse(txtbPrice.Text, out diemtb))
                {
                    throw new Exception("Vui Lòng Nhập Giá");
                }
                string masp = txtbMaSP.Text;
                string name = txtbName.Text;
                string loaisp = cbbLoaisp.Text;
                string donvi = cbbDV.Text;
                string count = txtbCount.Text;
                string price = txtbPrice.Text;
                int total=Convert.ToInt32(count)*Convert.ToInt32(price);
                datagvDS.Rows.Add(masp, name,loaisp, count, price, total,donvi);
            }
            catch
            (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void datagvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1 || e.RowIndex >= datagvDS.Rows.Count - 1)
                {
                    throw new Exception("Vui Lòng chọn Sản Phẩm");
                }
                rowChoose = e.RowIndex;
                txtbMaSP.Text = datagvDS.Rows[rowChoose].Cells["MaSP"].Value.ToString();
                txtbName.Text = datagvDS.Rows[rowChoose].Cells["dtName"].Value.ToString();
                txtbPrice.Text = datagvDS.Rows[rowChoose].Cells["dtPrice"].Value.ToString();
                txtbCount.Text = datagvDS.Rows[rowChoose].Cells["dtCount"].Value.ToString();
                cbbLoaisp.Text = datagvDS.Rows[rowChoose].Cells["dtLoai"].Value.ToString();
                cbbDV.Text = datagvDS.Rows[rowChoose].Cells["dtDV"].Value.ToString();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                txtbMaSP.ReadOnly = true;
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
                datagvDS.Rows[rowChoose].Cells["dtName"].Value=txtbName.Text;
                datagvDS.Rows[rowChoose].Cells["dtPrice"].Value=txtbPrice.Text;
                datagvDS.Rows[rowChoose].Cells["dtCount"].Value=txtbCount.Text;
                datagvDS.Rows[rowChoose].Cells["dtLoai"].Value=cbbLoaisp.Text;
                datagvDS.Rows[rowChoose].Cells["dtDV"].Value=cbbDV.Text;
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
                    throw new Exception("Vui Lòng chọn Sản Phẩm");
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
