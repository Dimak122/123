using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace task_6_17_1
{
    class ClassSetPoinds
    {
        public ClassNode[] setPoints; // множество исходных точек
        int[] Set1;  // первое подмножество
        int[] Set2;   // второе подмножество

        int W1;// вес первого подмножества
        int W2;// вес второго подмножества
        int X1, Y1;// координаты первого
        int X2, Y2;// координаты второго подмножества

        int X, Y; // координаты центра тяжести

        public int setLen
        {
            get { return setPoints.Length; }
        }


        public ClassSetPoinds()
        {
            setPoints = new ClassNode[0];
            Set1 = new int[0];
            Set2 = new int[0];
        }

        public void addPoint(int x, int y, int w)
        {
            int len = setPoints.Length; len++;
            Array.Resize(ref setPoints, len);
            setPoints[len - 1] = new ClassNode(x, y, w);
        }

        void ShowMark(Graphics gr, int x, int y,Color color,int size)
        {
            Color col = color;
            Pen pen = new Pen(col, 1);
            gr.DrawLine(pen, x - size, y - size, x + size, y + size);
            gr.DrawLine(pen, x - size, y + size, x + size, y - size);
        }

        public void ShowSet(Graphics gr)
        {
            Font font = new Font("Arial", 10, FontStyle.Regular);
            int NumNodes = setPoints.Length;
            for (int i = 0; i < NumNodes; i++) setPoints[i].DrawNode(gr); // рисуем узлы
        } //ShowSet

        int[] centre_of_gravity(int[] point1, int[] point2) //центр тяжести двух "точек"
        {
            int[] res=new int[2];
            int s = point1[0] + point2[0];
            res[0]=(point1[1]*point1[0]+point2[1]*point2[0])/s;
            res[1] = (point1[2] * point1[0] + point2[2] * point2[0]) / s;
            return res;
        } //centre_of_gravity

        public void RunAll(Graphics gr)
        {
            int[] res = new int[2]; // центр тяжести двух подмножеств

            // из двух первых точек формируем два подмножества
            Set1 = new int[1];
            Set1[0] = 0; W1 = setPoints[0].radius;
            X1 = setPoints[0].x; Y1 = setPoints[0].y;
            Set2 = new int[1];
            Set2[0] = 1; W2 = setPoints[1].radius;
            X2 = setPoints[1].x; Y2 = setPoints[1].y;

            if (setPoints.Length == 2)
            {
                int[] s1 = new int[3];
                int[] s2 = new int[3];
                s1[0] = setPoints[0].radius;
                s1[1] = setPoints[0].x;
                s1[2] = setPoints[0].y;
                s2[0] = setPoints[1].radius;
                s2[1] = setPoints[1].x;
                s2[2] = setPoints[1].y;
                res = centre_of_gravity(s1, s2);
            }
            else
            {
                for (int i = 2; i < setPoints.Length; i++)
                {

                    int[] wxyi = new int[3]; // очередная точка
                    wxyi[0] = setPoints[i].radius;
                    wxyi[1] = setPoints[i].x;
                    wxyi[2] = setPoints[i].y;

                    // попытка присоединить i-ую точку к первому подмножеству

                    int[] set1 = new int[3]; 
                    set1[0] = W1;
                    set1[1] = X1; set1[2] = Y1;

                    int[] centr1 = centre_of_gravity(wxyi, set1); // координаты ЦТ 1-го подмножества и очередной точки

                    int deltaX = centr1[0] - X2;
                    int deltaY = centr1[1] - Y2; 
                    int d1 = Convert.ToInt16(Math.Sqrt(deltaX * deltaX + deltaY * deltaY));

                    // попытка присоединить i-ую точку ко второму подмножеству
                    int[] set2 = new int[3];
                    set2[0] = W2;
                    set2[1] = X2; set2[2] = Y2; // координаты ЦТ 2-го подмножества и очередной точки

                    int[] centr2 = centre_of_gravity(wxyi, set2);

                    deltaX = centr2[0] - X1;
                    deltaY = centr2[1] - Y1;
                    int d2 = Convert.ToInt16(Math.Sqrt(deltaX * deltaX + deltaY * deltaY));

                    if (d1 < d2) // присоединяем i-ую точку к первому подмножеству
                    {
                        int len1 = Set1.Length;
                        Array.Resize(ref Set1, len1 + 1);
                        Set1[len1] = i;
                        X1 = centr1[0]; Y1 = centr1[1];
                        W1 += setPoints[i].radius;
                    }
                    else // присоединяем i-ую точку ко второму подмножеству
                    {
                        int len2 = Set2.Length;
                        Array.Resize(ref Set2, len2 + 1);
                        Set2[len2] = i;
                        X2 = centr2[0]; Y2 = centr2[1];
                        W2 += setPoints[i].radius;
                    }
                } // for
            }
            int[] S1 = new int[3];
            int[] S2 = new int[3];
            S1[0] = W1;
            S1[1] = X1;
            S1[2] = Y1;
            S2[0] = W2;
            S2[1] = X2;
            S2[2] = Y2;
            res = centre_of_gravity(S1, S2);
            X = res[0]; Y = res[1];
            int n1 = Set1.Length;
            Color color1 = Color.FromArgb(142,120,238);
            Color color2 = Color.FromArgb(232,181,73); 
            for (int i = 0; i < n1; i++)
                setPoints[Set1[i]].color = color1;
            int n2 = Set2.Length;
            for (int i = 0; i < n2; i++)
                setPoints[Set2[i]].color = color2;
            ShowSet(gr);
            ShowMark(gr, X1, Y1,color1,5);
            ShowMark(gr, X2, Y2,color2,5);
            ShowMark(gr, X, Y, Color.Red,10);
            gr.Dispose();
        } // RunAll

        public void clearAll(Graphics gr,int w,int h)
        {
            Array.Resize(ref setPoints, 0);
            SolidBrush br = new SolidBrush(Color.White);
            Rectangle rec = new Rectangle(0, 0, w, h);
            gr.FillRectangle(br, rec);
        }

    }
}
