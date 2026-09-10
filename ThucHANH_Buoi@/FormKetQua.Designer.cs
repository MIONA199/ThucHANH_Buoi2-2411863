namespace ThucHANH_Buoi_
{
    partial class FormKetQua
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FormKetQua";
            this.lvKetQua = new System.Windows.Forms.ListView();
            this.colMaSo = new System.Windows.Forms.ColumnHeader();
            this.colHoTen = new System.Windows.Forms.ColumnHeader();
            this.colNgaySinh = new System.Windows.Forms.ColumnHeader();
            this.colDiaChi = new System.Windows.Forms.ColumnHeader();
            this.colLop = new System.Windows.Forms.ColumnHeader();
            this.colPhai = new System.Windows.Forms.ColumnHeader();
            this.colChuyenNganh = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();

            // lvKetQua
            this.lvKetQua.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colMaSo, this.colHoTen, this.colNgaySinh, this.colDiaChi,
                this.colLop, this.colPhai, this.colChuyenNganh});
            this.lvKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvKetQua.FullRowSelect = true;
            this.lvKetQua.GridLines = true;
            this.lvKetQua.View = System.Windows.Forms.View.Details;

            // Columns
            this.colMaSo.Text = "Mã số"; this.colMaSo.Width = 80;
            this.colHoTen.Text = "Họ tên"; this.colHoTen.Width = 150;
            this.colNgaySinh.Text = "Ngày sinh"; this.colNgaySinh.Width = 90;
            this.colDiaChi.Text = "Địa chỉ"; this.colDiaChi.Width = 120;
            this.colLop.Text = "Lớp"; this.colLop.Width = 80;
            this.colPhai.Text = "Phái"; this.colPhai.Width = 60;
            this.colChuyenNganh.Text = "Chuyên ngành"; this.colChuyenNganh.Width = 200;

            // frmKetQua
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvKetQua);
            this.Text = "Kết quả tìm kiếm";

            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ListView lvKetQua;
        private System.Windows.Forms.ColumnHeader colMaSo, colHoTen, colNgaySinh,
            colDiaChi, colLop, colPhai, colChuyenNganh;
    }
}