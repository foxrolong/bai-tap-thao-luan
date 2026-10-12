using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNhapSN.Text, out int so))
            {
                lsbDaySo.Items.Add(so);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi nhập liệu");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTangMoiPhanTuLen2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                int giaTriCu = Convert.ToInt32(lsbDaySo.Items[i]);
                lsbDaySo.Items[i] = giaTriCu + 2;
            }
        }

        private void btnChonSoLeCuoi_Click(object sender, EventArgs e)
        {
            lsbDaySo.SelectedIndex = -1;
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                if (Convert.ToInt32(lsbDaySo.Items[i]) % 2 != 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnChonSoChanDau_Click(object sender, EventArgs e)
        {
            lsbDaySo.SelectedIndex = -1;
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                if (Convert.ToInt32(lsbDaySo.Items[i]) % 2 == 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnXoaPhanTuDangChon_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.SelectedIndex != -1)
            {
                lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phần tử trong danh sách để xóa!");
            }
        }

        private void btnXoaPhanTuDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
            {
                lsbDaySo.Items.RemoveAt(0);
            }
        }

        private void btnXoaPhanTuCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
            {
                lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
            }
        }

        private void btnXoaDaySo_Click(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }

        private void btnKetThucUngDung_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
