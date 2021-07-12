using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Reflection;
using rse.app.desk.rx.pharmacist;
using YourApp;
using rse.app.desk.rx.pharmacist.Dataset;
using System.Threading;

namespace rse.app.desk.rx.pharmacist.UI
{
    public partial class UCResepDetil : UserControl
    {
        private int _numofcopies { get; set; }
        private string _noresep { get; set; }
        private string _sep { get; set; }
        private string _noreg { get; set; }
        public UCResepDetil(string noresep)
        {
            InitializeComponent();
           
            _noresep = noresep;
        }

        private void UCResepDetil_Load(object sender, EventArgs e)
        {
            this.resep_detilTableAdapter.FillByNoResep(yakkumdb.resep_detil,_noresep);
            this.data_pasienTableAdapter.Fill(yakkumdb.data_pasien,_noresep);
            _noreg = lblNoReg.Text;
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            var ds = new Dataset.yakkumdbTableAdapters.data_pasienTableAdapter();
            ds.ClearBeforeFill = true;
            ds.Fill(yakkumdb.data_pasien,_noresep);
            var ds2 = new Dataset.yakkumdbTableAdapters.data_resepTableAdapter();
            ds2.ClearBeforeFill = true;
            ds2.Fill(yakkumdb.data_resep,_noresep);

            //this.rvResep.LocalReport.DataSources.Clear();

            ReportDataSource _rds = new ReportDataSource();
            _rds.Name = "dsPasien";
            _rds.Value = ds.GetData(_noresep);
            //this.rvResep.LocalReport.DataSources.Add(_rds);

            ReportDataSource _rds2 = new ReportDataSource();
            _rds2.Name = "dsResep";
            _rds2.Value = ds2.GetData(_noresep);
            //this.rvResep.LocalReport.DataSources.Add(_rds2);

            //this.rvResep.ZoomMode = ZoomMode.PageWidth;
            //this.rvResep.RefreshReport();

            LocalReport report = new LocalReport();
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string fullpath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\Reports\reportResep.rdlc";
            report.ReportPath = fullpath;
            MessageBox.Show(fullpath);
            report.DataSources.Add(_rds);
            report.DataSources.Add(_rds2);
            
            PrintReport.PrintToPrinter(report,_numofcopies);
            
        }

        public void load_report()
        {
            var ds = new Dataset.yakkumdbTableAdapters.data_pasienTableAdapter();
            ds.ClearBeforeFill = true;
            ds.Fill(yakkumdb.data_pasien,_noresep);
            var ds2 = new Dataset.yakkumdbTableAdapters.data_resepTableAdapter();
            ds2.ClearBeforeFill = true;
            ds2.Fill(yakkumdb.data_resep,_noresep);

            //this.rvResep.ZoomMode = ZoomMode.PageWidth;
            //this.rvResep.RefreshReport();
            DataTable dt = ds.GetData(_noresep);
            foreach (DataRow r in dt.Rows)
            {
                _sep = r["vc_no_sep"].ToString();
                //MessageBox.Show(_sep);
            }

            if (InvokeRequired)
            {
                // after we've done all the processing, 
                this.Invoke(new MethodInvoker(delegate
                {
                    // load the control with the appropriate data'
                    this.rvResep.ZoomMode = ZoomMode.PageWidth;
                    this.rvResep.RefreshReport();
                }));
                return;
            }
        }

        private void doSimpan()
        {
            var rh = new Dataset.yakkumdbTableAdapters.fa_rx_resep_hTableAdapter();
            //TODO : janganlupa uncomment
            rh.UpdateResponTime(DateTime.Now, _noresep);
            //load_report();
            //var _year = DateTime.Now.ToString("yyyy");
            //var _month = DateTime.Now.ToString("MM");
            //var _day = DateTime.Now.ToString("dd");
            //var _datepath = _year + @"\" + _month + @"\" + _day;
            //var _filename = _sep + "_resep.Pdf";
            ////string _path = @"\\192.168.2.222\Sharing Is Caring\ResepFarmasiSementara\" + _datepath + @"\" + _filename;
            //string _path = @"\\192.168.10.11\Data SEP\Casemix RJ\FARMASI RJ\" + _datepath + @"\" + _filename;

            //Functions.SavePDF.SavedPDF(rvResep, _path);
            PrintDialog pd = new PrintDialog();
            var result = pd.ShowDialog();
            //UCHome uchome = new UCHome();
            //uchome.Dock = DockStyle.Fill;

            if (result == DialogResult.Yes)
            {
                this._numofcopies = pd._printcopy;                                                                                                                                                   
                printResep();
                //this.Controls.Clear();
                //this.Controls.Add(uchome);
                rh.UpdateStatusFinal(_noresep);
            }
            if (result == DialogResult.No)
            {
                //this.Controls.Clear();
                //this.Controls.Add(uchome);
                rh.UpdateStatusFinal(_noresep);
            }
            
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //doSimpan();
            using (UI.LoadingWindow lw = new UI.LoadingWindow(doSimpan))
            {
                lw.ShowDialog(this);
            }
            UCHome uchome = new UCHome();
            uchome.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(uchome);
            MainForm.Refresh_list();
        }

