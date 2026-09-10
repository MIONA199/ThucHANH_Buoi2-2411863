using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ThucHANH_Buoi2
{
    
    public delegate int SoSanh(object sv1, object sv2);

    public class QuanLySinhVien
    {
        public List<SinhVien> dsSinhVien;

        public QuanLySinhVien()
        {
            dsSinhVien = new List<SinhVien>();
        }

        public SinhVien this[int index]
        {
            get { return dsSinhVien[index]; }
            set { dsSinhVien[index] = value; }
        }

        public void Them(SinhVien sv) => dsSinhVien.Add(sv);

        public SinhVien Tim(object obj, SoSanh ss)
        {
            foreach (SinhVien sv in dsSinhVien)
                if (ss(obj, sv) == 0)
                    return sv;
            return null;
        }

        public bool Sua(SinhVien svSua, object obj, SoSanh ss)
        {
            for (int i = 0; i < dsSinhVien.Count; i++)
                if (ss(obj, dsSinhVien[i]) == 0)
                {
                    dsSinhVien[i] = svSua;
                    return true;
                }
            return false;
        }

        public void Xoa(object obj, SoSanh ss)
        {
            for (int i = dsSinhVien.Count - 1; i >= 0; i--)
                if (ss(obj, dsSinhVien[i]) == 0)
                    dsSinhVien.RemoveAt(i);
        }

        public void DocTuFile(string filename)
        {
            if (!File.Exists(filename)) return;
            string[] lines = File.ReadAllLines(filename);
            var formats = new[] { "MM/dd/yyyy", "dd/MM/yyyy", "yyyy-MM-dd" };
            foreach (string line in lines)
            {
                string[] parts = line.Split('\t');
                if (parts.Length < 8) continue;
                SinhVien sv = new SinhVien();
                sv.MaSo = parts[0];
                sv.HoTen = parts[1];
                sv.NgaySinh = DateTime.ParseExact(parts[2], formats,
                    CultureInfo.InvariantCulture, DateTimeStyles.None);
                sv.DiaChi = parts[3];
                sv.Lop = parts[4];
                sv.Hinh = parts[5];
                sv.GioiTinh = (parts[6] == "1");
                string[] cn = parts[7].Split(new[] { ", " }, StringSplitOptions.None);
                foreach (string s in cn)
                    if (!string.IsNullOrEmpty(s))
                        sv.ChuyenNganh.Add(s);
                dsSinhVien.Add(sv);
            }
        }

        public void GhiRaFile(string filename)
        {
            List<string> lines = new List<string>();
            foreach (SinhVien sv in dsSinhVien)
            {
                string gt = sv.GioiTinh ? "1" : "0";
                string cn = string.Join(", ", sv.ChuyenNganh);
                lines.Add($"{sv.MaSo}\t{sv.HoTen}\t{sv.NgaySinh:MM/dd/yyyy}\t{sv.DiaChi}\t{sv.Lop}\t{sv.Hinh}\t{gt}\t{cn}");
            }
            File.WriteAllLines(filename, lines);
        }

        // ===== BÀI TẬP C.2: SẮP XẾP =====
        public void SapXepTheoMa(bool tangDan)
        {
            dsSinhVien.Sort((a, b) => tangDan
                ? a.MaSo.CompareTo(b.MaSo)
                : b.MaSo.CompareTo(a.MaSo));
        }

        public void SapXepTheoTen(bool tangDan)
        {
            dsSinhVien.Sort((a, b) => tangDan
                ? a.HoTen.CompareTo(b.HoTen)
                : b.HoTen.CompareTo(a.HoTen));
        }

        public void SapXepTheoLop(bool tangDan)
        {
            dsSinhVien.Sort((a, b) => tangDan
                ? a.Lop.CompareTo(b.Lop)
                : b.Lop.CompareTo(a.Lop));
        }

        // ===== BÀI TẬP C.2: TÌM KIẾM =====
        public List<SinhVien> TimTheoMa(string keyword)
        {
            List<SinhVien> result = new List<SinhVien>();
            foreach (SinhVien sv in dsSinhVien)
                if (sv.MaSo.ToLower().Contains(keyword.ToLower()))
                    result.Add(sv);
            return result;
        }

        public List<SinhVien> TimTheoTen(string keyword)
        {
            List<SinhVien> result = new List<SinhVien>();
            foreach (SinhVien sv in dsSinhVien)
                if (sv.HoTen.ToLower().Contains(keyword.ToLower()))
                    result.Add(sv);
            return result;
        }

        public List<SinhVien> TimTheoLop(string keyword)
        {
            List<SinhVien> result = new List<SinhVien>();
            foreach (SinhVien sv in dsSinhVien)
                if (sv.Lop.ToLower().Contains(keyword.ToLower()))
                    result.Add(sv);
            return result;
        }
    }
}
