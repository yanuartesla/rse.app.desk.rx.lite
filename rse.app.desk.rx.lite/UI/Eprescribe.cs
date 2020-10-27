using rse.app.desk.rx.lite.UI;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace rse.app.desk.rx.lite
{
    public partial class Eprescribe : Form
    {
        private string _nid { get; set; }
        public Eprescribe(string nid)
        {
            InitializeComponent();
            _nid = nid;
        }

        private void Eprescribe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yakkumdb.RM_KUNJUNG' table. You can move, or remove it, as needed.
            this.rM_KUNJUNGTableAdapter.FillByKlinik(this.yakkumdb.RM_KUNJUNG,_nid);
            switch (txtJnsK.Text)
            {
                case "L":
                    pictureBox2.Image = Properties.Resources.pharmacist_male;
                    break;
                case "P":
                    pictureBox2.Image = Properties.Resources.pharmacist_female;
                    break;
                default:
                    pictureBox2.Image = Properties.Resources.image_search;
                    break;
            }
            if (stKary.Text == "TRUE") { lblKary.Visible = true; }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            //LoadPanel.Width = 100;
            LoadPanel.Dock = DockStyle.Right;

            NavPanel.Dock = DockStyle.Fill;
            LoadPanel.Width = 100;
            rMKUNJUNGBindingSource.Filter = "vc_nama_p like '%" + guna2TextBox1.Text + "%' or vc_no_rm like '%" + guna2TextBox1.Text + "%'";
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            NavPanel.Dock = DockStyle.Left;
            LoadPanel.Dock = DockStyle.Fill;
            NavPanel.Width = 300;
        }

        private void guna2TextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //LoadPanel.Dock = DockStyle.Right;
            //LoadPanel.Width = 100;
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NavPanel.Width = 300;
            NavPanel.Dock = DockStyle.Left;
            LoadPanel.Dock = DockStyle.Fill;
        }

        private void btnAddRx_Click(object sender, EventArgs e)
        {
            btnAddRx.Visible = false;
            btnGambar.Visible = false;
            var _noreg = lblNoreg.Text;
            var _kdokter = lblkdokter.Text;
            var _kdfornas = 3;
            if (stKary.Text == "TRUE") { _kdfornas = 2; }

            var dt = new dataset.yakkumdbTableAdapters.resep_hTableAdapter();
            dt.UpsertQuery("RX" + _noreg + _kdokter,
                _noreg,
                NoRM.Text,
                lblkdokter.Text,
                lblKlinik.Text,
                "DRAFT"
                );

            obat myuc = new obat(_noreg, _kdokter, _kdfornas);
            myuc.Dock = DockStyle.Fill;
            LoadPanel.Controls.Add(myuc);
            myuc.Show();

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnGambar_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Process.Start("http://192.168.10.40/efile/irj/");
        }

        private void lblNoreg_Click(object sender, EventArgs e)
        {

        }

        private void NoRM_Click(object sender, EventArgs e)
        {

        }



        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (txtJnsK.Text)
            {
                case "L":
                    pictureBox2.Image = Properties.Resources.pharmacist_male;
                    break;
                case "P":
                    pictureBox2.Image = Properties.Resources.pharmacist_female;
                    break;
                default:
                    pictureBox2.Image = Properties.Resources.image_search;
                    break;
            }
            if (stKary.Text == "TRUE") { lblKary.Visible = true; }

        }

        private void guna2TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            LoadPanel.Dock = DockStyle.Right;
            NavPanel.Dock = DockStyle.Fill;
            LoadPanel.Width = 100;
        }
    }
}
