namespace bai1
{
    partial class Form1c2
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
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.labeldientich = new System.Windows.Forms.Label();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.txtChuVi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelbankinh = new System.Windows.Forms.Label();
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.labelchuvi = new System.Windows.Forms.Label();
            this.labelLoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDienTich
            // 
            this.txtDienTich.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienTich.Location = new System.Drawing.Point(281, 225);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.ReadOnly = true;
            this.txtDienTich.Size = new System.Drawing.Size(276, 35);
            this.txtDienTich.TabIndex = 21;
            // 
            // labeldientich
            // 
            this.labeldientich.AutoSize = true;
            this.labeldientich.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldientich.Location = new System.Drawing.Point(113, 229);
            this.labeldientich.Name = "labeldientich";
            this.labeldientich.Size = new System.Drawing.Size(145, 31);
            this.labeldientich.TabIndex = 20;
            this.labeldientich.Text = "DIỆN TÍCH";
            // 
            // btnLamLai
            // 
            this.btnLamLai.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamLai.Location = new System.Drawing.Point(417, 296);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(140, 39);
            this.btnLamLai.TabIndex = 19;
            this.btnLamLai.Text = "LÀM LẠI";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // txtChuVi
            // 
            this.txtChuVi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuVi.Location = new System.Drawing.Point(281, 167);
            this.txtChuVi.Name = "txtChuVi";
            this.txtChuVi.ReadOnly = true;
            this.txtChuVi.Size = new System.Drawing.Size(276, 35);
            this.txtChuVi.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(579, 36);
            this.label2.TabIndex = 17;
            this.label2.Text = "TÍNH CHU VI DIỆN TÍCH HÌNH TRÒN";
            // 
            // labelbankinh
            // 
            this.labelbankinh.AutoSize = true;
            this.labelbankinh.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbankinh.Location = new System.Drawing.Point(113, 115);
            this.labelbankinh.Name = "labelbankinh";
            this.labelbankinh.Size = new System.Drawing.Size(142, 31);
            this.labelbankinh.TabIndex = 16;
            this.labelbankinh.Text = "BÁN KÍNH";
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanKinh.Location = new System.Drawing.Point(281, 111);
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(276, 35);
            this.txtBanKinh.TabIndex = 15;
            this.txtBanKinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBanKinh_KeyPress);
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(281, 296);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(100, 39);
            this.btnTinh.TabIndex = 14;
            this.btnTinh.Text = "TÍNH";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // labelchuvi
            // 
            this.labelchuvi.AutoSize = true;
            this.labelchuvi.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelchuvi.Location = new System.Drawing.Point(113, 171);
            this.labelchuvi.Name = "labelchuvi";
            this.labelchuvi.Size = new System.Drawing.Size(104, 31);
            this.labelchuvi.TabIndex = 13;
            this.labelchuvi.Text = "CHU VI";
            this.labelchuvi.Click += new System.EventHandler(this.labelchuvi_Click);
            // 
            // labelLoi
            // 
            this.labelLoi.AutoSize = true;
            this.labelLoi.Location = new System.Drawing.Point(278, 151);
            this.labelLoi.Name = "labelLoi";
            this.labelLoi.Size = new System.Drawing.Size(156, 13);
            this.labelLoi.TabIndex = 22;
            this.labelLoi.Text = "vui long nhap so nguyen duong";
            this.labelLoi.Click += new System.EventHandler(this.labelLoi_Click);
            // 
            // Form1c2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLoi);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.labeldientich);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.txtChuVi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelbankinh);
            this.Controls.Add(this.txtBanKinh);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.labelchuvi);
            this.Name = "Form1c2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Label labeldientich;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.TextBox txtChuVi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelbankinh;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label labelchuvi;
        private System.Windows.Forms.Label labelLoi;
    }
}