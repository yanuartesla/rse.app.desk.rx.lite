using System;
using System.Windows.Forms;

namespace rse.app.desk.rx.lite.UI
{
    public partial class Pilihan : Form
    {
        public Pilihan()
        {
            InitializeComponent();
        }

        private void btYA_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btTidak_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
