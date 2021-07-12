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
        public int _jmlpasien { get; set; }
        //private roles _currentroles { get; set; }
        
        public Home(string KodeKlinik, string KodeDokter)
        {
            InitializeComponent();
            _kodeDokter = KodeDokter;
            _kodeKlinik = KodeKlinik;
        }

        private void getJmlPasien()
        {
            var ds = new PasienTableAdapter();
            if(ds.ScalarQueryJMLPasien(_kodeKlinik, _kodeDokter) != null)
            {
                _jmlpasien = Int32.Parse(ds.ScalarQueryJMLPasien(_kodeKlinik, _kodeDokter).ToString());
            }
        }
        private void populatePasien()
        {
            flpPasien.SuspendLayout();
            flpPasien.Controls.Clear();
            var ds = new PasienTableAdapter();
            //ds.FillByDokter(yakkumdb.Pasien, _kodeDokter,_kodeKlinik );
            DataTable dt = ds.GetDataByDokter(_kodeDokter, _kodeKlinik);
            foreach (DataRow r in dt.Rows)
            {
                var uc = new CardPasien
                {
                    //Tag = r["vc_nid"].ToString() + r["vc_kode_rx"].ToString(),
                    Tag = r["VC_NO_REGJ"].ToString()+ r["vc_nama_p"].ToString()+ r["VC_NO_RM"].ToString(),
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

            getJmlPasien();
            lblJMLPasien.Text = _jmlpasien.ToString();
            lblPxMenunggu.Text = flpPasien.Controls.Count.ToString();
            var _pxdilayani = _jmlpasien - flpPasien.Controls.Count;
            lblPxDilayani.Text = _pxdilayani.ToString();
        }

        private void uc_MouseCliked(object sender, EventArgs e)
        {
            UserControl us = (UserControl)sender;
            var _filter = us.Tag.ToString().Substring(0,13);

            if (!MainMenu.Instance.PnlContainer.Controls.ContainsKey("AddData"))
            {
                AddData ef = new AddData(_filter,_kodeKlinik,_kodeDokter) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                MainMenu.Instance.PnlContainer.Controls.Clear();
                MainMenu.Instance.PnlContainer.Controls.Add(ef);
                ef.Show();
            }


            //AddData ef = new AddData(_filter,_kodeKlinik,_kodeDokter) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.Controls.Clear();
            //this.Controls.Add(ef);
            //ef.Show();

        }
        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yakkumdb.Pasien' table. You can move, or remove it, as needed.
            //this.pasienTableAdapter.Fill(this.yakkumdb.Pasien);
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
                foreach (Control c in flpPasien.Controls)
                {
                    if (!c.Tag.ToString().ToLower().Contains(txtCariPasien.Text))
                    {
                        c.Hide();
                        //flpPasien.Controls.Remove(c);
                    }
                    else
                    {
                        c.Show();
                    }
            }
            
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
