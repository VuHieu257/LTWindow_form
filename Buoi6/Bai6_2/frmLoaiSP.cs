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

namespace Bai6_2
{
    public partial class frmLoaiSP : Form
    {
        LoaiSPDAO loaiSPDAO=new LoaiSPDAO();
        string insertupdate = "";
        public frmLoaiSP()
        {
            InitializeComponent();
        }

        private void frmLoaiSP_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaLoai.Enabled = false;
            btnDelete.Enabled = false;
            loadDSS();
            TongSP();
        }
        private void TongSP()
        {
            datagvSP.DataSource = loaiSPDAO.getList();
        }

        private void loadDSS()
        {
            txtbCount.Text = loaiSPDAO.getCount().ToString(); ;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            txtMaLoai.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtMaLoai.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLoai.Text.Length <= 1)
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
                string maloai = txtMaLoai.Text;
                string name = txtName.Text;
                string chitie = txtCT.Text;
                LoaiSP sv = new LoaiSP(maloai, name, chitie);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            loaiSPDAO.InsertSV(sv);
                            loadDSS();
                            TongSP();
                            MessageBox.Show("Thêm thành công", "thông báo");
                            break;
                        }
                    case "update":
                        {
                            loaiSPDAO.UpdateSV(sv);
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
                if (txtMaLoai.Text.Length != 10)
                {
                    throw new Exception("Mã sinh vien 10 ký tự số");
                }
                string maloai = txtMaLoai.Text;
                loaiSPDAO.DeleteSV(maloai);
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

        private void datagvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= datagvSP.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên");
                }
                txtMaLoai.Text = datagvSP.Rows[rowindex].Cells["MaLoai"].Value.ToString();
                txtName.Text = datagvSP.Rows[rowindex].Cells["TenLoai"].Value.ToString();
                txtCT.Text = datagvSP.Rows[rowindex].Cells["ChiTiet"].Value.ToString();
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
