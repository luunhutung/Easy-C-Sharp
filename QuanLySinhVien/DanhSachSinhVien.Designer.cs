namespace QuanLySinhVien
{
    partial class DanhSachSinhVien
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
            this.dgvDanhSachSinhVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemSinhVien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachSinhVien
            // 
            this.dgvDanhSachSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSinhVien.Location = new System.Drawing.Point(1, 99);
            this.dgvDanhSachSinhVien.Name = "dgvDanhSachSinhVien";
            this.dgvDanhSachSinhVien.Size = new System.Drawing.Size(703, 287);
            this.dgvDanhSachSinhVien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // btnThemSinhVien
            // 
            this.btnThemSinhVien.Location = new System.Drawing.Point(603, 418);
            this.btnThemSinhVien.Name = "btnThemSinhVien";
            this.btnThemSinhVien.Size = new System.Drawing.Size(92, 23);
            this.btnThemSinhVien.TabIndex = 3;
            this.btnThemSinhVien.Text = "Thêm Sinh viên";
            this.btnThemSinhVien.UseVisualStyleBackColor = true;
            this.btnThemSinhVien.Click += new System.EventHandler(this.btnThemSinhVien_Click);
            // 
            // DanhSachSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 453);
            this.Controls.Add(this.btnThemSinhVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachSinhVien);
            this.Name = "DanhSachSinhVien";
            this.Text = "Danh sách Sinh viên";
            this.Load += new System.EventHandler(this.DanhSachSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemSinhVien;
    }
}