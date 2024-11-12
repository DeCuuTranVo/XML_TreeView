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

            if (openFile.ShowDialog() == DialogResult.OK )
            {
                MessageBox.Show(openFile.SafeFileName);
                //MessageBox.Show(openFile.FileName);
            }

            //MessageBox.Show("Upload New XML File");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Current XML File");
        }
    }
    
}
