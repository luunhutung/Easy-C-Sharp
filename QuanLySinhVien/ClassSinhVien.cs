using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConnectDatabase;

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

        #region Get danh sách sinh viên
        public static List<ClassSinhVien> GetDanhSachSinhVien()
        {
            //if (DanhSachSinhVien == null)
            //    DanhSachSinhVien = new List<ClassSinhVien>();
            //return DanhSachSinhVien;

            ConnectDB connectDB = new ConnectDB();
            SqlDataReader result = connectDB.SelectQuery("SELECT * FROM SINHVIEN");
            List<ClassSinhVien> listSinhVien = new List<ClassSinhVien>();
            while (result.Read())
            {
                string maSV = result.GetValue(0).ToString();
                string tenSV = result.GetValue(1).ToString();
                string gioiTinh = result.GetValue(2).ToString();
                string soDT = result.GetValue(3).ToString();
                string diaChi = result.GetValue(4).ToString();
                string ngaySinh = result.GetValue(5).ToString();

                ClassSinhVien sinhvien = new ClassSinhVien(maSV, tenSV, bool.Parse(gioiTinh), soDT, diaChi, DateTime.Parse(ngaySinh));
                listSinhVien.Add(sinhvien);
            }
            return listSinhVien;
        }
        #endregion

        #region Tìm sinh viên theo mã sinh viên
        public static ClassSinhVien SinhVienById(string maSV)
        {
            //foreach ( var sv in DanhSachSinhVien)
            //{
            //    if (sv.MaSV == maSV)
            //        return sv;
            //}
            //return new ClassSinhVien();

            ConnectDB connectDB = new ConnectDB();

            string sql = @"SELECT * FROM SINHVIEN WHERE MaSV = '{0}'";

            SqlDataReader result = connectDB.SelectQuery(string.Format(sql, maSV));

            result.Read();
            string tenSV = result.GetValue(1).ToString();
            string gioiTinh = result.GetValue(2).ToString();
            string soDT = result.GetValue(3).ToString();
            string diaChi = result.GetValue(4).ToString();
            string ngaySinh = result.GetValue(5).ToString();

            ClassSinhVien sinhvien = new ClassSinhVien(maSV, tenSV, bool.Parse(gioiTinh), soDT, diaChi, DateTime.Parse(ngaySinh));
            return sinhvien;
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

            ConnectDB connectDB = new ConnectDB();

            string sql = string.Format(@"INSERT INTO SinhVien(MaSV, TenSV, GioiTinh, SoDT, DiaChi, NgaySinh) VALUES('{0}', N'{1}', '{2}', '{3}', N'{4}', '{5}')", this.MaSV, this.TenSV, this.GioiTinh, this.SoDT, this.DiaChi, this.NgaySinh);

            connectDB.InsertQuery(sql);
        }

        public static void Them(ClassSinhVien sv)
        {
            if (DanhSachSinhVien == null)
                DanhSachSinhVien = new List<ClassSinhVien>();

            DanhSachSinhVien.Add(sv);

            ConnectDB connectDB = new ConnectDB();

            string sql = string.Format(@"INSERT INTO SinhVien(MaSV, TenSV, GioiTinh, SoDT, DiaChi, NgaySinh) VALUES('{0}', N'{1}', '{2}', '{3}', N'{4}', '{5}')", sv.MaSV, sv.TenSV, sv.GioiTinh == true ? 1 : 0, sv.SoDT, sv.DiaChi, sv.NgaySinh);

            connectDB.InsertQuery(sql);

        }
        #endregion

        #region Xóa sinh viên trong danh sách
        public static void Xoa(string maSV)
        {
            DanhSachSinhVien.RemoveAll(sv => sv.MaSV == maSV);

            ConnectDB connectDB = new ConnectDB();

            string sql = @"DELETE FROM SinhVien WHERE MaSV = '{0}'";

            connectDB.InsertQuery(string.Format(sql, maSV));
        }
        #endregion

        #region Sửa sinh viên trong danh sách
        public static void Sua(ClassSinhVien sv)
        {
            //Xoa(sv.MaSV);
            //Them(sv);

            ConnectDB connectDB = new ConnectDB();

            string sql = @"UPDATE SinhVien SET TenSV = '{0}', GioiTinh = '{1}' SoDT = '{2}', DiaChi = '{3}', NgaySinh = '{4}', WHERE MaSV = '{5}'";

            connectDB.InsertQuery(string.Format(sql, sv.TenSV, sv.GioiTinh == true ? 1 : 0, sv.SoDT, sv.DiaChi, sv.NgaySinh, sv.MaSV));

        }
        #endregion

    }
}
