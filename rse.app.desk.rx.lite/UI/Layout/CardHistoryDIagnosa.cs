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
    public partial class CardHistoryDiagnosa : UserControl
    {
        public CardHistoryDiagnosa()
        {
            InitializeComponent();
        }

        private DateTime _tglreg;
        private string _namadokter;
        private string _klinik;
        private string _noreg;
        private static DataTable _data;


        [Category("Custom Prop")]
        public DateTime TGLReg
        {
            get { return _tglreg; }
            set { _tglreg = value; lblTglReg.Text = value.ToString("dd-MM-yyyy"); }
        }
        [Category("Custom Prop")]
        public string NamaDokter
        {
            get { return _namadokter; }
            set { _namadokter = value; lblNamaDokter.Text = value; }
        }

        public string NoREG
        {
            get { return _noreg; }
            set { _noreg = value; btnCopy.Tag = value; }
        }
        [Category("Custom Prop")]
        public string Klinik
        {
            get { return _klinik; }
            set { _klinik = value; lblKlinik.Text = value; }
        }

        public event EventHandler CpyDiagButtonClick
        {
            add { btnCopy.Click += value; }
            remove { btnCopy.Click -= value; }
        }
        //[Category("Custom Prop")]
        //public string Penanggung
        //{
        //    get { return _penanggung; }
        //    set { _penanggung = value; lblPenanggung.Text = value; }
        //}
        //[Category("Custom Prop")]
        //public string NoREG
        //{
        //    get { return _noreg; }
        //    set { _noreg = value; lblNoREG.Text = value; }
        //}

        [Category("Custom Prop")]
        public DataTable Data
        {
            get { return _data; }
            set { _data = value; }
        }
        private IEnumerable<TreeNode> GetTreeNodes<T>(
            IEnumerable<T> source,
            Func<T, Boolean> isRoot,
            Func<T, IEnumerable<T>, IEnumerable<T>> getChilds,
            Func<T, TreeNode> getItem)
        {
            IEnumerable<T> roots = source.Where(x => isRoot(x));
            foreach (T root in roots)
                yield return ConvertEntityToTreeNode(root, source, getChilds, getItem); ;
        }

        private TreeNode ConvertEntityToTreeNode<T>(
            T entity,
            IEnumerable<T> source,
            Func<T, IEnumerable<T>, IEnumerable<T>> getChilds,
            Func<T, TreeNode> getItem)
        {
            TreeNode node = getItem(entity);
            var childs = getChilds(entity, source);
            foreach (T child in childs)
                node.Nodes.Add(ConvertEntityToTreeNode(child, source, getChilds, getItem));
            return node;
        }

        public void LoadTreeData()
        {
           
            var source = _data.AsEnumerable();
            var nodes = GetTreeNodes(
                    source,
                    (r) => r.Field<int?>("PEQUID") == null,
                    (r, s) => s.Where(x => r["EQUID"].Equals(x["PEQUID"])),
                    (r) => new TreeNode { Text = r.Field<string>("DESEQU") }
            );
            treeViewDiagnosa.Nodes.AddRange(nodes.ToArray());
            treeViewDiagnosa.ExpandAll();
        }

        private void treeViewDiagnosa_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void CardHistoryDiagnosa_Load(object sender, EventArgs e)
        {

        }
    }
}
