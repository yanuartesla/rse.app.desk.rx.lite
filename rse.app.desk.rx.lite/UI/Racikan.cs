using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rse.app.desk.rx.lite.UI
{
    public partial class Racikan : Form
    {
        AutoCompleteStringCollection namesCollection =
        new AutoCompleteStringCollection();
        private  string _kodefornas { get; set; }
        private Boolean _btIter { get; set; }
        private decimal _jmliter { get; set; }
        public Racikan(String kodefornas)
        {
            InitializeComponent();
            _kodefornas = kodefornas;
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
            "where [kodefornas] >= " + _kodefornas + "and [vc_golongan] = '01'"+
           
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
            dgvRacik.Rows.Add(row);
        }

        private void dgvRacik_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
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
            
        }
    }
}
