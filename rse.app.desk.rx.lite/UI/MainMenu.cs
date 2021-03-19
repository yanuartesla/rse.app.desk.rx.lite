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
        public string _nidDokter { get; set; }
        public string _kodeKlinik { get; set; }
        public MainMenu()
        {
            InitializeComponent();
            _nidDokter = "0201";
            
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'yakkumdb.RMKLINIK' table. You can move, or remove it, as needed.
            this.rMKLINIKTableAdapter.Fill(this.yakkumdb.RMKLINIK);
            // TODO: This line of code loads data into the 'yakkumdb.resep_h' table. You can move, or remove it, as needed.
            this.resep_hTableAdapter.FillByDokter(this.yakkumdb.resep_h);

            bsKlinik.Filter = "vc_nid ="+ "'"+_nidDokter+ "'";
            
            cmbKlinik.DataSource = bsKlinik;
            cmbKlinik.DisplayMember = "vc_N_KLINIK";
            cmbKlinik.ValueMember = "vc_K_KLINIK";

            _kodeKlinik = cmbKlinik.SelectedValue.ToString();
            LoadHome();

        }

        private void LoadHome()
        {
            //BackgroudLoadPanel.SuspendLayout();
            Home myFrm = new Home(_kodeKlinik, _nidDokter);
            myFrm.Dock = DockStyle.Fill;
            myFrm.TopLevel = false;
            myFrm.AutoScroll = true;
            myFrm.FormBorderStyle = FormBorderStyle.None;
            LoadPanelChild.Controls.Add(myFrm);
            myFrm.Show();
            //BackgroudLoadPanel.ResumeLayout();
        }


    }
}
