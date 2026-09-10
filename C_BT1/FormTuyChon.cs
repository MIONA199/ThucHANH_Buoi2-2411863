using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_BT1
{
    public partial class FormTuyChon : Form
    {
        private QuanLyGiangVien qlgv;

        public FormTuyChon(QuanLyGiangVien qlgv)
        {
            InitializeComponent();
            this.qlgv = qlgv;
            btnTim.Click += btnTim_Click;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTuKhoa.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo");
                return;
            }

            GiangVien result = null;

            if (rdMaSo.Checked)
            {
                result = qlgv.Tim(keyword, (obj, gv) => ((string)obj == ((GiangVien)gv).MaSo) ? 0 : 1);
            }
            else if (rdHoTen.Checked)
            {
                foreach (GiangVien gv in qlgv.dsGiangVien)
                    if (gv.HoTen.ToLower().Contains(keyword.ToLower()))
                    {
                        result = gv;
                        break;
                    }
            }
            else if (rdSoDT.Checked)
            {
                foreach (GiangVien gv in qlgv.dsGiangVien)
                    if (gv.SoDT.Contains(keyword))
                    {
                        result = gv;
                        break;
                    }
            }

            if (result == null)
            {
                MessageBox.Show("Không tìm thấy giảng viên.", "Thông báo");
            }
            else
            {
                FormTBGiangVien frm = new FormTBGiangVien();
                frm.SetText(result.ToString());
                frm.ShowDialog();
            }
        }
    }
}
