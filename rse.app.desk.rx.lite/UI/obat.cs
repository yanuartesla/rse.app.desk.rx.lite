using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.VisualStyles;

namespace rse.app.desk.rx.lite.UI
{
    public partial class obat : UserControl
    {
        public String _kodeobat { get; set; }
        public int _kodefornas { get; set; }
        public string _noreg { get; set; }
        public string _kdokter { get; set; }
        AutoCompleteStringCollection namesCollection =
        new AutoCompleteStringCollection();
        public obat(string noreg, string kdokter)
        {
            InitializeComponent();
            _kodefornas = 1;
            _noreg = noreg;
            _kdokter = kdokter;

        }

        private void txtCariObat_Load(object sender, EventArgs e)
        {

            this.fa_rx_resep_dTableAdapter.Fill(this.yakkumdb.fa_rx_resep_d);
            bsResepdetail.Filter = "vc_kode_rx = '"+ lblKodeRtx.Text +"'";
            SqlDataReader dReader;
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = rse.app.desk.rx.lite.Properties.Settings.Default.yakkumdatabaseConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText =
            "Select  [vc_namaobat],[vc_kodeobat] from [dbo].[view_rse_fa_obat]" +
            "where [kodefornas] >= "+ _kodefornas + "and [vc_golongan] = '01'"+
             " or vc_namaobat like '%alat bantu dengar%'"+
               " or vc_namaobat like '%corset%'"+
                "or vc_namaobat like '%Neck Collar%'"+
               " or vc_namaobat like '%kruk%'"+
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
        }

       
        private void txtCariObat_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                _kodeobat = txtCariObat.Text;
                dosis ds = new dosis(_kodeobat, lblKodeRtx.Text);
                var result = ds.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.fa_rx_resep_dTableAdapter.Fill(this.yakkumdb.fa_rx_resep_d);
                    bsResepdetail.Filter = "vc_kode_rx = '" + lblKodeRtx.Text + "'";
                    dgvResep.Update();
                    dgvResep.Refresh();
                }
            }
        }
        private void txtCariObat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }
    }
        
}
