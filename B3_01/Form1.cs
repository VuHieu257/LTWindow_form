using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3_01
{
    public partial class progamn : Form
    {
        public progamn()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text, out a))
                {
                    throw new Exception("Số A không phải là số");
                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("Số B không phải là số");
                }
                txtKetQua.Text = (a + b).ToString();
            }
            catch(Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
           
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text, out a))
                {
                    throw new Exception("Số A không phải là số");
                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("Số B không phải là số");
                }
                txtKetQua.Text = (a - b).ToString();
            }
            catch (Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text, out a))
                {
                    throw new Exception("Số A không phải là số");
                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("Số B không phải là số");
                }
                txtKetQua.Text = (a * b).ToString();
            }
            catch (Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text, out a))
                {
                    throw new Exception("Số A không phải là số");
                }
                if (!double.TryParse(txtSoB.Text, out b) )
                {
                    throw new Exception("Số B không phải là số");
                }
                if (b > 0)
                {
                    txtKetQua.Text = (a / b).ToString();
                }
                else
                {
                    throw new Exception("Số B phải lớn hơn 0!!");
                }
            }
            catch (Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
