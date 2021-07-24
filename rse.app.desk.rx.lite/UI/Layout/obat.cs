using rse.app.desk.rx.lite.dataset.yakkumdbTableAdapters;
using rse.app.desk.rx.lite.UI.Layout;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using rse.app.desk.rx.lite.Fungtion;
//using static rse.app.desk.rx.lite.UI.Login;

namespace rse.app.desk.rx.lite.UI
{
    public partial class obat : UserControl
    {
        //private roles _currentroles { get; set; }
        public string _kodeobat { get; set; }
        public int _kodefornas { get; set; }
        public string _noreg { get; set; }
        public string _kdokter { get; set; }
        public string _norm { get; set; }
        public string[] _listobat { get; set; }
        public string[] _listobatdetil { get; set; }
        private string _kdpng { get; set; }

        public Label lblRtx { get { return lblKodeRtx; } }

        AutoCompleteStringCollection namesCollection =
        new AutoCompleteStringCollection();
        public obat(string noreg, string kdokter, int kfornas, string norm, string kdpng)
        {
            InitializeComponent();
            _kodefornas = kfornas;
            _noreg = noreg;
            _kdokter = kdokter;
            _norm = norm;
            _kdpng = kdpng;
            //_currentroles = _roles;
            pnlHistori.Width = 0;
            
        }

        private void txtCariObat_Load(object sender, EventArgs e)
        {
            LoadTemplateRacikan();
            this.view_resepTableAdapter.Fill(this.yakkumdb.view_resep, lblKodeRtx.Text);
            bs_view_resep.Filter = "vc_kode_rx = '" + lblKodeRtx.Text + "'";

            SqlDataReader dReader;
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = rse.app.desk.rx.lite.Properties.Settings.Default.yakkumdatabaseConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText =
            "Select  [vc_namaobat],[vc_kodeobat] from [dbo].[view_rse_fa_obat]" +
            "where [kodefornas] >= " + _kodefornas + "and [vc_golongan] = '01'" +
             " or vc_namaobat like '%alat bantu dengar%'" +
               " or vc_namaobat like '%corset%'" +
                "or vc_namaobat like '%Neck Collar%'" +
               " or vc_namaobat like '%kruk%'" +
               " or vc_namaobat like '%JARUM HUMULIN UNGU%'" +
            " order by [vc_namaobat] asc";
            conn.Open();
            dReader = cmd.ExecuteReader();
            if (dReader.HasRows == true)
            {
                while (dReader.Read())
                    namesCollection.Add(dReader["vc_namaobat"].ToString());
            }
            else
            {
                MessageBox.Show("Data not found");
            }

            dReader.Close();
            conn.Close();

            txtCariObat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCariObat.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCariObat.AutoCompleteCustomSource = namesCollection;

            lblKodeRtx.Text = "RX" + _noreg + _kdokter;

            this.view_resepTableAdapter.Fill(this.yakkumdb.view_resep, lblKodeRtx.Text);
            bs_view_resep.Filter = "vc_kode_rx = '" + lblKodeRtx.Text + "'";
            dgvResep.Update();
            dgvResep.Refresh();

            populateHistoryResep();
        }

        private void txtCariObat_KeyDown(object sender, KeyEventArgs e)
        {
            // TODO : Cek Retensi dari Sini
            if (e.KeyCode == Keys.Enter)
            {
                List<string> daftarobat = new List<string>();
                var dh = new dataset.yakkumdbTableAdapters.view_rse_fa_obatTableAdapter();
                var _resepdetail = new dataset.yakkumdbTableAdapters.fa_rx_resep_dTableAdapter();
                dh.Fill(yakkumdb.view_rse_fa_obat);
                DataTable dt = dh.GetData();
                foreach (DataRow r in dt.Rows)
                {
                    daftarobat.Add(r.Field<string>(4));
                }
                _listobat = daftarobat.ToArray();

                _resepdetail.FillByNoRx(yakkumdb.fa_rx_resep_d, lblKodeRtx.Text);
                DataTable dta = _resepdetail.GetDataByNoRx(lblKodeRtx.Text);
                List<string> obatdiresep = new List<string>();
                foreach (DataRow rs in dta.Rows)
                {
                    obatdiresep.Add(rs.Field<string>(1));
                }
                _listobatdetil = obatdiresep.ToArray();
                if (_listobat.Contains(txtCariObat.Text.ToUpper()) == false)
                { MessageBox.Show("Pastikan Nama Obat Sesuai !!", "Important Message"); }
                //else if (_listobatdetil.Contains(txtCariObat.Text.ToUpper()) == false)
                //{ MessageBox.Show("Obat Sudah Berada di Resep, Edit untuk melakukan perubahan."); }
                else
                {
                      var _maxno = (int)_resepdetail.ScalarQueryMaxNoUrutResep(lblKodeRtx.Text) + 1;
                     //MessageBox.Show(_maxno.ToString());
                    _kodeobat = txtCariObat.Text;
                    dosis ds = new dosis(_kodeobat, lblKodeRtx.Text, _kdokter, _maxno,_kodefornas,"",false);
                    var result = ds.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.view_resepTableAdapter.Fill(this.yakkumdb.view_resep, lblKodeRtx.Text);
                        bs_view_resep.Filter = "vc_kode_rx = '" + lblKodeRtx.Text + "'";
                        dgvResep.Update();
                        dgvResep.Refresh();

                    }
                }

            }
        }
     
