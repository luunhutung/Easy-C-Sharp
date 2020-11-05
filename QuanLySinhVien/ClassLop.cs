using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class ClassLop
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string DiaChi { get; set; }

        public static List<ClassLop> DanhSachLopHoc;

        #region Constructor
        public ClassLop()
        {
        }

        public ClassLop(string maLop, string tenLop, string diaChi)
        {
            MaLop = maLop;
            TenLop = tenLop;
            DiaChi = diaChi;
        }
        #endregion

        #region Thêm thông tin đối tượng hiện tại vào danh sách
        public void ThemLopHoc()
        {
            if (DanhSachLopHoc == null)
                DanhSachLopHoc = new List<ClassLop>();

            DanhSachLopHoc.Add(this);
        }
        #endregion

        public string LopHocToString()
        {
            return string.Format("{0}, {1}, {2}", MaLop, TenLop, DiaChi);
        }        
    }
}
