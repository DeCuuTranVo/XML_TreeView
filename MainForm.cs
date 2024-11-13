using System.Windows.Forms.Design;
using XML_TreeView.Models;
using XML_TreeView.Services;

namespace XML_TreeView
{
    public partial class MainForm : Form
    {
        private readonly IXmlTreeViewHandler _xmlTreeViewHandler;

        public MainForm(IXmlTreeViewHandler xmlTreeViewHandler)
        {
            _xmlTreeViewHandler = xmlTreeViewHandler;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

                //MessageBox.Show(openFile.SafeFileName);
                //MessageBox.Show(openFile.FileName);

                List<XNode> nodeList = _xmlTreeViewHandler.ExtractNodeList(openFile.FileName);
                XNode rootNode = _xmlTreeViewHandler.ConstructTree(nodeList);

                LoadTreeView(rootNode);
            }

            //MessageBox.Show("Upload New XML File");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Delete Current XML File");
            ClearTreeView();
        }

        private void ClearTreeView()
        {
            treeView1.Nodes.Clear();
        }

        private void LoadTreeView(XNode pXNode)
        {
            foreach (XNode item in pXNode.Nodes)
            {
                treeView1.Nodes.Add(item);
            }


            //TreeNode root1 = new TreeNode();
            //root1.Text = "Root 1";

            //TreeNode root11 = new TreeNode() { Text = "Root 1 1" };
            //root1.Nodes.Add(root11);

            //TreeNode root2 = new TreeNode();
            //root2.Text = "Root 2";

            //treeView1.Nodes.Add(root1);
            //treeView1.Nodes.Add(root2);
        }

    }

}
