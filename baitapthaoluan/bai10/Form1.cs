using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tongTien = 0;
            if (ckbTinHocA.Checked)
            {
                tongTien += 300000;
            }
            if (ckbTinHocB.Checked)
            {
                tongTien += 500000;
            }
            if (ckbTiengAnhA.Checked)
            {
                tongTien += 400000;
            }
            if (ckbTiengAnhB.Checked)
            {
                tongTien += 600000;
            }
            txtTongTien.Text = tongTien.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ckbTinHocA_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ckbTinHocB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbTiengAnhA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbTiengAnhB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ckbTinHocA.Checked = false;
            ckbTinHocB.Checked = false;
            ckbTiengAnhA.Checked = false;
            ckbTiengAnhB.Checked = false;
            txtTongTien.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
