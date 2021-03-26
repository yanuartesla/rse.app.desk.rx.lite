using rse.app.desk.rx.lite.dataset;
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
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
        }

        private void Template_Load(object sender, EventArgs e)
        {
            LoadICD10();
            LoadICD9();
        }
        private void txtCariDiagnosa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                var _dh = new dataset.yakkumdbTableAdapters.ICD10_2019_CodesTableAdapter();
                _dh.Fill(yakkumdb.ICD10_2019_Codes, txtCariDiagnosa.Text);
                DataTable dt = _dh.GetData(txtCariDiagnosa.Text);

                foreach (DataRow r in dt.Rows)
                {
                    DataGridViewRow row = (DataGridViewRow)dgvDiagnosa.Rows[0].Clone();
                    row.Cells[1].Value = r["vc_codes"].ToString();
                    row.Cells[2].Value = r["vc_desc_title"].ToString();
                    dgvDiagnosa.Rows.Add(row);
                    txtCariDiagnosa.Clear();

                }
                
            }
        }

        private void txtCariProsedur_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                var _dh = new dataset.yakkumdbTableAdapters.ICD9_CM_2011_Procedure_CodesTableAdapter();
                _dh.Fill(yakkumdb.ICD9_CM_2011_Procedure_Codes, txtCariProsedur.Text);
                DataTable dt = _dh.GetData(txtCariProsedur.Text);

                foreach (DataRow r in dt.Rows)
                {
                    DataGridViewRow row = (DataGridViewRow)dgvProcedure.Rows[0].Clone();
                    row.Cells[1].Value = r["vc_code_sp"].ToString();
                    row.Cells[2].Value = r["vc_long_description"].ToString();
                    dgvProcedure.Rows.Add(row);
                    txtCariProsedur.Clear();
                }

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

        private void dgvDiagnosa_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < 0)
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

        private void LoadICD10()
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(txtNama.Text == "")
            { MessageBox.Show("Masukkan Nama Template"); }
            else
            {
                var dh = new dataset.yakkumdbTableAdapters.fa_rx_templateTableAdapter();
                for (int i = 0; i < dgvDiagnosa.RowCount - 1; i++)
                {
                    if (dgvDiagnosa.Rows[i].Cells[1].Value.Equals(null))
                    {

                    }
                    else
                    {
                        dh.InsertQuery(
                           txtNama.Text,
                           dgvDiagnosa.Rows[i].Cells[1].Value.ToString(),
                           dgvDiagnosa.Rows[i].Cells[2].Value.ToString(),
                           "Diagnosa"
                        );

                    }

                }
                for (int i = 0; i < dgvProcedure.RowCount - 1; i++)
                {
                    if (dgvProcedure.Rows[i].Cells[1].Value.Equals(null))
                    {

                    }
                    else
                    {
                        dh.InsertQuery(
                           txtNama.Text,
                           dgvProcedure.Rows[i].Cells[1].Value.ToString(),
                           dgvProcedure.Rows[i].Cells[2].Value.ToString(),
                           "Prosedur"
                        );

                    }

                }
                this.Close();
            }
            
        }
    }
}
