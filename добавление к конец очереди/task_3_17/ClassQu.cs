using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_3_17
{
    class ClassQu
    {
        Node head; // голова очереди
        Node tail;  // хвост очереди


        public ClassQu() // конструктор
        {
            head = null;
        }

        public void add(int elem)
        {
            if (head == null) // создание первого элемента очереди
            {
                head = new Node(elem);
                tail = head;
            }
            else  // добавление в конец очереди
            {
                Node tmp = new Node(elem);
                tail.next = tmp;
                tail = tmp;
            }
        } // add

        public void createQu(string FileName)
        {
            FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            string s;
            s = reader.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] sNum = s.Split(); //(' ',',');
                    for (int i = 0; i < sNum.Length; i++)
                    {
                        if (sNum[i] != "")
                        {
                            int tmp = Convert.ToInt32(sNum[i]);
                            add(tmp);
                        }
                    }
                }
                s = reader.ReadLine();
            }
            reader.Close();
            stream.Close();
        } // createQu

        int outQu()
        {
            int res = head.info;
            head = head.next;
            return res;
        }

        bool isEmpty()
        {
            return head == null;
        }

        public string printQu() // неразрушающая печать очереди
        {
            string res = "";
            Node q=head;
            while (q != null)
            {
                int z = q.info;
                res += z.ToString() + "  ";
                q = q.next;
            }
            return res;
        }


    } // ClassQu

    ///////////////////////

    public class Node
    {
        public int info;
        public Node next;

        public Node(int i)
        {
            info = i;
            next = null;
        }
    } // Node
}
