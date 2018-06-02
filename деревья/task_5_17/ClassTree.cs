using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5_17
{
    class ClassTree
    {
        public ClassNode Root;

        public ClassTree()
        { Root = null; }
        public void CreateTreeSearch(string s)
        // создание упорядоченного дерева
        {
            string[] num;
            num = s.Split();
            int len = num.Length;
            ClassNode tmp = new ClassNode();
            for (int i = 0; i < len; i++)
            {
                int key = Convert.ToInt16(num[i]);
                tmp.Insert(ref Root, key);
            }
        }

        public void CreateTreeBalans(string s)
        // создание сбалансированного дерева
        {
            string[] sNum = s.Split();
            int len = sNum.Length;
            int[] n = new int[len];
            for (int i = 0; i < len; i++) n[i] = Convert.ToInt16(sNum[i]);
            ClassNode tmp = new ClassNode();
            int index = 0;
            tmp.left = tmp.CreateBalans(len, n, ref index);
            Root = tmp.left;
        }

        public string PrintTree()
        {
            string res = "";
            Root.PrintTree(Root, 0, ref res);
            return res;
        } //PrintTree


        void CompareTree(ClassNode t1, ClassNode t2, ref bool res)
        // прекращает работу сразу, как только найдёт несовпадение
        {
            if (res && (t1 != null && t2 != null))
            {
                res = res && t1.info == t2.info;
                CompareTree(t1.left, t2.left, ref res);
                res = res && ((t1.left == null && t2.left == null) || (t1.left != null && t2.left != null));
                CompareTree(t1.right, t2.right, ref res);
                res = res && ((t1.right == null && t2.right == null) || (t1.right != null && t2.right != null));
            }
        } //CompareTree

        public bool eqTreeLong(ClassNode t1, ClassNode t2)
            // функция продолжает работу, даже если нашла несовпадение
       {
            if (t1 != null && t2 != null)
            {
                return (t1.info == t2.info) && eqTreeLong(t1.left, t2.left) && eqTreeLong(t1.right, t2.right);
            }
            else
                if (t1 == null ^ t2 == null) return false;
                else return true;
        } // eqTreeLong

        public bool eqTreeShort(ClassNode t1, ClassNode t2)
        // прекращает работу сразу, как только найдёт несовпадение
        {
            bool result = true;
            CompareTree(t1, t2, ref result);
            return result;
        } //eqTreeShort

    }
}
