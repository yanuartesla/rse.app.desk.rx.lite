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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yakkumdb.resep_h' table. You can move, or remove it, as needed.
            this.resep_hTableAdapter.FillByDokter(this.yakkumdb.resep_h);

            Home myFrm = new Home();
            myFrm.Dock = DockStyle.Fill;
            myFrm.TopLevel = false;
            myFrm.AutoScroll = true; 
            myFrm.FormBorderStyle = FormBorderStyle.None;
            LoadPanelChild.Controls.Add(myFrm);
            myFrm.Show();
        }
    }
}
