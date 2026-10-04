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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.txtChuVi.Size = new System.Drawing.Size(276, 35);
            this.txtChuVi.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(242, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "TÍNH";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(442, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "LÀM LẠI";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtDienTich
            // 
            this.txtDienTich.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienTich.Location = new System.Drawing.Point(367, 224);
            this.txtDienTich.Name = "txtDienTich";
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtChuVi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelbankinh);
            this.Controls.Add(this.txtBanKinh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelchuvi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelchuvi;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.Label labelbankinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChuVi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Label labeldientich;
    }
}

