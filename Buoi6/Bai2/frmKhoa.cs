using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class frmKhoa : Form
    {
        public static string Khoa = null;
        public static List<string> khoaList = new List<string>();
        public static string[] lis = { "Mumbai", "London", "New York" };
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form frm = new frmThemKhoa();
            frm.ShowDialog();
        }
        private void loadKhoa()
        {
            for(int i = 0; i < lis.Length; i++) {
                khoaList.Add(lis[i]);
            }
            MessageBox.Show(khoaList.Count()+"");
        }
        private void frmKhoa_Load(object sender, EventArgs e)
        {
            loadKhoa();
        }
    }
}
