using rse.app.desk.rx.lite.UI;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static rse.app.desk.rx.lite.UI.Login;

namespace rse.app.desk.rx.lite
{
    public partial class Eprescribe : Form
    {
        private roles _curentRoles { get; set; }
        private string _nid { get; set; }
        public Eprescribe(string nid, roles roles)
        {
            InitializeComponent();
            _nid = nid;
            _curentRoles = roles;
        }

        private void Eprescribe_Load(object sender, EventArgs e)
        {
            logincheck();
            this.rM_KUNJUNGTableAdapter.FillByKlinik(this.yakkumdb.RM_KUNJUNG,_nid,_nid.Substring(0,2)+"00");
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
            flpMenu.Visible = false;
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

            // obat myuc = new obat(_noreg, _kdokter, _kdfornas, _curentRoles);
            obat myuc = new obat(_noreg, _kdokter, _kdfornas);
            myuc.Dock = DockStyle.Fill;
            LoadPanel.Controls.Add(myuc);
            myuc.Show();

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void logincheck()
        {

                switch (_curentRoles)
                {
                    //TODO : atur role
                    case roles.drgigi:
                        this.btnBMHP.Visible = false;
                        this.btnExpertise.Visible = false;
                        this.btEfile.Visible = false;
                        break;
                    
                    default:
                        break;
                }
                
           
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

        private void btnEfile_Click(object sender, EventArgs e)
        {
            Efile ef = new Efile(lblNoreg.Text);
            ef.Show();
        }

        private void btexpertise_Click(object sender, EventArgs e)
        {
            

            if (File.Exists(@"C:\Program Files\HP Inc\Setup_Expertise_Casemix\latih1.exe"))
            {
                Process.Start(@"C:\Program Files\HP Inc\Setup_Expertise_Casemix\latih1.exe");
                            }
            else
            {
                Process.Start(@"C:\Program Files (x86)\HP Inc\Setup_Expertise_Casemix\latih1.exe");
            }

            //Process proc = new Process();
            //ProcessStartInfo psi = new ProcessStartInfo("latih1.exe");
            //psi.WindowStyle = ProcessWindowStyle.Maximized;
            //proc.StartInfo = psi;

            //proc.Start();
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            Expertise ex = new Expertise();
            ex.Show();
        }

        private void btEfile_Click(object sender, EventArgs e)
        {
            Efile ef = new Efile(lblNoreg.Text);
            ef.Show();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            flpMenu.Visible = false;
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

            //obat myuc = new obat(_noreg, _kdokter, _kdfornas,_curentRoles);
            obat myuc = new obat(_noreg, _kdokter, _kdfornas);
            myuc.Dock = DockStyle.Fill;
            LoadPanel.Controls.Add(myuc);
            myuc.Show();
        }

        private void btnExpertise_Click(object sender, EventArgs e)
        {


            if (File.Exists(@"C:\Program Files\HP Inc\Setup_Expertise_Casemix\latih1.exe"))
            {
                Process.Start(@"C:\Program Files\HP Inc\Setup_Expertise_Casemix\latih1.exe");

            }
            else
            {
                Process.Start(@"C:\Program Files (x86)\HP Inc\Setup_Expertise_Casemix\latih1.exe");
            }


            //Process proc = new Process();
            //ProcessStartInfo psi = new ProcessStartInfo("latih1.exe");
            //psi.WindowStyle = ProcessWindowStyle.Maximized;
            //proc.StartInfo = psi;

            //proc.Start();
        }

        private void btnBMHP_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Masih dalam pengembangan...buka aplikasi secara manual");
            //Process proc = new Process();
            //ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\HP\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\HP Incrse.app.desk.rx.nurse.appref-ms");
            //psi.WindowStyle = ProcessWindowStyle.Maximized;
            //proc.StartInfo = psi;
            //proc.Start();
        }

        private void btnDiagnosa_Click(object sender, EventArgs e)
        {
            Diagnosis dg = new Diagnosis();
            dg.Dock = DockStyle.Fill;
            LoadPanel.Controls.Add(dg);
            dg.Show();
        }
    }
}
