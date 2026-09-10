namespace ThucHANH_Buoi2
{
    partial class FormTuyChon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

            private void InitializeComponent()
            {
            this.grpTieuChi = new System.Windows.Forms.GroupBox();
            this.rdMaSo = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.rdLop = new System.Windows.Forms.RadioButton();
            this.grpKieu = new System.Windows.Forms.GroupBox();
            this.rdTang = new System.Windows.Forms.RadioButton();
            this.rdGiam = new System.Windows.Forms.RadioButton();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();

            this.grpTieuChi.SuspendLayout();
            this.grpKieu.SuspendLayout();
            this.SuspendLayout();

            // grpTieuChi
            this.grpTieuChi.Controls.Add(this.rdMaSo);
            this.grpTieuChi.Controls.Add(this.rdHoTen);
            this.grpTieuChi.Controls.Add(this.rdLop);
            this.grpTieuChi.Location = new System.Drawing.Point(20, 20);
            this.grpTieuChi.Size = new System.Drawing.Size(300, 60);
            this.grpTieuChi.Text = "Tiêu chí";

            // rdMaSo
            this.rdMaSo.Checked = true;
            this.rdMaSo.Location = new System.Drawing.Point(20, 25);
            this.rdMaSo.Size = new System.Drawing.Size(80, 24);
            this.rdMaSo.Text = "Mã số";

            // rdHoTen
            this.rdHoTen.Location = new System.Drawing.Point(110, 25);
            this.rdHoTen.Size = new System.Drawing.Size(80, 24);
            this.rdHoTen.Text = "Họ tên";

            // rdLop
            this.rdLop.Location = new System.Drawing.Point(200, 25);
            this.rdLop.Size = new System.Drawing.Size(80, 24);
            this.rdLop.Text = "Lớp";

            // grpKieu (chỉ hiện khi sắp xếp)
            this.grpKieu.Controls.Add(this.rdTang);
            this.grpKieu.Controls.Add(this.rdGiam);
            this.grpKieu.Location = new System.Drawing.Point(20, 90);
            this.grpKieu.Size = new System.Drawing.Size(300, 60);
            this.grpKieu.Text = "Kiểu sắp xếp";

            // rdTang
            this.rdTang.Checked = true;
            this.rdTang.Location = new System.Drawing.Point(20, 25);
            this.rdTang.Size = new System.Drawing.Size(100, 24);
            this.rdTang.Text = "Tăng dần";

            // rdGiam
            this.rdGiam.Location = new System.Drawing.Point(150, 25);
            this.rdGiam.Size = new System.Drawing.Size(100, 24);
            this.rdGiam.Text = "Giảm dần";

            // lblTuKhoa
            this.lblTuKhoa.Location = new System.Drawing.Point(20, 165);
            this.lblTuKhoa.Size = new System.Drawing.Size(100, 23);
            this.lblTuKhoa.Text = "Từ khóa:";

            // txtTuKhoa
            this.txtTuKhoa.Location = new System.Drawing.Point(120, 162);
            this.txtTuKhoa.Size = new System.Drawing.Size(200, 22);

            // btnThucHien
            this.btnThucHien.Location = new System.Drawing.Point(120, 210);
            this.btnThucHien.Size = new System.Drawing.Size(100, 30);
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);

            // btnHuy
            this.btnHuy.Location = new System.Drawing.Point(230, 210);
            this.btnHuy.Size = new System.Drawing.Size(90, 30);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // frmTuyChon
            this.ClientSize = new System.Drawing.Size(350, 270);
            this.Controls.Add(this.grpTieuChi);
            this.Controls.Add(this.grpKieu);
            this.Controls.Add(this.lblTuKhoa);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.btnHuy);
            this.Text = "Tùy chọn";

            this.grpTieuChi.ResumeLayout(false);
            this.grpKieu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.GroupBox grpTieuChi, grpKieu;
        private System.Windows.Forms.RadioButton rdMaSo, rdHoTen, rdLop;
        private System.Windows.Forms.RadioButton rdTang, rdGiam;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnThucHien, btnHuy;

    }
}



