using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {

            try {
                double ChiSoDau = double.Parse(txtChiSoDau.Text);
                double ChiSoCuoi = double.Parse(txtChiSoCuoi.Text);
                double TongSo = 0;
                if (TongSo < ChiSoCuoi && ChiSoDau >= 0 && ChiSoCuoi >= 0)
                {
                    TongSo = ChiSoCuoi - ChiSoDau;
                    double ThanhTien = 0;
                    if (TongSo <= 100)
                    {
                        ThanhTien = TongSo * 500;
                    }
                    else if (TongSo <= 250)
                    {
                        ThanhTien = (100 * 500) + ((TongSo - 100) * 600);
                    }
                    else if (TongSo <= 300)
                    {
                        ThanhTien = (100 * 500) + (150 * 600) + ((TongSo - 250) * 800);
                    }
                    else
                    {
                        ThanhTien = (100 * 500) + (150 * 600) + (50 * 800) + ((TongSo - 300) * 1000);
                    }
                    txtSoTien.Text = ThanhTien.ToString();
            }
                else
                {
                    MessageBox.Show("Vui lòng nhập số nguyên dương và chỉ số cuối phải lớn hơn chỉ số đầu");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtChiSoCuoi.Text = "";
            txtChiSoDau.Focus();
            txtChiSoDau.Clear();
        }
    }
}
