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
    public partial class SuaLop : Form
    {
        #region Hàm khởi tạo
        public SuaLop()
        {
            InitializeComponent();
            SetInputForm(ClassLop.GetLopCanSua());
        }
        #endregion

        #region Lấy thông tin lớp cần sửa
        private void SetInputForm(ClassLop lopCanSua)
        {
            txtMaLopCanSua.Text = lopCanSua.MaLop;
            txtTenLopCanSua.Text = lopCanSua.TenLop;
            txtDiaChiLopCanSua.Text = lopCanSua.DiaChi;
        }
        #endregion

        #region Button Save
        private void btnSaveLop_Click(object sender, EventArgs e)
        {
            try
            {
                ClassLop LH = GetInputForm();

                ClassLop.Sua(LH);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private ClassLop GetInputForm()
        {
            if (txtTenLopCanSua.Text == "")
            {
                txtTenLopCanSua.Focus();
                throw new Exception("Vui lòng nhập học tên");
            }
            if (txtDiaChiLopCanSua.Text == "")
            {
                txtDiaChiLopCanSua.Focus();
                throw new Exception("Vui lòng nhập địa chỉ");
            }

            return new ClassLop(txtMaLopCanSua.Text, txtTenLopCanSua.Text, txtDiaChiLopCanSua.Text);
        }
        #endregion

        #region Button Xóa
        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            var isXoa = MessageBox.Show("Bạn có muốn xóa lớp " + ClassLop.GetLopCanSua().TenLop + " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (isXoa != DialogResult.OK)
                return;

            ClassLop.Xoa(ClassLop.GetLopCanSua().MaLop);

            DialogResult = DialogResult.OK;
        }
        #endregion

        #region Button Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
