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

namespace task_1_17
{
    public partial class Form1 : Form
    {
        string flName;
        ClassFile fl;
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                flName = openFileDialog1.FileName;
            }// if

            //////////
            FileStream stream = new FileStream(flName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            string s;
            s = reader.ReadLine();
            textBox1.Clear();
            while (s != null)
            {
                textBox1.AppendText(s + Environment.NewLine);
                s = reader.ReadLine();
            }
            reader.Close();
            stream.Close();
            /////////////

            посчитатьАбзацыToolStripMenuItem.Enabled = true;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            посчитатьАбзацыToolStripMenuItem.Enabled = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void посчитатьАбзацыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fl=new ClassFile();
            label2.Text = fl.nIndent(flName).ToString();
            label1.Visible = true;
            label2.Visible = true;
        }
    }
}
