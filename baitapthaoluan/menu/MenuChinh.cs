using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class MenuChinh : System.Windows.Forms.Form
    {
        public MenuChinh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bai1.Form1 bai1Form = new bai1.Form1();
            bai1Form.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            bai2.Form1 bai2Form = new bai2.Form1();
            bai2Form.ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            bai3.Form1 bai3Form = new bai3.Form1();
            bai3Form.ShowDialog();
        }

        private void MenuChinh_Load(object sender, EventArgs e)
        {

        }
    }
}
