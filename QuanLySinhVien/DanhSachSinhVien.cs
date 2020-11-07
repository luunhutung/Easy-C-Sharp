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
    public partial class DanhSachSinhVien : Form
    {
        public DanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void DanhSachSinhVien_Load(object sender, EventArgs e)
        {
            ResetDanhSachSinhVien();
        }

        #region Hàm Reset Danh sách Sinh viên
        private void ResetDanhSachSinhVien()
        {
            if (ClassSinhVien.DanhSachSinhVien != null)
                dgvDanhSachSinhVien.DataSource = ClassSinhVien.DanhSachSinhVien;
        }
        #endregion

        #region Button Thêm trên Form Danh sách sinh viên
        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            Form formThemSinhVien = new ThemSinhVien();

            var isOK = formThemSinhVien.ShowDialog();

            if (isOK == DialogResult.OK)
                ResetDanhSachSinhVien();
        }
        #endregion
    }
}
