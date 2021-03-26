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
    public partial class Pin : Form
    {
        public Pin()
        {
            InitializeComponent();
        }

        private void txtPIN_TextChanged(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
            if(txtPIN.Text.Length == 4)
            {
                if (txtPIN.Text == "1234")
                {
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else { lblWarning.Visible = true; txtPIN.Clear(); }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
