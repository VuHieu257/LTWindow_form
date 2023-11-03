using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bai6
{
    public partial class QLSV : Form
    {
        SinhVienDAO svDAO= new SinhVienDAO();
        KhoaDAO KhoaDAO = new KhoaDAO();
        string insertupdate = "";
        public QLSV()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            mtbMaSV.Enabled = false;
            btnDelete.Enabled = false;
            loadDSSinhVien();
            loadDSKhoa();
            TongSInhVIen();
        }

        private void TongSInhVIen()
        {
            datagvSV.DataSource = svDAO.getList();
        }

        private void loadDSKhoa()
        {
            cbKhoa.DataSource=KhoaDAO.getList();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
        }

        private void loadDSSinhVien()
        {
            txtbCount.Text = svDAO.getCount().ToString(); ;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnLuu.Enabled = true;
            mtbMaSV.Enabled=true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                double diemtb = 0;
                if(mtbMaSV.Text.Length!=10)
                {
                    throw new Exception("Mã sinh vien 10 ký tự số");
                }    
                if(!double.TryParse(tbDiem.Text, out diemtb))
                {
                    throw new Exception("Điểm sinh viên số");
                }
                string masv = mtbMaSV.Text;
                string hoten= tbName.Text;
                int makhoa=int.Parse(cbKhoa.SelectedValue.ToString());
                SinhVien sv=new SinhVien(masv,hoten,makhoa,diemtb);
                switch (insertupdate)
                {
                    case "insert":
                        {
                            svDAO.InsertSV(sv); 
                            loadDSSinhVien();
                            TongSInhVIen();
                            MessageBox.Show("Thêm thành công", "thông báo");
                            break;
                        }
                    case "update":
                        {
                            svDAO.UpdateSV(sv);
                            loadDSSinhVien();
                            TongSInhVIen();
                            MessageBox.Show("cập nhật thành công", "thông báo");
                            break;
                        }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            mtbMaSV.Enabled = true;
        }
        private void datagvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                int rowindex = e.RowIndex;
                if(rowindex == -1||rowindex>=datagvSV.Rows.Count-1) {
                    throw new Exception("Chưa chọn sinh viên");
                }
                mtbMaSV.Text = datagvSV.Rows[rowindex].Cells["MaSV"].Value.ToString();
                tbName.Text = datagvSV.Rows[rowindex].Cells["HoTen"].Value.ToString();
                cbKhoa.Text = datagvSV.Rows[rowindex].Cells["TenKhoa"].Value.ToString();
                tbDiem.Text = datagvSV.Rows[rowindex].Cells["DiemTB"].Value.ToString();
                btnDelete.Enabled = true;
            }catch (Exception ex) {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtbMaSV.Text.Length != 10)
                {
                    throw new Exception("Mã sinh vien 10 ký tự số");
                }
                string masv = mtbMaSV.Text;
                            svDAO.DeleteSV(masv);
                            loadDSSinhVien();
                            TongSInhVIen();
                            MessageBox.Show("Xóa thành công", "thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFil_Click(object sender, EventArgs e)
        {
            int makhoa=int.Parse(cbKhoa.SelectedValue.ToString());
            datagvSV.DataSource = svDAO.getList(makhoa);
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
