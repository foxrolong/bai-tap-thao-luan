using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
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

        private void btnDongY_Click(object sender, EventArgs e)
        {
            try
            {
                double txtDiemhk1 = double.Parse(txtDiemHK1.Text);
                double txtDiemhk2 = double.Parse(txtDiemHK2.Text);

                if (txtDiemhk1 >= 0 && txtDiemhk1 <= 10 && txtDiemhk2 >= 0 && txtDiemhk2 <= 10)
                {
                    double DiemTB = (txtDiemhk1 + txtDiemhk2) / 2;
                    if(DiemTB >= 8.0){
                        txtXepLoai.Text = "Giỏi";
                    }else if(DiemTB >= 6.5){
                        txtXepLoai.Text = "Khá";
                    }else if(DiemTB >= 5.0){
                        txtXepLoai.Text = "Trung bình";
                    }else{
                        txtXepLoai.Text = "Yếu";
                    }

                }
            }
            catch
            {
                MessageBox.Show("không hợp lệ vui lòng nhập lại điểm hợp lệ từ 0 đến 10");
                txtDiemHK1.Focus();
                txtDiemHK1.SelectAll();
            }

        }
    }
}
