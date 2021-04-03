using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rse.app.desk.rx.lite.UI.Layout
{
    public partial class CardPasien : UserControl
    {
        public CardPasien()
        {
            InitializeComponent();
        }

        private string _norm;
        private string _nama;
        private string _umur;
        private string _jk;
        private string _penanggung;
        private string _noantrian;
        private Boolean _btkary;


        [Category("Custom Prop")]
        public string NoRM
        {
            get { return _norm; }
            set { _norm = value; lblNoRM.Text = value; }
        }
        [Category("Custom Prop")]
        public string Nama
        {
            get { return _nama; }
            set { _nama = value; lblNama.Text = value; }
        }
        [Category("Custom Prop")]
        public string Umur
        {
            get { return _umur; }
            set { _umur = value; lblUmur.Text = value ; }
        }

        [Category("Custom Prop")]
        public string JK
        {
            get { return _jk; }
            set { _jk = value;
                switch (_jk)
                {
                    case "L":
                        pbJenisKelamin.Image = Properties.Resources.pharmacist_male_128;
                        break;
                    case "P":
                        pbJenisKelamin.Image = Properties.Resources.pharmacist_female_128;
                        break;
                    default:
                        //pbJenisKelamin.Image = Properties.Resources.image_search;
                        break;
                }

            }
        }

        [Category("Custom Prop")]
        public string Penanggung
        {
            get { return _penanggung; }
            set { _penanggung = value; txtPenanggung.Text = value; }
        }

        [Category("Custom Prop")]
        public string NoAntrian
        {
            get { return _noantrian; }
            set { _noantrian = value; lblNoAntrian.Text = value; }
        }

        [Category("Custom Prop")]
        public bool btKaryawan
        {
            get { return _btkary; }
            set { _btkary = value; switch (_btkary)
                {
                    case true:
                        lblKaryawan.Visible = true;
                        break;
                    
                    default:
                        lblKaryawan.Visible = false;
                        break;
                }
            }
        }


        private void CardPasien_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Bisque;
        }

        private void CardPasien_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.SeaShell;
        }

        
    }
}
