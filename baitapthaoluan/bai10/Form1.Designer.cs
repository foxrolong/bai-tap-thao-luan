namespace bai10
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
            this.ckbTinHocA = new System.Windows.Forms.CheckBox();
            this.cbMaHocVien = new System.Windows.Forms.ComboBox();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.ckbTinHocB = new System.Windows.Forms.CheckBox();
            this.ckbTiengAnhB = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ckbTiengAnhA = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ckbTinHocA
            // 
            this.ckbTinHocA.AutoSize = true;
            this.ckbTinHocA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ckbTinHocA.Location = new System.Drawing.Point(134, 185);
            this.ckbTinHocA.Name = "ckbTinHocA";
            this.ckbTinHocA.Size = new System.Drawing.Size(89, 22);
            this.ckbTinHocA.TabIndex = 0;
            this.ckbTinHocA.Text = "Tin học A";
            this.ckbTinHocA.UseVisualStyleBackColor = true;
            this.ckbTinHocA.CheckedChanged += new System.EventHandler(this.ckbTinHocA_CheckedChanged);
            // 
            // cbMaHocVien
            // 
            this.cbMaHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbMaHocVien.FormattingEnabled = true;
            this.cbMaHocVien.Location = new System.Drawing.Point(133, 61);
            this.cbMaHocVien.Name = "cbMaHocVien";
            this.cbMaHocVien.Size = new System.Drawing.Size(121, 26);
            this.cbMaHocVien.TabIndex = 1;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rdoNam.Location = new System.Drawing.Point(332, 61);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(58, 22);
            this.rdoNam.TabIndex = 2;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtHoTen.Location = new System.Drawing.Point(153, 106);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(491, 24);
            this.txtHoTen.TabIndex = 3;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnTinhTien.Location = new System.Drawing.Point(58, 368);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(145, 59);
            this.btnTinhTien.TabIndex = 4;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "TÍNH TIỀN HỌC TRUNG TÂM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(39, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã học viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(39, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Họ tên ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(260, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giới tính ";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rdoNu.Location = new System.Drawing.Point(396, 62);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(45, 22);
            this.rdoNu.TabIndex = 9;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // ckbTinHocB
            // 
            this.ckbTinHocB.AutoSize = true;
            this.ckbTinHocB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ckbTinHocB.Location = new System.Drawing.Point(134, 213);
            this.ckbTinHocB.Name = "ckbTinHocB";
            this.ckbTinHocB.Size = new System.Drawing.Size(88, 22);
            this.ckbTinHocB.TabIndex = 10;
            this.ckbTinHocB.Text = "Tin học b";
            this.ckbTinHocB.UseVisualStyleBackColor = true;
            this.ckbTinHocB.CheckedChanged += new System.EventHandler(this.ckbTinHocB_CheckedChanged);
            // 
            // ckbTiengAnhB
            // 
            this.ckbTiengAnhB.AutoSize = true;
            this.ckbTiengAnhB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ckbTiengAnhB.Location = new System.Drawing.Point(134, 269);
            this.ckbTiengAnhB.Name = "ckbTiengAnhB";
            this.ckbTiengAnhB.Size = new System.Drawing.Size(105, 22);
            this.ckbTiengAnhB.TabIndex = 12;
            this.ckbTiengAnhB.Text = "Tiếng anh B";
            this.ckbTiengAnhB.UseVisualStyleBackColor = true;
            this.ckbTiengAnhB.CheckedChanged += new System.EventHandler(this.ckbTiengAnhB_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(410, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "300.000 đồng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(410, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "500.000 đồng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(410, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "400.000 đồng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(410, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "600.000 đồng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(188, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtTongTien.Location = new System.Drawing.Point(263, 303);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(283, 24);
            this.txtTongTien.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCancel.Location = new System.Drawing.Point(296, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 59);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnExit.Location = new System.Drawing.Point(518, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 59);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ckbTiengAnhA
            // 
            this.ckbTiengAnhA.AutoSize = true;
            this.ckbTiengAnhA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ckbTiengAnhA.Location = new System.Drawing.Point(134, 241);
            this.ckbTiengAnhA.Name = "ckbTiengAnhA";
            this.ckbTiengAnhA.Size = new System.Drawing.Size(104, 22);
            this.ckbTiengAnhA.TabIndex = 11;
            this.ckbTiengAnhA.Text = "Tiếng anh A";
            this.ckbTiengAnhA.UseVisualStyleBackColor = true;
            this.ckbTiengAnhA.CheckedChanged += new System.EventHandler(this.ckbTiengAnhA_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.Location = new System.Drawing.Point(39, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ngày đăng ký";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTime.Location = new System.Drawing.Point(153, 141);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(262, 24);
            this.dateTime.TabIndex = 22;
            this.dateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ckbTiengAnhB);
            this.Controls.Add(this.ckbTiengAnhA);
            this.Controls.Add(this.ckbTinHocB);
            this.Controls.Add(this.rdoNu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.rdoNam);
            this.Controls.Add(this.cbMaHocVien);
            this.Controls.Add(this.ckbTinHocA);
            this.Name = "Form1";
            this.Text = "Tính tiền học trung tâm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbTinHocA;
        private System.Windows.Forms.ComboBox cbMaHocVien;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.CheckBox ckbTinHocB;
        private System.Windows.Forms.CheckBox ckbTiengAnhB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox ckbTiengAnhA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTime;
    }
}

