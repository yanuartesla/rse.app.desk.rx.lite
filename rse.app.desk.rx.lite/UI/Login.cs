using rse.app.desk.rx.lite.Fungtion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rse.app.desk.rx.lite.UI
{
    public partial class Login : Form
    {
        public enum roles
        {
            dokter,
            drgigi,
            sysadmin
        }

        public Login()
        {
            InitializeComponent();
            this.txtPass.KeyDown += txtPass_KeyDown;
            this.txtUser.KeyDown += txtUser_KeyDown;
            loadUser();
        }
        public roles UserRole { get; set; }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadUser()
        {
            List<string> _user = new List<string>();
            SqlDataReader dReader;
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = rse.app.desk.rx.lite.Properties.Settings.Default.yakkumdatabaseConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText =
            "Select  d.vc_nama_kry from [yakkumdatabase].[dbo].[fa_rx_user] u , [yakkumdatabase].[dbo].SDMDOKTER d where d.vc_nid = u.vc_nid";

            conn.Open();
            dReader = cmd.ExecuteReader();
            if (dReader.HasRows == true)
            {
                while (dReader.Read())
                    _user.Add(dReader["vc_nama_kry"].ToString());
            }
            else
            {
                MessageBox.Show("Data not found");
            }

            dReader.Close();
            conn.Close();

            txtUserSearch.Values = _user.ToArray();
        }
        private void DoLogin()
        {
            SimpleAES enc = new SimpleAES();
            dataset.yakkumdbTableAdapters.fa_rx_userTableAdapter ta = new dataset.yakkumdbTableAdapters.fa_rx_userTableAdapter();
            dataset.yakkumdb.fa_rx_userDataTable dt = new dataset.yakkumdb.fa_rx_userDataTable();

            var rv = ta.FillByNama(dt, this.txtUserSearch.Text);
            //string passwd = ta.GetPasswd(this.textBoxUser.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Pengguna Tidak Diketahui.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string nid = dt.Rows[0]["vc_nid"].ToString();
                //kirim parameter nid

                string passwd = dt.Rows[0]["vc_password"].ToString();
                var pwd = enc.DecryptString(passwd);
                if (pwd == this.txtPass.Text)
                {
                    string r = dt.Rows[0]["vc_role"].ToString();
                    switch (r)
                    {
                        case "dokter":
                            this.UserRole = roles.dokter;
                            break;
                        case "sysadmin":
                            this.UserRole = roles.sysadmin;
                            break;
                        case "drgigi":
                            this.UserRole = roles.drgigi;
                            break;
                        default:
                            break;
                    }
                    //this.DialogResult = DialogResult.OK;
                    //this.usernik = nik;
                    //_usernik = nik;
                    //this.userNIK = nik;
                    this.Hide();
                    //Eprescribe ep = new Eprescribe(nid,UserRole);
                    //ep.ShowDialog();
                    MainMenu mm = new MainMenu(nid);
                    mm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password Salah.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoLogin();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SimpleAES enc = new SimpleAES();
            txtpassstring.Text = enc.EncryptString(txtUser.Text);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SimpleAES enc = new SimpleAES();
            txtdecrpit.Text = enc.DecryptString(txtpassstring.Text);
        }

        private void txtUserSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtPass.Clear();
                this.txtPass.Focus();
            }
        }

        private void cbSaveLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSaveLogin.Checked)
            {
                //MessageBox.Show(this.txtUserSearch.Text);
                Properties.Settings.Default.strUser = this.txtUserSearch.Text;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.strPass = this.txtPass.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.txtUserSearch.Text = Properties.Settings.Default.strUser;
            this.txtPass.Text = Properties.Settings.Default.strPass;
        }

        private void txtUserSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtUserSearch.Clear();
        }
    }
}
