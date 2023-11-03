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
    public partial class frmDH : Form
    {
        DonHangDAO dhDAO = new DonHangDAO();
        string insertupdate = "";
        public frmDH()
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
                txtMaDH.Text = datagvSP.Rows[rowindex].Cells["MaDH"].Value.ToString();
                txtName.Text = datagvSP.Rows[rowindex].Cells["TenDH"].Value.ToString();
                dateTimePickerDH.Text = datagvSP.Rows[rowindex].Cells["NgayDH"].Value.ToString();
                dateTimePickerGH.Text = datagvSP.Rows[rowindex].Cells["NgayGH"].Value.ToString();
                txtCT.Text = datagvSP.Rows[rowindex].Cells["ChiTiet"].Value.ToString();
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDH_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaDH.Enabled = false;
            btnDelete.Enabled = false;
            loadDSS();
            TongSP();
        }
        private void TongSP()
        {
            datagvSP.DataSource = dhDAO.getList();
        }

        private void loadDSS()
        {
            txtbCount.Text = dhDAO.getCount().ToString(); ;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            txtMaDH.Enabled = true;
        }

           
        private void btnEdit_Click(object sender, EventArgs e)
        {
                insertupdate = "update";
                btnLuu.Enabled = true;
                txtMaDH.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDH.Text.Length <= 1)
                {
                    throw new Exception("Mã sản phẩm phải có ít nhất 1 ký tự");
                }
                if (txtName.Text.Length <= 1)
                {
                    throw new Exception("Tên sản phẩm phải có ít nhất 1 ký tự");
                }
                if (txtCT.Text.Length <= 1)
                {
                    throw new Exception("Đơn Vị tính phải có ít nhất 1 ký tự");
                }
                string madh = txtMaDH.Text;
                string name = txtName.Text;
                string ngaydh=dateTimePickerDH.Text;
                string ngaygh=dateTimePickerGH.Text;
                string chitie = txtCT.Text;
                DonHang sv = new DonHang(madh, name, ngaydh, ngaygh,chitie);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            dhDAO.InsertSV(sv);
                            loadDSS();
                            TongSP();
                            MessageBox.Show("Thêm thành công", "thông báo");
                            break;
                        }
                    case "update":
                        {
                            dhDAO.UpdateSV(sv);
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
                if (txtMaDH.Text.Length != 10)
                {
                    throw new Exception("Mã sinh vien 10 ký tự số");
                }
                string madh = txtMaDH.Text;
                dhDAO.DeleteSV(madh);
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
