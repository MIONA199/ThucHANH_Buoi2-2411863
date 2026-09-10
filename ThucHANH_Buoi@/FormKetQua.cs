using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucHANH_Buoi2;

namespace ThucHANH_Buoi_
{
    public partial class FormKetQua : Form
    {
        public FormKetQua(List<SinhVien> ds)
        {
            InitializeComponent();
            LoadResult(ds);
        }

        private void LoadResult(List<SinhVien> ds)
        {
            lvKetQua.Items.Clear();
            foreach (SinhVien sv in ds)
            {
                ListViewItem item = new ListViewItem(sv.MaSo);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sv.DiaChi);
                item.SubItems.Add(sv.Lop);
                item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");
                item.SubItems.Add(string.Join(", ", sv.ChuyenNganh));
                lvKetQua.Items.Add(item);
            }
        }
    }
}
