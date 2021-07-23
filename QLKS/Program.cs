using System;
using System.Linq;
using System.Windows.Forms;

namespace QLKS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static FormMenu femmenu = null;
        public static DangNhap frmDn = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();   
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new  DangNhap());
        }
    }
}
