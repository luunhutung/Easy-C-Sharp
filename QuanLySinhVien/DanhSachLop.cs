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
    public partial class DanhSachLop : Form
    {
        #region Hàm khởi tạo
        public DanhSachLop()
        {
            InitializeComponent();
        }
        #endregion

        #region Load Danh sách lớp
        private void DanhSachLop_Load(object sender, EventArgs e)
        {
            ResetDanhSachLop();
        }
        #endregion

        #region Hàm Reset Danh sách lớp
        private void ResetDanhSachLop()
        {
            if (ClassLop.DanhSachLopHoc != null)
                dgvDanhSachLopHoc.DataSource = ClassLop.DanhSachLopHoc.ToList();
        }
        #endregion

        #region Button Thêm trên Form Danh Sách Lớp
        private void button1_Click(object sender, EventArgs e)
        {
            Form formThem = new ThemLop();
            DialogResult isOK = formThem.ShowDialog();
            if (isOK == DialogResult.OK)
                ResetDanhSachLop();
        }
        #endregion

        #region Lấy Mã lớp khi click vào thông tin trên Danh sách lớp
        private void dgvDanhSachLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaLopHoc = dgvDanhSachLopHoc.Rows[e.RowIndex].Cells[0].Value.ToString();

            ClassLop LopCanSua = ClassLop.LopById(MaLopHoc);

            ClassLop.SetLopCanSua(LopCanSua);

            Form formSuaLopHoc = new SuaLop();
            
            var isOK = formSuaLopHoc.ShowDialog();

            if (isOK == DialogResult.OK)
                ResetDanhSachLop();
        }
        #endregion
    }
}
