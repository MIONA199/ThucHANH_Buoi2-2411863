using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ThucHANH_Buoi2
{
    public partial class FormSinhVien : Form
    {
        private QuanLySinhVien qlsv = new QuanLySinhVien();
        private bool isModified = false;

        public FormSinhVien()
        {
            InitializeComponent();
            this.Load += formSinhVien_Load;
            this.FormClosing += frmSinhVien_FormClosing;
        }

        private void formSinhVien_Load(object sender, EventArgs e)
        {
            // Tạo file mẫu nếu chưa có
            if (!File.Exists("DanhSachSV.txt"))
            {
                var sv1 = new SinhVien("SV.00001", "Nguyễn Văn A", new DateTime(2003, 10, 15),
                    "Đà Lạt", "CTK31", "", true, new List<string> { "Công nghệ phần mềm" });
                var sv2 = new SinhVien("SV.00002", "Trần Thị B", new DateTime(2002, 5, 20),
                    "Hà Nội", "CTK32", "", false, new List<string> { "Mạng truyền thông", "Hệ thống thông tin" });
                qlsv.Them(sv1);
                qlsv.Them(sv2);
                qlsv.GhiRaFile("DanhSachSV.txt");
            }
            qlsv.DocTuFile("DanhSachSV.txt");
            LoadListView();
            ResetControls();
        }

        public void LoadListView()
        {
            lvSinhVien.Items.Clear();
            foreach (SinhVien sv in qlsv.dsSinhVien)
            {
                ListViewItem item = new ListViewItem(sv.MaSo);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sv.DiaChi);
                item.SubItems.Add(sv.Lop);
                item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");
                item.SubItems.Add(string.Join(", ", sv.ChuyenNganh));
                item.SubItems.Add(sv.Hinh);
                lvSinhVien.Items.Add(item);
            }
        }

        private void ResetControls()
        {
            mtxtMaSo.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Clear();
            cboLop.SelectedIndex = -1;
            txtHinh.Clear();
            pbHinh.Image = null;
            rdNam.Checked = true;
            for (int i = 0; i < clbChuyenNganh.Items.Count; i++)
                clbChuyenNganh.SetItemChecked(i, false);
        }

        private SinhVien GetSinhVienFromControls()
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = mtxtMaSo.Text.Trim();
            sv.HoTen = txtHoTen.Text.Trim();
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.DiaChi = txtDiaChi.Text.Trim();
            sv.Lop = cboLop.Text;
            sv.Hinh = txtHinh.Text.Trim();
            sv.GioiTinh = rdNam.Checked;
            List<string> cn = new List<string>();
            for (int i = 0; i < clbChuyenNganh.Items.Count; i++)
                if (clbChuyenNganh.GetItemChecked(i))
                    cn.Add(clbChuyenNganh.Items[i].ToString());
            sv.ChuyenNganh = cn;
            return sv;
        }

        private void DisplaySinhVien(SinhVien sv)
        {
            if (sv == null) return;
            mtxtMaSo.Text = sv.MaSo;
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = sv.NgaySinh;
            txtDiaChi.Text = sv.DiaChi;
            cboLop.Text = sv.Lop;
            txtHinh.Text = sv.Hinh;
            if (!string.IsNullOrEmpty(sv.Hinh) && File.Exists(sv.Hinh))
                pbHinh.Image = Image.FromFile(sv.Hinh);
            else
                pbHinh.Image = null;
            rdNam.Checked = sv.GioiTinh;
            rdNu.Checked = !sv.GioiTinh;
            for (int i = 0; i < clbChuyenNganh.Items.Count; i++)
                clbChuyenNganh.SetItemChecked(i,
                    sv.ChuyenNganh.Contains(clbChuyenNganh.Items[i].ToString()));
        }

        // ===== BÀI TẬP C.2 - CHỨC NĂNG 1: CHỌN HÌNH =====
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialogHinh.ShowDialog() == DialogResult.OK)
            {
                txtHinh.Text = openFileDialogHinh.FileName;
                pbHinh.Image = Image.FromFile(openFileDialogHinh.FileName);
                isModified = true;
            }
        }

        // ===== CÁC NÚT CHỨC NĂNG =====
        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVienFromControls();
            if (string.IsNullOrEmpty(sv.MaSo))
            {
                MessageBox.Show("Vui lòng nhập mã số.");
                return;
            }
            foreach (SinhVien s in qlsv.dsSinhVien)
                if (s.MaSo == sv.MaSo)
                {
                    MessageBox.Show("Mã số đã tồn tại.");
                    return;
                }
            qlsv.Them(sv);
            LoadListView();
            ResetControls();
            isModified = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chọn một sinh viên để sửa.");
                return;
            }
            string maSo = lvSinhVien.SelectedItems[0].Text;
            SinhVien svMoi = GetSinhVienFromControls();
            bool found = false;
            for (int i = 0; i < qlsv.dsSinhVien.Count; i++)
            {
                if (qlsv.dsSinhVien[i].MaSo == maSo)
                {
                    qlsv.dsSinhVien[i] = svMoi;
                    found = true;
                    break;
                }
            }
            if (found)
            {
                LoadListView();
                ResetControls();
                isModified = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaSinhVienDuocChon();
        }

        private void XoaSinhVienDuocChon()
        {
            List<string> maXoa = new List<string>();
            foreach (ListViewItem item in lvSinhVien.Items)
                if (item.Checked)
                    maXoa.Add(item.Text);
            if (maXoa.Count == 0)
            {
                MessageBox.Show("Chọn ít nhất một sinh viên để xóa.");
                return;
            }
            if (MessageBox.Show("Xóa các sinh viên đã chọn?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (string ms in maXoa)
                    qlsv.Xoa(ms, (o1, o2) => ((string)o1 == ((SinhVien)o2).MaSo) ? 0 : 1);
                LoadListView();
                isModified = true;
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e) => ResetControls();
        private void btnThoat_Click(object sender, EventArgs e) => this.Close();

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0) return;
            string maSo = lvSinhVien.SelectedItems[0].Text;
            SinhVien sv = qlsv.Tim(maSo, (o1, o2) => ((string)o1 == ((SinhVien)o2).MaSo) ? 0 : 1);
            if (sv != null) DisplaySinhVien(sv);
        }

        // ===== BÀI TẬP C.2 - CHỨC NĂNG 2: MENU SẮP XẾP =====
        private void mnuSapXep_Click(object sender, EventArgs e)
        {
            FormTuyChon frm = new FormTuyChon(qlsv, true, () => LoadListView());
            frm.ShowDialog();
        }

        // ===== BÀI TẬP C.2 - CHỨC NĂNG 3: MENU TÌM KIẾM =====
        private void mnuTimKiem_Click(object sender, EventArgs e)
        {
            FormTuyChon frm = new FormTuyChon(qlsv, false, null);
            frm.ShowDialog();
        }

        // ===== CONTEXT MENU =====
        private void mnuXoa_Click(object sender, EventArgs e) => XoaSinhVienDuocChon();

        private void mnuTaiLai_Click(object sender, EventArgs e)
        {
            qlsv.dsSinhVien.Clear();
            qlsv.DocTuFile("DanhSachSV.txt");
            LoadListView();
            ResetControls();
            MessageBox.Show("Đã tải lại danh sách từ file.");
        }

        private void frmSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isModified)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn lưu thay đổi?", "Lưu",
                    MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                    qlsv.GhiRaFile("DanhSachSV.txt");
                else if (dr == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}