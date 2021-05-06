using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fix_Your_Subtitles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            //Console.WriteLine(fileName);
            StreamReader sr = new StreamReader(fileName,true);
            //sr.Peek();
            Encoding fileEncoding = sr.CurrentEncoding;
            string readFile = File.ReadAllText(fileName, );
            richTextBox1.Text = fileEncoding + "   " + readFile;
        }
    }
}
