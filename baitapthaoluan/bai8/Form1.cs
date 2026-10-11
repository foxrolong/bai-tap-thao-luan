using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int TimUSCLN(int a, int b)
        {
            a = Math.Abs(a); // Lấy giá trị tuyệt đối để xử lý số âm
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a; // Hoặc b vì lúc này a == b
        }
        private int TimBSCNN(int a, int b)
        {
            int uscln = TimUSCLN(a, b);
            if (uscln == 0) return 0; // Tránh lỗi chia cho 0 nếu cả a và b đều là 0
            return Math.Abs(a * b) / uscln;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoNguyenA.Text, out int a) && int.TryParse(txtSoNguyenB.Text, out int b))
            {
                if (a == 0 && b == 0)
                {
                    MessageBox.Show("Cả hai số không thể cùng bằng 0.", "Thông báo");
                    return;
                }

                int ketQua = 0;

                // Kiểm tra RadioButton nào được chọn[cite: 13]
                if (rdoUSCLN.Checked)
                {
                    ketQua = TimUSCLN(a, b);
                }
                else if (rdoBSCNN.Checked)
                {
                    ketQua = TimBSCNN(a, b);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn USCLN hoặc BSCNN.", "Thông báo");
                    return;
                }

                // Hiển thị kết quả ra TextBox[cite: 13]
                txtKetQua.Text = ketQua.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho a và b.", "Lỗi nhập liệu");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            txtSoNguyenA.Clear();
            txtSoNguyenB.Clear();
            txtKetQua.Clear();
            this.Close();
        }
    }
}
