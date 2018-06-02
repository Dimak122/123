using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_4_17
{
    class Class1Sort
    {
        int[] a;
        struct Index
        {
            public int l; // левая граница подмассива
            public int r;// правая граница подмассива
        }

        public Class1Sort()
        {
            a = new int[0];
        }

        public void makeArr(string s)
        {
            string []sNum = s.Split();
            for (int i = 0; i < sNum.Length; i++)
            {
                if (sNum[i] != "")
                {
                    int len = a.Length;
                    Array.Resize(ref a, len+1);
                    a[len] = Convert.ToInt16(sNum[i]);
                }
            }
        } // makeArr

        public void qwickSort()
        {
            Stack<Index> st = new Stack<Index>();
            Index tmp = new Index();
            tmp.l = 0; tmp.r = a.Length - 1;
            st.Push(tmp);
            do
            {
                tmp = st.Pop();
                int l = tmp.l; int r = tmp.r;
                do
                {
                    int i = l; int j = r; int mid = (l + r) / 2; int x = a[mid];
                    do
                    {
                        while (a[i] < x) i++;
                        while (a[j] > x) j--;
                        if (i <= j)
                        {
                            int temp = a[i]; a[i] = a[j]; a[j] = temp;
                            i++; j--;
                        }
                    }
                    while(i<=j);
                    if (i < r) //запись в стек запроса на сортировку правой части
                    {
                        tmp.l = i; tmp.r = r; st.Push(tmp);
                    }
                    r = j;
                }
                while(l<r);
            }
            while(st.Count!=0);
        } //qwickSort

        public void qwickSortDemo(TextBox txb) //textBox1.AppendText(s + Environment.NewLine);
        {
            string sDemo;
            int len = a.Length;
            sDemo = printArr(0, len-1);
            txb.AppendText("Исходный массив" + Environment.NewLine);
            txb.AppendText(sDemo + Environment.NewLine + Environment.NewLine);
            Stack<Index> st = new Stack<Index>();
            Index tmp = new Index();
            tmp.l = 0; tmp.r = a.Length - 1;
            st.Push(tmp);
            do
            {
                tmp = st.Pop();
                int l = tmp.l; int r = tmp.r;
                do
                {
                    int i = l; int j = r; int mid = (l + r) / 2; int x = a[mid];
                    do
                    {
                        while (a[i] < x) i++;
                        while (a[j] > x) j--;
                        if (i <= j)
                        {
                            int temp = a[i]; a[i] = a[j]; a[j] = temp;
                            i++; j--;
                        }
                        sDemo = printArr(l,r);
                        txb.AppendText(sDemo + Environment.NewLine);

                    }
                    while (i <= j);

                    if (i < r) //запись в стек запроса на сортировку правой части
                    {
                        tmp.l = i; tmp.r = r; st.Push(tmp);
                    }
                    sDemo = "запись в стек запроса на сортировку правой части";
                    txb.AppendText(sDemo + Environment.NewLine);
                    sDemo = printArr(i, r);
                    txb.AppendText(sDemo + Environment.NewLine);
                    r = j;
                }
                while (l < r);
                sDemo = "промежуточный результат";
                txb.AppendText(sDemo + Environment.NewLine);
                sDemo = printArr(0, len - 1);
                txb.AppendText(sDemo + Environment.NewLine + Environment.NewLine);
            }
            while (st.Count != 0);
            sDemo = "результат";
            txb.AppendText(sDemo + Environment.NewLine);
            sDemo = printArr(0, len - 1);
            txb.AppendText(sDemo + Environment.NewLine + Environment.NewLine);
 
        } //qwickSort

        public string printArr(int left, int right)
        {
            string res = "";
            for (int i = left; i <= right; i++)
                res += a[i] + "  ";
            return res;
        } //printArr
    }
}
