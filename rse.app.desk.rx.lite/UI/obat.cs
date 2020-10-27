using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace rse.app.desk.rx.lite.UI
{
    public partial class obat : UserControl
    {
        public string _kodeobat { get; set; }
        public int _kodefornas { get; set; }
        public string _noreg { get; set; }
        public string _kdokter { get; set; }
        public string[] _listobat { get; set; }
        public string[] _listobatdetil { get; set; }

        AutoCompleteStringCollection namesCollection =
        new AutoCompleteStringCollection();
        public obat(string noreg, string kdokter, int kfornas)
        {
            InitializeComponent();
            _kodefornas = kfornas;
            _noreg = noreg;
            _kdokter = kdokter;

        }

        private void txtCariObat_Load(object sender, EventArgs e)
        {

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



        }


        private void txtCariObat_KeyDown(object sender, KeyEventArgs e)
        {

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
                MessageBox.Show(_listobatdetil.ToString());
                if (_listobat.Contains(txtCariObat.Text.ToUpper()) == false)
                { MessageBox.Show("Pastikan Nama Obat Sesuai !!", "Important Message"); }
                //else if (_listobatdetil.Contains(txtCariObat.Text.ToUpper()) == false)
                //{ MessageBox.Show("Obat Sudah Berada di Resep, Edit untuk melakukan perubahan."); }
                else
                {

                    var _maxno = (int)_resepdetail.ScalarQueryMaxNoUrutResep(lblKodeRtx.Text) + 1;
                    //MessageBox.Show(_maxno.ToString());
                    _kodeobat = txtCariObat.Text;
                    dosis ds = new dosis(_kodeobat, lblKodeRtx.Text, _kdokter, _maxno);
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
        private void txtCariObat_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvResep_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 15;//Properties.Resources.pencil.Width;
                var h = 15;// Properties.Resources.pencil.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.pencil, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 7)
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
            if (e.RowIndex < 0)
                return;

            //I suposed you want to handle the event for column at index 1
            if (e.ColumnIndex == 6)
            {
                var val = this.dgvResep[1, e.RowIndex].Value.ToString();
                MessageBox.Show("Edited! " + val);
            }

            if (e.ColumnIndex == 7)
            {
                var val = this.dgvResep[1, e.RowIndex].Value.ToString();
                MessageBox.Show("Deleted! " + val);
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
            // MessageBox.Show(nurs.ToString());
            Racikan rc = new Racikan(_kodefornas, _namaracikan, _koderacikan, lblKodeRtx.Text, cs.ToString(), _kdokter, nurs);
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
                dh.UpdateStatus("WAITING", 2, DateTime.UtcNow, lblKodeRtx.Text);
            }
            if (result == DialogResult.No)
            {
                dh.UpdateStatus("ORDER", 3, DateTime.UtcNow, lblKodeRtx.Text);
            }

            MessageBox.Show("Resep Berhasil di Simpan");
            Eprescribe ep = new Eprescribe(_kdokter);
            ep.Show();
        }

        private void dgvResep_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
