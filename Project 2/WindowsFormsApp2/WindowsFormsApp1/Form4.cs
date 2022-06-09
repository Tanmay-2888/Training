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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SnQBatch1\Test1.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                int id = br.ReadInt32();
                string name = br.ReadString();
                int fees = br.ReadInt32();
                txtId.Text = id.ToString();
                txtCoursename.Text = name;
                txtFees.Text = fees.ToString();
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\SnQBatch1\Test1.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                int id = Convert.ToInt32(txtId.Text);
                string name = txtCoursename.Text;
                string fees = txtFees.Text;
                bw.Write(id);
                bw.Write(name);
                bw.Write(fees);
                bw.Close();
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
