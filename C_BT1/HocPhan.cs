using System;

namespace C_BT1
{
    public class HocPhan
    {
        public int ID { get; set; }
        public string TenHP { get; set; }
        public int SoTC { get; set; }

        public HocPhan(string ten)
        {
            TenHP = ten;
        }

        public HocPhan(int id, string ten, int tc)
        {
            ID = id;
            TenHP = ten;
            SoTC = tc;
        }

        public override string ToString()
        {
            return TenHP;
        }
    }
}
