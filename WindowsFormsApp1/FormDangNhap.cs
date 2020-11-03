using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        #region Form Rỗng
        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Form Đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTaiKhoan.Text == "")
                    throw new Exception("Chưa nhập tài khoản");
                
                if (txtMatKhau.Text == "")
                    throw new Exception("Chưa nhập mật khẩu");

                if (txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "123456")
                    this.DialogResult = DialogResult.OK;
                else
                    throw new Exception("Tài khoản hoặc mật khẩu không hợp lệ!!!");
            }
            catch (Exception ex)
            {
                lblThongBao.Text = ex.Message;
            }
        }
        #endregion
    }
}
