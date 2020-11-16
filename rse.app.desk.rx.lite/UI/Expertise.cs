using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rse.app.desk.rx.lite.UI
{
    public partial class Expertise : Form
    {

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);

        [DllImport("user32.dll", SetLastError = true)]
        static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);

        [DllImport("user32.dll")]
        static extern IntPtr SetActiveWindow(IntPtr hWnd);


        private const int GWL_STYLE = (-16);
        private const int WS_VISIBLE = 0x10000000;
        private const int WS_MAXIMIZE = 0x01000000;
        public Expertise()
        {
            InitializeComponent();
        }

        private void Expertise_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            Process notepad = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("FileZilla.exe");
            psi.WindowStyle = ProcessWindowStyle.Maximized;
            notepad.StartInfo = psi;

            notepad.Start();

            this.ResumeLayout();

            notepad.WaitForInputIdle(3000);

            IntPtr old = SetParent(notepad.MainWindowHandle, this.Handle);

            SetWindowLong(notepad.MainWindowHandle, GWL_STYLE, WS_VISIBLE + WS_MAXIMIZE);
            MoveWindow(notepad.MainWindowHandle, 100, 100, 400, 400, true);

            SetActiveWindow(notepad.MainWindowHandle);
            SwitchToThisWindow(notepad.MainWindowHandle, true);
        }
    }
}
