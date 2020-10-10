using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rse.app.desk.rx.farmasi.UI
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


        [Category ("Custom Prop")]
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
            set { _noresep = value;lblNoresep.Text = value; }
        }

        
    }
}
