using rse.app.desk.rx.lite.dataset;
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

        private void CardHistoryResep_Load(object sender, EventArgs e)
        {
            
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
           // dh.Fill(yakkumdb.resep_detil);
            DataTable ds = dh.GetDataByGolongan();
            foreach (DataRow r in ds.Rows)
            {
                // Rows
                dt.Rows.Add(Int32.Parse(r["vc_golongan"].ToString()), r["golongan_obat"].ToString());
                DataTable ds2 = dh.GetData(r["vc_golongan"].ToString());
                foreach (DataRow d in ds2.Rows)
                {
                    //dt.Rows.Add(10003, d["vc_nama_obat"].ToString(), 31);
                    //MessageBox.Show(d["vc_nama_obat"].ToString());
                    dt.Rows.Add(Int32.Parse(d["in_no_urut"].ToString()+ d["vc_kode_obat"].ToString()), d["vc_nama_obat"].ToString(), Int32.Parse(d["vc_golongan"].ToString()));
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

        public static IEnumerable<DataRow> GetData(int parentId)
        {
            //TODO: This is where your DB query would be to get only the rows that have the given parent,
            //for this demo I'm just using LINQ against static data
            return from r in _data.Rows.OfType<DataRow>()
                   where (r.Field<int?>("PEQUID") ?? 0) == parentId
                   select r;
        }

        
    }
}
