using rse.app.desk.rx.lite.dataset.yakkumdbTableAdapters;
using rse.app.desk.rx.lite.UI.Layout;
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
        public static MainMenu main;
        public string _nidDokter { get; set; }
        public string _kodeKlinik { get; set; }

        
        public MainMenu(string niddokter)
        {
            InitializeComponent();
            _nidDokter = niddokter;
            main = this;
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yakkumdb.resep_h' table. You can move, or remove it, as needed.
            this.resep_hTableAdapter.Fill(this.yakkumdb.resep_h);
            // TODO: This line of code loads data into the 'yakkumdb.RMKLINIK' table. You can move, or remove it, as needed.
            this.rMKLINIKTableAdapter.FillByNID(this.yakkumdb.RMKLINIK,_nidDokter);

            //MessageBox.Show(cmbKlinik.SelectedValue.ToString());
            _kodeKlinik =  cmbKlinik.SelectedValue.ToString();

            LoadHome();
           // pupolateResep();
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

        public void pupolateResep()
        {
            //MessageBox.Show(_nidDokter,_kodeKlinik);
            flpHistoriPasien.SuspendLayout();
            flpHistoriPasien.Controls.Clear();
            var ds = new resep_hTableAdapter();
            ds.FillByDokterGetDate(yakkumdb.resep_h, _nidDokter,_kodeKlinik);
            DataTable dt = ds.GetDataByDokterGetDate(_nidDokter,_kodeKlinik);
            foreach (DataRow r in dt.Rows)
            {
                var uc = new CardHistoriPasien
                {
                    Tag = r["vc_no_reg"].ToString()+r["int_k_status"].ToString(),
                    NoRM = r["vc_no_rm"].ToString(),
                    Nama = r["vc_nama_p"].ToString(),
                    Status = r["vc_status"].ToString() 
                };

                if (flpHistoriPasien.Controls.Count < 0)
                {
                    flpHistoriPasien.Controls.Clear();
                }

                else
                {
                    flpHistoriPasien.Controls.Add(uc);
                    uc.Click += uc_MouseCliked;
                }
            }
            flpHistoriPasien.ResumeLayout();
        }
        private void uc_MouseCliked(object sender, EventArgs e)
        {
            UserControl us = (UserControl)sender;
            var _filter = us.Tag.ToString();
            if (_filter.Substring(13) == "4")
            {
                MessageBox.Show("Resep Sudah di Finalisasi oleh Farmasi, Jika ada perubahan resep mohon konfirmasi ke farmasi");
            }
            else
            {
                
                AddData ef = new AddData(_filter.Substring(0, 13), _kodeKlinik, _nidDokter) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                LoadPanelChild.Controls.Clear();
                LoadPanelChild.Controls.Add(ef);
                ef.Show();
            }
            
        }
        private void LoadPanelChild_ControlAdded(object sender, ControlEventArgs e)
        {
            pupolateResep();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pupolateResep();
        }

        private void flpHistoriPasien_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void flpHistoriPasien_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void cmbKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKlinik.SelectedIndex != -1)
            {
                cmbKlinik.Text = cmbKlinik.SelectedValue.ToString();

                _kodeKlinik = cmbKlinik.SelectedValue.ToString();
                LoadPanelChild.Controls.Clear();
                LoadHome();
                //MessageBox.Show(cmbKlinik.SelectedValue.ToString());



                // If we also wanted to get the displayed text we could use
                // the SelectedItem item property:
                // string s = ((USState)ListBox1.SelectedItem).LongName;
            }

        }

        private void cmbKlinik_SelectedValueChanged(object sender, EventArgs e)
        {
           
            
        }
    }
}
