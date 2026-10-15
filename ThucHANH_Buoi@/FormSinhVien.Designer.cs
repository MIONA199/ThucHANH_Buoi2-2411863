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
            this.components = new System.ComponentModel.Container();
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
            this.colMaSo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChuyenNganh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiLai = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogHinh = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSapXep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxTTSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.grpGioiTinh.SuspendLayout();
            this.groupBoxDSSV.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxTTSV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxDSSV);
            this.splitContainer1.Size = new System.Drawing.Size(900, 576);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBoxTTSV
            // 
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
            this.groupBoxTTSV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTTSV.Name = "groupBoxTTSV";
            this.groupBoxTTSV.Size = new System.Drawing.Size(380, 576);
            this.groupBoxTTSV.TabIndex = 0;
            this.groupBoxTTSV.TabStop = false;
            this.groupBoxTTSV.Text = "Thông tin sinh viên";
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Location = new System.Drawing.Point(20, 30);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(39, 13);
            this.lblMaSo.TabIndex = 0;
            this.lblMaSo.Text = "Mã số:";
            // 
            // mtxtMaSo
            // 
            this.mtxtMaSo.Location = new System.Drawing.Point(110, 27);
            this.mtxtMaSo.Mask = "SV.00000";
            this.mtxtMaSo.Name = "mtxtMaSo";
            this.mtxtMaSo.Size = new System.Drawing.Size(120, 20);
            this.mtxtMaSo.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(20, 60);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(42, 13);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(110, 57);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(150, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 90);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(57, 13);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(110, 87);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(110, 20);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(20, 120);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(43, 13);
            this.lblDiaChi.TabIndex = 6;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(110, 117);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(110, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(20, 150);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(28, 13);
            this.lblLop.TabIndex = 8;
            this.lblLop.Text = "Lớp:";
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "CTK31",
            "CTK32",
            "CTK33",
            "CTK34",
            "CTK32CD",
            "CTK33CD",
            "CTK34CD"});
            this.cboLop.Location = new System.Drawing.Point(110, 147);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(180, 21);
            this.cboLop.TabIndex = 9;
            // 
            // lblHinh
            // 
            this.lblHinh.AutoSize = true;
            this.lblHinh.Location = new System.Drawing.Point(20, 180);
            this.lblHinh.Name = "lblHinh";
            this.lblHinh.Size = new System.Drawing.Size(32, 13);
            this.lblHinh.TabIndex = 10;
            this.lblHinh.Text = "Hình:";
            // 
            // txtHinh
            // 
            this.txtHinh.Location = new System.Drawing.Point(110, 177);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.ReadOnly = true;
            this.txtHinh.Size = new System.Drawing.Size(150, 20);
            this.txtHinh.TabIndex = 11;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(270, 176);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 25);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbHinh
            // 
            this.pbHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHinh.Location = new System.Drawing.Point(270, 19);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(120, 120);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 13;
            this.pbHinh.TabStop = false;
            // 
            // grpGioiTinh
            // 
            this.grpGioiTinh.Controls.Add(this.rdNam);
            this.grpGioiTinh.Controls.Add(this.rdNu);
            this.grpGioiTinh.Location = new System.Drawing.Point(20, 210);
            this.grpGioiTinh.Name = "grpGioiTinh";
            this.grpGioiTinh.Size = new System.Drawing.Size(200, 50);
            this.grpGioiTinh.TabIndex = 14;
            this.grpGioiTinh.TabStop = false;
            this.grpGioiTinh.Text = "Giới tính";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(20, 20);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(110, 20);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 1;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // clbChuyenNganh
            // 
            this.clbChuyenNganh.CheckOnClick = true;
            this.clbChuyenNganh.FormattingEnabled = true;
            this.clbChuyenNganh.Items.AddRange(new object[] {
            "Mạng truyền thông",
            "Công nghệ phần mềm",
            "Khoa học máy tính",
            "Trí tuệ nhân tạo",
            "Hệ thống thông tin",
            "Tin học ứng dụng"});
            this.clbChuyenNganh.Location = new System.Drawing.Point(20, 270);
            this.clbChuyenNganh.Name = "clbChuyenNganh";
            this.clbChuyenNganh.Size = new System.Drawing.Size(280, 94);
            this.clbChuyenNganh.TabIndex = 15;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(20, 390);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 30);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(115, 390);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 30);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(210, 390);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 30);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(20, 430);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(100, 30);
            this.btnMacDinh.TabIndex = 19;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(140, 430);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBoxDSSV
            // 
            this.groupBoxDSSV.Controls.Add(this.lvSinhVien);
            this.groupBoxDSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDSSV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDSSV.Name = "groupBoxDSSV";
            this.groupBoxDSSV.Size = new System.Drawing.Size(516, 576);
            this.groupBoxDSSV.TabIndex = 0;
            this.groupBoxDSSV.TabStop = false;
            this.groupBoxDSSV.Text = "Danh sách sinh viên";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.CheckBoxes = true;
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSo,
            this.colHoTen,
            this.colNgaySinh,
            this.colDiaChi,
            this.colLop,
            this.colPhai,
            this.colChuyenNganh,
            this.colHinh});
            this.lvSinhVien.ContextMenuStrip = this.contextMenuStrip1;
            this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(3, 16);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(510, 557);
            this.lvSinhVien.TabIndex = 0;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
            // 
            // colMaSo
            // 
            this.colMaSo.Text = "Mã số";
            this.colMaSo.Width = 80;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 130;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 90;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 112;
            // 
            // colLop
            // 
            this.colLop.Text = "Lớp";
            this.colLop.Width = 54;
            // 
            // colPhai
            // 
            this.colPhai.Text = "Phái";
            this.colPhai.Width = 50;
            // 
            // colChuyenNganh
            // 
            this.colChuyenNganh.Text = "Chuyên ngành";
            this.colChuyenNganh.Width = 180;
            // 
            // colHinh
            // 
            this.colHinh.Text = "Hình";
            this.colHinh.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXoa,
            this.mnuTaiLai});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 48);
            // 
            // mnuXoa
            // 
            this.mnuXoa.Name = "mnuXoa";
            this.mnuXoa.Size = new System.Drawing.Size(162, 22);
            this.mnuXoa.Text = "Xóa";
            this.mnuXoa.Click += new System.EventHandler(this.mnuXoa_Click);
            // 
            // mnuTaiLai
            // 
            this.mnuTaiLai.Name = "mnuTaiLai";
            this.mnuTaiLai.Size = new System.Drawing.Size(162, 22);
            this.mnuTaiLai.Text = "Tải lại danh sách";
            this.mnuTaiLai.Click += new System.EventHandler(this.mnuTaiLai_Click);
            // 
            // openFileDialogHinh
            // 
            this.openFileDialogHinh.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSapXep,
            this.mnuTimKiem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSapXep
            // 
            this.mnuSapXep.Name = "mnuSapXep";
            this.mnuSapXep.Size = new System.Drawing.Size(59, 20);
            this.mnuSapXep.Text = "Sắp xếp";
            this.mnuSapXep.Click += new System.EventHandler(this.mnuSapXep_Click);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(69, 20);
            this.mnuTimKiem.Text = "Tìm kiếm";
            this.mnuTimKiem.Click += new System.EventHandler(this.mnuTimKiem_Click);
            // 
            // FormSinhVien
            // 
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSinhVien";
            this.Text = "Quản lý sinh viên - Bài tập C.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSinhVien_FormClosing);
            this.Load += new System.EventHandler(this.formSinhVien_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxTTSV.ResumeLayout(false);
            this.groupBoxTTSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.grpGioiTinh.ResumeLayout(false);
            this.grpGioiTinh.PerformLayout();
            this.groupBoxDSSV.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

         private System.Windows.Forms.SplitContainer splitContainer1;
         private System.Windows.Forms.GroupBox groupBoxTTSV;
         private System.Windows.Forms.GroupBox groupBoxDSSV;
         private System.Windows.Forms.Label lblMaSo;
         private System.Windows.Forms.MaskedTextBox mtxtMaSo;
         private System.Windows.Forms.Label lblHoTen;
         private System.Windows.Forms.TextBox txtHoTen;
         private System.Windows.Forms.Label lblNgaySinh;
         private System.Windows.Forms.DateTimePicker dtpNgaySinh;
         private System.Windows.Forms.Label lblDiaChi;
         private System.Windows.Forms.TextBox txtDiaChi;
         private System.Windows.Forms.Label lblLop;
         private System.Windows.Forms.ComboBox cboLop;
         private System.Windows.Forms.Label lblHinh;
         private System.Windows.Forms.TextBox txtHinh;
         private System.Windows.Forms.Button btnBrowse;
         private System.Windows.Forms.PictureBox pbHinh;
         private System.Windows.Forms.GroupBox grpGioiTinh;
         private System.Windows.Forms.RadioButton rdNam;
         private System.Windows.Forms.RadioButton rdNu;
         private System.Windows.Forms.CheckedListBox clbChuyenNganh;
         private System.Windows.Forms.Button btnThem;
         private System.Windows.Forms.Button btnXoa;
         private System.Windows.Forms.Button btnSua;
         private System.Windows.Forms.Button btnMacDinh;
         private System.Windows.Forms.Button btnThoat;
         private System.Windows.Forms.ListView lvSinhVien;
         private System.Windows.Forms.ColumnHeader colMaSo;
         private System.Windows.Forms.ColumnHeader colHoTen;
         private System.Windows.Forms.ColumnHeader colNgaySinh;
         private System.Windows.Forms.ColumnHeader colDiaChi;
         private System.Windows.Forms.ColumnHeader colLop;
         private System.Windows.Forms.ColumnHeader colPhai;
         private System.Windows.Forms.ColumnHeader colChuyenNganh;
         private System.Windows.Forms.ColumnHeader colHinh;
         private System.Windows.Forms.OpenFileDialog openFileDialogHinh;
         private System.Windows.Forms.MenuStrip menuStrip1;
         private System.Windows.Forms.ToolStripMenuItem mnuSapXep;
         private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
         private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
         private System.Windows.Forms.ToolStripMenuItem mnuXoa;
         private System.Windows.Forms.ToolStripMenuItem mnuTaiLai;

    }
}
