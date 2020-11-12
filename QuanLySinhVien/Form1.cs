using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Thoát
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (hoi != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Thêm lớp
        private void thêmLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formThemLop = new ThemLop();
            formThemLop.ShowDialog();
        }
        #endregion

        #region Danh sách lớp
        private void danhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formDanhSachLop = new DanhSachLop();
            formDanhSachLop.MdiParent = this;
            formDanhSachLop.Show();
        }
        #endregion

        #region Thêm Sinh viên
        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formThemSinhVien = new ThemSinhVien();
            formThemSinhVien.MdiParent = this;
            formThemSinhVien.Show();
        }
        #endregion

        #region Danh sách Sinh viên
        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formDanhSachSinhVien = new DanhSachSinhVien();
            formDanhSachSinhVien.MdiParent = this;
            formDanhSachSinhVien.Show();
        }
        #endregion

        #region Sinh viên theo lớp
        private void sinhViênTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formSinhVienTheoLop = new SinhVienTheoLop();
            formSinhVienTheoLop.MdiParent = this;
            formSinhVienTheoLop.Show();
        }
        #endregion

        #region Sinh viên học lại
        private void sinhViênHọcLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formSinhVienHocLai = new SinhVienHocLai();
            formSinhVienHocLai.MdiParent = this;
            formSinhVienHocLai.Show();
        }
        #endregion

        #region Điểm theo lớp
        private void điểmTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formDiemTheoLop = new DiemTheoLop();
            formDiemTheoLop.MdiParent = this;
            formDiemTheoLop.Show();
        }
        #endregion

        #region Hàm Load
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Bảng điểm
        private void cậpNhậtBảngĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formBangDiem = new BangDiem();
            formBangDiem.MdiParent = this;
            formBangDiem.Show();
        }
        #endregion
    }
}
