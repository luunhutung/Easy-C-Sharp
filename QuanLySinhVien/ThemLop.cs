using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class ThemLop : Form
    {
        public ThemLop()
        {
            InitializeComponent();
        }

        #region Button Thêm Lớp
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ClassLop lophoc = GetInputForm();

                lophoc.ThemLopHoc();

                DialogResult = DialogResult.OK;

                /*Form FormDanhSachLop = new DanhSachLop();
                FormDanhSachLop.Show();
                Close();

                SetInputForm(new ClassLop());*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Button Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtDiaChiLop.Text = "";
        }
        #endregion

        #region Lấy thông tin từ Form
        private ClassLop GetInputForm()
        {
            if (txtMaLop.Text == "")
                throw new Exception("Vui lòng nhập mã lớp");
            if (txtTenLop.Text == "")
                throw new Exception("Vui lòng nhập tên lớp");
            if (txtDiaChiLop.Text == "")
                throw new Exception("Vui lòng nhập địa chỉ lớp");

            return new ClassLop(txtMaLop.Text, txtTenLop.Text, txtDiaChiLop.Text);
        }
        #endregion

        #region Gắn thông tin cho Form
        private void SetInputForm(ClassLop classLop)
        {
            txtMaLop.Text = classLop.MaLop;
            txtTenLop.Text = classLop.TenLop;
            txtDiaChiLop.Text = classLop.DiaChi;
        }
        #endregion


    }
}
