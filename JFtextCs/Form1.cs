using System.Windows.Forms;

namespace JFtextCs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "text files|*.txt";
            saveDialog.ShowDialog();

            File.WriteAllText(saveDialog.FileName, this.GetRichTextBox().Text);
        }
        private void openToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "text files|*.txt";
            openDialog.ShowDialog();


            TabPage tabPage = new TabPage();
            RichTextBox textArea = new RichTextBox();
            textArea.Dock = DockStyle.Fill;

            tabPage.Controls.Add(textArea);
            tabControl1.TabPages.Add(tabPage);
        
            this.GetRichTextBox().Text = File.ReadAllText(openDialog.FileName);
            tabPage.Text = openDialog.FileName;

        }
        private void newToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            
            TabPage tabPage = new TabPage("my document");
            RichTextBox textArea = new RichTextBox();
            textArea.Dock = DockStyle.Fill;

            tabPage.Controls.Add(textArea);
            tabControl1.TabPages.Add(tabPage);
        }
        public void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void undoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            GetRichTextBox().Undo();
        }
        private void redoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            GetRichTextBox().Redo();
        }
        private void wrapFalseToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            GetRichTextBox().WordWrap = false;
        }
        private void wrapTrueToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            GetRichTextBox().WordWrap = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private RichTextBox GetRichTextBox()
        {
            RichTextBox textArea = null;
            TabPage tabPage = tabControl1.SelectedTab;

            if (tabPage != null)
            {
                textArea = tabPage.Controls[0] as RichTextBox;
            }
            return textArea;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
