using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="admin" && txtPassword.Text=="asd")
            {
                frmMain.ten=txtUserName.Text;
                this.Close();
            }
            else
            {
                lblThongBao.Text = "Đăng nhập thất bại";
                lblThongBao.ForeColor = Color.Red;
            }

        }
    }
}
