using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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


            File.WriteAllText(saveDialog.FileName, this.textArea.Text);
        }
        private void openToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "text files|*.txt";
            openDialog.ShowDialog();

            textArea.Text = File.ReadAllText(openDialog.FileName);
        }
        private void newToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            textArea.Text = "";
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
            this.textArea.Undo();
        }
        private void redoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.textArea.Redo();
        }
        private void wrapFalseToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.textArea.WordWrap = false;
        }
        private void wrapTrueToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.textArea.WordWrap = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
