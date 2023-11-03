using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B7_1
{
    public partial class frmDN : Form
    {
        public frmDN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = MaHoa.ToMD5(txtPassword.Text.Trim());
            ThanhVienDAO thanhvienDAO = new ThanhVienDAO();
            ThanhVien tv = thanhvienDAO.GetRow(username);

            if (tv == null)
            {
                lbThongBao.Text = "Tài khoản không tồn tại";


            }
            else
            {
                if (tv.PassWord == password)
                {
                    frmMain.thanhvien = tv;
                    this.Close();
                }
                else
                {
                    lbThongBao.Text = "Mật khẩu không chính xác";
                }
            }
        }
      
    }
}
