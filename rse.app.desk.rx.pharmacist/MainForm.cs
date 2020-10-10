using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rse.app.desk.rx.pharmacist.UI;

namespace rse.app.desk.rx.pharmacist
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void populateItems()
        {
            var ds = new Dataset.yakkumdbTableAdapters.resep_orderTableAdapter();
            ds.Fill(yakkumdb.resep_order);
            DataTable dt = ds.GetData();
            foreach (DataRow r in dt.Rows)
            {
                var uc = new CardResep
                {
                    Tag = r["vc_kode_rx"].ToString(),
                    NoRM = r["vc_no_rm"].ToString(),
                    Nama = r["vc_nama_p"].ToString(),
                    NOreg = r["vc_no_reg"].ToString(),
                    NoResep = r["vc_kode_rx"].ToString(),
                    namaklinik = r["nama_klinik"].ToString(),
                    tgllahir = "tgl.Lahir : " + r["tgllahir"].ToString()+" / "+r["umur"].ToString(),
                    jk = r["vc_jenis_k"].ToString(),
                    alamat = r["alamat"].ToString()
                    
                };

                if (flowLayout.Controls.Count < 0)
                {
                    flowLayout.Controls.Clear();
                }

                else
                {
                    flowLayout.Controls.Add(uc);

                    uc.Click += uc_MouseCliked;
                    
                }
                 
            }
            //CardResep[] cardReseps = new CardResep[10];

            //for (int i = 0; i < cardReseps.Length; i++)
            //{
            //    cardReseps[i] = new CardResep();
            //    cardReseps[i].NoRM = "00518035";
            //    cardReseps[i].Nama = "Yanuar Tesla";
            //    cardReseps[i].NOreg = "20201009000001";
            //    cardReseps[i].NoResep = "RX121584553536";
            //    cardReseps[i].Tag = "RX121584553536";

            //    if (flowLayout.Controls.Count < 0)
            //    {
            //        flowLayout.Controls.Clear();
            //    }

            //    else
            //        flowLayout.Controls.Add(cardReseps[i]);
            //    cardReseps[i].MouseClick += uc_MouseCliked;
            //}
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yakkumdb.resep_order' table. You can move, or remove it, as needed.
            //this.resep_orderTableAdapter.Fill(this.yakkumdb.resep_order);
            
            populateItems();
        }

        private void uc_MouseCliked(object sender, EventArgs e)
        {
            panelResepD.Controls.Clear();
            UserControl us = (UserControl)sender;
            var _filter = us.Tag.ToString();

           // MessageBox.Show("jadi yess" + _filter);
            UCResepDetil rd = new UCResepDetil(_filter);
            
            rd.Dock = DockStyle.Fill;
            panelResepD.Controls.Add(rd);
            rd.Show();
            rd.Refresh();
        }
    }
}
