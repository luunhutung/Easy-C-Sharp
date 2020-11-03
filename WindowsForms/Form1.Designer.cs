namespace WindowsForms
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
            this.btnXinChao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXinChao
            // 
            this.btnXinChao.Location = new System.Drawing.Point(210, 70);
            this.btnXinChao.Name = "btnXinChao";
            this.btnXinChao.Size = new System.Drawing.Size(75, 23);
            this.btnXinChao.TabIndex = 0;
            this.btnXinChao.Text = "Xin Chào";
            this.btnXinChao.UseVisualStyleBackColor = true;
            this.btnXinChao.Click += new System.EventHandler(this.btnXinChao_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(583, 415);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXinChao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXinChao;
        private System.Windows.Forms.Button btnThoat;
    }
}

