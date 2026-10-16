namespace bai12
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXuatNgauNhien = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnDemCacSoLe = new System.Windows.Forms.Button();
            this.btnTimPTNhoNhat = new System.Windows.Forms.Button();
            this.btnTongCacSoLe = new System.Windows.Forms.Button();
            this.btnSapXepTang = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(40, 37);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(607, 24);
            this.txtN.TabIndex = 0;
            this.txtN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mảng gốc";
            // 
            // btnXuatNgauNhien
            // 
            this.btnXuatNgauNhien.Location = new System.Drawing.Point(63, 251);
            this.btnXuatNgauNhien.Name = "btnXuatNgauNhien";
            this.btnXuatNgauNhien.Size = new System.Drawing.Size(148, 23);
            this.btnXuatNgauNhien.TabIndex = 2;
            this.btnXuatNgauNhien.Text = "Xuất Ngẫu Nhiên";
            this.btnXuatNgauNhien.UseVisualStyleBackColor = true;
            this.btnXuatNgauNhien.Click += new System.EventHandler(this.btnXuatNgauNhien_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKetQua);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 105);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(40, 46);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(607, 24);
            this.txtKetQua.TabIndex = 1;
            // 
            // btnDemCacSoLe
            // 
            this.btnDemCacSoLe.Location = new System.Drawing.Point(63, 297);
            this.btnDemCacSoLe.Name = "btnDemCacSoLe";
            this.btnDemCacSoLe.Size = new System.Drawing.Size(148, 23);
            this.btnDemCacSoLe.TabIndex = 3;
            this.btnDemCacSoLe.Text = "Đếm Các Số Lẻ";
            this.btnDemCacSoLe.UseVisualStyleBackColor = true;
            // 
            // btnTimPTNhoNhat
            // 
            this.btnTimPTNhoNhat.Location = new System.Drawing.Point(63, 341);
            this.btnTimPTNhoNhat.Name = "btnTimPTNhoNhat";
            this.btnTimPTNhoNhat.Size = new System.Drawing.Size(148, 23);
            this.btnTimPTNhoNhat.TabIndex = 4;
            this.btnTimPTNhoNhat.Text = "Tìm Phần Tử Nhỏ Nhất";
            this.btnTimPTNhoNhat.UseVisualStyleBackColor = true;
            // 
            // btnTongCacSoLe
            // 
            this.btnTongCacSoLe.Location = new System.Drawing.Point(292, 251);
            this.btnTongCacSoLe.Name = "btnTongCacSoLe";
            this.btnTongCacSoLe.Size = new System.Drawing.Size(148, 23);
            this.btnTongCacSoLe.TabIndex = 5;
            this.btnTongCacSoLe.Text = "Tổng Các Số Lẻ";
            this.btnTongCacSoLe.UseVisualStyleBackColor = true;
            // 
            // btnSapXepTang
            // 
            this.btnSapXepTang.Location = new System.Drawing.Point(292, 297);
            this.btnSapXepTang.Name = "btnSapXepTang";
            this.btnSapXepTang.Size = new System.Drawing.Size(148, 23);
            this.btnSapXepTang.TabIndex = 6;
            this.btnSapXepTang.Text = "Sắp Xếp Tăng";
            this.btnSapXepTang.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(292, 341);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(148, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSapXepTang);
            this.Controls.Add(this.btnTongCacSoLe);
            this.Controls.Add(this.btnTimPTNhoNhat);
            this.Controls.Add(this.btnDemCacSoLe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXuatNgauNhien);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXuatNgauNhien;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnDemCacSoLe;
        private System.Windows.Forms.Button btnTimPTNhoNhat;
        private System.Windows.Forms.Button btnTongCacSoLe;
        private System.Windows.Forms.Button btnSapXepTang;
        private System.Windows.Forms.Button btnThoat;
    }
}

