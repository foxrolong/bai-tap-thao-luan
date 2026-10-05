using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtBanKinh.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
            
                double BanKinh = double.Parse(txtBanKinh.Text);
                if (BanKinh <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên dương và khác 0");
                    txtBanKinh.Text = BanKinh.ToString();
                    txtBanKinh.Focus();
                    txtBanKinh.SelectAll();
                    return;
                }
                double chuvi = 2 * Math.PI * BanKinh;
                double dientich = Math.PI * BanKinh * BanKinh;

                txtChuVi.Text = chuvi.ToString();
                txtDienTich.Text = dientich.ToString();
            }
            catch
            {
                MessageBox.Show("không hợp lệ vui lòng nhập lại");
                txtBanKinh.Focus();
                txtBanKinh.SelectAll();
            }

        }

        private void txtBanKinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtBanKinh.Text = "";
            txtChuVi.Text = "";
            txtDienTich.Text = "";
            txtBanKinh.Focus();
            txtBanKinh.SelectAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBanKinh;
        }
    }
}
