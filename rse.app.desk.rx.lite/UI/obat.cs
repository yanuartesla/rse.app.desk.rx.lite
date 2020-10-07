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
        public string _kodeobat { get; set; }
        public int _kodefornas { get; set; }
        public string _noreg { get; set; }
        public string _kdokter { get; set; }
        public string[] _listobat { get; set; }

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

            this.view_resepTableAdapter.Fill(this.yakkumdb.view_resep);
            bs_view_resep.Filter = "vc_kode_rx = '"+ lblKodeRtx.Text +"'";
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
                List<string> daftarobat = new List<string>();
                var dh = new dataset.yakkumdbTableAdapters.view_rse_fa_obatTableAdapter();
                dh.Fill(yakkumdb.view_rse_fa_obat);
                DataTable dt = dh.GetData();
                foreach(DataRow r in dt.Rows)
                {
                    daftarobat.Add(r.Field<string>(4));
                }
                _listobat = daftarobat.ToArray();
                if (_listobat.Contains(txtCariObat.Text.ToUpper()) == false )
                { MessageBox.Show("Pastikan Nama Obat Sesuai !!", "Important Message"); }
                else
                {
                    _kodeobat = txtCariObat.Text;
                    dosis ds = new dosis(_kodeobat, lblKodeRtx.Text,_kdokter);
                    var result = ds.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.view_resepTableAdapter.Fill(this.yakkumdb.view_resep);
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
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 15;//Properties.Resources.pencil.Width;
                var h = 15;// Properties.Resources.pencil.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.pencil, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 6)
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
            if (e.ColumnIndex == 5)
            {
                var val = this.dgvResep[1, e.RowIndex].Value.ToString();
                MessageBox.Show("Edited! " + val);
            }
               
            if (e.ColumnIndex == 6)
            {
                var val = this.dgvResep[1, e.RowIndex].Value.ToString();
                MessageBox.Show("Deleted! " + val);
            }
                
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Racikan  rc = new Racikan("1");
            rc.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
        
}
