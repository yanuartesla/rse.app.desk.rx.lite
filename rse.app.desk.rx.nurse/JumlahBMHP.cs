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
    public partial class JumlahBMHP : Form
    {
        private string _namabmhp { get; set; }
        private string _koderx { get; set; }
        private string _kdokter { get; set; }
        private int _nourut { get; set; }
        public JumlahBMHP(string nama, string korx, string kdokter, int nourut)
        {
            InitializeComponent();
            _namabmhp = nama;
            _koderx = korx;
            _kdokter = kdokter;
            _nourut = nourut;
        }

        private void JumlahBMHP_Load(object sender, EventArgs e)
        {
            this.view_rse_fa_obatTableAdapter.Fill(yakkumdb.view_rse_fa_obat,_namabmhp);
            this.txtJumlah.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtJumlah.Text == "" || cmbSatuan.SelectedIndex == 0 )
            {
                MessageBox.Show("Masukan Jumlah Alat");
            }
            else
            {

                float _jumlahbmhp = (float)Convert.ToDouble(txtJumlah.Text);
                bool valid = float.TryParse(txtJumlah.Text.ToString(), out _jumlahbmhp);

                var bm = new yakkumdbTableAdapters.bmhpTableAdapter();
                bm.InsertQuery(
                    _koderx,
                    "AL"+_koderx.Substring(2) + lblKodeObat.Text,
                    _nourut,
                    lblKodeObat.Text,
                    lblNama.Text,
                    Math.Round(_jumlahbmhp,4),
                    cmbSatuan.Text,
                    _kdokter
                    );
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void cmbSatuan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
