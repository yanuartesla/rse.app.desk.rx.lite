using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static rse.app.desk.rx.lite.UI.Login;

namespace rse.app.desk.rx.lite.UI
{
    
    public partial class AddData : Form
    {
        public String _noreg { get; set; }
        public String _kodedokter { get; set; }

        public int _kodeFronas { get; set; }

        public String _kodeKlinik { get; set; }

        public string _koderesep { get; set; }

        // private roles _currentroles { get; set; }
        public AddData(String NoReg, string KodeKlinik, string KodeDokter)
        {
            InitializeComponent();
            _noreg = NoReg;
            _kodeKlinik = KodeKlinik;
            _kodedokter = KodeDokter;

        }

        private void AddData_Load(object sender, EventArgs e)
        {
            
            this.pasienTableAdapter.FillByNoreg(this.yakkumdb.Pasien,_noreg);

            //TODO : ganti fornas variable
            obat _obat = new obat(_noreg, _kodedokter, 3);
            _koderesep = _obat.lblRtx.Text;
            _obat.Dock = DockStyle.Fill;
            tbResepBody.Controls.Add(_obat);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabData.SelectedIndex =
            (tabData.SelectedIndex + 1) % tabData.TabCount;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabData.SelectedIndex =
            (tabData.SelectedIndex - 1) % tabData.TabCount;
        }

        private void btnAnamNext_Click(object sender, EventArgs e)
        {
            tabData.SelectedIndex =
            (tabData.SelectedIndex + 1) % tabData.TabCount;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            LoadHome();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            
            var dh = new dataset.yakkumdbTableAdapters.resep_hTableAdapter();
            Pilihan pl = new Pilihan();
            var result = pl.ShowDialog();
            if (result == DialogResult.Yes)
            {
                dh.UpdateStatus("WAITING", 2, DateTime.Now, _koderesep);
            }
            if (result == DialogResult.No)
            {
                dh.UpdateStatus("ORDER", 3, DateTime.Now, _koderesep);
            }

            MessageBox.Show("Resep Berhasil di Simpan");
            LoadHome();
        }

        private void LoadHome ()
        {
            Home hm = new Home(_kodeKlinik, _kodedokter) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.Controls.Add(hm);
            hm.Show();
        }

        private void btnBackResep_Click(object sender, EventArgs e)
        {
            tabData.SelectedIndex =
            (tabData.SelectedIndex - 1) % tabData.TabCount;
        }
    }
}
