using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai7
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoLuongVe.Text, out int soLuong) && soLuong > 0 && double.TryParse(txtDonGia.Text, out double donGia) && donGia > 0)
            {
                double thanhTien = soLuong * donGia;
                double vat = thanhTien * 0.1;

                double giamGia = 0;
                if (rdoCaNhan.Checked)
                {
                    giamGia = thanhTien * 0.03;
                }
                else if (rdoDonViKhac.Checked)
                {
                    giamGia = thanhTien * 0.05;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn Cá nhân hoặc Đơn vị khác!", "Thông báo");
                    return;
                }


                double tongTien = (thanhTien + vat) - giamGia;

                txtThanhTien.Text = thanhTien.ToString("#,##0");
                txtThueVAT.Text = vat.ToString("#,##0");
                txtGiamGia.Text = giamGia.ToString("#,##0");
                txtTongCong.Text = tongTien.ToString("#,##0");
            }
            else
            {
                MessageBox.Show("Số lượng vé và Đơn giá phải là số lớn hơn 0!", "Lỗi nhập liệu");
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtTenKhachHang.Clear();
            txtSoLuongVe.Clear();
            txtDiaChi.Clear();
            txtDonGia.Clear();
            txtThanhTien.Clear();
            txtThueVAT.Clear();
            txtGiamGia.Clear();
            txtTongCong.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
