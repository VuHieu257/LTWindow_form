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
    public partial class frmCTDH : Form
    {
        DonHangCTDAO DonHangCTDAO = new DonHangCTDAO();
        string insertupdate = "";
        public frmCTDH()
        {
            InitializeComponent();
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
                mtbMaSP.Text = datagvSP.Rows[rowindex].Cells["MaSP"].Value.ToString();
                txtName.Text = datagvSP.Rows[rowindex].Cells["TenSP"].Value.ToString();
                txtDH.Text = datagvSP.Rows[rowindex].Cells["MaDH"].Value.ToString();
                txtCTDH.Text = datagvSP.Rows[rowindex].Cells["MaCTDH"].Value.ToString();
                txtDVTinh.Text = datagvSP.Rows[rowindex].Cells["DVTinh"].Value.ToString();
                txtGiaBan.Text = datagvSP.Rows[rowindex].Cells["GiaBan"].Value.ToString();
                txtdown.Text = datagvSP.Rows[rowindex].Cells["SoLuong"].Value.ToString();
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCTDH_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            mtbMaSP.Enabled = false;
            btnDelete.Enabled = false;
            loadDSS();
            TongSP();
        }
        private void TongSP()
        {
            datagvSP.DataSource = DonHangCTDAO.getList();
        }

        private void loadDSS()
        {
            txtbCount.Text = DonHangCTDAO.getCount().ToString(); ;
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
                double number = 0;
                if (txtDH.Text.Length <= 1)
                {
                    throw new Exception("Mã sản phẩm phải có ít nhất 1 ký tự");
                }
                if (txtName.Text.Length <= 1)
                {
                    throw new Exception("Tên sản phẩm phải có ít nhất 1 ký tự");
                }
                if (txtCTDH.Text.Length <= 1)
                {
                    throw new Exception("Mã Chi tiết đơn hàng phải có ít nhất 1 ký tự");
                }
                if (txtDVTinh.Text.Length <= 1)
                {
                    throw new Exception("Đơn Vị tính phải có ít nhất 1 ký tự");
                }
                if (!double.TryParse(txtdown.Text, out number))
                {
                    throw new Exception("Điểm sinh viên số");
                }
                string masp = mtbMaSP.Text;
                string name = txtName.Text;
                string madh = txtDH.Text;
                string mactdh = txtCTDH.Text;
                string dongia = txtGiaBan.Text;
                string dvtinh = txtDVTinh.Text;
                DonHangCT sv = new DonHangCT(mactdh,madh,masp, name, dvtinh, dongia , number);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            DonHangCTDAO.InsertSV(sv);
                            loadDSS();
                            TongSP();
                            MessageBox.Show("Thêm thành công", "thông báo");
                            break;
                        }
                    case "update":
                        {
                            DonHangCTDAO.UpdateSV(sv);
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
                if (txtCTDH.Text.Length != 10)
                {
                    throw new Exception("Mã sinh vien 10 ký tự số");
                }
                string mactdh = txtCTDH.Text;
                DonHangCTDAO.DeleteSV(mactdh);
                loadDSS();
                TongSP();
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
