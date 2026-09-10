using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ThucHANH_Buoi_;

namespace ThucHANH_Buoi2
{
    public partial class FormTuyChon : Form
    {
        private QuanLySinhVien qlsv;
        private bool isSapXep;
        private Action reloadAction;

        public FormTuyChon(QuanLySinhVien qlsv, bool isSapXep, Action reloadAction)
        {
            InitializeComponent();
            this.qlsv = qlsv;
            this.isSapXep = isSapXep;
            this.reloadAction = reloadAction;

            if (isSapXep)
            {
                this.Text = "Sắp xếp sinh viên";
                this.grpKieu.Visible = true;
                this.lblTuKhoa.Visible = false;
                this.txtTuKhoa.Visible = false;
            }
            else
            {
                this.Text = "Tìm kiếm sinh viên";
                this.grpKieu.Visible = false;
                this.lblTuKhoa.Visible = true;
                this.txtTuKhoa.Visible = true;
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (isSapXep)
            {
                // ===== SẮP XẾP =====
                bool tangDan = rdTang.Checked;
                if (rdMaSo.Checked)
                    qlsv.SapXepTheoMa(tangDan);
                else if (rdHoTen.Checked)
                    qlsv.SapXepTheoTen(tangDan);
                else if (rdLop.Checked)
                    qlsv.SapXepTheoLop(tangDan);

                reloadAction?.Invoke();
                MessageBox.Show("Đã sắp xếp danh sách.");
                this.Close();
            }
            else
            {
                // ===== TÌM KIẾM =====
                string keyword = txtTuKhoa.Text.Trim();
                if (string.IsNullOrEmpty(keyword))
                {
                    MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                    return;
                }

                List<SinhVien> result;
                if (rdMaSo.Checked)
                    result = qlsv.TimTheoMa(keyword);
                else if (rdHoTen.Checked)
                    result = qlsv.TimTheoTen(keyword);
                else
                    result = qlsv.TimTheoLop(keyword);

                if (result.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sinh viên nào.");
                }
                else
                {
                    FormKetQua form = new FormKetQua(result);
                    form.ShowDialog();
                }
            }
        }
      
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}