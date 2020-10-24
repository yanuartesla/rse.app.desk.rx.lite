using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rse.app.desk.rx.pharmacist.UI
{
    public partial class editObat : Form
    {
        private string _kodeobat { get; set; }
        public editObat(string kodeobat)
        {
            InitializeComponent();
            _kodeobat = kodeobat;
        }

        private void editObat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yakkumdb.resep_detil' table. You can move, or remove it, as needed.
            this.resep_detilTableAdapter.FillByKobat(this.yakkumdb.resep_detil,_kodeobat);
            this.ActiveControl = txtJumlah;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtJumlah.Text == "")
            {
                MessageBox.Show("Masukan Jumlah!!");
            }
            else {
                var rd = new Dataset.yakkumdbTableAdapters.resep_detilTableAdapter();
                rd.UpdateJumlah(Int32.Parse(txtJumlah.Text), _kodeobat);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
    }
}
