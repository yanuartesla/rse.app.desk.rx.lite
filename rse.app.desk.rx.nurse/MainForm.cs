using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rse.app.desk.rx.nurse
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(lblKklinik.Text);
            // TODO: This line of code loads data into the 'yakkumdb.RMKLINIK' table. You can move, or remove it, as needed.
            //this.rMKLINIKTableAdapter.Fill(this.yakkumdb.RMKLINIK);
            this.cmbNKlinik.Text = Properties.Settings.Default.strKlinik;
            this.lblKklinik.Text = Properties.Settings.Default.strKlinik.Substring(0, 4);
            //MessageBox.Show(lblKklinik.Text);
            populateItems();
            timerreset.Start();
        }

        private void populateItems()
        {
            flpNotif.Controls.Clear(); 
            var ds = new yakkumdbTableAdapters.resep_waitingTableAdapter();
            ds.Fill(yakkumdb.resep_waiting, lblKklinik.Text);
            DataTable dt = ds.GetData(lblKklinik.Text);
            foreach (DataRow r in dt.Rows)
            {
                var uc = new CardResep
                {
                    Tag = r["vc_nid"].ToString()+r["vc_kode_rx"].ToString(),
                    NoRM = r["vc_no_rm"].ToString(),
                    Nama = r["vc_nama_Peserta"].ToString(),
                    NoResep = r["vc_kode_rx"].ToString(),
                    namaklinik = r["vc_kode_poli_bpjs"].ToString(),
                    Dokter = r["dokter"].ToString(),
                    SEP = r["vc_no_sep"].ToString(),
                    kdokter = r["vc_nid"].ToString()
                };

                if (flpNotif.Controls.Count < 0)
                {
                    flpNotif.Controls.Clear();
                }

                else
                {
                    flpNotif.Controls.Add(uc);
                    uc.Click += uc_MouseCliked;
                }
            }
        }

        private void uc_MouseCliked(object sender, EventArgs e)
        {
           // MessageBox.Show("test");

            pnlContent.Controls.Clear();
            UserControl us = (UserControl)sender;
            var _filter = us.Tag.ToString();

           //MessageBox.Show("jadi yess" + _filter);
            InputBMHP rd = new InputBMHP(_filter.Substring(0,4),_filter.Substring(4));

            rd.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(rd);
            rd.Show();
            rd.Refresh();
           // timerreset.Stop();
        }

        private void timerreset_Tick(object sender, EventArgs e)
        {
            populateItems();
        }

        private void cmbNKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            string klinik =  cmbNKlinik.Text;
            lblKklinik.Text = klinik.Substring(0,4);
            populateItems();
            // MessageBox.Show(klinik.Substring(0, 4));
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                MessageBox.Show(this.cmbNKlinik.Text);
                Properties.Settings.Default.strKlinik = this.cmbNKlinik.Text;
                Properties.Settings.Default.Save();
            }
            
        }
    }
}
