namespace ThucHANH_Buoi2
{
    partial class FormTimKiem
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lvKetQua = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvKetQua
            // 
            this.lvKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvKetQua.View = System.Windows.Forms.View.Details;
            this.lvKetQua.FullRowSelect = true;
            this.lvKetQua.GridLines = true;
            this.lvKetQua.Columns.Add("Mã số", 80);
            this.lvKetQua.Columns.Add("Họ tên", 120);
            this.lvKetQua.Columns.Add("Ngày sinh", 90);
            this.lvKetQua.Columns.Add("Địa chỉ", 100);
            this.lvKetQua.Columns.Add("Lớp", 80);
            this.lvKetQua.Columns.Add("Phái", 50);
            this.lvKetQua.Columns.Add("Chuyên ngành", 150);
            // 
            // FormTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lvKetQua);
            this.Text = "Kết quả tìm kiếm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListView lvKetQua;
    }
}