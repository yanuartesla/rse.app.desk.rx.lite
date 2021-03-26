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
    
    public partial class AddData : Form
    {
        public string _noreg { get; set; }
        public string _kodedokter { get; set; }

        public int _kodeFornas { get; set; }

        public string _kodeKlinik { get; set; }

        public string _koderesep { get; set; }
        public string _nik { get; set; }

        

        public AddData(string NoReg, string KodeKlinik, string KodeDokter)
        {
            InitializeComponent();
            _noreg = NoReg;
            _kodeKlinik = KodeKlinik;
            _kodedokter = KodeDokter;
            
     
        }

        private void AddData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yakkumdb.fa_rx_diagnosa' table. You can move, or remove it, as needed.
            this.fa_rx_diagnosaTableAdapter.FillByNoReg(this.yakkumdb.fa_rx_diagnosa,_noreg);

            this.pasienTableAdapter.FillByNoreg(this.yakkumdb.Pasien,_noreg);

            this.rJ_cpptTableAdapter.Fill(this.rmdb.RJ_cppt, _noreg);
            //TODO : ganti fornas variable
            DataRow dr = this.pasienTableAdapter.GetDataByNoreg( _noreg).Rows[0];
            string png = dr["VC_K_INSTANSI"].ToString();
            var stkary = (Boolean)dr["bt_kary"];
            switch(png)
            {
                case "323":
                    if (stkary == true) { _kodeFornas = 2; }
                    else { _kodeFornas = 3; }
                    break;
                default:
                    _kodeFornas = 0;
                    break;
            }

            obat _obat = new obat(_noreg, _kodedokter, _kodeFornas);
            _obat.Dock = DockStyle.Fill;
            tbResepBody.Controls.Add(_obat);

            _koderesep = "RX" + _noreg + _kodedokter;

            LoadICD10();
            LoadICD9();
            LoadTemplate();
            
        }
        private void LoadTemplate()
        {
            Guna.UI2.WinForms.Guna2Button button = new Guna.UI2.WinForms.Guna2Button();
            var dh = new dataset.yakkumdbTableAdapters.fa_rx_templateTableAdapter();
            dh.FillByDistinct(yakkumdb.fa_rx_template);
            DataTable dt = dh.GetDataByDistinct();

            foreach (DataRow r in dt.Rows)
            {
                button.Tag = r["nama_template"].ToString();
                button.Text = r["nama_template"].ToString();
                button.AutoRoundedCorners = true;
                button.AutoSize = true;
                flowLayoutPanel1.Controls.Add(button);
                button.Click += button_MouseCliked;
            }
            
        }
        private void button_MouseCliked(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button bt = (Guna.UI2.WinForms.Guna2Button)sender;
            var _filter = bt.Tag.ToString();

            var dh = new dataset.yakkumdbTableAdapters.fa_rx_templateTableAdapter();
            dh.FillByNamaJEnis(yakkumdb.fa_rx_template,_filter, "Diagnosa");
            DataTable dt = dh.GetDataByNamaJenis(_filter, "Diagnosa");

            

            foreach (DataRow r in dt.Rows)
            {
                DataGridViewRow row = (DataGridViewRow)dgvDiagnosa.Rows[0].Clone();
                row.Cells[1].Value = r["icd_code"].ToString();
                row.Cells[2].Value = r["icd_desc"].ToString();
                dgvDiagnosa.Rows.Add(row);
            }

            dh.FillByNamaJEnis(yakkumdb.fa_rx_template, _filter, "Prosedur");
            DataTable dt2 = dh.GetDataByNamaJenis(_filter, "Prosedur");

           

            foreach (DataRow r in dt2.Rows)
            {
                DataGridViewRow row2 = (DataGridViewRow)dgvProcedure.Rows[0].Clone();
                row2.Cells[1].Value = r["icd_code"].ToString();
                row2.Cells[2].Value = r["icd_desc"].ToString();
                dgvProcedure.Rows.Add(row2);
            }

        }
            private void LoadICD10 ()
        {

            List<string> _icd10 = new List<string>();
            SqlDataReader dReader;
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = rse.app.desk.rx.lite.Properties.Settings.Default.yakkumdatabaseConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText =
            "Select  [vc_code_desc] from [dbo].[ICD10_2019_Codes] where [bt_valid_coding] = 1";
            
            conn.Open();
            dReader = cmd.ExecuteReader();
            if (dReader.HasRows == true)
            {
                while (dReader.Read())
                    _icd10.Add(dReader["vc_code_desc"].ToString());
            }
            else
            {
                MessageBox.Show("Data not found");
            }

            dReader.Close();
            conn.Close();

            txtCariDiagnosa.Values = _icd10.ToArray();
        }

        private void LoadICD9()
        {

            List<string> _icd9 = new List<string>();
            SqlDataReader dReader;
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = rse.app.desk.rx.lite.Properties.Settings.Default.yakkumdatabaseConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText =
            "Select  [vc_code_desc] from [dbo].[ICD9_CM_2011_Procedure_Codes]";//where [bt_valid_coding] = 1";

            conn.Open();
            dReader = cmd.ExecuteReader();
            if (dReader.HasRows == true)
            {
                while (dReader.Read())
                    _icd9.Add(dReader["vc_code_desc"].ToString());
            }
            else
            {
                MessageBox.Show("Data not found");
            }

            dReader.Close();
            conn.Close();

            txtCariProsedur.Values = _icd9.ToArray();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            tabData.SelectedIndex =
            (tabData.SelectedIndex + 1) % tabData.TabCount;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabData.SelectedIndex =
            (tabData.SelectedIndex - 1) % tabData.TabCount;
        }

        private void btnAnamNext_Click(object sender, EventArgs e)
        {
            tabData.SelectedIndex =
            (tabData.SelectedIndex + 1) % tabData.TabCount;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            LoadHome();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

            UpsertResep();

            var dh = new dataset.yakkumdbTableAdapters.resep_hTableAdapter();
            Pilihan pl = new Pilihan();
            var result = pl.ShowDialog();
            if (result == DialogResult.Yes)
            {
                dh.UpdateStatus("WAITING", 2, DateTime.Now, _koderesep);
            }
            if (result == DialogResult.No)
            {
                dh.UpdateStatus("ORDER", 3, DateTime.Now, _koderesep);
            }

            insertCPPT();
            insertDiagnosa();
            
            MessageBox.Show("Resep Berhasil di Simpan");
            LoadHome();
           
        }
        private void insertDiagnosa()
        {

            var dt = new dataset.rmdbTableAdapters.diagnosa_utamaTableAdapter();
            var ds = new dataset.rmdbTableAdapters.RMIcdSekunderRalanTableAdapter();
            for (int i = 0; i < dgvDiagnosa.RowCount - 1; i++)
            {
                if (dgvDiagnosa.Rows[i].Cells[1].Value.Equals(null))
                {

                }
                if(i==0)
                {
                    dt.InsertQuery(
                        _noreg,
                        txtNoRM.Text,
                        dgvDiagnosa.Rows[i].Cells[2].Value.ToString(),
                        _kodedokter,
                        dgvDiagnosa.Rows[i].Cells[1].Value.ToString()
                         );
                }
                if(i>0)
                {
                    ds.InsertQuery(
                        _noreg,
                        txtNoRM.Text,
                        dgvDiagnosa.Rows[i].Cells[1].Value.ToString(),
                        dgvDiagnosa.Rows[i].Cells[2].Value.ToString(),
                        _kodedokter,
                        "E-Presc"
                        );
                }
            }
                
               
        }
        private void insertCPPT()
        {
            var dt = new dataset.rmdbTableAdapters.RJ_cpptTableAdapter();
            dt.InsertQuery(
                _noreg,
                _nik,
                txtNoRM.Text,
                DateTime.Today.ToString("yyyy-MM-dd"),
                DateTime.Now.ToString("HH:mm:ss"),
                _kodeKlinik,
                _kodedokter,
                txtTensi.Text,
                txtNadi.Text,
                txtSuhu.Text,
                txtPernapasan.Text,
                txtSaturasi.Text,
                rtbRiwayatPenyakit.Text,
                rtbSubyektif.Text,
                rtbCatatan.Text + "BB :" + numBB.ToString(),
                _kodedokter,
                "Dokter"

                ) ;
        }
        private void UpsertResep()
        {
            var dt = new dataset.yakkumdbTableAdapters.resep_hTableAdapter();
            dt.UpsertQuery("RX" + _noreg + _kodedokter,
                _noreg,
                txtNoRM.Text,
                _kodedokter,
                _kodeKlinik,
                "DRAFT"
                );
        }
        private void LoadHome ()
        {
            Home hm = new Home(_kodeKlinik, _kodedokter) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.Controls.Add(hm);
            hm.Show();
        }

        private void btnBackResep_Click(object sender, EventArgs e)
        {
            tabData.SelectedIndex =
            (tabData.SelectedIndex - 1) % tabData.TabCount;
        }


        private void txtCariDiagnosa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewRow row = (DataGridViewRow)dgvDiagnosa.Rows[0].Clone();
                var dh = new dataset.yakkumdbTableAdapters.ICD10_2019_CodesTableAdapter();
                dh.Fill(yakkumdb.ICD10_2019_Codes,txtCariDiagnosa.Text);
                DataTable dt = dh.GetData(txtCariDiagnosa.Text);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {

                        row.Cells[1].Value = r["vc_codes"].ToString();
                        row.Cells[2].Value = r["vc_desc_title"].ToString();

                    }
                }
                else 
                {
                    row.Cells[1].Value = "-";
                    row.Cells[2].Value = txtCariDiagnosa.Text.ToString();
                }
                dgvDiagnosa.Rows.Add(row);
                txtCariDiagnosa.Clear();
            }
        }

        private void dgvDiagnosa_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if(e.RowIndex <0)
            { return; }
            else
            {
                using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
                {
                    e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
                }
            }
            
        }

        private void dgvProcedure_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);

            }
        }

        private void txtCariProsedur_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewRow row = (DataGridViewRow)dgvProcedure.Rows[0].Clone();
                var dh = new dataset.yakkumdbTableAdapters.ICD9_CM_2011_Procedure_CodesTableAdapter();
                dh.Fill(yakkumdb.ICD9_CM_2011_Procedure_Codes, txtCariProsedur.Text);
                DataTable dt = dh.GetData(txtCariProsedur.Text);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        row.Cells[1].Value = r["vc_code_sp"].ToString();
                        row.Cells[2].Value = r["vc_long_description"].ToString();
                    }
                }
                else 
                {
                    row.Cells[1].Value = "-";
                    row.Cells[2].Value = txtCariProsedur.Text.ToString();
                }
                   
                dgvProcedure.Rows.Add(row);
                txtCariProsedur.Clear();
            }
                
        }

        private void dgvCPPTPerawat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0)
                return;

            //I suposed you want to handle the event for column at index 1
            if (e.ColumnIndex == this.dgvCPPTPerawat.Columns["btnCopy"].Index)
            {
                //MessageBox.Show("Mohon Maaf fungsi ini sedang dalam pengembangan..");
                var dp = this.dgvCPPTPerawat.Columns;
                rtbSubyektif.Text = this.dgvCPPTPerawat[dp["subyektifDataGridViewTextBoxColumn"].Index, e.RowIndex].Value.ToString();
                txtTensi.Text = this.dgvCPPTPerawat[dp["tensiDataGridViewTextBoxColumn"].Index, e.RowIndex].Value.ToString(); 
                txtSuhu.Text = this.dgvCPPTPerawat[dp["suhuDataGridViewTextBoxColumn"].Index, e.RowIndex].Value.ToString(); 
                txtNadi.Text = this.dgvCPPTPerawat[dp["nadiDataGridViewTextBoxColumn"].Index, e.RowIndex].Value.ToString(); 
                txtPernapasan.Text = this.dgvCPPTPerawat[dp["pernapasanDataGridViewTextBoxColumn"].Index, e.RowIndex].Value.ToString(); 
                txtSaturasi.Text = this.dgvCPPTPerawat[dp["saturasiDataGridViewTextBoxColumn"].Index, e.RowIndex].Value.ToString(); 
                rtbRiwayatPenyakit.Text = this.dgvCPPTPerawat[dp["riwayatpenyakitDataGridViewTextBoxColumn"].Index, e.RowIndex].Value.ToString(); 
                rtbCatatan.Text = this.dgvCPPTPerawat[dp["catatanDataGridViewTextBoxColumn"].Index, e.RowIndex].Value.ToString(); 
                
                _nik = this.dgvCPPTPerawat[dp["nikDataGridViewTextBoxColumn"].Index, e.RowIndex].Value.ToString();
            }
        }

        private void dgvDiagnosa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == this.dgvDiagnosa.Columns["btnPrimary"].Index)
            {
                //this.dgvDiagnosa.Rows.Insert(0, dgvDiagnosa.Rows[e.RowIndex]);
                //this.dgvDiagnosa.Rows.Remove(dgvDiagnosa.Rows[e.RowIndex]);
                
                
            }
            if (e.ColumnIndex == this.dgvDiagnosa.Columns["btnDelete"].Index)
            {

                this.dgvDiagnosa.Rows.Remove(dgvDiagnosa.Rows[e.RowIndex]);
            }

        }

        private void dgvDiagnosa_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0

            if (e.ColumnIndex == this.dgvDiagnosa.Columns["btnDelete"].Index)
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

        private void dgvProcedure_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0

            if (e.ColumnIndex == this.dgvProcedure.Columns["btnDel"].Index)
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

        private void dgvProcedure_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            
            if (e.ColumnIndex == this.dgvProcedure.Columns["btnDel"].Index)
            {

                this.dgvProcedure.Rows.Remove(dgvProcedure.Rows[e.RowIndex]);
            }

        }

        private void btnTemplate_Click(object sender, EventArgs e)
        {
            Template tmp = new Template();
            tmp.Show();
        }
    }
}
