namespace JFtextCs
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            wordWrapToolStripMenuItem = new ToolStripMenuItem();
            wrapTrueToolStripMenuItem = new ToolStripMenuItem();
            wrapFalseToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, fontToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1689, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, openToolStripMenuItem, newToolStripMenuItem, aboutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("JetBrains Mono ExtraBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(90, 38);
            fileToolStripMenuItem.Text = "file";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeyDisplayString = "";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(359, 44);
            saveToolStripMenuItem.Text = "save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(359, 44);
            openToolStripMenuItem.Text = "open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(359, 44);
            newToolStripMenuItem.Text = "new";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(359, 44);
            aboutToolStripMenuItem.Text = "about";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(359, 44);
            exitToolStripMenuItem.Text = "exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem });
            editToolStripMenuItem.Font = new Font("JetBrains Mono ExtraBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(90, 38);
            editToolStripMenuItem.Text = "edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(203, 44);
            undoToolStripMenuItem.Text = "undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(203, 44);
            redoToolStripMenuItem.Text = "redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wordWrapToolStripMenuItem });
            fontToolStripMenuItem.Font = new Font("JetBrains Mono ExtraBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(90, 38);
            fontToolStripMenuItem.Text = "font";
            // 
            // wordWrapToolStripMenuItem
            // 
            wordWrapToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wrapTrueToolStripMenuItem, wrapFalseToolStripMenuItem });
            wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            wordWrapToolStripMenuItem.Size = new Size(273, 44);
            wordWrapToolStripMenuItem.Text = "word wrap";
            // 
            // wrapTrueToolStripMenuItem
            // 
            wrapTrueToolStripMenuItem.Name = "wrapTrueToolStripMenuItem";
            wrapTrueToolStripMenuItem.Size = new Size(217, 44);
            wrapTrueToolStripMenuItem.Text = "true";
            wrapTrueToolStripMenuItem.Click += wrapTrueToolStripMenuItem_Click;
            // 
            // wrapFalseToolStripMenuItem
            // 
            wrapFalseToolStripMenuItem.Name = "wrapFalseToolStripMenuItem";
            wrapFalseToolStripMenuItem.Size = new Size(217, 44);
            wrapFalseToolStripMenuItem.Text = "false";
            wrapFalseToolStripMenuItem.Click += wrapFalseToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 42);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1689, 833);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1643, 825);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(1637, 819);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "welcome to JFtext to get started open a text file or create a new one\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1689, 875);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Font = new Font("JetBrains Mono ExtraBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "JFtext";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem wordWrapToolStripMenuItem;
        private ToolStripMenuItem wrapTrueToolStripMenuItem;
        private ToolStripMenuItem wrapFalseToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private RichTextBox richTextBox1;
    }
}
