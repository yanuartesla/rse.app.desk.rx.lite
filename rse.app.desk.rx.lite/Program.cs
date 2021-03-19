using rse.app.desk.rx.lite.UI;
using System;
using System.Windows.Forms;

namespace rse.app.desk.rx.lite
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UI.Home("0200","0201"));
        }
    }
}
