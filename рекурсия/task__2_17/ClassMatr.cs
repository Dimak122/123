using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace task__2_17
{
    class ClassMatr
    {
        public int[,] matr; // исходная матрица
        int dim; // размерность матрицы

        public ClassMatr()
        {
            matr = new int[0, 0];
        }

        public void MatrFromFile(string FileName) 
        {
            FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            string s;
            s = reader.ReadLine();
            dim = Convert.ToInt16(s);
            matr = new int[dim,dim];
            int i = 0;
            s = reader.ReadLine();
            while (s != null)
            {
                string[] sNum = s.Split();
                int k = 0;
                for (int j = 0; j < sNum.Length; j++)
                    if (sNum[j] != "")
                    {
                        matr[i, k] = Convert.ToInt16(sNum[j]); k++; ///////////////
                    }
                s = reader.ReadLine(); i++;
            }
            reader.Close();
            stream.Close();
        } //MatrFromFile

        public void matrToGridView(DataGridView dgv)
        {

            dgv.ColumnCount = dim;
            dgv.RowCount = dim;

            for (int i = 0; i < dim; i++)
            {
                dgv.Columns[i].Width = 50;

                for (int j = 0; j < dim; j++)
                    dgv[j, i].Value = matr[i, j]; //////
            }
        } //matrToGridWiew

        void GridViewToMatr(DataGridView dgv)
        {
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                    matr[i, j] = Convert.ToInt16(dgv[j, i].Value); //////
            }
        } //GridViewToMatr

        int [,]newMatr(int[,]m, int nCol,int dm )
        // новая матрица получается из старой (m) вычеркиванием первой строки и nCol-го столбца.
        // размерность "старой" матрицы -- dm
        {
            int [,]res=new int[dm-1,dm-1];
            // переписываем левую часть матрицы
            for (int i = 1; i < dm; i++)
                for (int j = 0; j < nCol; j++)
                    res[i-1, j] = m[i, j];
            // переписываем правую часть матрицы
            for (int i = 1; i < dm; i++)
                for (int j = nCol+1; j < dm; j++)
                    res[i-1, j-1] = m[i, j];

            return res;
        } // newMatr

        int determinant(int [,]m, int dm)
            // функция вычисления детерминанта
        {
            if (dm == 2) return (m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0]);
            else
            {
                int res = 0; int fact = -1;
                for (int i = 0; i < dm; i++)
                {
                    fact *= -1;
                    res += fact * m[0, i] * determinant(newMatr(m,i, dm),dm-1);
                }
                return res;
            } 
        } // determinant


        public string resDeterm(DataGridView dgv)
        {
            GridViewToMatr(dgv);
            return determinant(matr, dim).ToString();
        }

    }
}
