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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(51, 295);
            button1.Name = "button1";
            button1.Size = new Size(147, 31);
            button1.TabIndex = 0;
            button1.Text = "Upload New XML File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(51, 359);
            button2.Name = "button2";
            button2.Size = new Size(147, 31);
            button2.TabIndex = 1;
            button2.Text = "Clear Current TreeView";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Right;
            treeView1.Location = new Point(376, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(424, 450);
            treeView1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 33);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "File Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 74);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 4;
            label2.Text = "File Path";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 108);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 5;
            label3.Text = "Number of Nodes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 144);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 6;
            label4.Text = "Greatest Depth";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(treeView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "XML TreeView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TreeView treeView1;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
