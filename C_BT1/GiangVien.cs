using System;

namespace C_BT1
{
    public class GiangVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SoDT { get; set; }
        public string Mail { get; set; }
        public string[] NgoaiNgu { get; set; }
        public DanhSachHocPhan dshocPhan;

        public GiangVien()
        {
            dshocPhan = new DanhSachHocPhan();
            NgoaiNgu = new string[20];
        }

        public GiangVien(string maso, string hoten, DateTime ngaysinh, string gt,
                         string sdt, string mail, DanhSachHocPhan ds, string[] nn)
        {
            MaSo = maso;
            HoTen = hoten;
            NgaySinh = ngaysinh;
            GioiTinh = gt;
            SoDT = sdt;
            Mail = mail;
            dshocPhan = ds;
            NgoaiNgu = nn;
        }

        public override string ToString()
        {
            string s = "Mã số: " + MaSo + "\n" +
                       "Họ tên: " + HoTen + "\n" +
                       "Ngày sinh: " + NgaySinh.ToShortDateString() + "\n" +
                       "Giới tính: " + GioiTinh + "\n" +
                       "SĐT: " + SoDT + "\n" +
                       "Mail: " + Mail + "\n";

            string nn = "Ngoại ngữ: ";
            foreach (string t in NgoaiNgu)
                if (!string.IsNullOrEmpty(t))
                    nn += t + "; ";
            s += nn + "\n";

            string hp = "Môn dạy: ";
            foreach (HocPhan h in dshocPhan.ds)
                hp += h.TenHP + "; ";
            s += hp;

            return s;
        }
    }
}
