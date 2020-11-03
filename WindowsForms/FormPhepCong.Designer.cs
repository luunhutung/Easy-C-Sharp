namespace WindowsForms
{
    partial class FormPhepCong
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
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.txtHieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTich = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(76, 20);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(100, 20);
            this.txtSoA.TabIndex = 1;
            this.txtSoA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSoA_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số a:";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(249, 23);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 3;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập số b: ";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(76, 59);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(100, 20);
            this.txtSoB.TabIndex = 2;
            this.txtSoB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSoB_KeyUp);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(249, 52);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng: ";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(65, 114);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(36, 20);
            this.txtTong.TabIndex = 5;
            // 
            // txtHieu
            // 
            this.txtHieu.Location = new System.Drawing.Point(135, 114);
            this.txtHieu.Name = "txtHieu";
            this.txtHieu.Size = new System.Drawing.Size(36, 20);
            this.txtHieu.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hiệu:";
            // 
            // txtTich
            // 
            this.txtTich.Location = new System.Drawing.Point(206, 114);
            this.txtTich.Name = "txtTich";
            this.txtTich.Size = new System.Drawing.Size(33, 20);
            this.txtTich.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tích:";
            // 
            // txtThuong
            // 
            this.txtThuong.Location = new System.Drawing.Point(290, 114);
            this.txtThuong.Name = "txtThuong";
            this.txtThuong.Size = new System.Drawing.Size(36, 20);
            this.txtThuong.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Thương:";
            // 
            // FormPhepCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 159);
            this.Controls.Add(this.txtThuong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTich);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoA);
            this.Name = "FormPhepCong";
            this.Text = "FormPhepCong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPhepCong_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.TextBox txtHieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThuong;
        private System.Windows.Forms.Label label6;
    }
}