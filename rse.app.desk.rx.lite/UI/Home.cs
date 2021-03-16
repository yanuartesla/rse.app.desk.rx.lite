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
        public Home()
        {
            InitializeComponent();
            
        }

        private void populatePasien()
        {
            flpPasien.SuspendLayout();
            flpPasien.Controls.Clear();
            var ds = new PasienTableAdapter();
            ds.FillByDokter(yakkumdb.Pasien, "0201","0200" );
            DataTable dt = ds.GetDataByDokter("0201", "0200");
            foreach (DataRow r in dt.Rows)
            {
                var uc = new CardPasien
                {
                    //Tag = r["vc_nid"].ToString() + r["vc_kode_rx"].ToString(),
                    NoRM = r["VC_NO_RM"].ToString(),
                    Nama = r["vc_nama_p"].ToString(),
                    Umur = r["in_umurth"].ToString() + " tahun",
                    JK = r["vc_jenis_k"].ToString(),
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
           
            _mainMenu.cola
            Efile ef = new Efile("2103160200006");
            _mainMenu.LoadPanelChild.Controls.Clear();

            //ef.Dock = DockStyle.Fill;
            ef.TopLevel = false;
            //ef.AutoScroll = true;
            //ef.FormBorderStyle = FormBorderStyle.None;
            _mainMenu.LoadPanelChild.Controls.Add(ef);
            this.Hide();
            ef.Show();
            MessageBox.Show("test");

            //UserControl us = (UserControl)sender;
            //var _filter = us.Tag.ToString();

            //MessageBox.Show("jadi yess" + _filter);
            //InputBMHP rd = new InputBMHP(_filter.Substring(0, 4), _filter.Substring(4));

            //rd.Dock = DockStyle.Fill;
            //pnlContent.Controls.Add(rd);
            //rd.Show();
            //rd.Refresh();

            // timerreset.Stop();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            
            populatePasien();
        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {
            populatePasien();
        }
    }
}
