using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ThucHANH_Buoi2
{
    public partial class FormTimKiem : Form
    {
        public FormTimKiem(List<SinhVien> ds)
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