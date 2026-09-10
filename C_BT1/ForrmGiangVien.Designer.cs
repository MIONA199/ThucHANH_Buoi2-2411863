namespace C_BT1
{
    partial class FormGiangVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
       
            private void InitializeComponent()
        {
            this.lblMaSo = new System.Windows.Forms.Label();
            this.cboMaSo = new System.Windows.Forms.ComboBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.mtxtSoDT = new System.Windows.Forms.MaskedTextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.grpGioiTinh = new System.Windows.Forms.GroupBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.grpNgoaiNgu = new System.Windows.Forms.GroupBox();
            this.chkAnh = new System.Windows.Forms.CheckBox();
            this.chkPhap = new System.Windows.Forms.CheckBox();
            this.chkNhat = new System.Windows.Forms.CheckBox();
            this.chkNga = new System.Windows.Forms.CheckBox();
            this.grpHocPhan = new System.Windows.Forms.GroupBox();
            this.lbDanhSachHP = new System.Windows.Forms.ListBox();
            this.lbHocPhanDay = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThongBao = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.linkLienHe = new System.Windows.Forms.LinkLabel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Location = new System.Drawing.Point(30, 30);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(50, 16);
            this.lblMaSo.TabIndex = 0;
            this.lblMaSo.Text = "Mã số:";
            // 
            // cboMaSo
            // 
            this.cboMaSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaSo.Items.AddRange(new object[] { "001", "002", "003", "004" });
            this.cboMaSo.Location = new System.Drawing.Point(120, 27);
            this.cboMaSo.Name = "cboMaSo";
            this.cboMaSo.Size = new System.Drawing.Size(100, 24);
            this.cboMaSo.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(30, 70);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(55, 16);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(120, 67);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(30, 110);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(70, 16);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(120, 105);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(120, 22);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Location = new System.Drawing.Point(30, 150);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(76, 16);
            this.lblSoDT.TabIndex = 6;
            this.lblSoDT.Text = "Số điện thoại:";
            // 
            // mtxtSoDT
            // 
            this.mtxtSoDT.Location = new System.Drawing.Point(120, 147);
            this.mtxtSoDT.Mask = "(0633) 000-000";
            this.mtxtSoDT.Name = "mtxtSoDT";
            this.mtxtSoDT.Size = new System.Drawing.Size(120, 22);
            this.mtxtSoDT.TabIndex = 7;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(30, 190);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(35, 16);
            this.lblMail.TabIndex = 8;
            this.lblMail.Text = "Mail:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(120, 187);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 22);
            this.txtMail.TabIndex = 9;
            // 
            // grpGioiTinh
            // 
            this.grpGioiTinh.Controls.Add(this.rdNam);
            this.grpGioiTinh.Controls.Add(this.rdNu);
            this.grpGioiTinh.Location = new System.Drawing.Point(33, 230);
            this.grpGioiTinh.Name = "grpGioiTinh";
            this.grpGioiTinh.Size = new System.Drawing.Size(150, 50);
            this.grpGioiTinh.TabIndex = 10;
            this.grpGioiTinh.TabStop = false;
            this.grpGioiTinh.Text = "Giới tính";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(10, 20);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(57, 20);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(80, 20);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(45, 20);
            this.rdNu.TabIndex = 1;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // grpNgoaiNgu
            // 
            this.grpNgoaiNgu.Controls.Add(this.chkAnh);
            this.grpNgoaiNgu.Controls.Add(this.chkPhap);
            this.grpNgoaiNgu.Controls.Add(this.chkNhat);
            this.grpNgoaiNgu.Controls.Add(this.chkNga);
            this.grpNgoaiNgu.Location = new System.Drawing.Point(33, 290);
            this.grpNgoaiNgu.Name = "grpNgoaiNgu";
            this.grpNgoaiNgu.Size = new System.Drawing.Size(200, 120);
            this.grpNgoaiNgu.TabIndex = 11;
            this.grpNgoaiNgu.TabStop = false;
            this.grpNgoaiNgu.Text = "Ngoại ngữ";
            // 
            // chkAnh
            // 
            this.chkAnh.AutoSize = true;
            this.chkAnh.Location = new System.Drawing.Point(10, 25);
            this.chkAnh.Name = "chkAnh";
            this.chkAnh.Size = new System.Drawing.Size(96, 20);
            this.chkAnh.TabIndex = 0;
            this.chkAnh.Text = "Tiếng Anh";
            this.chkAnh.UseVisualStyleBackColor = true;
            // 
            // chkPhap
            // 
            this.chkPhap.AutoSize = true;
            this.chkPhap.Location = new System.Drawing.Point(10, 55);
            this.chkPhap.Name = "chkPhap";
            this.chkPhap.Size = new System.Drawing.Size(102, 20);
            this.chkPhap.TabIndex = 1;
            this.chkPhap.Text = "Tiếng Pháp";
            this.chkPhap.UseVisualStyleBackColor = true;
            // 
            // chkNhat
            // 
            this.chkNhat.AutoSize = true;
            this.chkNhat.Location = new System.Drawing.Point(10, 85);
            this.chkNhat.Name = "chkNhat";
            this.chkNhat.Size = new System.Drawing.Size(100, 20);
            this.chkNhat.TabIndex = 2;
            this.chkNhat.Text = "Tiếng Nhật";
            this.chkNhat.UseVisualStyleBackColor = true;
            // 
            // chkNga
            // 
            this.chkNga.AutoSize = true;
            this.chkNga.Location = new System.Drawing.Point(120, 25);
            this.chkNga.Name = "chkNga";
            this.chkNga.Size = new System.Drawing.Size(86, 20);
            this.chkNga.TabIndex = 3;
            this.chkNga.Text = "Tiếng Nga";
            this.chkNga.UseVisualStyleBackColor = true;
            // 
            // grpHocPhan
            // 
            this.grpHocPhan.Location = new System.Drawing.Point(280, 30);
            this.grpHocPhan.Name = "grpHocPhan";
            this.grpHocPhan.Size = new System.Drawing.Size(400, 380);
            this.grpHocPhan.TabIndex = 12;
            this.grpHocPhan.TabStop = false;
            this.grpHocPhan.Text = "Học phần";
            // 
            // lbDanhSachHP
            // 
            this.lbDanhSachHP.Location = new System.Drawing.Point(10, 25);
            this.lbDanhSachHP.Name = "lbDanhSachHP";
            this.lbDanhSachHP.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhSachHP.Size = new System.Drawing.Size(150, 200);
            this.lbDanhSachHP.TabIndex = 0;
            // 
            // lbHocPhanDay
            // 
            this.lbHocPhanDay.Location = new System.Drawing.Point(220, 25);
            this.lbHocPhanDay.Name = "lbHocPhanDay";
            this.lbHocPhanDay.Size = new System.Drawing.Size(150, 200);
            this.lbHocPhanDay.TabIndex = 2;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(180, 80);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(30, 25);
            this.btnChon.TabIndex = 1;
            this.btnChon.Text = ">";
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(180, 130);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(30, 25);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "<";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThongBao
            // 
            this.btnThongBao.Location = new System.Drawing.Point(33, 420);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(90, 30);
            this.btnThongBao.TabIndex = 13;
            this.btnThongBao.Text = "Thông báo";
            this.btnThongBao.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(140, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(230, 420);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // linkLienHe
            // 
            this.linkLienHe.AutoSize = true;
            this.linkLienHe.Location = new System.Drawing.Point(330, 430);
            this.linkLienHe.Name = "linkLienHe";
            this.linkLienHe.Size = new System.Drawing.Size(56, 16);
            this.linkLienHe.TabIndex = 16;
            this.linkLienHe.TabStop = true;
            this.linkLienHe.Text = "Liên hệ";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(33, 460);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(140, 460);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 30);
            this.btnTim.TabIndex = 18;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 520);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.linkLienHe);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnThongBao);
            this.Controls.Add(this.grpHocPhan);
            this.Controls.Add(this.grpNgoaiNgu);
            this.Controls.Add(this.grpGioiTinh);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.mtxtSoDT);
            this.Controls.Add(this.lblSoDT);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.cboMaSo);
            this.Controls.Add(this.lblMaSo);
            this.Name = "frmGiangVien";
            this.Text = "Quản lý giảng viên";
            // Add controls to grpHocPhan
            this.grpHocPhan.Controls.Add(this.lbDanhSachHP);
            this.grpHocPhan.Controls.Add(this.btnChon);
            this.grpHocPhan.Controls.Add(this.lbHocPhanDay);
            this.grpHocPhan.Controls.Add(this.btnXoa);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.ComboBox cboMaSo;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.MaskedTextBox mtxtSoDT;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.GroupBox grpGioiTinh;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.GroupBox grpNgoaiNgu;
        private System.Windows.Forms.CheckBox chkAnh;
        private System.Windows.Forms.CheckBox chkPhap;
        private System.Windows.Forms.CheckBox chkNhat;
        private System.Windows.Forms.CheckBox chkNga;
        private System.Windows.Forms.GroupBox grpHocPhan;
        private System.Windows.Forms.ListBox lbDanhSachHP;
        private System.Windows.Forms.ListBox lbHocPhanDay;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel linkLienHe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        #endregion
    }
}
