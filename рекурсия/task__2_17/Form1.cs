using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task__2_17
/*
 * 17.	Вычислить определитель заданной матрицы, пользуясь формулой разложения по первой строке:
 * det(A)=сумма от 1 до n (  (-1)в степени (k+1)*А(1,k)*det(B(k))  ),
 * где матрица B(k) получается вычеркиванием из А первой строки и k-го столбца.

*/
{
    public partial class Form1 : Form
    {
        string FlName;
        ClassMatr mtr;
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                FlName = openFileDialog1.FileName;

            mtr = new ClassMatr();
            mtr.MatrFromFile(FlName);
            mtr.matrToGridView(dgv);
            dgv.Visible = true;
            найтиОпределительToolStripMenuItem.Enabled = true;
            label1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            найтиОпределительToolStripMenuItem.Enabled = false;
            dgv.Visible = false;
            label1.Visible = false;

        }

        private void найтиОпределительToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "определитель = " + mtr.resDeterm(dgv);
            label1.Visible = true;
        }
    }
}
