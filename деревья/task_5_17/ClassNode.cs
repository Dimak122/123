using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5_17
{
    class ClassNode
    {
        public int info;
        public ClassNode left;
        public ClassNode right;


        public ClassNode()
        { }
        public ClassNode(int i)
        {
            info = i;
            left = null;
            right = null;
        }

        public void Insert(ref ClassNode t, int aInfo)
        // вставка в упорядоченное дерево
        {
            if (t == null) // вставка элемента в пустое дерево
            {
                t = new ClassNode(aInfo);
            }
            else
            {
                if (aInfo < t.info) { Insert(ref t.left, aInfo); }
                else { Insert(ref t.right, aInfo); };
            }
        } //CreateSearch

        public ClassNode CreateBalans(int numNode, int[] num, ref int indx)
        // создание сбалансированного дерева
        {
            ClassNode res;
            int nLeft, nRight;
            if (numNode == 0) { res = null; }
            else
            {
                nLeft = numNode / 2;
                nRight = numNode - nLeft - 1;
                res = new ClassNode(num[indx]);
                indx++;
                res.left = CreateBalans(nLeft, num, ref indx);
                res.right = CreateBalans(nRight, num, ref indx);
            }
            return res;
        } //CreateBalans


        public void PrintTree(ClassNode node, int level, ref string result)
        {
            if (node.right != null) PrintTree(node.right, level + 2, ref  result);
            for (int i = 0; i < level; i++) result += "  ";
            result += node.info.ToString() + Environment.NewLine;
            if (node.left != null) PrintTree(node.left, level + 2, ref  result);
        } //PrintTree

    }
}
