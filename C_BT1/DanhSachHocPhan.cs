using System.Collections.Generic;

namespace C_BT1
{
    public class DanhSachHocPhan
    {
        public List<HocPhan> ds;

        public DanhSachHocPhan()
        {
            ds = new List<HocPhan>();
        }

        public HocPhan this[int index]
        {
            get { return ds[index] as HocPhan; }
            set { ds[index] = value; }
        }

        public void Them(HocPhan hp)
        {
            ds.Add(hp);
        }

        public override string ToString()
        {
            string s = "Danh sach mon hoc: ";
            foreach (object mh in ds)
                s += mh as HocPhan + "; ";
            return s;
        }
    }
}
