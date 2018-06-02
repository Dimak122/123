using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_1_17
{
    class ClassFile
    {
        public ClassFile() { }

        public int nIndent(string FileName)
        //  функция подсчёта абзацев в текстовом файле
        {
            const int lenIndent=5; // красная строка == 5 пробелов
            const string indent = "     "; // отступ
            int result = 0;
            FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            string s;
            s = reader.ReadLine();
            while (s != null)
            {
                if (s != "" && s.Length > lenIndent)
                {
                    if (indent==s.Substring(0,5)&&s[5]!=' ')  result++;
                }
                s = reader.ReadLine();
            }
            reader.Close();
            stream.Close();

            return result;
        }
    }
}
