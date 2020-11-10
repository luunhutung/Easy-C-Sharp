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
    public partial class SuaSinhVien : Form
    {
        #region Hàm khởi tạo
        public SuaSinhVien()
        {
            InitializeComponent();
            SetInputForm(ClassSinhVien.GetSinhVienCanSua());
        }
        #endregion

        #region Hàm Load
        private void SuaSinhVien_Load(object sender, EventArgs e)
        {
            comboBoxGioiTinhSVCanSua.DataSource = GioiTinh.Get();
            comboBoxGioiTinhSVCanSua.DisplayMember = "Name";
            comboBoxGioiTinhSVCanSua.ValueMember = "Id";
            comboBoxGioiTinhSVCanSua.SelectedIndex = 0;
        }
        #endregion

        #region Lấy thông tin của sinh viên cần sửa
        private void SetInputForm(ClassSinhVien svCanSua)
        {
            txtMaSVCanSua.Text = svCanSua.MaSV;
            txtTenSVCanSua.Text = svCanSua.TenSV;
            comboBoxGioiTinhSVCanSua.SelectedValue = svCanSua.GioiTinh;
            txtSoDTSinhVienCanSua.Text = svCanSua.SoDT;
            txtDiaChiSVCanSua.Text = svCanSua.DiaChi;
            dateTimePickerNgaySinhSVCanSua.Value = svCanSua.NgaySinh;
        }
        #endregion

        #region Button Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ClassSinhVien SV = GetInputForm();

                ClassSinhVien.Sua(SV);
                
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ClassSinhVien GetInputForm()
        {
            if (txtTenSVCanSua.Text == "")
            {
                txtTenSVCanSua.Focus();
                throw new Exception("Vui lòng nhập học tên");
            }
            if (comboBoxGioiTinhSVCanSua.Text == "")
            {
                comboBoxGioiTinhSVCanSua.Focus();
                throw new Exception("Vui lòng chọn giới tính");
            }
            if (txtSoDTSinhVienCanSua.Text == "")
            {
                txtSoDTSinhVienCanSua.Focus();
                throw new Exception("Vui lòng nhập số điện thoại");
            }
            if (txtDiaChiSVCanSua.Text == "")
            {
                txtDiaChiSVCanSua.Focus();
                throw new Exception("Vui lòng nhập địa chỉ");
            }

            GioiTinh gt = (GioiTinh)comboBoxGioiTinhSVCanSua.SelectedItem;

            return new ClassSinhVien(txtMaSVCanSua.Text, txtTenSVCanSua.Text, gt.Id, txtSoDTSinhVienCanSua.Text, txtDiaChiSVCanSua.Text, dateTimePickerNgaySinhSVCanSua.Value);
        }
        #endregion

        #region Button Xóa
        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            var isXoa = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (isXoa != DialogResult.OK)
                return;

            ClassSinhVien.Xoa(ClassSinhVien.GetSinhVienCanSua().MaSV);

            DialogResult = DialogResult.OK;
        }
        #endregion

        #region Button Thoát
        private void btnThoatSuaSV_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

    }
}
