using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rse.app.desk.rx.lite.UI
{
    public partial class Efile : Form
    {
        
        public Efile(string noreg)
        {
            InitializeComponent();

            //Upgrade the default web browser
            var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
                Key.SetValue(appName, 99999, RegistryValueKind.DWord);

            string _url = "http://192.168.10.40/efile/irj/identitas.php?&VC_NO_REGJ=" + noreg;

            webBrowser1.Navigate(_url);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
