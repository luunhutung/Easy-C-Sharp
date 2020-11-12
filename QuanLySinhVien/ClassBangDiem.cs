using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class ClassBangDiem
    {
        #region Property
        public string MaLop { get; set; }
        public string MaSV { get; set; }
        public double DiemToan { get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }

        public static List<ClassBangDiem> ListBangDiem { get; set; }
        #endregion

        #region Constructor
        public ClassBangDiem(string maLop, string maSV, double diemToan, double diemLy, double diemHoa)
        {
            MaLop = maLop;
            MaSV = maSV;
            DiemToan = diemToan;
            DiemLy = diemLy;
            DiemHoa = diemHoa;
        }
        #endregion

        #region Hàm Get bảng điểm
        public List<ClassBangDiem> GetBangDiem()
        {
            return ListBangDiem;
        }
        #endregion

        #region Thêm
        public static void Them(ClassBangDiem bangdiem)
        {
            if (ListBangDiem == null)
                ListBangDiem = new List<ClassBangDiem>();

            ListBangDiem.Add(bangdiem);
        }
        #endregion

        #region Xóa
        public static void Xoa(string maLop, string maSV)
        {
            ListBangDiem.RemoveAll(item => item.MaLop == maLop &&  item.MaSV == maSV);
        }
        #endregion

        #region Sửa
        public static void Sua(ClassBangDiem bangdiem)
        {
            Xoa(bangdiem.MaLop, bangdiem.MaSV);
            Them(bangdiem);
        }
        #endregion

    }
}
