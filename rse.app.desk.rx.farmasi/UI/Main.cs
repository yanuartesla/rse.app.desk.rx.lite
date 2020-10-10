using rse.app.desk.rx.farmasi.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rse.app.desk.rx.farmasi
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void ListResep_Load(object sender, EventArgs e)
        {
            populateItems();
        }
        private void populateItems()
        {
            CardResep[] cardReseps = new CardResep[20];
            
            for (int i = 0; i < cardReseps.Length; i++)
            {
                cardReseps[i] = new CardResep();
                cardReseps[i].NoRM = "00518035";
                cardReseps[i].Nama = "Yanuar Tesla";
                cardReseps[i].NOreg = "20201009000001";
                cardReseps[i].NoResep = "RX121584553536";
                if (flowLayout.Controls.Count > 0)
                {
                    flowLayout.Controls.Clear();
                }
                flowLayout.Controls.Add(cardReseps[i]);
            }
        }

       
    }
}
