using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_BT1
{
    public partial class FormTBGiangVien : Form
    {
        public FormTBGiangVien()
        {
            InitializeComponent();
        }
        public void SetText(string s)
        {
            this.lblThongBao.Text = s;
        }
    }
}
