using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6_3
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btnSp_Click(object sender, EventArgs e)
        {
            Form form = new frmSach();
            form.ShowDialog();
        }

        private void btnloaiSach_Click(object sender, EventArgs e)
        {
            Form form = new frmLoaiSach();
            form.ShowDialog();
        }

        private void btnNXB_Click(object sender, EventArgs e)
        {
            Form form = new frmNXB();
            form.ShowDialog();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            Form form = new frmNhanVien();
            form.ShowDialog();
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
