using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rse.app.desk.rx.lite.Fungtion;

namespace rse.app.desk.rx.lite.UI
{
    public partial class Login : Form
    {
        public enum roles
        {
            dokter,
            sysadmin
        }

        public Login()
        {
            InitializeComponent();
        }
        public roles UserRole { get; set; }
       

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DoLogin()
        {
            SimpleAES enc = new SimpleAES();
            dataset.yakkumdbTableAdapters.fa_rx_userTableAdapter ta = new dataset.yakkumdbTableAdapters.fa_rx_userTableAdapter();
            dataset.yakkumdb.fa_rx_userDataTable dt = new dataset.yakkumdb.fa_rx_userDataTable();

            var rv = ta.FillByUser(dt, this.txtUser.Text);
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
                        default:

                            break;
                    }
                    this.DialogResult = DialogResult.OK;
                    //this.usernik = nik;
                    //_usernik = nik;
                    //this.userNIK = nik;
                    this.Close();
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
    }
}
