using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class GioiTinh
    {
        const bool Nam = true;
        const bool Nu = false;

        public bool Id { get; set; }
        public string Name { get; set; }

        public static List<GioiTinh> Get()
        {
            List<GioiTinh> listGioiTinh = new List<GioiTinh>();

            GioiTinh gioiTinhNam = new GioiTinh();
            
            gioiTinhNam.Id = Nam;
            gioiTinhNam.Name = "Nam";

            listGioiTinh.Add(gioiTinhNam);

            GioiTinh gioiTinhNu = new GioiTinh();
            
            gioiTinhNu.Id = Nu;
            gioiTinhNu.Name = "Nữ";
            
            listGioiTinh.Add(gioiTinhNu);
            
            return listGioiTinh;
        }
    }
}
