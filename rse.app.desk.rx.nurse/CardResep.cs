using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rse.app.desk.rx.nurse
{
    public partial class CardResep : UserControl
    {
        public CardResep()
        {
            InitializeComponent();
        }
        private string _norm;
        private string _dokter;
        private string _sep;
        private string _noresep;
        private string _nama;
        private string _klinik;


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
        public string NoResep
        {
            get { return _noresep; }
            set { _noresep = value; lblNoResep.Text = value; }
        }
       
        [Category("Custom Prop")]
        public string namaklinik
        {
            get { return _klinik; }
            set { _klinik = value; lblklinik.Text = value; }
        }

        [Category("Custom Prop")]
        public string Dokter
        {
            get { return _dokter; }
            set { _dokter = value; lblDokter.Text = value; }
        }
        [Category("Custom Prop")]
        public string SEP
        {
            get { return _sep; }
            set { _sep = value; lblSEP.Text = value; }
        }
    }
}
