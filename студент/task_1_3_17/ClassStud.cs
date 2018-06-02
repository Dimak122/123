using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters.Binary;

namespace task_1_3_17
{
//   [Serializable]
    class ClassStud
    {
          public string FIO;
          public DateTime Year;
          public double[] MedB;
          public byte Kurs;
          public byte Group;

        public ClassStud(string aFIO, DateTime aYear, string aMedB, byte aKurs, byte aGroup) 
        {
            FIO = aFIO;
            Year = aYear;
            Kurs = aKurs;
            Group = aGroup;
            string[] mb = aMedB.Split();
            int n = mb.Length;
            MedB = new double[n];
            for (int i = 0; i < n; i++)
                MedB[i] = Convert.ToDouble(mb[i]);
        } // ClassStud()
    }
}
