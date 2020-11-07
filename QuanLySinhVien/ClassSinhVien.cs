using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class ClassSinhVien
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }

        public static List<ClassSinhVien> DanhSachSinhVien;

        #region Constructor
        public ClassSinhVien()
        {
        }

        public ClassSinhVien(string maSV, string tenSV, bool gioiTinh, string soDT, string diaChi, DateTime ngaySinh)
        {
            MaSV = maSV;
            TenSV = tenSV;
            SoDT = soDT;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
        }
        #endregion

        #region Tính tuổi sinh viên
        public int Tuoi()
        {
            return DateTime.Now.Year - this.NgaySinh.Year;
        }
        #endregion

        #region Sinh viên to String
        public string SinhVienToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}", MaSV, TenSV, SoDT, DiaChi, GioiTinh, NgaySinh);
        }
        #endregion

        #region Thêm sinh viên vừa nhập vào danh sách
        public void Them()
        {
            if (DanhSachSinhVien == null)
                DanhSachSinhVien = new List<ClassSinhVien>();
            DanhSachSinhVien.Add(this);
        }

        public static void Them(ClassSinhVien sv)
        {
            if (DanhSachSinhVien == null)
                DanhSachSinhVien = new List<ClassSinhVien>();
            DanhSachSinhVien.Add(sv);
        }
        #endregion
        
        public static void Xoa(string maSV)
        {   
            DanhSachSinhVien.RemoveAll(sv => sv.MaSV == maSV);
        }

        public static void Sua(ClassSinhVien sv)
        {
            Xoa(sv.MaSV);
            Them(sv);
        }

    }
}
