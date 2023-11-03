using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace B7_1
{
    public partial class frmThanhVien : Form
    {
        string AddOrEdit = " ";
        ThanhVienDAO thanhVienDAO=new ThanhVienDAO();
        public frmThanhVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmThanhVien_Load(object sender, EventArgs e)
        {
            datagvTV.DataSource = thanhVienDAO.getList();
            txtbCount.Text=thanhVienDAO.getCount().ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUserName.Text.Trim();
                string passw = txtPassword.Text.Trim();
                string name = mtbName.Text.Trim();
                string email = tbEmail.Text.Trim();
                string number = tbNumber.Text.Trim();
                string quyen=txtQuyen.Text.Trim();
                switch(AddOrEdit)
                {
                    case "Add":
                        {
                            ThanhVien tv =new ThanhVien();
                            tv.UserName=username;
                            tv.PassWord=passw;
                            tv.Quyen=quyen;
                             tv.Name=name;
                            tv.Email=email;
                            tv.Number=number;
                            thanhVienDAO.Insert(tv);
                            txtbCount.Text=thanhVienDAO.getCount().ToString();
                            datagvTV.DataSource=thanhVienDAO.getList();
                            break;
                        }
                    case "Edit":
                        {
                            ThanhVien tv = new ThanhVien();
                            tv.UserName = username;
                            tv.PassWord = passw;
                            tv.Quyen = quyen;
                            tv.Name = name;
                            tv.Email = email;
                            tv.Number = number;

                            thanhVienDAO.Update(tv);
                            datagvTV.DataSource = thanhVienDAO.getList();
                            break;
                        }
                }

            }catch(Exception ex) {

                MessageBox.Show(ex.Message,"Thông Báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ThanhVien tv = thanhVienDAO.GetRow(txtUserName.Text);
            thanhVienDAO.Delete(tv);
            txtbCount.Text = thanhVienDAO.getCount().ToString();
            datagvTV.DataSource=thanhVienDAO.getList() ;
        }

        private void datagvTV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex<datagvTV.Rows.Count)
            {
                int vt=e.RowIndex;
                txtUserName.Text = datagvTV.Rows[vt].Cells["UserName"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Add";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddOrEdit = "Update";
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            frmMain.tabControl.TabPages.Remove(frmMain.tabControl.TabPages["tbThanhVien"]);
        }
    }
}
