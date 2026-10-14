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
            

            // tính thưởng ngày 
            double SoNgay = Convert.ToDouble(txtSoNgayCong.Text);
            double ThuongNgay = SoNgay * 50000;
            txtThuongNgay.Text = ThuongNgay.ToString();

            // hệ số phụ cấp
            char kytudau = cboMaNv.Text[0];
            double phucap = 0;
                if (kytudau == 'A')
                {
                    phucap = 500000;
                    txtHeSoPhuCap.Text = phucap.ToString();
                }
                else if (kytudau == 'B')
                {
                    phucap = 300000;
                    txtHeSoPhuCap.Text = phucap.ToString();
                }
                else if (kytudau == 'C')
                {
                    phucap = 200000;
                    txtHeSoPhuCap.Text = phucap.ToString();
                }

            // phụ cấp chức vụ
            double PhuCapCV = 0;
           
            if (kytudau == 'A') PhuCapCV = 500000;
            else if (kytudau == 'B') PhuCapCV = 300000;
            else if (kytudau == 'C') PhuCapCV = 200000;
            txtPhuCapCv.Text = PhuCapCV.ToString();

            // tính lương thời gian
            double LuongTG = Convert.ToDouble(txtLuongCB.Text) * SoNgay;

            // tính Lương thời gian = Số ngày × Lương cơ bản
            double LuongCB = Convert.ToDouble(txtLuongCB.Text);
            if (SoNgay > 22)
            {
                LuongTG = (22 * LuongCB) + ((SoNgay - 22) * 2 * LuongCB);
            }
            else
            {
                LuongTG = SoNgay * LuongCB;
            }
            txtLuongTG.Text = LuongTG.ToString();

            //  tính tổng Tổng cộng = Lương TG + Phụ cấp CV +Thưởng ngày
            double TongCong = LuongTG + PhuCapCV + ThuongNgay;
            txtTongCong.Text = TongCong.ToString();

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
