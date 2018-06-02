using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_5_17
{
    public partial class Form1 : Form
    {
        ClassTree tr1;
        ClassTree tr2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonMake1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s != "")
            {
                tr1 = new ClassTree();
                tr1.CreateTreeSearch(s);
                s = tr1.PrintTree();
                textBoxTree1.Text = s;
            }
            else
            {
                MessageBox.Show("Нет данных для построения дерева");
                textBox1.Focus();
            }
        }

        private void buttonMake2_Click(object sender, EventArgs e)
        {
            string s = textBox2.Text;
            if (s != "")
            {
                tr2 = new ClassTree();
                tr2.CreateTreeSearch(s);
                s = tr2.PrintTree();
                textBoxTree2.Text = s;
            }
            else
            {
                MessageBox.Show("Нет данных для построения дерева");
                textBox1.Focus();
            }
        }

        private void buttonComp_Click(object sender, EventArgs e)
        {
            bool eq = true;
//            eq = tr1.eqTreeLong(tr1.Root, tr2.Root);
            eq = tr1.eqTreeShort(tr1.Root, tr2.Root);
            if (eq) MessageBox.Show("равны");
            else MessageBox.Show("не равны");
            textBoxTree1.Clear();
            textBoxTree2.Clear();
        }
    }
}
