namespace XML_TreeView.Components
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uploadFileButton = new Button();
            clearTreeViewButton = new Button();
            treeView1 = new TreeView();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            label2 = new Label();
            fileNameTextBox = new TextBox();
            filePathTextBox = new TextBox();
            panel1 = new Panel();
            originalTreeButton = new Button();
            sortDescendingButton = new Button();
            sortAscendingButton = new Button();
            reverseTreeViewButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // uploadFileButton
            // 
            uploadFileButton.BackColor = Color.DeepSkyBlue;
            uploadFileButton.Location = new Point(12, 130);
            uploadFileButton.Name = "uploadFileButton";
            uploadFileButton.Size = new Size(220, 31);
            uploadFileButton.TabIndex = 0;
            uploadFileButton.Text = "Upload New XML File";
            uploadFileButton.UseVisualStyleBackColor = false;
            uploadFileButton.Click += uploadFileButton_Click;
            // 
            // clearTreeViewButton
            // 
            clearTreeViewButton.BackColor = SystemColors.ButtonShadow;
            clearTreeViewButton.Location = new Point(277, 130);
            clearTreeViewButton.Name = "clearTreeViewButton";
            clearTreeViewButton.Size = new Size(200, 31);
            clearTreeViewButton.TabIndex = 1;
            clearTreeViewButton.Text = "Clear Current TreeView";
            clearTreeViewButton.UseVisualStyleBackColor = false;
            clearTreeViewButton.Click += clearTreeViewButton_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(504, 71);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(505, 448);
            treeView1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "File Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 4;
            label2.Text = "File Path";
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.Enabled = false;
            fileNameTextBox.Location = new Point(78, 30);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.Size = new Size(399, 23);
            fileNameTextBox.TabIndex = 5;
            // 
            // filePathTextBox
            // 
            filePathTextBox.Enabled = false;
            filePathTextBox.Location = new Point(78, 71);
            filePathTextBox.Name = "filePathTextBox";
            filePathTextBox.Size = new Size(399, 23);
            filePathTextBox.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(originalTreeButton);
            panel1.Controls.Add(sortDescendingButton);
            panel1.Controls.Add(sortAscendingButton);
            panel1.Controls.Add(reverseTreeViewButton);
            panel1.Location = new Point(504, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 63);
            panel1.TabIndex = 7;
            // 
            // originalTreeButton
            // 
            originalTreeButton.BackColor = SystemColors.ActiveCaption;
            originalTreeButton.Location = new Point(0, -1);
            originalTreeButton.Name = "originalTreeButton";
            originalTreeButton.Size = new Size(127, 64);
            originalTreeButton.TabIndex = 9;
            originalTreeButton.Text = "Original Order";
            originalTreeButton.UseVisualStyleBackColor = false;
            originalTreeButton.Click += originalTreeButton_Click;
            // 
            // sortDescendingButton
            // 
            sortDescendingButton.BackColor = Color.LightSteelBlue;
            sortDescendingButton.Location = new Point(387, 0);
            sortDescendingButton.Name = "sortDescendingButton";
            sortDescendingButton.Size = new Size(118, 63);
            sortDescendingButton.TabIndex = 10;
            sortDescendingButton.Text = "Sort \r\n(Descending Order)";
            sortDescendingButton.UseVisualStyleBackColor = false;
            sortDescendingButton.Click += sortDescendingButton_Click;
            // 
            // sortAscendingButton
            // 
            sortAscendingButton.BackColor = Color.DeepSkyBlue;
            sortAscendingButton.Location = new Point(256, -1);
            sortAscendingButton.Name = "sortAscendingButton";
            sortAscendingButton.Size = new Size(125, 64);
            sortAscendingButton.TabIndex = 9;
            sortAscendingButton.Text = "Sort\r\n(Ascending Order)";
            sortAscendingButton.UseVisualStyleBackColor = false;
            sortAscendingButton.Click += sortAscendingButton_Click;
            // 
            // reverseTreeViewButton
            // 
            reverseTreeViewButton.BackColor = SystemColors.GradientActiveCaption;
            reverseTreeViewButton.Location = new Point(133, 0);
            reverseTreeViewButton.Name = "reverseTreeViewButton";
            reverseTreeViewButton.Size = new Size(117, 63);
            reverseTreeViewButton.TabIndex = 8;
            reverseTreeViewButton.Text = "Reverse TreeView";
            reverseTreeViewButton.UseVisualStyleBackColor = false;
            reverseTreeViewButton.Click += reverseTreeView_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 519);
            Controls.Add(panel1);
            Controls.Add(filePathTextBox);
            Controls.Add(fileNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(treeView1);
            Controls.Add(clearTreeViewButton);
            Controls.Add(uploadFileButton);
            Name = "MainForm";
            Text = "XML TreeView";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uploadFileButton;
        private Button clearTreeViewButton;
        private TreeView treeView1;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label label2;
        private TextBox fileNameTextBox;
        private TextBox filePathTextBox;
        private Panel panel1;
        private Button reverseTreeViewButton;
        private Button sortDescendingButton;
        private Button sortAscendingButton;
        private Button originalTreeButton;
    }
}
