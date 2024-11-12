using XML_TreeView.Models;

namespace XML_TreeView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "Chọn File XML";

            openFile.Filter = "File xml| *.xml; |All File|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ClearTreeView();

                //MessageBox.Show(openFile.SafeFileName);
                //MessageBox.Show(openFile.FileName);

                List<XNode> nodeList = XmlTreeViewConverter.ExtractNodeList(openFile.FileName);
                XNode rootNode = XmlTreeViewConverter.ConstructTree(nodeList);

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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
