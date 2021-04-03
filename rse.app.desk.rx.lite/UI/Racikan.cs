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
        private int _kodefornas { get; set; }
        private Boolean _btIter { get; set; }
        private decimal _jmliter { get; set; }
        private string _namaracikan { get; set; }
        private string _koderxd { get; set; }
        private string _koderx { get; set; }
        private string _kracik { get; set; }
        private string _kdokter { get; set; }
        private int _nourut { get; set; }

        public Racikan(int kodefornas, string namaracikan, string koderxd, string koderx, string kracik, string kdokter, int nourut)
        {
            InitializeComponent();
            _kodefornas = kodefornas;
            _namaracikan = namaracikan;
            Obat.Text = _namaracikan;
            _koderxd = koderxd;
            _koderx = koderx;
            _kracik = kracik;
            _nourut = nourut;
            _kdokter = kdokter;
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
            if(txtJumlah.Text == "")
            {
                MessageBox.Show("Masukkan Jumlah Racikan");
            }
            //if(cmbSatuanDosis.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Pilih Satuan Dosis");
            //}
            else
            {
                var dt = new dataset.yakkumdbTableAdapters.fa_rx_racikanTableAdapter();
                for (int i = 0; i < dgvRacik.RowCount - 1; i++)
                {

                    if (dgvRacik.Rows[i].Cells[1].Value.Equals(null))
                    {

                    }
                    else
                    {
                        dt.InsertQuery(
                           _koderxd,
                           i + 1,
                           dgvRacik.Rows[i].Cells[5].Value.ToString(),
                           dgvRacik.Rows[i].Cells[1].Value.ToString(),
                           dgvRacik.Rows[i].Cells[2].Value.ToString(),
                           dgvRacik.Rows[i].Cells[3].Value.ToString()
                        );

                    }

                }
                var dh = new dataset.yakkumdbTableAdapters.fa_rx_resep_dTableAdapter();
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
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
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
            else if (cmbSatuanDosis.Text == "")
            { MessageBox.Show("Masukan Satuan Dosis"); return false; }
            else if (cmbSatuan.Text == "")
            { MessageBox.Show("Masukan Satuan Jumlah Obat"); return false; }
            else
            {
                return true;
            }
        }
    }
}
