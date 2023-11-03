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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Addpanel(Form frm)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(frm);

            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new frmSinhVien();
            Addpanel(form);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new frmKhoa();
            Addpanel(form);
        }
    }
}
