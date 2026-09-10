using System;
using System.Collections.Generic;

namespace ThucHANH_Buoi2
{
    public class SinhVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Lop { get; set; }
        public string Hinh { get; set; }        // đường dẫn ảnh
        public bool GioiTinh { get; set; }      // true: Nam, false: Nữ
        public List<string> ChuyenNganh { get; set; }

        public SinhVien()
        {
            ChuyenNganh = new List<string>();
        }

        public SinhVien(string ms, string ht, DateTime ngay, string dc, string lop,
                        string hinh, bool gt, List<string> cn)
        {
            MaSo = ms;
            HoTen = ht;
            NgaySinh = ngay;
            DiaChi = dc;
            Lop = lop;
            Hinh = hinh;
            GioiTinh = gt;
            ChuyenNganh = cn ?? new List<string>();
        }
    }
}
