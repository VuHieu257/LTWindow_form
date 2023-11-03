using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B03_btvn
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
                if (mtbMaS.Text.Length == 0 || mtbTen.Text.Length == 0 || mtbGia.Text.Length== 0||mtbSL.Text.Length!=0)
                {
                    MessageBox.Show("Không được để trống các ô");
                }
                string MaS = mtbMaS.Text;
                string  Ten = mtbTen.Text;
                string Gia = (mtbGia.Text);
                string Sl= (mtbSL.Text);
                txtDanhSach.Text += stt + " - Mã Sách:" + MaS + "- Tên Sách:" + Ten + "- Giá Sách:" + Gia + "- Số lượng" + Sl +"\r\n";
                stt++;
                mtbMaS.Text = "";
                mtbTen.Text = "";
                mtbGia.Text = "";
                mtbSL.Text = "";

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
