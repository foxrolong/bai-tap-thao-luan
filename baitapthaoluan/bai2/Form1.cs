using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Chieudai = double.Parse(txtChieudai.Text);
                double Chieurong = double.Parse(txtChieurong.Text);
                if (Chieudai > 0 && Chieurong > 0)
                {
                    double Chuvi = 2 * (Chieudai + Chieurong);
                    double Dientich = Chieudai * Chieurong;
                    txtChuvi.Text = Chuvi.ToString();
                    txtDientich.Text = Dientich.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số nguyên dương và khác 0");
                    txtChieudai.Focus();
                    txtChieudai.SelectAll();
                }
            }
            catch
            {
                MessageBox.Show("không hợp lệ vui lòng nhập lại số nguyên dương và khác 0");
                txtChieudai.Focus();
                txtChieudai.SelectAll();
            }

        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtChieudai.Clear();
            txtChieurong.Clear();
            txtChuvi.Clear();
            txtDientich.Clear();
        }
    }
}