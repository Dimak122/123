using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_1_2_17
{
    class ClassFile
    {
        public ClassFile() { }
        Random rnd = new Random();
        string[] flNames = new string[5] { "NameA", "NameB", "NameC", "NameD", "NameE" };

        public void createFile(string fileName, int i)
        {
            int num = rnd.Next(17);

           FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
           BinaryWriter writer = new BinaryWriter(stream);

           for (int j = 0; j < num; j++) writer.Write(i);
           writer.Close();
           stream.Close();
        } // createFile

        public void create_4_Files()
        {
            for (int i = 0; i < 4; i++) createFile(flNames[i], i + 1);
        } // create_4_Files

        public string FileToString(string fileName)
        {
            string res = "";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            // пока не достигнут конец файла
            // считываем каждое значение из файла
            while (reader.PeekChar() > -1)
            {
                int x = reader.ReadInt32();
                res += x + "  ";
            }
            reader.Close();
            stream.Close();

            return res;
        } //FileToString

        public string file_4_toString()
        {
            string res = "";
            for (int i = 0; i < 4; i++)
                res += FileToString(flNames[i]) + Environment.NewLine;
            return res + Environment.NewLine;
        }

        public void makeMerge()
        {
            FileStream[] stream = new FileStream[4];
            BinaryReader[] reader = new BinaryReader[4];

            for (int i = 0; i < 4; i++)
            {
                stream[i] = new FileStream(flNames[i], FileMode.Open, FileAccess.Read);
                reader[i] = new BinaryReader(stream[i]);
            }
            
            FileStream streamE = new FileStream("NameE", FileMode.Create, FileAccess.Write);
            BinaryWriter writerE = new BinaryWriter(streamE);

            while 
                (reader[0].PeekChar() > -1 && reader[1].PeekChar() > -1 && reader[2].PeekChar() > -1 && reader[3].PeekChar() > -1)
            {
                for (int j = 0; j < 4; j++)
                {
                    int x = reader[j].ReadInt32();
                    writerE.Write(x);
                }
            }

            for (int j = 0; j < 4; j++)
            {
                reader[j].Close();
                stream[j].Close();
            }

            writerE.Close();
            streamE.Close();
        }
    }
}
