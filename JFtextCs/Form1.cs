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
        private void button1_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();

           
            
        }
    }
}
