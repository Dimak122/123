using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace task_6_17_1
{
    class ClassNode
    {
        public int radius; // "вес" точки
        public int x, y; // координаты точки
        public Color color = Color.Brown; //
        public int wLine = 2; // толщина линии

        public ClassNode(int ex, int ey, int number)
        {
            radius = number;
            x = ex; y = ey;
            color = Color.Brown;
        }

        public void DrawNode(Graphics gr)
        {
            SolidBrush br = new SolidBrush(color);
            Rectangle rec = new Rectangle(x - radius / 2, y - radius / 2, radius, radius);
            gr.FillEllipse(br, rec); 
            br.Dispose();
        } // DrawNode
    }
}
