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
    public partial class frmSach : Form
    {
        SachDAO SachDAO = new SachDAO();
        NhaXuatBanDAO NXBDAO = new NhaXuatBanDAO();
        NhanVienDAO NVDAO = new NhanVienDAO();
        string insertupdate = "";
        public frmSach()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMaSach.Enabled = false;
            btnDelete.Enabled = false;
            loadDSSach();
            //loadDS();
            TongSach();
        }
        private void TongSach()
        {
            datagvSP.DataSource = SachDAO.getList();
        }

        //private void loadDS()
        //{
        //    cbNXB.DataSource = NXBDAO.getList();
        //    cbNXB.DisplayMember = "TenNXB";
        //    cbNXB.ValueMember = "MaNXB";

        //    cbNV.DataSource = NXBDAO.getList();
        //    cbNV.DisplayMember = "TenNV";
        //    cbNV.ValueMember = "MaNV";
        //}

        private void loadDSSach()
        {
            txtbCount.Text = SachDAO.getCount().ToString(); ;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            txtMaSach.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtMaSach.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                double gia = 0;
                if (txtMaSach.Text.Length <=0)
                {
                    throw new Exception("Mã Sách Không được để trống");
                }
                if (txtTenSach.Text.Length <= 0)
                {
                    throw new Exception("Tên Sách Không được để trống");
                }
                if (txtTacGia.Text.Length <= 0)
                {
                    throw new Exception("Tác Giả Không được để trống");
                }
                if (txtMaLoai.Text.Length <= 0)
                {
                    throw new Exception("Mã Loại Không được để trống");
                }
                if (txtXB.Text.Length <= 0)
                {
                    throw new Exception("Năm Xuất Bản Không được để trống");
                }
                if (txtNXB.Text.Length <= 0)
                {
                    throw new Exception("Nhà Xuất Bản Không được để trống");
                }
                if (txtNV.Text.Length <= 0)
                {
                    throw new Exception("Nhân Viên Không được để trống");
                }
                if (!double.TryParse(txtGia.Text, out gia))
                {
                    throw new Exception("Nhập Giá Sách");
                }
                string masach = txtMaSach.Text;
                string tensach = txtTenSach.Text;
                string tacgia = txtTacGia.Text;
                string maloai = txtMaLoai.Text;
                string namxbs = txtXB.Text;
                string nv = txtXB.Text;
                string nxb = txtXB.Text;
                Sach sv = new Sach(masach,tensach,tacgia,gia,maloai, nv, namxbs, nxb);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            SachDAO.InsertSV(sv);
                            loadDSSach();
                            //loadDS();
                            TongSach();
                            MessageBox.Show("Thêm thành công", "thông báo");
                            break;
                        }
                    case "update":
                        {
                            SachDAO.UpdateSV(sv);
                            loadDSSach();
                            //loadDS();
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
                if (txtMaSach.Text.Length <= 0)
                {
                    throw new Exception("Mã Sách Không được để trống");
                }
                string mas = txtMaSach.Text;
                SachDAO.DeleteSV(mas);
                loadDSSach();
                //loadDS();
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

        private void datagvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= datagvSP.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn Sách");
                }
                txtMaSach.Text = datagvSP.Rows[rowindex].Cells["MaSach"].Value.ToString();
                txtTenSach.Text = datagvSP.Rows[rowindex].Cells["TenSach"].Value.ToString();
                txtTacGia.Text = datagvSP.Rows[rowindex].Cells["TacGia"].Value.ToString();
                txtGia.Text = datagvSP.Rows[rowindex].Cells["Gia"].Value.ToString();
                txtMaLoai.Text = datagvSP.Rows[rowindex].Cells["TenLoai"].Value.ToString();
                txtNXB.Text = datagvSP.Rows[rowindex].Cells["TenNXB"].Value.ToString();
                txtXB.Text = datagvSP.Rows[rowindex].Cells["NamXB"].Value.ToString();
                txtNV.Text = datagvSP.Rows[rowindex].Cells["TenNV"].Value.ToString();
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
