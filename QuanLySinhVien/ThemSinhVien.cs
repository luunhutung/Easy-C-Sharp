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
    public partial class ThemSinhVien : Form
    {
        public ThemSinhVien()
        {
            InitializeComponent();
        }

        #region Hàm Load
        private void ThemSinhVien_Load(object sender, EventArgs e)
        {
            comboBoxGioiTinh.DataSource = GioiTinh.Get();
            comboBoxGioiTinh.DisplayMember = "Name";
            comboBoxGioiTinh.ValueMember = "Id";
            comboBoxGioiTinh.SelectedIndex = 0;
        }
        #endregion

        #region Button Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ClassSinhVien sinhvien = GetInputForm();

                sinhvien.Them();

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Button Reset
        private void btnResetSV_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            txtSoDT.Text = "";
            txtDiaChiSV.Text = "";
            dateTimePickerNgaySinh.ResetText();
        }
        #endregion

        #region Lấy thông tin từ Form
        private ClassSinhVien GetInputForm()
        {
            if (txtMaSV.Text == "")
            {
                txtMaSV.Focus();
                throw new Exception("Vui lòng nhập mã sinh viên");
            }
            if (txtTenSV.Text == "")
            {
                txtTenSV.Focus();
                throw new Exception("Vui lòng nhập học tên");
            }   
            if (comboBoxGioiTinh.Text == "")
            {
                comboBoxGioiTinh.Focus();
                throw new Exception("Vui lòng chọn giới tính");
            }
            if (txtSoDT.Text == "")
            {
                txtSoDT.Focus();
                throw new Exception("Vui lòng nhập số điện thoại");
            }    
            if (txtDiaChiSV.Text == "")
            {
                txtDiaChiSV.Focus();
                throw new Exception("Vui lòng nhập địa chỉ");
            }

            GioiTinh gt = (GioiTinh) comboBoxGioiTinh.SelectedItem;

            return new ClassSinhVien(txtMaSV.Text, txtTenSV.Text, gt.Id, txtSoDT.Text, txtDiaChiSV.Text, dateTimePickerNgaySinh.Value);
        }
        #endregion

    }
}
