namespace ThucHANH_Buoi2
{
    partial class FormSinhVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxTTSV = new System.Windows.Forms.GroupBox();
            this.lblMaSo = new System.Windows.Forms.Label();
            this.mtxtMaSo = new System.Windows.Forms.MaskedTextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblHinh = new System.Windows.Forms.Label();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.grpGioiTinh = new System.Windows.Forms.GroupBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.clbChuyenNganh = new System.Windows.Forms.CheckedListBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBoxDSSV = new System.Windows.Forms.GroupBox();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.colMaSo = new System.Windows.Forms.ColumnHeader();
            this.colHoTen = new System.Windows.Forms.ColumnHeader();
            this.colNgaySinh = new System.Windows.Forms.ColumnHeader();
            this.colDiaChi = new System.Windows.Forms.ColumnHeader();
            this.colLop = new System.Windows.Forms.ColumnHeader();
            this.colPhai = new System.Windows.Forms.ColumnHeader();
            this.colChuyenNganh = new System.Windows.Forms.ColumnHeader();
            this.colHinh = new System.Windows.Forms.ColumnHeader();
            this.openFileDialogHinh = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSapXep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiLai = new System.Windows.Forms.ToolStripMenuItem();

            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxTTSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.grpGioiTinh.SuspendLayout();
            this.groupBoxDSSV.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();

