using System.Collections.Generic;

namespace C_BT1
{
    public delegate int SoSanh(object obj1, object obj2);
    public class QuanLyGiangVien
    {
        public List<GiangVien> dsGiangVien;

        public QuanLyGiangVien()
        {
            dsGiangVien = new List<GiangVien>();
        }

        public void Them(GiangVien gv)
        {
            dsGiangVien.Add(gv);
        }

        public GiangVien Tim(object obj, SoSanh ss)
        {
            foreach (GiangVien gv in dsGiangVien)
                if (ss(obj, gv) == 0)
                    return gv;
            return null;
        }

        public void Xoa(object obj, SoSanh ss)
        {
            for (int i = dsGiangVien.Count - 1; i >= 0; i--)
                if (ss(obj, dsGiangVien[i]) == 0)
                    dsGiangVien.RemoveAt(i);
        }

        public bool Sua(GiangVien gvSua, object obj, SoSanh ss)
        {
            for (int i = 0; i < dsGiangVien.Count; i++)
                if (ss(obj, dsGiangVien[i]) == 0)
                {
                    dsGiangVien[i] = gvSua;
                    return true;
                }
            return false;
        }
    }   
}
