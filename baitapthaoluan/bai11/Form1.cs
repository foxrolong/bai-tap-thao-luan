using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string maNhanVien = cboMaNv.Text;
            if (maNhanVien == "A001")
            {
                txtTenNhanVien.Text = "Nguyễn Văn A";
                txtLuongCB.Text = "5000000";
            }
            else if (maNhanVien == "B002")
            {
                txtTenNhanVien.Text = "Trần Thị B";
                txtLuongCB.Text = "4500000";
            }
            else if (maNhanVien == "C003")
            {
                txtTenNhanVien.Text = "Lê Văn C";
                txtLuongCB.Text = "4000000";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char kytudau = cboMaNv.Text[0];
            double phucap = 0;
            if(kytudau == 'A')
            {
                phucap = 500000;
                txtHeSoPhuCap.Text = phucap.ToString();
            }
            else if(kytudau == 'B')
            {
                phucap = 300000;
                txtHeSoPhuCap.Text = phucap.ToString();
            }
            else if(kytudau == 'C')
            {
                phucap = 200000;
                txtHeSoPhuCap.Text = phucap.ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHeSoPhuCap.Clear();
            txtLuongCB.Clear();
            txtTenNhanVien.Clear();
            txtSoNgayCong.Clear();
            txtPhuCapCv.Clear();
            txtThuongNgay.Clear();
            txtLuongTG.Clear();
            txtTongCong.Clear();
            cboMaNv.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
