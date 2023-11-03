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
    public partial class frmMain : Form
    {
        public static string ten = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(ten == null)
            {
                Form frmLogin = new frmlogin();
                frmLogin.ShowDialog();
                toolStripLabel1.Text = ten;
            }
           
        }

       
    }
}
