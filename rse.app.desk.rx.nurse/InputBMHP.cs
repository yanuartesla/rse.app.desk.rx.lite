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
using System.Globalization;

namespace rse.app.desk.rx.nurse
{
    
    public partial class InputBMHP : UserControl
    {
        AutoCompleteStringCollection namesCollection =
        new AutoCompleteStringCollection();
        private string _koderx { get; set; }
        private string _kdokter { get; set; }
        public InputBMHP(string kdokter,string koderx)
        {
            InitializeComponent();
            _koderx = koderx;
            _kdokter = kdokter;
        }

        private void InputBMHP_Load(object sender, EventArgs e)
        {
            //insert paket gigi
            var dt = new yakkumdbTableAdapters.bmhpTableAdapter();
            var dt2 = new yakkumdbTableAdapters.resep_waitingTableAdapter();
            var statpaket = dt2.ScalarQueryStatPaket(_koderx);
            var nourut = (int)dt.ScalarNoUrut(_koderx) + 1;
            if (_kdokter.Substring(0, 2) == "12")
            {
                if(statpaket!="PAKET" )
                {
                    this.bmhpTableAdapter.InsertQueryPaketGigi(_koderx, nourut, _kdokter);
                    this.resep_waitingTableAdapter.UpdateQueryStatPaket(_koderx);
                }
                
            }

            SqlDataReader dReader;
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = rse.app.desk.rx.nurse.Properties.Settings.Default.yakkumdatabaseConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText =
            "Select  [vc_namaobat],[vc_kodeobat] from [dbo].[view_rse_fa_obat]" +
            "where [kodefornas] >= " + 3 + "and [vc_golongan] = '31'" +
            "or [vc_kodeobat] = '002241'or [vc_kodeobat] = '002769'or [vc_kodeobat] = '002071'" +
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

            txtcariBMHP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtcariBMHP.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtcariBMHP.AutoCompleteCustomSource = namesCollection;

            this.resep_waitingTableAdapter.FillByKoderesep(this.yakkumdb.resep_waiting, _koderx);

            this.bmhpTableAdapter.Fill(this.yakkumdb.bmhp, _koderx);
            dgvBMHP.Update();
            dgvBMHP.Refresh();

            this.fa_rx_tindakanTableAdapter.Fill(this.yakkumdb.fa_rx_tindakan, _koderx);
            dgvTindakan.Update();
            dgvTindakan.Refresh();

        }

        private void txtcariBMHP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var dt =new yakkumdbTableAdapters.bmhpTableAdapter();
                
                var nourut = (int)dt.ScalarNoUrut(_koderx) + 1;
                JumlahBMHP jj = new JumlahBMHP(txtcariBMHP.Text,_koderx,_kdokter,nourut);
                var result = jj.ShowDialog();
                if(result == DialogResult.OK)
                {
                    this.bmhpTableAdapter.Fill(yakkumdb.bmhp, _koderx);
                    dgvBMHP.Update();
                    dgvBMHP.Refresh();
                }
            }
        }

        private void dgvTindakan_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            string titleText = dgvTindakan.Columns[1].HeaderText;
            if (titleText.Equals("Nama Tindakan"))
            {
                TextBox autoText = e.Control as TextBox;
                if (autoText != null)
                {
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest;
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                    addItems(DataCollection);
                    autoText.AutoCompleteCustomSource = DataCollection;
                }
            }
        }

        public void addItems(AutoCompleteStringCollection col)
        {

            SqlDataReader dReader;
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = rse.app.desk.rx.nurse.Properties.Settings.Default.yakkumdatabaseConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText =
            "SELECT distinct [VC_Nm_Tarip] FROM [yakkumdatabase].[dbo].[KeuTarip] where VC_Kd_Beban = 20 ";
            conn.Open();
            dReader = cmd.ExecuteReader();
            if (dReader.HasRows == true)
            {
                while (dReader.Read())
                    col.Add(dReader["VC_Nm_Tarip"].ToString());
            }
            else
            {
                MessageBox.Show("Data not found");
            }

            dReader.Close();
            conn.Close();
            //col.Add("Product 1");
            //col.Add("Product 2");
            //col.Add("Product 3");
            //col.Add("Product 4");
            //col.Add("Product 5");
            //col.Add("Product 6");
        }

        private void dgvTindakan_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);

            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            var dt = new yakkumdbTableAdapters.fa_rx_tindakanTableAdapter();
            for (int i = 0; i < dgvTindakan.RowCount - 1; i++)
            {

                // if (dgvTindakan.Rows[i].Cells[1].Value.Equals(null))

                if (dgvTindakan.Rows[i].Cells[1].Value != null)
                {
                    dt.DeleteTindakan(_koderx);
                    dt.InsertQuery(
                        _koderx,
                        dgvTindakan.Rows[i].Cells[1].Value.ToString()
                        );
                }
                else
                {
                    
                }
            }

            var dh = new yakkumdbTableAdapters.resep_waitingTableAdapter();
            dh.UpdateQuery(_koderx);
            MessageBox.Show("Data Berhasil di Simpan");
            this.Controls.Clear();
        }

        private void dgvBMHP_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 4)
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

        private void dgvBMHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             var rxd = new yakkumdbTableAdapters.bmhpTableAdapter();
            if (e.RowIndex < 0)
                return;

           

            if (e.ColumnIndex == 4)
            {
                // Deleted event
                var val2 = this.dgvBMHP[6, e.RowIndex].Value.ToString();
                var val = this.dgvBMHP[5, e.RowIndex].Value.ToString();
                rxd.DeleteQuery(val);


                this.bmhpTableAdapter.Fill(this.yakkumdb.bmhp, val2);
                this.dgvBMHP.Update();
                this.dgvBMHP.Refresh();
               // MessageBox.Show("Deleted! " + val);
            }
        }

        private void dgvBMHP_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);

            }
        }
    }
}
