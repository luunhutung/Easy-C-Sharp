using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TestConnectDatabase;

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

            ConnectDB connectDB = new ConnectDB();

            string sql = @"INSERT INTO LopHoc(MaLop, TenLop, DiaChi) VALUES('{0}', N'{1}', N'{2}')";

            connectDB.InsertQuery(string.Format(sql, this.MaLop, this.TenLop, this.DiaChi));
        }

        private static void ThemLop(ClassLop lophoc)
        {
            if (DanhSachLopHoc == null)
                DanhSachLopHoc = new List<ClassLop>();

            DanhSachLopHoc.Add(lophoc);

            ConnectDB connectDB = new ConnectDB();

            string sql = @"INSERT INTO LopHoc(MaLop, TenLop, DiaChi) VALUES('{0}', '{1}', '{2}')";

            connectDB.InsertQuery(string.Format(sql, lophoc.MaLop, lophoc.TenLop, lophoc.DiaChi));
        }
        #endregion

        #region Xóa lớp học
        public static void Xoa(string maLop)
        {
            //DanhSachLopHoc.RemoveAll(lophoc => lophoc.MaLop == maLop);

            ConnectDB connectDB = new ConnectDB();

            string sql = @"DELETE FROM LopHoc WHERE MaLop = '{0}'";

            connectDB.InsertQuery(string.Format(sql, maLop));
        }
        #endregion

        #region Sửa lớp học
        public static void Sua(ClassLop lophoc)
        {
            //Xoa(lophoc.MaLop);
            //ThemLop(lophoc);

            ConnectDB connectDB = new ConnectDB();

            string sql = @"UPDATE LopHoc SET TenLop = N'{0}', DiaChi = N'{1}' WHERE MaLop = '{2}'";

            connectDB.InsertQuery(string.Format(sql, lophoc.TenLop, lophoc.DiaChi, lophoc.MaLop));
        }
        #endregion

        #region Get danh sách lớp
        public static List<ClassLop> GetDanhSachLopHoc()
        {
            //if (DanhSachLopHoc == null)
            //    DanhSachLopHoc = new List<ClassLop>();
            //return DanhSachLopHoc;

            ConnectDB connectDB = new ConnectDB();
            SqlDataReader result = connectDB.SelectQuery("SELECT * FROM LopHoc");
            List<ClassLop> listLopHoc = new List<ClassLop>();
            while (result.Read())
            {
                string maLop = result.GetValue(0).ToString();
                string tenLop = result.GetValue(1).ToString();
                string diaChi = result.GetValue(2).ToString();

                ClassLop lophoc = new ClassLop(maLop, tenLop, diaChi);
                listLopHoc.Add(lophoc);
            }
            return listLopHoc;
        }
        #endregion

        #region Tìm lớp học bằng Mã lớp
        public static ClassLop LopById(string maLopHoc)
        {
            //if (DanhSachLopHoc != null)
            //    foreach (var lophoc in DanhSachLopHoc)
            //    {
            //        if (lophoc.MaLop == maLopHoc)
            //            return lophoc;
            //    }
            //return new ClassLop();

            ConnectDB connectDB = new ConnectDB();

            string sql = @"SELECT * FROM LopHoc WHERE MaLop = {0}";

            SqlDataReader result = connectDB.SelectQuery(string.Format(sql, maLopHoc));

            result.Read();
            string maLop = result.GetValue(0).ToString();
            string tenLop = result.GetValue(1).ToString();
            string diaChi = result.GetValue(2).ToString();

            ClassLop lophoc = new ClassLop(maLop, tenLop, diaChi);

            return lophoc;
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
