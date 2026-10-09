using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtChiSoCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoKwTieuThu_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtTongCong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhDiem_Click(object sender, EventArgs e)
        {
            double LapTrinhC = double.Parse(txtLTC.Text);
            double LapTrinhTruyenThong = double.Parse(txtTT.Text);
            double MaNguonMo = double.Parse(txtMaNguonMo.Text);
            double QuanTriMang = double.Parse(txtQTM.Text);
            double DTB = (LapTrinhC + LapTrinhTruyenThong + MaNguonMo + QuanTriMang) / 4;
            txtDiemTB.Text = DTB.ToString();
            if (DTB >= 0 && DTB <= 10)
            {
                if (DTB >= 8)
                {
                    txtXepLoai.Text = "Giỏi";
                }
                else if (DTB >= 7)
                {
                    txtXepLoai.Text = "Khá";
                }
                else if (DTB >= 5)
                {
                    txtXepLoai.Text = "Trung Bình";
                }
                else
                {
                    txtXepLoai.Text = "Yếu";
                }
            }
        }
    }
}