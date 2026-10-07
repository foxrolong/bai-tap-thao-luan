using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
                // trong trường hợp này tôi muốn cho phép nhập kiểu char nhưng lại báo cho họ biết bên dưới bằng label là nếu bạn ko dùng số sẽ lỗi và tôi sẽ tự xóa nó đi nếu bạn cố tình nhập vào và tính
                // e.Handled = true; dùng để ngăn chặn ký tự không hợp lệ được nhập vào TextBox. Khi e.Handled được đặt thành true, sự kiện KeyPress sẽ bị hủy bỏ và ký tự không hợp lệ sẽ không được thêm vào TextBox. Điều này giúp đảm bảo rằng người dùng chỉ có thể nhập các ký tự hợp lệ (chỉ số và phím backspace) vào TextBox, tránh lỗi khi tính toán sau này.
                //e.Handled = true;
                labelLoi.Text = "Vui lòng nhập số nguyên dương và khác 0";
            }else if(keychar == '-'){
                // trong trường hợp keychar chỉ biết 1 ký tự chứ ko biết toàn bộ nếu sử lý số -29 thì nó chỉ biết số từng ký tự một nên ta sử lý dấu -

                labelLoi.Text = " không được nhaaoj số âm ";
            }
        }

        private void labelLoi_Click(object sender, EventArgs e)
        {

        }
    }
}