        private void printResep()
        {

            var ds = new Dataset.yakkumdbTableAdapters.data_pasienTableAdapter();
            ds.ClearBeforeFill = true;
            ds.Fill(yakkumdb.data_pasien, _noresep);    

            var ds2 = new Dataset.yakkumdbTableAdapters.data_resepTableAdapter();
            ds2.ClearBeforeFill = true;
            ds2.Fill(yakkumdb.data_resep, _noresep);

            var ds3 = new Dataset.rmdbTableAdapters.diagnosa_utamaTableAdapter();
            ds3.ClearBeforeFill = true;
           
            ds3.Fill(rmdb.diagnosa_utama, _noreg);

            var ds4 = new Dataset.rmdbTableAdapters.RMIcdSekunderRalanTableAdapter();
            ds4.ClearBeforeFill = true;
            ds4.Fill(rmdb.RMIcdSekunderRalan, _noreg);

            var ds5 = new Dataset.yakkumdbTableAdapters.fa_rx_tindakanTableAdapter();
            ds5.ClearBeforeFill = true;
            ds5.Fill(yakkumdb.fa_rx_tindakan, _noresep);

            var ds6 = new Dataset.yakkumdbTableAdapters.fa_rx_prosedurTableAdapter();
            ds6.ClearBeforeFill = true;
            ds6.Fill(yakkumdb.fa_rx_prosedur, _noreg);

            var ds7 = new Dataset.yakkumdbTableAdapters.fa_rx_resep_hTableAdapter();
            ds7.ClearBeforeFill = true;
            ds7.FillByKdResep(yakkumdb.fa_rx_resep_h, _noresep);
            //this.rvResep.LocalReport.DataSources.Clear();

            ReportDataSource _rds = new ReportDataSource();
            _rds.Name = "dsPasien";
            _rds.Value = ds.GetData(_noresep);
            //this.rvResep.LocalReport.DataSources.Add(_rds);

            ReportDataSource _rds2 = new ReportDataSource();
            _rds2.Name = "dsResep";
            _rds2.Value = ds2.GetData(_noresep);
            //this.rvResep.LocalReport.DataSources.Add(_rds2);

            ReportDataSource _rds3 = new ReportDataSource();
            _rds3.Name = "dsDiagnosa";
            _rds3.Value = ds3.GetData(_noreg);

            ReportDataSource _rds4 = new ReportDataSource();
            _rds4.Name = "dsDiagSec";
            _rds4.Value = ds4.GetData(_noreg);

            ReportDataSource _rds5 = new ReportDataSource();
            _rds5.Name = "dsTindakanPer";
            _rds5.Value = ds5.GetData(_noresep);

            ReportDataSource _rds6 = new ReportDataSource();
            _rds6.Name = "dsProcedure";
            _rds6.Value = ds6.GetData(_noreg);

            ReportDataSource _rds7 = new ReportDataSource();
            _rds7.Name = "dsResepH";
            _rds7.Value = ds6.GetData(_noreg);
            //this.rvResep.ZoomMode = ZoomMode.PageWidth;
            //this.rvResep.RefreshReport();

            LocalReport report = new LocalReport();
            //string path = Path.GetDirectoryName(Application.ExecutablePath);
            //string fullpath = @"C:\rse.app.resource\Reports\reportResep.rdlc";
            //report.ReportPath = fullpath;
            report.ReportEmbeddedResource = "rse.app.desk.rx.pharmacist.Reports.reportResep.rdlc";
            report.DataSources.Add(_rds);
            report.DataSources.Add(_rds2);
            report.DataSources.Add(_rds3);
            report.DataSources.Add(_rds4);
            report.DataSources.Add(_rds5);
            report.DataSources.Add(_rds6);
            report.DataSources.Add(_rds7);

            for (int q = 1; q <= _numofcopies; q++)
            {
                PrintReport.PrintToPrinter(report, _numofcopies);
            }


            var _year = DateTime.Now.ToString("yyyy");
            var _month = DateTime.Now.ToString("MM");
            var _day = DateTime.Now.ToString("dd");
            var _datepath = _year + @"\" + _month + @"\" + _day;
            var _filename = _sep + "_resep.Pdf";
            //string _path = @"\\192.168.2.222\Sharing Is Caring\ResepFarmasiSementara\" + _datepath + @"\" + _filename;
            string _path = @"\\192.168.10.11\Data SEP\Casemix RJ\FARMASI RJ\" + _datepath + @"\" + _filename;

            Functions.SavePDF.SavedPDF(report, _path);

        }
        private void dgvResep_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 7)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 20;//Properties.Resources.pencil.Width;
                var h = 20;// Properties.Resources.pencil.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.edit, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            
        }

        private void dgvResep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I suposed you want to handle the event for column at index 1

            if (e.ColumnIndex == 7)
            {
                var val = this.dgvResep[8, e.RowIndex].Value.ToString();
                editObat eb = new editObat(val);
                var result = eb.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.resep_detilTableAdapter.FillByNoResep(yakkumdb.resep_detil, _noresep);
                    dgvResep.Update();
                    dgvResep.Refresh();
                }
                // MessageBox.Show("edited! " + val);
            }
            else 
            {
                var btracik = this.dgvResep[9, e.RowIndex].Value.ToString();
                if(btracik == "True")
                {
                    var _koderxd = this.dgvResep[8, e.RowIndex].Value.ToString();
                    this.fa_rx_racikanTableAdapter.Fill(yakkumdb.fa_rx_racikan, _koderxd);
                    dgvRacikan.Update();
                    dgvRacikan.Refresh();
                    pnlRacikan.Visible = true;
                }
                else 
                {
                    pnlRacikan.Visible = false;
                }
                //pnpMessageBox.Show(btracik);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.populateItems();
        }
    }
}
