using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_1
{
    public partial class Form1 : Form
    {
        string[] dsKhoa = { "CNTT", "QTKD", "Kế Toán", "Ngoại Ngữ" };
        int rowChoose = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string masv = mtbMaSV.Text;
                string name = tbName.Text;
                string age = dtkAge.Text;
                string khoa = cbKhoa.Text;
                if(masv.Length<=2)
                {
                    throw new Exception("Mã Sinh Viên Phải đủ 10 ký tự");
                }
                if (name.Length<=1)
                {
                    throw new Exception("Họ Tên sinh viên ít nhất là 1 ký tự");
                }
               datagvDS.Rows.Add(masv, name, age, khoa);
                tbName.Text = "";
                mtbMaSV.Text = "";
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            dtkAge.MaxDate=DateTime.Now;
            LoadKhoa();
        }
        private void LoadKhoa()
        {
            cbKhoa.DataSource=dsKhoa;
            cbKhoa.SelectedIndex=0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            { 
                string masv = mtbMaSV.Text;
                mtbMaSV.ReadOnly=true;
                string name = tbName.Text;
                string age = dtkAge.Text;
                string khoa = cbKhoa.Text;
                if(rowChoose==-1||rowChoose>=datagvDS.Rows.Count-1)
                {
                    throw new Exception("Chưa Chọn Sinh Viên Cần cập nhật");
                }
                if (name.Length <= 1)
                {
                    throw new Exception("Họ Tên sinh viên ít nhất là 1 ký tự");
                }
                datagvDS.Rows[rowChoose].Cells["dtName"].Value=name;
                datagvDS.Rows[rowChoose].Cells["dtAge"].Value=age;
                datagvDS.Rows[rowChoose].Cells["dtKhoa"].Value= khoa;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void datagvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex==-1|| e.ColumnIndex>=datagvDS.RowCount-1)
                {
                    throw new Exception("Chưa Chọn Sinh Viên");
                }
                rowChoose = e.RowIndex;
                mtbMaSV.Text = datagvDS.Rows[rowChoose].Cells["MaSV"].Value.ToString();
                tbName.Text = datagvDS.Rows[rowChoose].Cells["dtName"].Value.ToString();
                dtkAge.Text = datagvDS.Rows[rowChoose].Cells["dtAge"].Value.ToString();
                cbKhoa.Text = datagvDS.Rows[rowChoose].Cells["dtKhoa"].Value.ToString();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        try
            {
                if (rowChoose == -1 || rowChoose >= datagvDS.RowCount - 1)
            {
                throw new Exception("Chưa Chọn Sinh Viên");
            }
            datagvDS.Rows.RemoveAt(rowChoose);
            rowChoose = -1;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn Thoát Không","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
             if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }   
    }
}
