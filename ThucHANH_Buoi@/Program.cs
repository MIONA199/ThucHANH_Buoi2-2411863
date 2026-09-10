using System;
using System.Windows.Forms;
using ThucHANH_Buoi2;

namespace ThucHANH_Buoi2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSinhVien());
        }
    }
}