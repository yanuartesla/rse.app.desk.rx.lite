using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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
        private decimal _retensi { get; set; }
        private String _norx { get; set; }
        private Boolean _btIter { get; set; }
        private Boolean _btFav { get; set; }

        public dosis(string namaobat,string norx)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 64, 64));
            _nmobat = namaobat;
            _norx = norx;
        }

        private void dosis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yakkumdb.view_rse_fa_obat' table. You can move, or remove it, as needed.
            this.view_rse_fa_obatTableAdapter.Fill(this.yakkumdb.view_rse_fa_obat);
            // TODO: This line of code loads data into the 'yakkumdb.view_rse_fa_obat' table. You can move, or remove it, as needed.
            this.view_rse_fa_obatTableAdapter.FillByNamaObat(this.yakkumdb.view_rse_fa_obat, _nmobat);
            retensi.Text = "Retensi : " + retensi.Text + " / kasus";

            dataset.yakkumdbTableAdapters.view_rse_fa_obatTableAdapter da = new dataset.yakkumdbTableAdapters.view_rse_fa_obatTableAdapter();

            DataTable dt = da.GetDataByNamaObat(_nmobat);
            foreach (DataRow r in dt.Rows)
            {
                if (r.Field<float>(0).Equals(null))
                {
                    _retensi = 9999;
                }
                else { _retensi = r.Field<decimal>(0); }
                _kobat = r.Field<string>(3);
                
            }
            bsObat.Filter = "vc_namaobat = '" +Obat.Text+"'";
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
            }
            else if(!EtherCheck.Checked)
            {
                numiter.Visible = false;
                _btIter = false;
            }
        }

        private void numDD1_ValueChanged(object sender, EventArgs e)
        {
            var _jml = numDD1.Value * numDD2.Value;
            if(_jml > _retensi)
            {
                MessageBox.Show("Jumlah " +_jml.ToString()+" melebihi retensi");
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            var dh = new dataset.yakkumdbTableAdapters.fa_rx_resep_dTableAdapter();
            dh.InsertQuery
                (_norx,
                _norx+_kobat,
                _kobat,
                "",
                false,
                numDD1.Value,
                numDD2.Value,
                txtSignalain.Text,
                _btIter,
                numiter.Value,
                _btFav

                );
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void numDD2_ValueChanged(object sender, EventArgs e)
        {
            var _jml = numDD1.Value * numDD2.Value;
            if (_jml > _retensi)
            {
                MessageBox.Show("Jumlah " + _jml.ToString() + " melebihi retensi");
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
    }
}
