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
            //Pin pl = new Pin();
            //var result = pl.ShowDialog();
            //if (result == DialogResult.Yes)
            //{
                
            //}

        }

        private void btTidak_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
            //Pin pl = new Pin();
            //var result = pl.ShowDialog();
            //if (result == DialogResult.Yes)
            //{
               
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
