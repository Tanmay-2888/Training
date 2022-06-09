using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfolder_Click(object sender, EventArgs e)
        {
            string path = @"D:\SnQBatch";
            if (Directory.Exists(path))
            {
                MessageBox.Show("Folder is already exists");
            }
            else
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("Folder is Created");
            }
        }

        private void btnfile_Click(object sender, EventArgs e)
        {
            string path = @"D:\SnQBatch\Test.txt"; //txt=> Text file
            if (File.Exists(path))
            {
                MessageBox.Show("File already exists");
            }
            else
            {
                File.Create(path);
                MessageBox.Show("File created");

            }
        }
    }
}
