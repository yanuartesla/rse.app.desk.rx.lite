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

namespace rse.app.desk.rx.lite
{
    public partial class HistoryCPPT : Form
    {
        public HistoryCPPT(string _norm)
        {
            InitializeComponent();

            //Upgrade the default web browser
            var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
                Key.SetValue(appName, 99999, RegistryValueKind.DWord);

            //string _url = "http://192.168.10.41/cppt/rm/admin/ppa/print_cppt.php?&no_rm=00537385";
            string _url = "http://192.168.10.41/cppt/rm/admin/ppa/print_cppt.php?&no_rm=" + _norm;

            wbCppt.Navigate(_url);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
