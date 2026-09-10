using System.Diagnostics;

namespace C_BT1
{
    public partial class FormGiangVien : Form
    {
        private QuanLyGiangVien qlgv = new QuanLyGiangVien();

        public FormGiangVien()
        {
            InitializeComponent();
            this.Load += FormGiangVien_Load;
            // Gán sự kiện
            btnChon.Click += btnChon_Click;
            btnXoa.Click += btnXoa_Click;
            btnThongBao.Click += btnThongBao_Click;
            btnCancel.Click += btnCancel_Click;
            btnExit.Click += btnExit_Click;
            linkLienHe.LinkClicked += linkLienHe_LinkClicked;
            btnThem.Click += btnThem_Click;
            btnTim.Click += btnTim_Click;
        }

        private void FormGiangVien_Load(object sender, EventArgs e)
        {
            string lienHe = "https://cntt.dlu.edu.vn/";
            this.linkLienHe.Links.Add(0, lienHe.Length, lienHe);
            this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];

            // Khởi tạo danh sách học phần
            lbDanhSachHP.Items.Clear();
            lbDanhSachHP.Items.Add("Lập trình C#");
            lbDanhSachHP.Items.Add("Cơ sở dữ liệu");
            lbDanhSachHP.Items.Add("Mạng máy tính");
            lbDanhSachHP.Items.Add("Hệ điều hành");
            lbDanhSachHP.Items.Add("Trí tuệ nhân tạo");
        }

        // Sự kiện Chọn học phần
        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDanhSachHP.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbHocPhanDay.Items.Add(lbDanhSachHP.SelectedItems[i]);
                this.lbDanhSachHP.Items.Remove(lbDanhSachHP.SelectedItems[i]);
                i--;
            }
        }

        // Sự kiện Xóa học phần
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbHocPhanDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbDanhSachHP.Items.Add(lbHocPhanDay.SelectedItems[i]);
                this.lbHocPhanDay.Items.Remove(lbHocPhanDay.SelectedItems[i]);
                i--;
            }
        }

        // Reset controls
        private void Reset()
        {
            this.cboMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.mtxtSoDT.Text = "";
            this.rdNam.Checked = true;
            chkAnh.Checked = false;
            chkPhap.Checked = false;
            chkNhat.Checked = false;
            chkNga.Checked = false;
            // Chuyển học phần từ danh sách dạy về danh sách chung
            foreach (object ob in this.lbHocPhanDay.Items)
                this.lbDanhSachHP.Items.Add(ob);
            this.lbHocPhanDay.Items.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strlink = e.Link.LinkData.ToString();
            Process.Start(strlink);
        }

        // Lấy thông tin giảng viên từ controls
        private GiangVien GetGiangVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
                gt = "Nữ";

            // Lấy ngoại ngữ
            List<string> nnList = new List<string>();
            if (chkAnh.Checked) nnList.Add("Tiếng Anh");
            if (chkPhap.Checked) nnList.Add("Tiếng Pháp");
            if (chkNhat.Checked) nnList.Add("Tiếng Nhật");
            if (chkNga.Checked) nnList.Add("Tiếng Nga");
            string[] nn = nnList.ToArray();

            // Lấy học phần dạy
            DanhSachHocPhan dshp = new DanhSachHocPhan();
            foreach (object hp in lbHocPhanDay.Items)
                dshp.Them(new HocPhan(hp.ToString()));

            GiangVien gv = new GiangVien()
            {
                MaSo = this.cboMaSo.Text,
                HoTen = this.txtHoTen.Text,
                NgaySinh = this.dtpNgaySinh.Value,
                GioiTinh = gt,
                SoDT = this.mtxtSoDT.Text,
                Mail = this.txtMail.Text,
                NgoaiNgu = nn,
                dshocPhan = dshp
            };
            return gv;
        }

        // Sự kiện Thông báo
        private void btnThongBao_Click(object sender, EventArgs e)
        {
            FormTBGiangVien frm = new FormTBGiangVien();
            frm.SetText(GetGiangVien().ToString());
            frm.ShowDialog();
        }

        // Sự kiện Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            GiangVien gv = GetGiangVien();
            // Kiểm tra mã số trùng
            foreach (GiangVien g in qlgv.dsGiangVien)
                if (g.MaSo == gv.MaSo)
                {
                    MessageBox.Show("Mã số đã tồn tại. Vui lòng nhập mã khác.", "Thông báo");
                    return;
                }
            qlgv.Them(gv);
            MessageBox.Show("Đã thêm giảng viên thành công.", "Thông báo");
            Reset();
        }

        // Sự kiện Tìm
        private void btnTim_Click(object sender, EventArgs e)
        {
            FormTuyChon frm = new FormTuyChon(qlgv);
            frm.ShowDialog();
        }
    }
}
