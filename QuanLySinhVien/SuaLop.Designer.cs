namespace QuanLySinhVien
{
    partial class SuaLop
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
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChiLopCanSua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenLopCanSua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveLop = new System.Windows.Forms.Button();
            this.txtMaLopCanSua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaLop.Location = new System.Drawing.Point(82, 164);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(66, 23);
            this.btnXoaLop.TabIndex = 5;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "SỬA LỚP";
            // 
            // txtDiaChiLopCanSua
            // 
            this.txtDiaChiLopCanSua.Location = new System.Drawing.Point(61, 121);
            this.txtDiaChiLopCanSua.Name = "txtDiaChiLopCanSua";
            this.txtDiaChiLopCanSua.Size = new System.Drawing.Size(163, 20);
            this.txtDiaChiLopCanSua.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Địa chỉ:";
            // 
            // txtTenLopCanSua
            // 
            this.txtTenLopCanSua.Location = new System.Drawing.Point(61, 84);
            this.txtTenLopCanSua.Name = "txtTenLopCanSua";
            this.txtTenLopCanSua.Size = new System.Drawing.Size(163, 20);
            this.txtTenLopCanSua.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên Lớp:";
            // 
            // btnSaveLop
            // 
            this.btnSaveLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveLop.Location = new System.Drawing.Point(6, 164);
            this.btnSaveLop.Name = "btnSaveLop";
            this.btnSaveLop.Size = new System.Drawing.Size(70, 23);
            this.btnSaveLop.TabIndex = 4;
            this.btnSaveLop.Text = "Save";
            this.btnSaveLop.UseVisualStyleBackColor = true;
            this.btnSaveLop.Click += new System.EventHandler(this.btnSaveLop_Click);
            // 
            // txtMaLopCanSua
            // 
            this.txtMaLopCanSua.Location = new System.Drawing.Point(61, 47);
            this.txtMaLopCanSua.Name = "txtMaLopCanSua";
            this.txtMaLopCanSua.ReadOnly = true;
            this.txtMaLopCanSua.Size = new System.Drawing.Size(163, 20);
            this.txtMaLopCanSua.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Lớp:";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(154, 164);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(70, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // SuaLop
            // 
            this.AcceptButton = this.btnSaveLop;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 199);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaLop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiaChiLopCanSua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenLopCanSua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveLop);
            this.Controls.Add(this.txtMaLopCanSua);
            this.Controls.Add(this.label1);
            this.Name = "SuaLop";
            this.Text = "Sửa lớp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChiLopCanSua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenLopCanSua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveLop;
        private System.Windows.Forms.TextBox txtMaLopCanSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
    }
}