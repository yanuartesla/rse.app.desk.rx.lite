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
        public JumlahBMHP(string nama, string korx)
        {
            InitializeComponent();
            _namabmhp = nama;
            _koderx = korx;
        }

        private void JumlahBMHP_Load(object sender, EventArgs e)
        {
            this.view_rse_fa_obatTableAdapter.Fill(yakkumdb.view_rse_fa_obat,_namabmhp);
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
                    _koderx + lblKodeObat.Text,
                    12,
                    lblKodeObat.Text,
                    lblNama.Text,
                    Int32.Parse(txtJumlah.Text),
                    lblSatuan.Text,
                    ""
                    );
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
    }
}
