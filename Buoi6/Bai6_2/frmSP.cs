using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6_2
{
    public partial class frmSP : Form
    {
        SanPhamDAO SanPhamDAO = new SanPhamDAO();
        string insertupdate = "";
        public frmSP()
        {
            InitializeComponent();
        }

        private void frmSP_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            mtbMaSP.Enabled = false;
            btnDelete.Enabled = false;
            loadDSS();
            TongSP();
        }
        private void TongSP()
        {
            datagvSP.DataSource = SanPhamDAO.getList();
        }

        private void loadDSS()
        {
            txtbCount.Text = SanPhamDAO.getCount().ToString(); ;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            mtbMaSP.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            mtbMaSP.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                double giaban = 0;
                double giamua = 0;
                if (mtbMaSP.Text.Length <= 1)
                {
                    throw new Exception("Mã sản phẩm phải có ít nhất 1 ký tự");
                }
                if (tbName.Text.Length <= 1)
                {
                    throw new Exception("Tên sản phẩm phải có ít nhất 1 ký tự");
                }
                if (txtDVTinh.Text.Length <= 1)
                {
                    throw new Exception("Đơn Vị tính phải có ít nhất 1 ký tự");
                }
                if (txtLoai.Text.Length <= 1)
                {
                    throw new Exception("loại sản phẩm phải có ít nhất 1 ký tự");
                }
                if (!double.TryParse(txtGiaBan.Text, out giaban))
                {
                    throw new Exception("Giá Bán phải là số");
                }
                if (!double.TryParse(txtGiaMua.Text, out giamua))
                {
                    throw new Exception("Giá Mua phải là số");
                }
                string masp = mtbMaSP.Text;
                string tensp = tbName.Text;
                string dvtinh = txtDVTinh.Text;
                string maloai = txtLoai.Text;
                SanPham sv = new SanPham(masp, tensp, dvtinh, maloai, giaban,giamua);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            SanPhamDAO.InsertSV(sv);
                            loadDSS();
                            TongSP();
                            MessageBox.Show("Thêm thành công", "thông báo");
                            break;
                        }
                    case "update":
                        {
                            SanPhamDAO.UpdateSV(sv);
                            loadDSS();
                            TongSP();
                            MessageBox.Show("cập nhật thành công", "thông báo");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtbMaSP.Text.Length != 10)
                {
                    throw new Exception("Mã sinh vien 10 ký tự số");
                }
                string masp = mtbMaSP.Text;
                SanPhamDAO.DeleteSV(masp);
                loadDSS();
                TongSP();
                MessageBox.Show("Xóa thành công", "thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datagvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= datagvSP.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên");
                }
                mtbMaSP.Text = datagvSP.Rows[rowindex].Cells["MaSV"].Value.ToString();
                tbName.Text = datagvSP.Rows[rowindex].Cells["TenSP"].Value.ToString();
                txtLoai.Text = datagvSP.Rows[rowindex].Cells["MaLoai"].Value.ToString();
                txtDVTinh.Text = datagvSP.Rows[rowindex].Cells["DVTinh"].Value.ToString();
                txtGiaMua.Text = datagvSP.Rows[rowindex].Cells["GiaMua"].Value.ToString();
                txtGiaBan.Text = datagvSP.Rows[rowindex].Cells["GiaBan"].Value.ToString();
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
