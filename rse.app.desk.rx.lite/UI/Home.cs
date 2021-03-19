using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rse.app.desk.rx.lite.dataset.yakkumdbTableAdapters;
using rse.app.desk.rx.lite.UI;
using rse.app.desk.rx.lite.UI.Layout;

namespace rse.app.desk.rx.lite.UI
{
    public partial class Home : Form
    {
        private MainMenu _mainMenu = new MainMenu();
        public string _kodeDokter { get; set; }
        public string _kodeKlinik { get; set; }
        public Home(string KodeKlinik, string KodeDokter)
        {
            InitializeComponent();
            _kodeDokter = KodeDokter;
            _kodeKlinik = KodeKlinik;
            
        }

        private void populatePasien()
        {
            flpPasien.SuspendLayout();
            flpPasien.Controls.Clear();
            var ds = new PasienTableAdapter();
            ds.FillByDokter(yakkumdb.Pasien, _kodeDokter,_kodeKlinik );
            DataTable dt = ds.GetDataByDokter(_kodeDokter, _kodeKlinik);
            foreach (DataRow r in dt.Rows)
            {
                var uc = new CardPasien
                {
                    //Tag = r["vc_nid"].ToString() + r["vc_kode_rx"].ToString(),
                    Tag = r["VC_NO_REGJ"].ToString(),
                    NoRM = r["VC_NO_RM"].ToString(),
                    Nama = r["vc_nama_p"].ToString(),
                    Umur = r["in_umurth"].ToString() + " tahun",
                    JK = r["vc_jenis_k"].ToString(),
                    Penanggung = r["vc_n_png"].ToString(),
                    NoAntrian = r["NO_ANTRIAN"].ToString()
                };

                if (flpPasien.Controls.Count < 0)
                {
                    flpPasien.Controls.Clear();
                }

                else
                {
                    
                    flpPasien.Controls.Add(uc);
                    uc.Click += uc_MouseCliked;
                }
            }
            flpPasien.ResumeLayout();
        }

        private void uc_MouseCliked(object sender, EventArgs e)
        {
            AddData ef = new AddData { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.Controls.Add(ef);
            ef.Show();

            //ef.AutoScroll = true;
            //ef.FormBorderStyle = FormBorderStyle.None;
            //_mainMenu.LoadPanelChild.Controls.Add(ef);
            
            //UserControl us = (UserControl)sender;
            //var _filter = us.Tag.ToString();

            //MessageBox.Show("jadi yess" + _filter);
            //InputBMHP rd = new InputBMHP(_filter.Substring(0, 4), _filter.Substring(4));

        }
        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yakkumdb.fa_rx_user' table. You can move, or remove it, as needed.
            this.fa_rx_userTableAdapter.Fill(this.yakkumdb.fa_rx_user);
            // TODO: This line of code loads data into the 'yakkumdb.fa_rx_racikan' table. You can move, or remove it, as needed.
            this.fa_rx_racikanTableAdapter.Fill(this.yakkumdb.fa_rx_racikan);
            // TODO: This line of code loads data into the 'yakkumdb.fa_rx_user' table. You can move, or remove it, as needed.
            this.fa_rx_userTableAdapter.FillByNid(this.yakkumdb.fa_rx_user,_kodeDokter);
            // TODO: This line of code loads data into the 'yakkumdb.RMKLINIK' table. You can move, or remove it, as needed.
            this.rMKLINIKTableAdapter.Fill(this.yakkumdb.RMKLINIK);

            populatePasien();
        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {
            populatePasien();
        }

        private void txtCariPasien_TextChanged(object sender, EventArgs e)
        {
            bsPasien.Filter = "vc_nama_p like '%" + txtCariPasien.Text + "%' or vc_no_rm like '%" + txtCariPasien.Text + "%'";
        }
    }
}
