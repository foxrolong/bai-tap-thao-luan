namespace bai1
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
            this.labelchuvi = new System.Windows.Forms.Label();
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.labelbankinh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChuVi = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.labeldientich = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelchuvi
            // 
            this.labelchuvi.AutoSize = true;
            this.labelchuvi.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelchuvi.Location = new System.Drawing.Point(199, 170);
            this.labelchuvi.Name = "labelchuvi";
            this.labelchuvi.Size = new System.Drawing.Size(104, 31);
            this.labelchuvi.TabIndex = 0;
            this.labelchuvi.Text = "CHU VI";
            this.labelchuvi.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanKinh.Location = new System.Drawing.Point(367, 110);
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(276, 35);
            this.txtBanKinh.TabIndex = 3;
            this.txtBanKinh.TextChanged += new System.EventHandler(this.txtBanKinh_TextChanged);
            // 
            // labelbankinh
            // 
            this.labelbankinh.AutoSize = true;
            this.labelbankinh.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbankinh.Location = new System.Drawing.Point(199, 114);
            this.labelbankinh.Name = "labelbankinh";
            this.labelbankinh.Size = new System.Drawing.Size(142, 31);
            this.labelbankinh.TabIndex = 7;
            this.labelbankinh.Text = "BÁN KÍNH";
            this.labelbankinh.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(579, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "TÍNH CHU VI DIỆN TÍCH HÌNH TRÒN";
            // 
            // txtChuVi
            // 
            this.txtChuVi.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuVi.Location = new System.Drawing.Point(367, 166);
            this.txtChuVi.Name = "txtChuVi";
            this.txtChuVi.ReadOnly = true;
            this.txtChuVi.Size = new System.Drawing.Size(276, 35);
            this.txtChuVi.TabIndex = 9;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(367, 295);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(100, 39);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "TÍNH";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamLai.Location = new System.Drawing.Point(503, 295);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(140, 39);
            this.btnLamLai.TabIndex = 10;
            this.btnLamLai.Text = "LÀM LẠI";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // txtDienTich
            // 
            this.txtDienTich.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienTich.Location = new System.Drawing.Point(367, 224);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.ReadOnly = true;
            this.txtDienTich.Size = new System.Drawing.Size(276, 35);
            this.txtDienTich.TabIndex = 12;
            // 
            // labeldientich
            // 
            this.labeldientich.AutoSize = true;
            this.labeldientich.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldientich.Location = new System.Drawing.Point(199, 228);
            this.labeldientich.Name = "labeldientich";
            this.labeldientich.Size = new System.Drawing.Size(145, 31);
            this.labeldientich.TabIndex = 11;
            this.labeldientich.Text = "DIỆN TÍCH";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 604);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.labeldientich);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.txtChuVi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelbankinh);
            this.Controls.Add(this.txtBanKinh);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.labelchuvi);
            this.Name = "Form1";
            this.Text = "Tính chu vi & diện tích hình tròn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelchuvi;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.Label labelbankinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChuVi;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Label labeldientich;
    }
}

