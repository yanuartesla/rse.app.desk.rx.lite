using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rse.app.desk.rx.lite.UI.Layout
{
    public partial class CardHistoriPasien : UserControl
    {
        public CardHistoriPasien()
        {
            InitializeComponent();
        }

        private string _norm;
        private string _nama;
        private string _status;

        [Category("Custom Prop")]
        public string NoRM
        {
            get { return _norm; }
            set { _norm = value; lblNoRM.Text = value; }
        }
        [Category("Custom Prop")]
        public string Nama
        {
            get { return _nama; }
            set { _nama = value; lblNama.Text = value; }
        }
        [Category("Custom Prop")]
        public string Status
        {
            get { return _status; }
            set { _status = value; lblStatus.Text = value; }
        }

        private void CardHistoriPasien_MouseEnter(object sender, EventArgs e)
        {
            pnlUtama.BackColor = Color.Lavender;
            pnlStatus.BackColor = Color.LightGreen;
        }

        private void CardHistoriPasien_MouseLeave(object sender, EventArgs e)
        {
            pnlUtama.BackColor = Color.LavenderBlush;
            pnlStatus.BackColor = Color.Orange;
        }
    }
}
