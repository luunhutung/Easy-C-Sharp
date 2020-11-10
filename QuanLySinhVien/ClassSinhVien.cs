﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class ClassSinhVien
    {
        #region Property
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public bool GioiTinh { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }

        public static List<ClassSinhVien> DanhSachSinhVien;

        private static ClassSinhVien SinhVienCanSua;

        #endregion

        #region Constructor
        public ClassSinhVien()
        {
        }

        public ClassSinhVien(string maSV, string tenSV, bool gioiTinh, string soDT, string diaChi, DateTime ngaySinh)
        {
            MaSV = maSV;
            TenSV = tenSV;
            GioiTinh = gioiTinh;
            SoDT = soDT;
            DiaChi = diaChi;
            NgaySinh = ngaySinh;
        }

        public static List<ClassSinhVien> GetDanhSachSinhVien()
        {
            return DanhSachSinhVien;
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

        #region Tìm sinh viên theo mã sinh viên
        public static ClassSinhVien SinhVienById(string maSV)
        {
            foreach ( var sv in DanhSachSinhVien)
            {
                if (sv.MaSV == maSV)
                    return sv;
            }
            return new ClassSinhVien();
        }
        #endregion

        #region Set thông tin sinh viên cần sửa
        public static void SetSinhVienCanSua(ClassSinhVien sVCanSua)
        {
            SinhVienCanSua = sVCanSua;
        }
        #endregion

        #region Get thông tin sinh viên cần sửa
        public static ClassSinhVien GetSinhVienCanSua()
        {
            if (SinhVienCanSua == null)
                return new ClassSinhVien();

            return SinhVienCanSua;
        }
        #endregion

        #region Thêm sinh viên vào danh sách
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

        #region Xóa sinh viên trong danh sách
        public static void Xoa(string maSV)
        {   
            DanhSachSinhVien.RemoveAll(sv => sv.MaSV == maSV);
        }
        #endregion

        #region Sửa sinh viên trong danh sách
        public static void Sua(ClassSinhVien sv)
        {
            Xoa(sv.MaSV);
            Them(sv);
        }
        #endregion

    }
}