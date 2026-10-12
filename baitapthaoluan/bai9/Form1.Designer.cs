namespace bai9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsbDaySo = new System.Windows.Forms.ListBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtNhapSN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChonSoChanDau = new System.Windows.Forms.Button();
            this.btnChonSoLeCuoi = new System.Windows.Forms.Button();
            this.btnXoaPhanTuDangChon = new System.Windows.Forms.Button();
            this.btnXoaPhanTuDau = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaPhanTuCuoi = new System.Windows.Forms.Button();
            this.btnKetThucUngDung = new System.Windows.Forms.Button();
            this.btnXoaDaySo = new System.Windows.Forms.Button();
            this.btnTangMoiPhanTuLen2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbDaySo
            // 
            this.lsbDaySo.FormattingEnabled = true;
            this.lsbDaySo.Location = new System.Drawing.Point(12, 165);
            this.lsbDaySo.Name = "lsbDaySo";
            this.lsbDaySo.Size = new System.Drawing.Size(362, 290);
            this.lsbDaySo.TabIndex = 0;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(510, 122);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(110, 28);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "Nhập số";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtNhapSN
            // 
            this.txtNhapSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNhapSN.Location = new System.Drawing.Point(161, 122);
            this.txtNhapSN.Name = "txtNhapSN";
            this.txtNhapSN.Size = new System.Drawing.Size(312, 24);
            this.txtNhapSN.TabIndex = 7;
            this.txtNhapSN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập số nguyên:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 100);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 70);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ứng dụng xử lý dãy số ";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaPhanTuCuoi);
            this.groupBox2.Controls.Add(this.btnXoaPhanTuDau);
            this.groupBox2.Controls.Add(this.btnXoaPhanTuDangChon);
            this.groupBox2.Controls.Add(this.btnChonSoLeCuoi);
            this.groupBox2.Controls.Add(this.btnChonSoChanDau);
            this.groupBox2.Controls.Add(this.btnTangMoiPhanTuLen2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox2.Location = new System.Drawing.Point(380, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 305);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnChonSoChanDau
            // 
            this.btnChonSoChanDau.Location = new System.Drawing.Point(32, 77);
            this.btnChonSoChanDau.Name = "btnChonSoChanDau";
            this.btnChonSoChanDau.Size = new System.Drawing.Size(252, 36);
            this.btnChonSoChanDau.TabIndex = 3;
            this.btnChonSoChanDau.Text = "Chọn số chẵn đầu";
            this.btnChonSoChanDau.UseVisualStyleBackColor = true;
            this.btnChonSoChanDau.Click += new System.EventHandler(this.btnChonSoChanDau_Click);
            // 
            // btnChonSoLeCuoi
            // 
            this.btnChonSoLeCuoi.Location = new System.Drawing.Point(31, 120);
            this.btnChonSoLeCuoi.Name = "btnChonSoLeCuoi";
            this.btnChonSoLeCuoi.Size = new System.Drawing.Size(252, 36);
            this.btnChonSoLeCuoi.TabIndex = 4;
            this.btnChonSoLeCuoi.Text = "Chọn số lẻ cuối";
            this.btnChonSoLeCuoi.UseVisualStyleBackColor = true;
            this.btnChonSoLeCuoi.Click += new System.EventHandler(this.btnChonSoLeCuoi_Click);
            // 
            // btnXoaPhanTuDangChon
            // 
            this.btnXoaPhanTuDangChon.Location = new System.Drawing.Point(32, 162);
            this.btnXoaPhanTuDangChon.Name = "btnXoaPhanTuDangChon";
            this.btnXoaPhanTuDangChon.Size = new System.Drawing.Size(252, 36);
            this.btnXoaPhanTuDangChon.TabIndex = 5;
            this.btnXoaPhanTuDangChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaPhanTuDangChon.UseVisualStyleBackColor = true;
            this.btnXoaPhanTuDangChon.Click += new System.EventHandler(this.btnXoaPhanTuDangChon_Click);
            // 
            // btnXoaPhanTuDau
            // 
            this.btnXoaPhanTuDau.Location = new System.Drawing.Point(31, 204);
            this.btnXoaPhanTuDau.Name = "btnXoaPhanTuDau";
            this.btnXoaPhanTuDau.Size = new System.Drawing.Size(252, 36);
            this.btnXoaPhanTuDau.TabIndex = 6;
            this.btnXoaPhanTuDau.Text = "Xóa phần tử đầu";
            this.btnXoaPhanTuDau.UseVisualStyleBackColor = true;
            this.btnXoaPhanTuDau.Click += new System.EventHandler(this.btnXoaPhanTuDau_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoaDaySo);
            this.panel2.Controls.Add(this.btnKetThucUngDung);
            this.panel2.Location = new System.Drawing.Point(12, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 70);
            this.panel2.TabIndex = 12;
            // 
            // btnXoaPhanTuCuoi
            // 
            this.btnXoaPhanTuCuoi.Location = new System.Drawing.Point(31, 246);
            this.btnXoaPhanTuCuoi.Name = "btnXoaPhanTuCuoi";
            this.btnXoaPhanTuCuoi.Size = new System.Drawing.Size(252, 36);
            this.btnXoaPhanTuCuoi.TabIndex = 7;
            this.btnXoaPhanTuCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaPhanTuCuoi.UseVisualStyleBackColor = true;
            this.btnXoaPhanTuCuoi.Click += new System.EventHandler(this.btnXoaPhanTuCuoi_Click);
            // 
            // btnKetThucUngDung
            // 
            this.btnKetThucUngDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKetThucUngDung.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKetThucUngDung.Location = new System.Drawing.Point(45, 22);
            this.btnKetThucUngDung.Name = "btnKetThucUngDung";
            this.btnKetThucUngDung.Size = new System.Drawing.Size(252, 36);
            this.btnKetThucUngDung.TabIndex = 8;
            this.btnKetThucUngDung.Text = "Kết thúc ứng dụng";
            this.btnKetThucUngDung.UseVisualStyleBackColor = false;
            this.btnKetThucUngDung.Click += new System.EventHandler(this.btnKetThucUngDung_Click);
            // 
            // btnXoaDaySo
            // 
            this.btnXoaDaySo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnXoaDaySo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoaDaySo.Location = new System.Drawing.Point(443, 22);
            this.btnXoaDaySo.Name = "btnXoaDaySo";
            this.btnXoaDaySo.Size = new System.Drawing.Size(252, 36);
            this.btnXoaDaySo.TabIndex = 9;
            this.btnXoaDaySo.Text = "Xóa dãy số";
            this.btnXoaDaySo.UseVisualStyleBackColor = false;
            this.btnXoaDaySo.Click += new System.EventHandler(this.btnXoaDaySo_Click);
            // 
            // btnTangMoiPhanTuLen2
            // 
            this.btnTangMoiPhanTuLen2.Location = new System.Drawing.Point(32, 35);
            this.btnTangMoiPhanTuLen2.Name = "btnTangMoiPhanTuLen2";
            this.btnTangMoiPhanTuLen2.Size = new System.Drawing.Size(252, 36);
            this.btnTangMoiPhanTuLen2.TabIndex = 2;
            this.btnTangMoiPhanTuLen2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTangMoiPhanTuLen2.UseVisualStyleBackColor = true;
            this.btnTangMoiPhanTuLen2.Click += new System.EventHandler(this.btnTangMoiPhanTuLen2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhapSN);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.lsbDaySo);
            this.Name = "Form1";
            this.Text = "Xử lý dãy số với ListBox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbDaySo;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtNhapSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaPhanTuCuoi;
        private System.Windows.Forms.Button btnXoaPhanTuDau;
        private System.Windows.Forms.Button btnXoaPhanTuDangChon;
        private System.Windows.Forms.Button btnChonSoLeCuoi;
        private System.Windows.Forms.Button btnChonSoChanDau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoaDaySo;
        private System.Windows.Forms.Button btnKetThucUngDung;
        private System.Windows.Forms.Button btnTangMoiPhanTuLen2;
    }
}

