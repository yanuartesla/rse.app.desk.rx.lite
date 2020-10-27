using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace rse.app.desk.rx.lite.UI
{

    public partial class dosis : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int left,
           int top,
           int right,
           int bottom,
           int width,
           int height
          );
        public String _nmobat { get; set; }
        private String _kobat { get; set; }
        private decimal _retriksi { get; set; }
        private String _norx { get; set; }
        private Boolean _btIter { get; set; }
        private Boolean _btFav { get; set; }
        private string _kdokter { get; set; }
        private decimal _jmliter { get; set; }
        private int _nourut { get; set; }

        public dosis(string namaobat, string norx, string kodedokter, int nourut)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 64, 64));
            _nmobat = namaobat;
            _norx = norx;
            _kdokter = kodedokter;
            _nourut = nourut;
        }

        private void dosis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yakkumdb.view_rse_fa_obat' table. You can move, or remove it, as needed.
            this.view_rse_fa_obatTableAdapter.Fill(this.yakkumdb.view_rse_fa_obat);
            // TODO: This line of code loads data into the 'yakkumdb.view_rse_fa_obat' table. You can move, or remove it, as needed.
            this.view_rse_fa_obatTableAdapter.FillByNamaObat(this.yakkumdb.view_rse_fa_obat, _nmobat);


            dataset.yakkumdbTableAdapters.view_rse_fa_obatTableAdapter da = new dataset.yakkumdbTableAdapters.view_rse_fa_obatTableAdapter();

            DataTable dt = da.GetDataByNamaObat(_nmobat);
            foreach (DataRow r in dt.Rows)
            {

                _retriksi = r.Field<decimal>(0);
                _kobat = r.Field<string>(3);

                if (_retriksi == 999)
                {
                    retensi.Visible = false;
                }
                else { }

            }
            bsObat.Filter = "vc_namaobat = '" + Obat.Text + "'";
            retensi.Text = "Retriksi : " + retensi.Text + " / kasus";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
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
            if (checkretriksi() == true)
            {

                var dh = new dataset.yakkumdbTableAdapters.fa_rx_resep_dTableAdapter();
                dh.InsertQuery
                    (_norx,
                    _norx + _kobat,
                    _kobat,
                    "",
                    false,
                    txtSignalain.Text,
                    _btIter,
                    _jmliter,
                    _btFav,
                    Int32.Parse(txtJumlah.Text),
                    _kdokter,
                    _nourut,
                    txtdd1.Text,
                    txtdd2.Text,
                    lblSatuan.Text,
                    Obat.Text,
                    cmbSatuanDosis.Text

                    );
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }



        private void favCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EtherCheck.Checked)
            {
                _btFav = true;
            }
            else if (!EtherCheck.Checked)
            {
                _btFav = false;
            }
        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private Boolean checkretriksi()
        {


            if (txtJumlah.Text == "")
            {
                MessageBox.Show("Masukan Jumlah Obat");
                return false;
            }
            if (cmbSatuanDosis.Text == "")
            { MessageBox.Show("Masukan Satuan Dosis"); return false; }
            else
            {
                var _jml = Int32.Parse(txtJumlah.Text);
                if (_jml > _retriksi)
                {
                    MessageBox.Show("Jumlah " + _jml.ToString() + " melebihi Retriksi Obat");
                    return false;
                }
                else { return true; }
            }

        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {
            checkretriksi();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Obat_Click(object sender, EventArgs e)
        {

        }

        private void bsObat_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblkodeobat_Click(object sender, EventArgs e)
        {

        }

        private void numiter_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numDD2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numDD1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSignalain_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void retensi_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }
    }
}