            // splitContainer1
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxTTSV);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxDSSV);
            this.splitContainer1.Size = new System.Drawing.Size(900, 577);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.TabIndex = 0;

            // groupBoxTTSV
            this.groupBoxTTSV.Controls.Add(this.lblMaSo);
            this.groupBoxTTSV.Controls.Add(this.mtxtMaSo);
            this.groupBoxTTSV.Controls.Add(this.lblHoTen);
            this.groupBoxTTSV.Controls.Add(this.txtHoTen);
            this.groupBoxTTSV.Controls.Add(this.lblNgaySinh);
            this.groupBoxTTSV.Controls.Add(this.dtpNgaySinh);
            this.groupBoxTTSV.Controls.Add(this.lblDiaChi);
            this.groupBoxTTSV.Controls.Add(this.txtDiaChi);
            this.groupBoxTTSV.Controls.Add(this.lblLop);
            this.groupBoxTTSV.Controls.Add(this.cboLop);
            this.groupBoxTTSV.Controls.Add(this.lblHinh);
            this.groupBoxTTSV.Controls.Add(this.txtHinh);
            this.groupBoxTTSV.Controls.Add(this.btnBrowse);
            this.groupBoxTTSV.Controls.Add(this.pbHinh);
            this.groupBoxTTSV.Controls.Add(this.grpGioiTinh);
            this.groupBoxTTSV.Controls.Add(this.clbChuyenNganh);
            this.groupBoxTTSV.Controls.Add(this.btnThem);
            this.groupBoxTTSV.Controls.Add(this.btnXoa);
            this.groupBoxTTSV.Controls.Add(this.btnSua);
            this.groupBoxTTSV.Controls.Add(this.btnMacDinh);
            this.groupBoxTTSV.Controls.Add(this.btnThoat);
            this.groupBoxTTSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTTSV.Text = "Thông tin sinh viên";

            // lblMaSo
            this.lblMaSo.Location = new System.Drawing.Point(20, 30);
            this.lblMaSo.Size = new System.Drawing.Size(100, 23);
            this.lblMaSo.Text = "Mã số:";

            // mtxtMaSo
            this.mtxtMaSo.Location = new System.Drawing.Point(120, 27);
            this.mtxtMaSo.Mask = "SV.00000";
            this.mtxtMaSo.Size = new System.Drawing.Size(100, 22);

            // lblHoTen
            this.lblHoTen.Location = new System.Drawing.Point(20, 60);
            this.lblHoTen.Size = new System.Drawing.Size(100, 23);
            this.lblHoTen.Text = "Họ tên:";

            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(120, 57);
            this.txtHoTen.Size = new System.Drawing.Size(150, 22);

            // lblNgaySinh
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 90);
            this.lblNgaySinh.Size = new System.Drawing.Size(100, 23);
            this.lblNgaySinh.Text = "Ngày sinh:";

            // dtpNgaySinh
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(120, 87);
            this.dtpNgaySinh.Size = new System.Drawing.Size(150, 22);

            // lblDiaChi
            this.lblDiaChi.Location = new System.Drawing.Point(20, 120);
            this.lblDiaChi.Size = new System.Drawing.Size(100, 23);
            this.lblDiaChi.Text = "Địa chỉ:";

            // txtDiaChi
            this.txtDiaChi.Location = new System.Drawing.Point(120, 117);
            this.txtDiaChi.Size = new System.Drawing.Size(150, 22);

            // lblLop
            this.lblLop.Location = new System.Drawing.Point(20, 150);
            this.lblLop.Size = new System.Drawing.Size(100, 23);
            this.lblLop.Text = "Lớp:";

            // cboLop
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Items.AddRange(new object[] { "CTK31", "CTK32", "CTK33", "CTK34", "CTK32CD", "CTK33CD", "CTK34CD" });
            this.cboLop.Location = new System.Drawing.Point(120, 147);
            this.cboLop.Size = new System.Drawing.Size(150, 24);

            // lblHinh
            this.lblHinh.Location = new System.Drawing.Point(20, 180);
            this.lblHinh.Size = new System.Drawing.Size(100, 23);
            this.lblHinh.Text = "Hình:";

            // txtHinh
            this.txtHinh.Location = new System.Drawing.Point(120, 177);
            this.txtHinh.ReadOnly = true;
            this.txtHinh.Size = new System.Drawing.Size(150, 22);

            // btnBrowse
            this.btnBrowse.Location = new System.Drawing.Point(280, 176);
            this.btnBrowse.Size = new System.Drawing.Size(30, 25);
            this.btnBrowse.Text = "...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);

            // pbHinh
            this.pbHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHinh.Location = new System.Drawing.Point(230, 30);
            this.pbHinh.Size = new System.Drawing.Size(110, 120);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabStop = false;

            // grpGioiTinh
            this.grpGioiTinh.Controls.Add(this.rdNam);
            this.grpGioiTinh.Controls.Add(this.rdNu);
            this.grpGioiTinh.Location = new System.Drawing.Point(20, 210);
            this.grpGioiTinh.Size = new System.Drawing.Size(250, 50);
            this.grpGioiTinh.Text = "Giới tính";

            // rdNam
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(20, 20);
            this.rdNam.Size = new System.Drawing.Size(75, 24);
            this.rdNam.Text = "Nam";

            // rdNu
            this.rdNu.Location = new System.Drawing.Point(120, 20);
            this.rdNu.Size = new System.Drawing.Size(75, 24);
            this.rdNu.Text = "Nữ";

            // clbChuyenNganh
            this.clbChuyenNganh.CheckOnClick = true;
            this.clbChuyenNganh.Items.AddRange(new object[] {
                "Mạng truyền thông", "Công nghệ phần mềm", "Khoa học máy tính",
                "Trí tuệ nhân tạo", "Hệ thống thông tin", "Tin học ứng dụng"});
            this.clbChuyenNganh.Location = new System.Drawing.Point(20, 270);
            this.clbChuyenNganh.Size = new System.Drawing.Size(250, 100);

            // btnThem
            this.btnThem.Location = new System.Drawing.Point(20, 390);
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(105, 390);
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnSua
            this.btnSua.Location = new System.Drawing.Point(190, 390);
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnMacDinh
            this.btnMacDinh.Location = new System.Drawing.Point(20, 430);
            this.btnMacDinh.Size = new System.Drawing.Size(100, 30);
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);

            // btnThoat
            this.btnThoat.Location = new System.Drawing.Point(150, 430);
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // groupBoxDSSV
            this.groupBoxDSSV.Controls.Add(this.lvSinhVien);
            this.groupBoxDSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDSSV.Text = "Danh sách sinh viên";

            // lvSinhVien
            this.lvSinhVien.CheckBoxes = true;
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colMaSo, this.colHoTen, this.colNgaySinh, this.colDiaChi,
                this.colLop, this.colPhai, this.colChuyenNganh, this.colHinh});
            this.lvSinhVien.ContextMenuStrip = this.contextMenuStrip1;
            this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);

            // Columns
            this.colMaSo.Text = "Mã số"; this.colMaSo.Width = 80;
            this.colHoTen.Text = "Họ tên"; this.colHoTen.Width = 120;
            this.colNgaySinh.Text = "Ngày sinh"; this.colNgaySinh.Width = 90;
            this.colDiaChi.Text = "Địa chỉ"; this.colDiaChi.Width = 100;
            this.colLop.Text = "Lớp"; this.colLop.Width = 70;
            this.colPhai.Text = "Phái"; this.colPhai.Width = 50;
            this.colChuyenNganh.Text = "Chuyên ngành"; this.colChuyenNganh.Width = 150;
            this.colHinh.Text = "Hình"; this.colHinh.Width = 80;

            // openFileDialogHinh
            this.openFileDialogHinh.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuSapXep, this.mnuTimKiem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);

            // mnuSapXep
            this.mnuSapXep.Text = "Sắp xếp";
            this.mnuSapXep.Click += new System.EventHandler(this.mnuSapXep_Click);

            // mnuTimKiem
            this.mnuTimKiem.Text = "Tìm kiếm";
            this.mnuTimKiem.Click += new System.EventHandler(this.mnuTimKiem_Click);

            // contextMenuStrip1
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuXoa, this.mnuTaiLai});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 52);

            // mnuXoa
            this.mnuXoa.Text = "Xóa";
            this.mnuXoa.Click += new System.EventHandler(this.mnuXoa_Click);

            // mnuTaiLai
            this.mnuTaiLai.Text = "Tải lại danh sách";
            this.mnuTaiLai.Click += new System.EventHandler(this.mnuTaiLai_Click);

            // frmSinhVien
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "Quản lý sinh viên - Bài tập C.2";

            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxTTSV.ResumeLayout(false);
            this.groupBoxTTSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.grpGioiTinh.ResumeLayout(false);
            this.groupBoxDSSV.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxTTSV, groupBoxDSSV;
        private System.Windows.Forms.Label lblMaSo, lblHoTen, lblNgaySinh, lblDiaChi, lblLop, lblHinh;
        private System.Windows.Forms.MaskedTextBox mtxtMaSo;
        private System.Windows.Forms.TextBox txtHoTen, txtDiaChi, txtHinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.GroupBox grpGioiTinh;
        private System.Windows.Forms.RadioButton rdNam, rdNu;
        private System.Windows.Forms.CheckedListBox clbChuyenNganh;
        private System.Windows.Forms.Button btnThem, btnXoa, btnSua, btnMacDinh, btnThoat;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader colMaSo, colHoTen, colNgaySinh, colDiaChi, colLop, colPhai, colChuyenNganh, colHinh;
        private System.Windows.Forms.OpenFileDialog openFileDialogHinh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSapXep, mnuTimKiem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuXoa, mnuTaiLai;

    }
}