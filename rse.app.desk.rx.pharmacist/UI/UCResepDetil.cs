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
    public partial class UCResepDetil : UserControl
    {
        private string _noresep { get; set; }
        public UCResepDetil(string noresep)
        {
            InitializeComponent();
            _noresep = noresep;
        }

        private void UCResepDetil_Load(object sender, EventArgs e)
        {
            this.resep_detilTableAdapter.FillByNoResep(yakkumdb.resep_detil,_noresep);
            dgvResep.Update();dgvResep.Refresh();
        }
    }
}
