using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace KisayolYoneticisi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew;
            Mutex m = new Mutex(true, "KisayolYoneticisi", out createdNew);
            if (createdNew)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmShortCutList());
            }
            else
            {
                MessageBox.Show("Program is already running!..", "Warning: Multiple Running");
                return;
            }
        }

    }
}
