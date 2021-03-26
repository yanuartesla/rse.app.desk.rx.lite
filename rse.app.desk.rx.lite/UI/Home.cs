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
//using static rse.app.desk.rx.lite.UI.Login;

namespace rse.app.desk.rx.lite.UI
{
    public partial class Home : Form
    {
        //private MainMenu _mainMenu = new MainMenu();
        public string _kodeDokter { get; set; }
        public string _kodeKlinik { get; set; }


        //private roles _currentroles { get; set; }
        
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
                    NoAntrian = r["NO_ANTRIAN"].ToString(),
                    btKaryawan = (Boolean)r["bt_kary"],
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
            UserControl us = (UserControl)sender;
            var _filter = us.Tag.ToString();
            

            AddData ef = new AddData(_filter,_kodeKlinik,_kodeDokter) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.Controls.Add(ef);
            ef.Show();


        }
        private void Home_Load(object sender, EventArgs e)
        {
            this.fa_rx_userTableAdapter.FillByNid(this.yakkumdb.fa_rx_user,_kodeDokter);
            //this.rMKLINIKTableAdapter.Fill(this.yakkumdb.RMKLINIK);

            populatePasien();
        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {
            populatePasien();
        }

        private void txtCariPasien_TextChanged(object sender, EventArgs e)
        {
            //bsPasien.Filter = "vc_nama_p like '%" + txtCariPasien.Text + "%' or vc_no_rm like '%" + txtCariPasien.Text + "%'";
            //foreach (CardPasien uc in flpPasien.Controls)
            //{
            //    MessageBox.Show(txtCariPasien.Text);
            //    if (!uc.Text.Contains(txtCariPasien.Text) )//&& !uc.Description.Contains(textBox.Text))
            //    {
            //        //uc.Visibility = Visibility.Collapsed;
            //       // MessageBox.Show(txtCariPasien.Text);
            //    }
            //    else
            //    {
            //        //Set Visible if it DOES match
            //       // uc.Visibility = Visibility.Visible;
            //    }
            //}
            //populatePasien();
        }

        //private void SetLoading(bool displayLoader)
        //{
        //    if (displayLoader)
        //    {
        //        this.Invoke((MethodInvoker)delegate
        //        {
        //            //picLoader.Visible = true;
        //            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
        //        });
        //    }
        //    else
        //    {
        //        this.Invoke((MethodInvoker)delegate
        //        {
        //           // picLoader.Visible = false;
        //            this.Cursor = System.Windows.Forms.Cursors.Default;
        //        });
        //    }
        //}
    }
}
