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
        #region Property
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string DiaChi { get; set; }

        public static List<ClassLop> DanhSachLopHoc;

        private static ClassLop LopCanSua;

        #endregion

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

        #region Lớp học To String
        public string LopHocToString()
        {
            return string.Format("{0}, {1}, {2}", MaLop, TenLop, DiaChi);
        }
        #endregion

        #region Thêm thông tin lớp vừa nhập vào danh sách
        public void ThemLopHoc()
        {
            if (DanhSachLopHoc == null)
                DanhSachLopHoc = new List<ClassLop>();

            DanhSachLopHoc.Add(this);
        }

        private static void ThemLop(ClassLop lophoc)
        {
            if (DanhSachLopHoc == null)
                DanhSachLopHoc = new List<ClassLop>();

            DanhSachLopHoc.Add(lophoc);
        }
        #endregion

        #region Xóa lớp học
        public static void Xoa(string maLop)
        {
            DanhSachLopHoc.RemoveAll(lophoc => lophoc.MaLop == maLop);
        }
        #endregion

        #region Sửa lớp học
        public static void Sua(ClassLop lophoc)
        {
            Xoa(lophoc.MaLop);
            ThemLop(lophoc);
        }
        #endregion

        #region Get danh sách lớp
        public static List<ClassLop> GetDanhSachLopHoc()
        {
            if (DanhSachLopHoc == null)
                DanhSachLopHoc = new List<ClassLop>();
            return DanhSachLopHoc;
        }
        #endregion

        #region Tìm lớp học bằng Mã lớp
        public static ClassLop LopById(string maLopHoc)
        {
            if (DanhSachLopHoc != null)
                foreach (var lophoc in DanhSachLopHoc)
                {
                    if (lophoc.MaLop == maLopHoc)
                        return lophoc;
                }
            return new ClassLop();
        }
        #endregion

        #region Set thông tin lớp cần sửa
        public static void SetLopCanSua(ClassLop lopCanSua)
        {
            LopCanSua = lopCanSua;
        }
        #endregion

        #region Get thông tin lớp cần sửa
        public static ClassLop GetLopCanSua()
        {
            if (LopCanSua == null)
                return new ClassLop();

            return LopCanSua;
        }
        #endregion
    }
}
