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

namespace task_1_3_17
{
    public partial class Form1 : Form
    {
        string FileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
            }// if

            //////////
            FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
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

            показатьЛучшихСтудентовToolStripMenuItem.Enabled = true;
        }

        private void показатьЛучшихСтудентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassListStud st=new ClassListStud();
            string s = st.best_5(FileName);
            textBox1.AppendText(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            показатьЛучшихСтудентовToolStripMenuItem.Enabled = false;

        }
    }
}
