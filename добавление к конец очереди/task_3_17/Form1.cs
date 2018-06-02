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

namespace task_3_17
{
    public partial class Form1 : Form
    {
        ClassQu qu;
        string flName;

        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) flName = openFileDialog1.FileName; ;

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

            создатьОчередьToolStripMenuItem.Enabled = true;
            textBox1.Visible = true;
            textBoxIn.Visible = false;
            textBoxQu.Visible = false;
            textBoxNewQu.Visible = false;
        }

        private void создатьОчередьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qu = new ClassQu();
            qu.createQu(flName);
            string s = qu.printQu();
            textBoxQu.Text = s;
            textBoxQu.Visible = true;
            добавитьЭлементToolStripMenuItem.Enabled = true;
            textBoxIn.Visible = true;
            textBoxIn.Clear();


        }

        private void добавитьЭлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(textBoxIn.Text);
                qu.add(x);
                string s = qu.printQu();
                textBoxNewQu.Text = s;
                textBoxNewQu.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("ошибка ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            создатьОчередьToolStripMenuItem.Enabled = false;
            добавитьЭлементToolStripMenuItem.Enabled = false;
            textBox1.Visible = false;
            textBoxIn.Visible = false;
            textBoxQu.Visible = false;
            textBoxNewQu.Visible=false;
        }

        private void условиеЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создать очередь, информационные поля которой содержат числа из текстового файла. Вставить в конец списка (после последнего элемента) новый элемент с информационным  полем d.  ");
        }


    }
}
