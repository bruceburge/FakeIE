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

namespace TempIE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            if(args.Length > 1)
            {
                if(File.Exists(args[1]))
                {
                    webBrowser1.Url = new Uri(args[1]);                    
                }
                else
                {
                    MessageBox.Show($"Could not load {Environment.NewLine} {args[1]} file does not exist");
                }
            }
        }
    }
}
