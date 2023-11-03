using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6_3
{
    public partial class frmNhanVien : Form
    {
        NhanVienDAO nhanVienDAO=new NhanVienDAO();
        string insertupdate = "";
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtManv.Enabled = false;
            btnDelete.Enabled = false;
            loadDSSach();
            TongSach();
        }
        private void TongSach()
        {
            datagvSP.DataSource = nhanVienDAO.getList();
        }
        private void loadDSSach()
        {
            txtbCount.Text = nhanVienDAO.getCount().ToString();
            cbGT.SelectedIndex = 0;
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
                txtManv.Text = datagvSP.Rows[rowindex].Cells["MaNV"].Value.ToString();
                txtTenNV.Text = datagvSP.Rows[rowindex].Cells["TenNV"].Value.ToString();
                cbGT.Text = datagvSP.Rows[rowindex].Cells["GioiTinh"].Value.ToString();
                txtSDT.Text = datagvSP.Rows[rowindex].Cells["DienThoai"].Value.ToString();
                txtEmail.Text = datagvSP.Rows[rowindex].Cells["Email"].Value.ToString();
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            txtManv.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtManv.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtManv.Text.Length <= 0)
                {
                    throw new Exception("Mã Không được để trống");
                }
                if (txtTenNV.Text.Length <= 0)
                {
                    throw new Exception("Tên NV Không được để trống");
                }
                if (cbGT.SelectedIndex == 0)
                {
                    throw new Exception("Vui Lòng chọn giới tính");
                }
                if (txtSDT.Text.Length <= 0)
                {
                    throw new Exception("Số Điện thoại Không được để trống");
                }
                if (txtEmail.Text.Length <= 0)
                {
                    throw new Exception("Năm Xuất Bản Không được để trống");
                }
                string manv = txtManv.Text;
                string tennv = txtTenNV.Text;
                string gt = cbGT.Text;
                string sodt = txtSDT.Text;
                string namxbs = txtEmail.Text;
                NhanVien sv = new NhanVien(manv, tennv, gt, sodt, namxbs);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            nhanVienDAO.InsertSV(sv);
                            loadDSSach();
                            TongSach();
                            MessageBox.Show("Thêm thành công", "thông báo");
                            break;
                        }
                    case "update":
                        {
                            nhanVienDAO.UpdateSV(sv);
                            loadDSSach();
                            TongSach();
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
                if (txtManv.Text.Length <= 0)
                {
                    throw new Exception("Mã NV Không được để trống");
                }
                string manv = txtManv.Text;
                nhanVienDAO.DeleteSV(manv);
                loadDSSach();
                TongSach();
                MessageBox.Show("Xóa thành công", "thông báo");
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
