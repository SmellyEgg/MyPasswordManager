using MyPasswordManager.View;
using System;
using System.Windows.Forms;

namespace MyPasswordManager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Controller.CommonController.Logging.OpenLogFile();
            Application.Run(new frmLogin());
        }
    }
}
