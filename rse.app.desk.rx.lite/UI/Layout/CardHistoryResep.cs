﻿using rse.app.desk.rx.lite.dataset;
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
    
    public partial class CardHistoryResep : UserControl
    {
        public CardHistoryResep()
        {
            InitializeComponent();
        }
        public Variable vr;
        public void setVariable(Variable _vr)
        {
            vr = _vr;
        }


        private DateTime _tglreg;
        private string _namadokter;
        private string _klinik;
        private string _penanggung;
        private string _noreg;
        private string _noresep;

        [Category("Custom Prop")]
        public DateTime TGLReg
        {
            get { return _tglreg; }
            set { _tglreg= value; lblTglReg.Text = value.ToString("dd-MM-yyyy"); }
        }
        [Category("Custom Prop")]
        public string NamaDokter
        {
            get { return _namadokter; }
            set { _namadokter = value; lblNamaDokter.Text = value; }
        }
        [Category("Custom Prop")]
        public string Klinik
        {
            get { return _klinik; }
            set { _klinik = value; lblKlinik.Text = value; }
        }
        [Category("Custom Prop")]
        public string Penanggung
        {
            get { return _penanggung; }
            set { _penanggung = value; lblPenanggung.Text = value; }
        }
        [Category("Custom Prop")]
        public string NoREG
        {
            get { return _noreg; }
            set { _noreg = value;lblNoREG.Text = value;  }
        }
        [Category("Custom Prop")]
        public string NoRSP
        {
            get { return _noresep; }
            set { _noresep = value; btnCopyRsp.Tag = value; }
        }


        public event EventHandler CpyButtonClick
        {
            add { btnCopyRsp.Click += value; }
            remove { btnCopyRsp.Click -= value; }
        }
        
        private void CardHistoryResep_Load(object sender, EventArgs e)
        {
            Variable _variable = new Variable(); _variable._noregis = lblNoREG.Text;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitializeTree();
        }

        //Called from TreeView.BeforeExpand
        private void OnBeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            var currentNode = e.Node;

            //If the current node has already been expanded then we're done
            if (currentNode.Nodes.Count != 1 || GetNodeId(currentNode.Nodes[0]) != 0)
                return;

            //Get the children of this one
            var children = MyDatabase.GetData(GetNodeId(currentNode));
            try
            {
                treeView1.BeginUpdate();

                //Add the new nodes
                currentNode.Nodes.Clear();

                foreach (var child in children)
                    currentNode.Nodes.Add(CreateNode(child));
            }
            finally
            {
                treeView1.EndUpdate();
            };
        }

        private void InitializeTree()
        {
            //Populate the tree with the root items
            var rootItems = MyDatabase.GetData(0);

            try
            {
                treeView1.BeginUpdate();
                foreach (var item in rootItems)
                    treeView1.Nodes.Add(CreateNode(item));
            }
            finally
            {
                treeView1.EndUpdate();
                treeView1.ExpandAll();
            };
        }

        //Helper method to convert the data from the DB to a treenode
        private TreeNode CreateNode(DataRow row)
        {
            var node = new TreeNode() { Text = row.Field<string>("DESEQU") };

            //TODO: For this demo we're just going assign the key of the item to the node but you could store anything
            node.Tag = row.Field<int>("EQUID");

            //TODO: Going with the fast option so we'll create a dummy node
            var child = new TreeNode();
            node.Nodes.Add(child);

            return node;
        }

        //Helper method to get the ID of the node 
        private int GetNodeId(TreeNode node)
        {
            return node.Tag != null ? (int)node.Tag : 0;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //    private void GetOpenedNodesRecursively(TreeView aTreeView)
        //    {
        //        int Y = 0;
        //        foreach(TreeNode n in aTreeView.Nodes)
        //        {
        //            Y += treeView1.ItemHeight;
        //            if(n.IsExpanded )
        //            {
        //                Y += RecursiveYIncrement(n);
        //            }
        //        }
        //    }

        //    private void RecursiveYIncrement(TreeNode n)
        //    {
        //        int Y = 0;
        //        foreach(TreeNode aNode in n.Nodes)
        //        {
        //            Y += treeView1.ItemHeight;
        //            if(aNode.IsExpanded)
        //            {
        //                Y += RecursiveYIncrement(aNode);
        //            }
        //        }
        //    }

    }
    public class Variable
    {
        public string _noregis { get; set; }
        
    }
    //Dummy data manager
    public static class MyDatabase
    {
        //Some dummy data in memory, this would be in your DB normally
        static MyDatabase()
        {
            var dt = new DataTable();
            _data = dt;

            dt.Columns.Add("EQUID", typeof(int));
            dt.Columns.Add("DESEQU", typeof(string));
            var parentColumn = dt.Columns.Add("PEQUID", typeof(int));

            //Data Resep
            var dh = new dataset.yakkumdbTableAdapters.resep_detilTableAdapter();
            var th = new dataset.yakkumdbTableAdapters.fa_rx_racikanTableAdapter();
            // dh.Fill(yakkumdb.resep_detil);

            CardHistoryResep chr = new CardHistoryResep();

            // TODO : Cari cara get variable dari luar class
            MessageBox.Show(chr.Tag.ToString());
            DataTable ds = dh.GetDataByGolongan(chr.Tag.ToString());
            //DataTable ds = dh.GetDataByGolongan("2104050700014");
            foreach (DataRow r in ds.Rows)
            {
                // Rows
                dt.Rows.Add(Int32.Parse(r["kd_golongan"].ToString()), r["golongan_obat"].ToString());
                DataTable ds2 = dh.GetData("2104050700014", r["kd_golongan"].ToString());
                foreach (DataRow d in ds2.Rows)
                {
                    //dt.Rows.Add(10003, d["vc_nama_obat"].ToString(), 31);
                    //MessageBox.Show(d["vc_kode_rx"].ToString().Substring(2)+ d["vc_kode_obat"].ToString());
                    dt.Rows.Add(Int32.Parse( d["in_no_urut"].ToString()+ d["vc_kode_obat"].ToString()), d["vc_nama_obat"].ToString(), Int32.Parse(d["kd_golongan"].ToString()));

                   // MessageBox.Show(d["bt_racikan"].ToString());
                    if((Boolean)d["bt_racikan"] == true)
                    {
                        DataTable tt = th.GetDataByKodeRD(d["vc_kode_rx_d"].ToString());
                        foreach (DataRow t in tt.Rows)
                        {
                           //MessageBox.Show(t["vc_nama_obat"].ToString());
                           dt.Rows.Add(Int32.Parse(t["in_no_urut"].ToString() + t["vc_k_obat"].ToString()), "    "+t["vc_nama_obat"].ToString(), Int32.Parse(d["in_no_urut"].ToString() + d["vc_kode_obat"].ToString()));
                        }
                    }
                }
            }
           
              
            //dt.Rows.Add(10001, "Phase 2");
            //dt.Rows.Add(10002, "MEG Piping System", 10001);
            //dt.Rows.Add(10003, "4 1/2in Piggy-Back Line and Riser", 10002);
            //dt.Rows.Add(10004, "MEG Injection", 10003);
            //dt.Rows.Add(10005, "Flow Transmitter-A", 10003);
            //dt.Rows.Add(10006, "Motor Operated Valve", 10003);
            //dt.Rows.Add(10007, "Switchboard Cubicle", 10004);
            //dt.Rows.Add(10008, "Motor Operated Valve", 10004);
        }

        private static readonly DataTable _data;

        public static string _noreg { get; set; }

        public static IEnumerable<DataRow> GetData(int parentId)
        {
            //TODO: This is where your DB query would be to get only the rows that have the given parent,
            //for this demo I'm just using LINQ against static data
            return from r in _data.Rows.OfType<DataRow>()
                  where (r.Field<int?>("PEQUID") ?? 0) == parentId
                   //where (r.Field<string>("PEQUID") == parentId)
                   select r;
        }

        
    }
}
