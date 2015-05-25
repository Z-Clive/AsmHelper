using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AsmHelper
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

            using (var registryKey = Registry.CurrentUser)
            using (var rk = registryKey.OpenSubKey("Software", false))
            using (var rkA = rk.OpenSubKey("AsmHelper", false))
            {
                if (rkA == null)
                {
                    Application.Run(new Snack.Snack());

                    using (var rkA1 = rk.OpenSubKey("AsmHelper", false))
                    {
                        if (rkA1 != null)
                        {
                            Application.Run(new AsmHelperMain());
                        }
                    }
                }
                else
                {
                    Application.Run(new AsmHelperMain());
                }
            }
        }
    }
}
