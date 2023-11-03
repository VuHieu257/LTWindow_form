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

namespace Bai6_3
{
    public partial class frmNXB : Form
    {
        NhaXuatBanDAO nhaXuatBanDAO=new NhaXuatBanDAO();
        string insertupdate = "";
        public frmNXB()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNXB.Text.Length <= 0)
                {
                    throw new Exception("Mã NXB Không được để trống");
                }
                string mas = txtMaNXB.Text;
                nhaXuatBanDAO.DeleteSV(mas);
                loadDSSach();
                TongSach();
                MessageBox.Show("Xóa thành công", "thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnOut_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmNXB_Load(object sender, EventArgs e)
        {

            btnLuu.Enabled = false;
            txtMaNXB.Enabled = false;
            btnDelete.Enabled = false;
            loadDSSach();
            TongSach();
        }
        private void TongSach()
        {
            datagvSP.DataSource = nhaXuatBanDAO.getList();
        }
        private void loadDSSach()
        {
            txtbCount.Text = nhaXuatBanDAO.getCount().ToString(); ;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNXB.Text.Length <= 0)
                {
                    throw new Exception("Mã Không được để trống");
                }
                if (txtTenNXB.Text.Length <= 0)
                {
                    throw new Exception("Tên NXB Không được để trống");
                }
                if (txtDiaChi.Text.Length <= 0)
                {
                    throw new Exception("Tác Giả Không được để trống");
                }
                if (txtSDT.Text.Length <= 0)
                {
                    throw new Exception("Số Điện thoại Không được để trống");
                }
                if (txtEmail.Text.Length <= 0)
                {
                    throw new Exception("Năm Xuất Bản Không được để trống");
                }
                string mamxb = txtMaNXB.Text;
                string tennxb = txtTenNXB.Text;
                string diachi = txtDiaChi.Text;
                string sodt = txtSDT.Text;
                string namxbs = txtEmail.Text;
                NhaXuatBan sv = new NhaXuatBan(mamxb, tennxb, diachi, sodt, namxbs);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            nhaXuatBanDAO.InsertSV(sv);
                            loadDSSach();
                            TongSach();
                            MessageBox.Show("Thêm thành công", "thông báo");
                            break;
                        }
                    case "update":
                        {
                            nhaXuatBanDAO.UpdateSV(sv);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtMaNXB.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            txtMaNXB.Enabled = true;
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
                txtMaNXB.Text = datagvSP.Rows[rowindex].Cells["MaNXB"].Value.ToString();
                txtTenNXB.Text = datagvSP.Rows[rowindex].Cells["TenNXB"].Value.ToString();
                txtDiaChi.Text = datagvSP.Rows[rowindex].Cells["DiaChi"].Value.ToString();
                txtSDT.Text = datagvSP.Rows[rowindex].Cells["DienThoai"].Value.ToString();
                txtEmail.Text = datagvSP.Rows[rowindex].Cells["Email"].Value.ToString();
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
