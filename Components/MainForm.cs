using System.Windows.Forms.Design;
using XML_TreeView.Models;
using XML_TreeView.Services;

namespace XML_TreeView.Components
{
    public partial class MainForm : Form
    {
        private readonly IXmlTreeViewHandler _xmlTreeViewHandler;
        private XTree _xTree = new XTree();
        private XTree _initTree = new XTree();

        public MainForm(IXmlTreeViewHandler xmlTreeViewHandler)
        {
            _xmlTreeViewHandler = xmlTreeViewHandler;
            InitializeComponent();
        }

        private void ClearTreeView()
        {
            treeView1.Nodes.Clear();
        }

        private void LoadTreeView(XTree pXTree)
        {
            foreach (XNode item in pXTree.RootNode.Nodes)
            {
                treeView1.Nodes.Add(item);
            }
        }

        private void uploadFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "Choose XML Files";

            openFile.Filter = "File xml| *.xml; |All Files|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Check if file is not null

                // Check if file is of xml type

                // Try catch and event handler


                ClearTreeView();

                fileNameTextBox.Text = openFile.SafeFileName;
                filePathTextBox.Text = openFile.FileName;

                List<XNode> nodeList = _xmlTreeViewHandler.ExtractNodeList(openFile.FileName);
                _xTree = _xmlTreeViewHandler.ConstructTree(nodeList);
                _initTree = _xmlTreeViewHandler.CloneTree(_xTree);

                //_xTree.Reverse();
                LoadTreeView(_xTree);

                //xTree.Print();             
            }

            //MessageBox.Show("Upload New XML File");
        }

        private void clearTreeViewButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Delete Current XML File");
            ClearTreeView();
            fileNameTextBox.Text = string.Empty;
            filePathTextBox.Text = string.Empty;
        }

        private void reverseTreeView_Click(object sender, EventArgs e)
        {
            ClearTreeView();
            _xTree.Reverse();
            LoadTreeView(_xTree);
        }

        private void sortAscendingButton_Click(object sender, EventArgs e)
        {
            ClearTreeView();
            _xTree.Sort(SortOrder.Ascending);
            LoadTreeView(_xTree);
        }

        private void sortDescendingButton_Click(object sender, EventArgs e)
        {
            ClearTreeView();
            _xTree.Sort(SortOrder.Descending);
            LoadTreeView(_xTree);
        }

        private void originalTreeButton_Click(object sender, EventArgs e)
        {
            ClearTreeView();
            _xTree = _xmlTreeViewHandler.CloneTree(_initTree);
            LoadTreeView(_xTree);
        }
    }
}


