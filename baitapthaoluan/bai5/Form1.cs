using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // xử lý sự kiện chọn cá nhân hay cơ quan bằng checked (radio button)
            double DonGia = 0;

            if (rdoCaNhan.Checked == true)
            {
                DonGia = 5000;
            }
            else if (rdoCoQuan.Checked == true)
            {
                DonGia = 6000;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại khách hàng.");
                return;
            }

            double ChiSoCu = double.Parse(txtChiSoCu.Text);
            double ChiSoMoi = double.Parse(txtChiSoMoi.Text);
            double SoKwTieuThu = 0;
            if (ChiSoMoi >= 0 && ChiSoCu >=0 && ChiSoMoi > ChiSoCu )
            {
                SoKwTieuThu = ChiSoMoi - ChiSoCu;
                txtSoKwTieuThu.Text = SoKwTieuThu.ToString();
            }
            else
            {
                MessageBox.Show("vui lòng nhập chỉ số cũ lớn hơn chỉ số mới.");
            }
            



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
