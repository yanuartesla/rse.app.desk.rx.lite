using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rse.app.desk.rx.pharmacist.UI;

namespace rse.app.desk.rx.pharmacist
{

    internal struct LASTINPUTINFO
    {
        public uint cbSize;
        public uint dwTime;
    }
    public partial class MainForm : Form
    {
        [DllImport("User32.dll")]
        public static extern bool LockWorkStation();
        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO Dummy);
        [DllImport("Kernel32.dll")]
        private static extern uint GetLastError();

        public static uint GetIdleTime()
        {
            LASTINPUTINFO LastUserAction = new LASTINPUTINFO();
            LastUserAction.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(LastUserAction);
            GetLastInputInfo(ref LastUserAction);
            return ((uint)Environment.TickCount - LastUserAction.dwTime);
        }

        public static long GetTickCount()
        {
            return Environment.TickCount;
        }

        public static long GetLastInputTime()
        {
            LASTINPUTINFO LastUserAction = new LASTINPUTINFO();
            LastUserAction.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(LastUserAction);
            if (!GetLastInputInfo(ref LastUserAction))
            {
                throw new Exception(GetLastError().ToString());
            }

            return LastUserAction.dwTime;
        }
        public MainForm()
        {
            InitializeComponent();
            
        }

        public void populateItems()
        {
            //if (flowLayout.Controls.Count > 1)
            //{ playSimpleSound(); }
            //else
            //{
            flowLayout.Controls.Clear();
            var ds = new Dataset.yakkumdbTableAdapters.resep_orderTableAdapter();
                ds.Fill(yakkumdb.resep_order);
                DataTable dt = ds.GetData();
                foreach (DataRow r in dt.Rows)
                {
                    var uc = new CardResep
                    {
                        Tag = r["vc_kode_rx"].ToString(),
                        NoRM = r["vc_no_rm"].ToString(),
                        Nama = r["vc_nama_p"].ToString(),
                        NOreg = r["vc_no_reg"].ToString(),
                        NoResep = r["vc_kode_rx"].ToString(),
                        namaklinik = r["nama_klinik"].ToString(),
                        tgllahir = "tgl.Lahir : " + r["tgllahir"].ToString() + " / " + r["umur"].ToString(),
                        jk = r["vc_jenis_k"].ToString(),
                        alamat = r["alamat"].ToString()
                    };

                    if (flowLayout.Controls.Count < 0)
                    {
                        flowLayout.Controls.Clear();
                    }

                    else
                    {
                        flowLayout.Controls.Add(uc);
                        uc.Click += uc_MouseCliked;
                    }

                }

           // }
            
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yakkumdb.resep_order' table. You can move, or remove it, as needed.
            //this.resep_orderTableAdapter.Fill(this.yakkumdb.resep_order);
            populateItems();
            timerRefresh.Start();
            timerIdle.Start();
            //timerIdle.Enabled = !timerIdle.Enabled;
        }

        private void uc_MouseCliked(object sender, EventArgs e)
        {

            timerRefresh.Stop();
            panelResepD.Controls.Clear();
            UserControl us = (UserControl)sender;
            var _filter = us.Tag.ToString();

           // MessageBox.Show("jadi yess" + _filter);
            UCResepDetil rd = new UCResepDetil(_filter);
            
            rd.Dock = DockStyle.Fill;
            panelResepD.Controls.Add(rd);
            rd.Show();
            rd.Refresh();

            
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            populateItems();
            if (flowLayout.Controls.Count > 0)
            { playSimpleSound(); }
        }



        private void timerIdle_Tick(object sender, EventArgs e)
        {
            if (GetIdleTime() > 7000)  //10 secs, Time to wait before locking
                                       // LockWorkStation();
                timerRefresh.Start();
        }

        private void playSimpleSound()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string fullpath =  @"C:\rse.app.resource\sound\soft-bells-495.wav";
            SoundPlayer simpleSound = new SoundPlayer(fullpath);
            simpleSound.Play();
        }


    }
}
