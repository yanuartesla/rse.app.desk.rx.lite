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
            if (txtJumlah.Text == "")
            {
                MessageBox.Show("Masukan Jumlah Alat");
            }
            else
            {
                var bm = new yakkumdbTableAdapters.bmhpTableAdapter();
                bm.InsertQuery(
                    _koderx,
                    "AL"+_koderx.Substring(2) + lblKodeObat.Text,
                    _nourut,
                    lblKodeObat.Text,
                    lblNama.Text,
                    Int32.Parse(txtJumlah.Text),
                    lblSatuan.Text,
                    _kdokter
                    );
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
    }
}
