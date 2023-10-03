using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace B4_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
           
                cbbBan.Items.Add("bàn 1");
                cbbBan.Items.Add("bàn 2");
                cbbBan.Items.Add("bàn 3");
                cbbBan.Items.Add("bàn 4");
                cbbBan.Items.Add("bàn 5");
                cbbBan.Items.Add("bàn 6");
                cbbBan.Items.Add("bàn 7");
                cbbBan.Items.Add("bàn 8");
                cbbBan.Items.Add("bàn 9");
                cbbBan.Items.Add("bàn 10");
                //lbSinhVien.Items.Add("Trần Quốc Huy(Nghiện)");
                //lbSinhVien.Items.Add("Vũ Minh hiếu");
                //lbSinhVien.Items.Add("Trần Minh Phát");
                cbbBan.SelectedIndex = 0;
                CbSoLuong.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string ChonBan = cbbBan.SelectedIndex.ToString();
                ListView monlv = lvMon as ListView;
                ListViewItem item = monlv.SelectedItems[0];
                if (ChonBan == "0")
                {
                    throw new Exception("Vui lòng chọn bàn");
                }
                if (item.Checked)
                {
                    throw new Exception("Vui lòng chọn món");
                }
                else
                {
                    string ban = cbbBan.SelectedItem.ToString();
                    string soluong = CbSoLuong.SelectedItem.ToString();
                    string tenmon = " ";
                    string gia = " ";
                    ListViewItem item1 = new ListViewItem(ban);
                    if (item.Text == "01")
                     {
                      tenmon = "Cà phê đá";
                       gia = "15000 ";
                    }
                    else
                    {

                        if(item.Text == "02")
                        {
                            tenmon = "Cà phê sữa";
                            gia = "18000 ";

                        }
                        else
                        {
                            tenmon = "Nước cam";
                            gia = "25000 ";

                        }
                    }
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tenmon });
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = soluong });
                        item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = gia });
                        lvDatMon.Items.Add(item1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
