using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3_02
{

    public partial class Form1 : Form
    {
        private int stt;
    

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtbMaSV.Text.Length==0 || mtbHoTen.Text.Length==0||mtbNgaySnh.Text.Length==8)
                {
                    MessageBox.Show("Không được để trống các ô");
                }
                string MaSV=mtbMaSV.Text;
                string HoTen=mtbHoTen.Text;
                string NgaySinh=(mtbNgaySnh.Text);
                string Gender = (rbtnNam.Checked) ? "Nam" : "Nữ";
                string Sothich = null;
                if(cbTT.Checked )
                {
                    Sothich += "Du Lịch ,";
                }
                if (cbDL.Checked)
                {
                    Sothich += "Du Lịch ,";
                }
                if (cbMS.Checked)
                {
                    Sothich += "Du Lịch ,";
                }
                txtDanhSach.Text += stt + "Mã SV:" + MaSV + "-Họ Tên:" + HoTen + "-Ngày Sinh:" + NgaySinh + "-Giới Tính" + Gender +"-Sở Thích:"+ Sothich + "\r\n";
                stt++;
                mtbMaSV.Text = "";
                mtbHoTen.Text = "";
                mtbNgaySnh.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtDanhSach.Text = "";
        }
    }
}
