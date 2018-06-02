using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace task_1_3_17
{
    [Serializable]
    public  class ClassListStud//: ISerializable
    {
         ClassStud[] listStud;

        struct max
        {
            public double Max;
            public int Indx;
        }

        max[] max5;

        public ClassListStud()
        {
            listStud = new ClassStud[0];
        }

        void formStructMax()
        {
            max5 = new max[5];
            for (int i = 0; i < 5; i++)
            {
                max5[i].Max = 0;
                max5[i].Indx = 0;
            }
        } // formStructMax()

        void formListStud_FromText(string FileName)
        {
            FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            string fio;
            fio = reader.ReadLine();
            while (fio != null)
            {

                    string sd = reader.ReadLine();
                    DateTime date = DateTime.Parse(sd);
                    string mB = reader.ReadLine();
                    byte kurs = Convert.ToByte(reader.ReadLine());
                    byte gr = Convert.ToByte(reader.ReadLine());
                    int n = listStud.Length;
                    Array.Resize(ref listStud, n + 1);
                    listStud[n] = new ClassStud(fio, date, mB, kurs, gr);
                fio = reader.ReadLine();
            }
            reader.Close();
            stream.Close();
        } // formListStud

        void ListToFile()//(string fileName)
        {
            // сериализация всего массива listStud
            FileStream stream = new FileStream("stud.st", FileMode.Create, FileAccess.Write);
            BinaryFormatter bfm = new BinaryFormatter();
            bfm.Serialize(stream, listStud);

            stream.Close();


        }// ListToFile

        void listFromFile()//(string fileName)
        {
            // десериализация
            FileStream stream = new FileStream("stud.st", FileMode.Open, FileAccess.Read);
            BinaryFormatter bfm_ = new BinaryFormatter();
            ClassStud[] listStud = (ClassStud[])bfm_.Deserialize(stream); 
                stream.Close();
        } // istFromFile

        double averBall(int i)
        {
            double res = 0;
            int n = listStud[i].MedB.Length;
            for (int j = 0; j < n; j++) res += listStud[i].MedB[j];

            return res/n;
        }

        void search_5_max()
        {
            formStructMax();
            for (int i = 0; i < listStud.Length; i++) //  для всех студентов
            {
                double avBall=averBall(i);
                if (avBall > max5[0].Max) // больше первого максимума
                {
                    for (int j = 4; j > 0; j--)
                    {
                        max5[j].Max = max5[j - 1].Max;
                        max5[j].Indx = max5[j - 1].Indx;
                    }
                    max5[0].Max = avBall; max5[0].Indx = i;
                }
                else
                    if (avBall > max5[1].Max)  // больше второго максимума
                    {
                        for (int j = 4; j > 1; j--)
                        {
                            max5[j].Max = max5[j - 1].Max;
                            max5[j].Indx = max5[j - 1].Indx;
                        }
                        max5[1].Max = avBall; max5[1].Indx = i;
                    }
                    else
                        if (avBall > max5[2].Max) // больше третьего максимума
                        {
                            for (int j = 4; j > 2; j--)
                            {
                                max5[j].Max = max5[j - 1].Max;
                                max5[j].Indx = max5[j - 1].Indx;
                            }
                            max5[2].Max = avBall; max5[2].Indx = i;
                        }
                        else
                            if (avBall > max5[3].Max) // больше четвёртого максимума
                            {
                                max5[4].Max = max5[3].Max;
                                max5[4].Indx = max5[3].Indx;
                                max5[3].Max = avBall; max5[3].Indx = i;
                            }
                            else
                            {
                                if (avBall > max5[4].Max) // больше пятого максимума
                                {
                                    max5[4].Max = avBall; max5[4].Indx = i;
                                }
                            }
            } // for
        } //search_5_max

        public string best_5(string FlName)
        {
            formListStud_FromText(FlName);
            ListToFile();
            listFromFile();

            search_5_max();
            
            string res = Environment.NewLine;
            for (int i = 0; i < 5; i++)
            {
                res += listStud[max5[i].Indx].FIO + "  " + String.Format("{0:0.00}", max5[i].Max) + Environment.NewLine; 
            }
                return res;
        } //best_5
    }

    
}
