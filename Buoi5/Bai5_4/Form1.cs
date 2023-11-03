using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg|* .jpg|png|*.png|bmp|*.bmp|Tất cả|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                String pathFile= ofd.FileName;
                pbImage.Image = new Bitmap(pathFile);
            }    
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Document|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader stream= new StreamReader(fs,Encoding.UTF8);
                txtContent.Text=stream.ReadToEnd();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Text Document|*.txt";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.AddExtension = true;
            saveFileDialog.Title = "Where do you want to save the file?";
            saveFileDialog.InitialDirectory = @"C:/";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs= new FileStream(saveFileDialog.FileName,FileMode.Open);
                StreamWriter writer= new StreamWriter(fs,Encoding.UTF8);
                writer.Write(txtContent.Text);
                writer.Flush();
                fs.Close();
            }    
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn Thoát Không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
