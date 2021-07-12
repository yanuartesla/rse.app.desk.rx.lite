using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rse.app.desk.rx.lite.UI
{
    public partial class NoDrugDialog : Form
    {
        private string _kdresep;
        public NoDrugDialog(string kdresep)
        {
            InitializeComponent();
            _kdresep = kdresep;
            rbTanpaObat.Checked = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var dh = new dataset.yakkumdbTableAdapters.resep_hTableAdapter();
            if (rbTanpaObat.Checked == true)
            { dh.UpdateTanpaObat(rbTanpaObat.Text,true, _kdresep); }
            else if (rbRujuk.Checked == true)
            { dh.UpdateTanpaObat(rbRujuk.Text, true, _kdresep); }
            else if (rbOpname.Checked == true)
            { dh.UpdateTanpaObat(rbOpname.Text, true, _kdresep); }
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
