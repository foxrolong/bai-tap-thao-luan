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
    public partial class Form1c2 : Form
    {
        public Form1c2()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
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
            
        }

        private void labelchuvi_Click(object sender, EventArgs e)
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

        private void txtBanKinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keychar = e.KeyChar;
            if (!char.IsDigit(keychar) && keychar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
