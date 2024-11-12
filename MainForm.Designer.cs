namespace XML_TreeView
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
            button1 = new Button();
            button2 = new Button();
            treeView1 = new TreeView();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(62, 50);
            button1.Name = "button1";
            button1.Size = new Size(147, 31);
            button1.TabIndex = 0;
            button1.Text = "Upload New XML File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(62, 119);
            button2.Name = "button2";
            button2.Size = new Size(147, 31);
            button2.TabIndex = 1;
            button2.Text = "Delete Current XML File";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(333, 33);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(424, 384);
            treeView1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(treeView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "XML TreeView";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private TreeView treeView1;
        private OpenFileDialog openFileDialog1;
    }
}
