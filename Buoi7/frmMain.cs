using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B7_1
{
    public partial class frmMain : Form
    {
        public static ThanhVien thanhvien = null;
        public static TabControl tabControl = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(thanhvien == null)
            {
                Form frm = new frmDN();
                frm.ShowDialog();
            }
            toolStripLabelDN.Text = thanhvien.UserName;

            TabControlMain.ImageList = LoadImageList();
            tabControl = TabControlMain;
        }
        private ImageList LoadImageList() {
            ImageList iconsList=new ImageList();
            iconsList.TransparentColor = Color.Blue;
            iconsList.ColorDepth=ColorDepth.Depth32Bit;
            iconsList.ImageSize= new Size(25,25);
            iconsList.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Resources\\photo-profile.png"));
            iconsList.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Resources\\photo-profile.png"));
            iconsList.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Resources\\photo-profile.png"));
            iconsList.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Resources\\photo-profile.png"));
            iconsList.Images.Add(Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Resources\\photo-profile.png"));
            return iconsList;
        }
        private void TabControlMain_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabelDN_Click(object sender, EventArgs e)
        {
            TabPage tab =new TabPage();
            tab.Text = "Sinh Viên";
            tab.Name = "Sinh Viên";
            tab.ImageIndex = 1;

            Form frm = new frmSinhVien();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);


            if(!ExistTabPage(TabControlMain, "tbSinhVien"))
            {
                TabControlMain.TabPages.Add(tab);
            }
            TabControlMain.SelectedTab = TabControlMain.TabPages["tbSinhVien"];
        }
        private bool ExistTabPage(TabControl control,string tabPageName)
        {
            bool check=false;
            for (int i = 0;i<control.TabPages.Count;i++)
            {
                if (control.TabPages[i].Name == tabPageName)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

    }
}
