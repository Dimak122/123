using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace task_6_17_1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Graphics gr;
        ClassSetPoinds setP;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setP = new ClassSetPoinds();

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int w = rnd.Next(16) + 7;
            setP.addPoint(e.X, e.Y, w);
            int len = setP.setPoints.Length;
            gr = CreateGraphics();
            setP.setPoints[len - 1].DrawNode(gr);
            gr.Dispose();
        }

        private void buttonSplit_Click(object sender, EventArgs e)
        {
            if (setP.setLen >= 2)
            {
                gr = CreateGraphics();
                setP.RunAll(gr);
                gr.Dispose();

            }
            else
            {
                MessageBox.Show("Должно быть не меньше двух точек");
                gr = CreateGraphics();
                int w = ClientRectangle.Width;
                int h = ClientRectangle.Height;
                setP.clearAll(gr, w, h);
                gr.Dispose();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            gr = CreateGraphics();
            int w=ClientRectangle.Width;
            int h = ClientRectangle.Height;
            setP.clearAll(gr,w,h);
            gr.Dispose();
        }
    }
}
