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

namespace Bai6
{
    public partial class QLKhoa : Form
    {
        SinhVienDAO svDAO = new SinhVienDAO();
        KhoaDAO KhoaDAO = new KhoaDAO();
        string insertupdate = "";
        public QLKhoa()
        {
            InitializeComponent();
        }

        private void QLKhoa_Load(object sender, EventArgs e)
        {
            TongKhoa();
        }
        private void TongKhoa()
        {
            datagvKhoa.DataSource =KhoaDAO.getList();
        }

        private void datagvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                try
                {
                    int rowindex = e.RowIndex;
                    if (rowindex == -1 || rowindex >= datagvKhoa.Rows.Count - 1)
                    {
                        throw new Exception("Chưa chọn sinh viên");
                    }
                    txtbMK.Text = datagvKhoa.Rows[rowindex].Cells["MaKhoa"].Value.ToString();
                    txtbName.Text = datagvKhoa.Rows[rowindex].Cells["TenKHoa"].Value.ToString();
                    txtbNote.Text = datagvKhoa.Rows[rowindex].Cells["GhiChu"].Value.ToString();
                    btnDelete.Enabled = true;
                    btnEdit.Enabled= true;
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
                txtbMK.Enabled = true;
                txtbMK.ReadOnly = false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            txtbMK.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
                try
                {
                    if (txtbMK.Text.Length ==0)
                    {
                        throw new Exception("Mã Khoa không được để chống");
                    }
                    if (txtbName.Text.Length == 0)
                    {
                        throw new Exception("Tên khoa không được để chống");
                    }
                    string makhoa = txtbMK.Text;
                    string hoten = txtbName.Text;
                string note = txtbNote.Text;
                    Khoa k = new Khoa(makhoa, hoten, note);
                     //Khoa k = new Khoa(makhoa, hoten);
                    switch (insertupdate)
                    {
                        case "insert":
                            {
                                KhoaDAO.InsertTwo(k);
                                TongKhoa();
                                MessageBox.Show("Thêm thành công", "thông báo");
                                break;
                            }
                        case "update":
                            {
                                KhoaDAO.UpdateTwo(k);
                                TongKhoa();
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
                string maKhoa = txtbMK.Text;
                KhoaDAO.DeleteTwo(maKhoa);
                TongKhoa();
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
