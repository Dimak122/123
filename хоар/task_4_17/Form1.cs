using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_4_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1Sort cls = new Class1Sort();
            string s = textBoxIn.Text;
            cls.makeArr(s);
            textBoxOut.Clear();

            cls.qwickSortDemo(textBoxOut);
//            cls.qwickSort();

            //s = cls.printArr();
            //textBoxOut.AppendText(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
