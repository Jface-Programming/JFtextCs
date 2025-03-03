using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System;

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

            this.textArea.Text = File.ReadAllText(openDialog.FileName);
        }
        private void newToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.textArea.Text = string.Empty;
        }
    }
}
