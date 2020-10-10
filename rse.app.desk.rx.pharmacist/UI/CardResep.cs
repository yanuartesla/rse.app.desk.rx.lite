using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace rse.app.desk.rx.pharmacist.UI
{
    public partial class CardResep : UserControl
    {
        public CardResep()
        {
            InitializeComponent();
        }
        private string _norm;
        private string _noreg;
        private string _noresep;
        private string _nama;
        private string _tgllhr;
        private string _jeniskelamin;
        private string _alamat;
        private string _namaklinik;



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
        public string NOreg
        {
            get { return _noreg; }
            set { _noreg = value; lblNoreg.Text = value; }
        }
        [Category("Custom Prop")]
        public string NoResep
        {
            get { return _noresep; }
            set { _noresep = value; lblNoResep.Text = value; }
        }
        [Category("Custom Prop")]
        public string tgllahir
        {
            get { return _tgllhr; }
            set { _tgllhr = value; lblTglLahir.Text = value; }
        }
        [Category("Custom Prop")]
        public string jk
        {
            get { return _jeniskelamin; }
            set { _jeniskelamin = value; lblJK.Text = value; }
        }
        [Category("Custom Prop")]
        public string alamat
        {
            get { return _alamat; }
            set { _alamat = value; lblAlamat.Text = value; }
        }
        [Category("Custom Prop")]
        public string namaklinik
        {
            get { return _namaklinik; }
            set { _namaklinik = value; lblNamaKlinik.Text = value; }
        }

        private void CardResep_MouseHover(object sender, EventArgs e)
        {
            this.ForeColor = Color.NavajoWhite;
        }
    }
}
