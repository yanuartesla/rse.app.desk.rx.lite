using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace rse.app.desk.rx.lite.UI
{
    public partial class Racikan : Form
    {
        AutoCompleteStringCollection namesCollection =
        new AutoCompleteStringCollection();
        private int _kdtemplateracikan { get; set; }
        private int _kodefornas { get; set; }
        private Boolean _btIter { get; set; }
        private decimal _jmliter { get; set; }
        private string _namaracikan { get; set; }
        private string _koderxd { get; set; }
        private string _koderx { get; set; }
        private string _kracik { get; set; }
        private string _kdokter { get; set; }
        private int _nourut { get; set; }
        private int _template { get; set; }

        public Racikan(int kdtemplateracikan, int kodefornas, string namaracikan, string koderxd, string koderx, string kracik, string kdokter, int nourut, int temp)
        {
            InitializeComponent();
            _kdtemplateracikan = kdtemplateracikan;
            _kodefornas = kodefornas;
            _namaracikan = namaracikan;
            Obat.Text = _namaracikan;
            _koderxd = koderxd;
            _koderx = koderx;
            _kracik = kracik;
            _nourut = nourut;
            _kdokter = kdokter;
            _template = temp; // TODO : _template: 0 = reguler, 1 = template, 2 = edit
            load_Template();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNamaObat_Load(object sender, EventArgs e)
        {
            SqlDataReader dReader;
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = rse.app.desk.rx.lite.Properties.Settings.Default.yakkumdatabaseConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText =
            "Select  [vc_namaobat],[vc_kodeobat] from [dbo].[view_rse_fa_obat]" +
            "where [kodefornas] >= " + _kodefornas + "and [vc_golongan] = '01'" +

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

            txtNamaObat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNamaObat.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNamaObat.AutoCompleteCustomSource = namesCollection;
        }

        
        private void txtNamaObat_TextChanged(object sender, EventArgs e)
        {
            // viewrsefaobatBindingSource.Filter = "[vc_namaobat] = '" + txtNamaObat.Text + "'";
        }

        private void Racikan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yakkumdb.view_rse_fa_obat' table. You can move, or remove it, as needed.
            this.view_rse_fa_obatTableAdapter.Fill(this.yakkumdb.view_rse_fa_obat);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgvRacik.Rows[0].Clone();
            row.Cells[1].Value = txtNamaObat.Text;
            row.Cells[2].Value = txtDosis.Text;
            row.Cells[3].Value = cmbSat.Text;
            row.Cells[5].Value = lblKobat.Text;
            dgvRacik.Rows.Add(row);
            txtNamaObat.Clear();
            txtDosis.Clear();
            cmbSat.SelectedIndex = -1;
        }

        private void dgvRacik_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //var grid = sender as DataGridView;
            //var rowIdx = (e.RowIndex + 1).ToString();

            //var centerFormat = new StringFormat()
            //{
            //    // right alignment might actually make more sense for numbers
            //    Alignment = StringAlignment.Center,
            //    LineAlignment = StringAlignment.Center
            //};

            //var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            //e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);

            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void EtherCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (EtherCheck.Checked)
            {
                numiter.Visible = true;
                _btIter = true;
                _jmliter = numiter.Value;
            }
            else if (!EtherCheck.Checked)
            {
                numiter.Visible = false;
                _btIter = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (cekkelengkapan())
            {
                case false:
                    //MessageBox.Show("Salah");
                    break;
                case true:
                    //MessageBox.Show("Benar");
                    var dt = new dataset.yakkumdbTableAdapters.fa_rx_racikanTableAdapter();
                    dt.DeleteQueryByKodeRXD(_koderxd);
                    for (int i = 0; i < dgvRacik.RowCount - 1; i++)
                    {
                        dt.InsertQuery(
                             _koderxd,
                             i + 1,
                             dgvRacik.Rows[i].Cells[5].Value.ToString(),
                             dgvRacik.Rows[i].Cells[1].Value.ToString(),
                             dgvRacik.Rows[i].Cells[2].Value.ToString(),
                             dgvRacik.Rows[i].Cells[3].Value.ToString()
                          );
                        //if (dgvRacik.Rows[i].Cells[2].Value.ToString() == "" || string.IsNullOrEmpty(dgvRacik.Rows[i].Cells[3].Value as string))
                        //{
                        //    MessageBox.Show("Masukan Obat Racikan");
                        //}
                        //else
                        //{
                        //dt.InsertQuery(
                        //   _koderxd,
                        //   i + 1,
                        //   dgvRacik.Rows[i].Cells[5].Value.ToString(),
                        //   dgvRacik.Rows[i].Cells[1].Value.ToString(),
                        //   dgvRacik.Rows[i].Cells[2].Value.ToString(),
                        //   dgvRacik.Rows[i].Cells[3].Value.ToString()
                        //);
                        //}
                    }
                    var dh = new dataset.yakkumdbTableAdapters.fa_rx_resep_dTableAdapter();
                    if (_template == 2)
                    {
                        dh.UpdateQuery(
                            Double.Parse(txtJumlah.Text),
                            cmbSatuan.Text,
                            txtdd1.Text,
                            txtdd2.Text,
                            cmbSatuanDosis.Text,
                            txtSignalain.Text,
                            _koderxd,
                            _nourut
                            );
                    }
                    else
                    {
                        dh.InsertQuery
                        (_koderx,
                        _koderxd,
                        "999999",
                        _kracik,
                        true,
                        txtSignalain.Text,
                        _btIter,
                        _jmliter,
                        false,
                        Int32.Parse(txtJumlah.Text),
                        _kdokter,
                        _nourut,
                        txtdd1.Text,
                        txtdd2.Text,
                        cmbSatuan.Text,
                        _namaracikan,
                        cmbSatuanDosis.Text

                        );
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
            }


            //if(cekkelengkapan() == false) { MessageBox.Show("Salah"); }
            //if (cekkelengkapan() == true) 
            //{
                
            //}
            ////if (txtJumlah.Text == "")
            ////{
            ////    MessageBox.Show("Masukkan Jumlah Racikan");
            ////}
            ////if(cmbSatuanDosis.SelectedIndex == -1)
            ////{
            ////    MessageBox.Show("Pilih Satuan Dosis");
            ////}
            //else
            //{
               
            //}
        }

        private void dgvRacik_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0

            if (e.ColumnIndex == 4)
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
        private Boolean cekkelengkapan()
        {
            if (txtJumlah.Text == "")
            {
                MessageBox.Show("Masukan Jumlah Obat");
                return false;
            }
            //else if (cmbSatuanDosis.Text == "")
            //{ MessageBox.Show("Masukan Satuan Dosis"); return false; }
            else if (cmbSatuan.Text == "")
            { MessageBox.Show("Masukan Satuan Jumlah Obat"); return false; }

            else if (dgvRacik.Rows.Count < 2)
            {
                MessageBox.Show("Masukan Obat Racikan");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void load_Template()
        {
            // TODO : _template: 0 = reguler, 1 = template, 2 = edit
            //MessageBox.Show("Show");
            if (_template == 1)
            {
               // MessageBox.Show(_namaracikan.Substring(0, _namaracikan.Length - 3) + "0106");
                var dh = new dataset.yakkumdbTableAdapters.fa_rx_template_racikanTableAdapter();
                dh.FillByTempDokter(yakkumdb.fa_rx_template_racikan, _namaracikan.Substring(0, _namaracikan.Length - 3).TrimStart(), _kdokter, _kodefornas);
                DataTable dt = dh.GetDataByTempDokter(_namaracikan.Substring(0, _namaracikan.Length - 3).TrimStart(), _kdokter, _kdtemplateracikan);

                foreach (DataRow r in dt.Rows)
                {
                    //MessageBox.Show(r["nama_obat"].ToString());
                    
                    DataGridViewRow row = (DataGridViewRow)dgvRacik.Rows[0].Clone();
                    row.Cells[1].Value = r["nama_obat"].ToString();
                    row.Cells[2].Value = r["dosis"].ToString();
                    row.Cells[3].Value = r["satuan"].ToString();
                    row.Cells[5].Value = r["kode_obat"].ToString();
                   
                    dgvRacik.Rows.Add(row);
                }
            }
            if (_template == 2)
            {
                var dt = new dataset.yakkumdbTableAdapters.fa_rx_racikanTableAdapter();
                var dh = new dataset.yakkumdbTableAdapters.fa_rx_resep_dTableAdapter();
                DataRow dr = dh.GetDataByRXD(_koderxd).Rows[0];
                //Obat.Text = dr["vc_namaobat"].ToString();
                //lblkodeobat.Text = dr["vc_kode_obat"].ToString();
                txtdd1.Text = dr["nvc_dd1"].ToString();
                txtdd2.Text = dr["nvc_dd2"].ToString();
                txtJumlah.Text = dr["num_jml"].ToString();
                txtSignalain.Text = dr["vc_signalain"].ToString();
                cmbSatuanDosis.Text = dr["vc_satuan_dosis"].ToString();
                cmbSatuan.Text = dr["vc_satuan"].ToString();

                DataTable t = dt.GetDataByKodeRD(_koderxd);
                foreach (DataRow r in t.Rows)
                {
                    DataGridViewRow row = (DataGridViewRow)dgvRacik.Rows[0].Clone();
                    row.Cells[1].Value = r["vc_nama_obat"].ToString();
                    row.Cells[2].Value = r["vc_dosis"].ToString();
                    row.Cells[3].Value = r["vc_satuan"].ToString();
                    row.Cells[5].Value = r["vc_k_obat"].ToString();

                    dgvRacik.Rows.Add(row);
                }
            }

            else {
                // MessageBox.Show("TEst");
                }
        }

        private void dgvRacik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && !string.IsNullOrEmpty(dgvRacik.Rows[e.RowIndex].Cells[1].Value as string))
            {
                dgvRacik.Rows.Remove(dgvRacik.Rows[e.RowIndex]);
                //if (dgvRacik.Rows[e.RowIndex].Cells[1].Value.ToString() != "")
                //{ dgvRacik.Rows.Remove(dgvRacik.Rows[e.RowIndex]); }
            }
        }
    }
}