        private void dgvResep_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 9)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 15;//Properties.Resources.pencil.Width;
                var h = 15;// Properties.Resources.pencil.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.pencil, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 10)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 15;//Properties.Resources.pencil.Width;
                var h = 15;// Properties.Resources.pencil.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvResep_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            ////I supposed the image column is at index 1
            //if (e.ColumnIndex == 6)
            //    e.Value = Properties.Resources.delete;
        }

        private void dgvResep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());
            string bt_racikan = this.dgvResep[8, e.RowIndex].Value.ToString();
            var rxd = new dataset.yakkumdbTableAdapters.fa_rx_resep_dTableAdapter();
            var dtracikan = new dataset.yakkumdbTableAdapters.fa_rx_racikanTableAdapter();
            var _kdrxd = this.dgvResep[5, e.RowIndex].Value.ToString();

            if (e.RowIndex < 0)
                return;

            //I suposed you want to handle the event for column at index 1
            if (e.ColumnIndex == 9)
            {
                
                _kodeobat = this.dgvResep[1, e.RowIndex].Value.ToString();
                

                if (bt_racikan == "False")
                {
                    dosis ds = new dosis
                        (_kodeobat, 
                        lblKodeRtx.Text, 
                        _kdokter, 
                        (int)this.dgvResep[7, e.RowIndex].Value, 
                        _kodefornas, 
                        _kdrxd, 
                        true);
                    var result = ds.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.view_resepTableAdapter.Fill(this.yakkumdb.view_resep, lblKodeRtx.Text);
                        bs_view_resep.Filter = "vc_kode_rx = '" + lblKodeRtx.Text + "'";
                        dgvResep.Update();
                        dgvResep.Refresh();
                    }
                }
                if(bt_racikan == "True")
                {
                    //MessageBox.Show("Edit Racikan");
                    var temp = 2;
                    
                    // MessageBox.Show(nurs.ToString());
                    Racikan rc = new Racikan(
                        0, 
                        _kodefornas, 
                        _kodeobat,
                        _kdrxd, 
                        lblKodeRtx.Text,
                        this.dgvResep[7, e.RowIndex].Value.ToString(),
                        _kdokter,
                        (int)this.dgvResep[7, e.RowIndex].Value, 
                        temp);
                    var result = rc.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.view_resepTableAdapter.Fill(this.yakkumdb.view_resep, lblKodeRtx.Text);
                        bs_view_resep.Filter = "vc_kode_rx = '" + lblKodeRtx.Text + "'";
                        dgvResep.Update();
                        dgvResep.Refresh();
                    }
                }

                //MessageBox.Show(this.dgvResep[11, e.RowIndex].Value.ToString());
                // TODO : Edit Event
                //var kdrxd = this.dgvResep[8, e.RowIndex].Value.ToString();
                //var kdrx = this.dgvResep[9, e.RowIndex].Value.ToString();
                //var nourut = Int32.Parse(this.dgvResep[10, e.RowIndex].Value.ToString());
                //var namaobat = this.dgvResep[1, e.RowIndex].Value.ToString();
                //MessageBox.Show(namaobat + kdrx+_kdokter+nourut);
                //dosis ds = new dosis(namaobat, kdrx, _kdokter, nourut);
                //var result = ds.ShowDialog();
                //if (result == DialogResult.OK)
                //{
                //    this.view_resepTableAdapter.Fill(this.yakkumdb.view_resep, lblKodeRtx.Text);
                //    dgvResep.Update();
                //    dgvResep.Refresh();
                //}

            }

            if (e.ColumnIndex == 10)
            {
                // Deleted event
                var val = this.dgvResep[5, e.RowIndex].Value.ToString();
                var no_urut = Int32.Parse(this.dgvResep[7, e.RowIndex].Value.ToString());
                rxd.DeleteObat(val,no_urut);
                if(bt_racikan == "True")
                {
                    dtracikan.DeleteQueryByKodeRXD(_kdrxd);
                }

                this.view_resepTableAdapter.Fill(this.yakkumdb.view_resep, lblKodeRtx.Text);
                dgvResep.Update();
                dgvResep.Refresh();
               // MessageBox.Show("Deleted! " + val);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            var dh = new dataset.yakkumdbTableAdapters.fa_rx_resep_dTableAdapter();
            dh.Fill(yakkumdb.fa_rx_resep_d);
            var sc = dh.ScalarQueryNoRacikan(lblKodeRtx.Text).ToString();
            var cs = Int32.Parse(sc) + 1;
            var _koderacikan = "RC" + _noreg + _kdokter + cs.ToString("00000");
            var _namaracikan = "Racikan " + cs.ToString("00");

            var nu = dh.ScalarQueryMaxNoUrutResep(lblKodeRtx.Text).ToString();
            var nurs = int.Parse(nu) + 1;
            var temp = 0;
            // MessageBox.Show(nurs.ToString());
            Racikan rc = new Racikan(0,_kodefornas, _namaracikan, _koderacikan, lblKodeRtx.Text, cs.ToString(), _kdokter, nurs,temp);
            var result = rc.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.view_resepTableAdapter.Fill(this.yakkumdb.view_resep, lblKodeRtx.Text);
                bs_view_resep.Filter = "vc_kode_rx = '" + lblKodeRtx.Text + "'";
                dgvResep.Update();
                dgvResep.Refresh();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var dh = new dataset.yakkumdbTableAdapters.resep_hTableAdapter();
            Pilihan pl = new Pilihan();
            var result = pl.ShowDialog();
            if (result == DialogResult.Yes)
            {
                dh.UpdateStatus("WAITING", 2, DateTime.Now, lblKodeRtx.Text);
            }
            if (result == DialogResult.No)
            {
                dh.UpdateStatus("ORDER", 3, DateTime.Now, lblKodeRtx.Text);
            }

            MessageBox.Show("Resep Berhasil di Simpan");
            //Eprescribe ep = new Eprescribe(_kdokter,_currentroles);
            //ep.Show();
        }

        private void dgvResep_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void LoadTemplateRacikan()
        {
           // MessageBox.Show(_kodefornas.ToString());
            var _kodetmpracikan = 0;
            if (_kdpng == "323")
            {
                _kodetmpracikan = 3;
            }
            else { _kodetmpracikan = 1; }
            var dh = new dataset.yakkumdbTableAdapters.fa_rx_template_racikanTableAdapter();
            dh.FillByDist(yakkumdb.fa_rx_template_racikan, _kdokter, _kodetmpracikan);
            DataTable dt = dh.GetDataByDist(_kdokter, _kodetmpracikan);

            foreach (DataRow r in dt.Rows)
            {
                //MessageBox.Show(r["nama_template"].ToString());
                Guna.UI2.WinForms.Guna2Button button = new Guna.UI2.WinForms.Guna2Button();
                button.Tag = r["nid_dokter"].ToString()+ r["nama_template"].ToString();
                button.Text = r["nama_template"].ToString();
                button.AutoRoundedCorners = true;
                //button.AutoSize = true;
                flptemRacikan.Controls.Add(button);
                button.Click += button_MouseCliked;
            }

        }

        private void button_MouseCliked(object sender, EventArgs e)
        {

            Guna.UI2.WinForms.Guna2Button us = (Guna.UI2.WinForms.Guna2Button)sender;
            var _filter = us.Tag.ToString();


            var dh = new dataset.yakkumdbTableAdapters.fa_rx_resep_dTableAdapter();
            dh.Fill(yakkumdb.fa_rx_resep_d);
            var sc = dh.ScalarQueryNoRacikan(lblKodeRtx.Text).ToString();
            var cs = Int32.Parse(sc) + 1;
            var _koderacikan = "RC" + _noreg + _kdokter + cs.ToString("00000");
            var _namaracikan = _filter.ToString().Substring(4) +" " + cs.ToString("00");

            var nu = dh.ScalarQueryMaxNoUrutResep(lblKodeRtx.Text).ToString();
            var nurs = int.Parse(nu) + 1;

            int temp = 1;
            var kdtemplateracikan = 0;
            if(_kdpng == "323")
            {
                kdtemplateracikan = 3;
            }
            else
            {
                kdtemplateracikan = 1;
            }
            
            //Racikan rc = new Racikan(_kodefornas, _namaracikan, _koderacikan, lblKodeRtx.Text, cs.ToString(), _kdokter, nurs,temp);
            Racikan rc = new Racikan(kdtemplateracikan,_kodefornas, _namaracikan, _koderacikan, lblKodeRtx.Text, cs.ToString(), _kdokter, nurs, temp);

            var result = rc.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.view_resepTableAdapter.Fill(this.yakkumdb.view_resep, lblKodeRtx.Text);
                bs_view_resep.Filter = "vc_kode_rx = '" + lblKodeRtx.Text + "'";
                dgvResep.Update();
                dgvResep.Refresh();
            }

        }

        private void flpHistoriResep_Paint(object sender, PaintEventArgs e)
        {

        }

        private void populateHistoryResep()
        {
            flpHistoriResep.SuspendLayout();
            flpHistoriResep.Controls.Clear();
            var ds = new RM_KUNJUNGTableAdapter();
            DataTable dt = ds.GetDataByNoRM(_norm, _noreg);
           // DataTable dt = ds.GetDataByNoRM("00022634", "2012281200015");
            foreach (DataRow r in dt.Rows)
            {
                var uc = new CardHistoryResep
                {
                    //Tag = r["vc_nid"].ToString() + r["vc_kode_rx"].ToString(),
                    Tag = r["vc_kode_rx"].ToString(),
                    TGLReg = (DateTime)r["DT_TGL_REG"],
                    NamaDokter = r["nama_dokter"].ToString(),
                    Klinik = r["vc_N_KLINIK"].ToString(),
                    Penanggung = r["vc_n_png"].ToString(),
                    NoREG = r["VC_NO_REGJ"].ToString(),
                    NoRSP = r["vc_kode_rx"].ToString(),
                    Data = Treedata(r["VC_NO_REGJ"].ToString())
                    //Data = Treedata("2104070700016")
                };

                if (flpHistoriResep.Controls.Count < 0)
                {
                    flpHistoriResep.Controls.Clear();
                }

                else
                {
                    //uc.InitializeTree();
                    uc.LoadTreeData();
                    uc.CpyButtonClick += uc_cpyResepClik;
                    flpHistoriResep.Controls.Add(uc);
                    //uc.Click += uc_MouseCliked;
                }
            }
            flpHistoriResep.ResumeLayout();

        }

        private void uc_cpyResepClik(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button us = (Guna.UI2.WinForms.Guna2Button)sender;
            var _cpyNoResep = us.Tag.ToString();

            //MessageBox.Show(_cpyNoResep);
            var dh = new dataset.yakkumdbTableAdapters.fa_rx_resep_dTableAdapter();
            var dt = new dataset.yakkumdbTableAdapters.fa_rx_racikanTableAdapter();
            DataTable ds = dh.GetDataByKodeRXonlyRX(_cpyNoResep);
            foreach (DataRow r in ds.Rows)
            {
                var nu = (int)dh.ScalarQueryMaxNoUrutResep(lblKodeRtx.Text) +1;
                var sc = (int)dh.ScalarQueryNoRacikan(lblKodeRtx.Text) + 1;
                
                var _koderacikan = "RC" + _noreg + _kdokter + sc.ToString("00000");
                //MessageBox.Show(_koderacikan);
                if ((Boolean)r["bt_racikan"] == true)
                {
                    dh.InsertQuery
                    (lblKodeRtx.Text,
                    _koderacikan,
                    "999999",
                    sc.ToString(),
                    true,
                     r["vc_signalain"].ToString(),
                    (Boolean)r["bt_iter"],
                    (Decimal)r["num_jmliter"],
                    (Boolean)r["bt_fav"],
                    (Decimal)r["num_jml"],
                    _kdokter,
                    nu,
                    r["nvc_dd1"].ToString(),
                    r["nvc_dd2"].ToString(),
                    r["vc_satuan"].ToString(),
                    r["vc_nama_obat"].ToString(),
                    r["vc_satuan_dosis"].ToString()

                    );
                    DataTable tt = dt.GetDataByKodeRD(r["vc_kode_rx_d"].ToString());
                    foreach (DataRow t in tt.Rows)
                    {
                        dt.InsertQuery(
                          _koderacikan,
                          (int)t["in_no_urut"],
                          t["vc_k_obat"].ToString(),
                          t["vc_nama_obat"].ToString(),
                          t["vc_dosis"].ToString(),
                          t["vc_satuan"].ToString()
                       );
                    }
                }
                else {
                    dh.InsertQuery
                  (lblKodeRtx.Text,
                  lblKodeRtx.Text + r["vc_kode_obat"].ToString(),
                  r["vc_kode_obat"].ToString(),
                  "",
                  false,
                  r["vc_signalain"].ToString(),
                  (Boolean)r["bt_iter"],
                  (Decimal)r["num_jmliter"],
                  (Boolean)r["bt_fav"],
                  (Decimal)r["num_jml"],
                  _kdokter,
                  nu,
                  r["nvc_dd1"].ToString(),
                  r["nvc_dd2"].ToString(),
                  r["vc_satuan"].ToString(),
                  r["vc_nama_obat"].ToString(),
                  r["vc_satuan_dosis"].ToString()
                  );
                }
                
            }

            this.view_resepTableAdapter.Fill(this.yakkumdb.view_resep, lblKodeRtx.Text);
            bs_view_resep.Filter = "vc_kode_rx = '" + lblKodeRtx.Text + "'";
            dgvResep.Update();
            dgvResep.Refresh();

            hrclose();
            //AddData ef = new AddData(_filter, _kodeKlinik, _kodeDokter) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.Controls.Clear();
            //this.Controls.Add(ef);
            //ef.Show();
        }

        public static DataTable Treedata(string noreg)
        {
            var dt = new DataTable();
            dt.Columns.Add("EQUID", typeof(int));
            dt.Columns.Add("DESEQU", typeof(string));
            var parentColumn = dt.Columns.Add("PEQUID", typeof(int));

            //Data Resep
            var dh = new dataset.yakkumdbTableAdapters.resep_detilTableAdapter();
            var th = new dataset.yakkumdbTableAdapters.fa_rx_racikanTableAdapter();

            // TODO : Cari cara get variable dari luar class
            //MessageBox.Show(noreg);
            DataTable ds = dh.GetDataByGolongan(noreg);
            foreach (DataRow r in ds.Rows)
            {
                //Rows
                //MessageBox.Show(r["golongan_obat"].ToString());
                dt.Rows.Add(Int32.Parse(r["kd_golongan"].ToString()), r["golongan_obat"].ToString());
                DataTable ds2 = dh.GetData(noreg, r["kd_golongan"].ToString());//r["kd_golongan"].ToString()
                foreach (DataRow d in ds2.Rows)
                {
                    //MessageBox.Show(d["vc_nama_obat"].ToString() + d["bt_racikan"].ToString());
                    dt.Rows.Add(
                        Int32.Parse(d["in_no_urut"].ToString() + d["vc_kode_obat"].ToString()),
                        d["num_jml"].ToString() + " " + d["vc_satuan"].ToString() + " | " +d["vc_nama_obat"].ToString(), 
                        Int32.Parse(d["kd_golongan"].ToString())
                        );

                    if ((Boolean)d["bt_racikan"] == true)
                    //if ( d["bt_racikan"].ToString() == "1")
                    {
                        DataTable tt = th.GetDataByKodeRD(d["vc_kode_rx_d"].ToString());
                        foreach (DataRow t in tt.Rows)
                        {
                            //MessageBox.Show(t["vc_nama_obat"].ToString());
                            dt.Rows.Add(
                                Int32.Parse(t["in_no_urut"].ToString() + t["vc_k_obat"].ToString()),
                                t["vc_dosis"].ToString() + " " + t["vc_satuan"].ToString()+" | "+t["vc_nama_obat"].ToString(), 
                                Int32.Parse(d["in_no_urut"].ToString() + d["vc_kode_obat"].ToString()));
                        }
                    }
                }
            }
            return (dt);
        }

        private Boolean _hresepstate { get; set; }
        public void hropen ()
        {
            if (_hresepstate == true)
            { }
            else
            {
                _hresepstate = true;
                pnlHistori.Visible = false;
                pnlHistori.Width = 470;
                guna2Transition1.ShowSync(pnlHistori);
                flpHistoriResep.Focus();
            }
            
        }
        public void hrclose()
        {
            if (_hresepstate == false)
            { }
            else
            {
                _hresepstate = false;
                pnlHistori.Visible = false;
                pnlHistori.Width = 0;
            }

        }

        private void pnlhresepShow_MouseHover(object sender, EventArgs e)
        {
            hropen();
        }

        private void dgvResep_MouseHover(object sender, EventArgs e)
        {
            hrclose();
        }

        private void btnHideHistory_Click(object sender, EventArgs e)
        {
            hrclose();
        }

        private void dgvResep_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
