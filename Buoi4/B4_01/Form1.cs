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

namespace B4_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbSinhVien.Items.Add("Đinh Ngọc Hoàng");
            lbSinhVien.Items.Add("Trần Quốc Huy(Nghiện)");
            lbSinhVien.Items.Add("Vũ Minh hiếu");
            lbSinhVien.Items.Add("Trần Minh Phát");
            cbbKhoa.SelectedIndex=0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbHoTen.Text.Length == 0)
                {
                    throw new Exception("Không được để trống Họ tên");  
                }string Hoten=txtbHoTen.Text;
                lbSinhVien.Items.Add(Hoten);
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn chắc chắn muốn thoát", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dl == DialogResult.OK)
                Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string chonTen = lbSinhVien.SelectedIndex.ToString();
                string chonKhoa = cbbKhoa.SelectedIndex.ToString();
                if (chonKhoa == "0")
                {
                    throw new Exception("Vui lòng chọn Khoa");
                }
                if (chonTen == "-1" )
                {
                    throw new Exception("Vui lòng chọn tên");
                }else
                {
                    string hoten = lbSinhVien.SelectedItem.ToString();
                    string khoa = cbbKhoa.SelectedItem.ToString();
                    ListViewItem item = new ListViewItem(hoten);
                    //listSV.Items.Add(hoten);
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });
                    listViewSV.Items.Add(item);
                    lbSinhVien.Items.RemoveAt(lbSinhVien.SelectedIndex);
                }                   
              
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            try
            {
                string chonTen = lbSinhVien.SelectedIndex.ToString();
                string chonKhoa = cbbKhoa.SelectedIndex.ToString();
                if (chonKhoa == "0")
                {
                    throw new Exception("Vui lòng chọn Khoa");
                }              
                else
                {
                    int count = lbSinhVien.Items.Count;
                    for(int i=0;i<count; i++)
                    {
                        string hoten = lbSinhVien.Items[i].ToString();
                        string khoa = cbbKhoa.SelectedItem.ToString();
                        ListViewItem item = new ListViewItem(hoten);
                        //listSV.Items.Add(hoten);
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = khoa });
                        listViewSV.Items.Add(item);
                    }
                    lbSinhVien.Items.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewSV.Items)
            {
                if(item.Selected)
                {
                    DialogResult dl = MessageBox.Show("Bạn muốn xóa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dl == DialogResult.OK)
                    {
                        listViewSV.Items.RemoveAt(item.Index);
                        lbSinhVien.Items.Add(item.Text);

                    }
                }
            }

        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dl = MessageBox.Show("Bạn muốn xóa tất cả", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                {
                        foreach (ListViewItem item in listViewSV.Items)
                    {

                        listViewSV.Items.RemoveAt(item.Index);
                        lbSinhVien.Items.Add(item.Text);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
