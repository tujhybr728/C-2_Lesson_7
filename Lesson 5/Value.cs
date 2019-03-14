using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5
{
    class Value
    {
        //public MainWindow Main = new MainWindow();
        //public string[,] Listall;
        public string path = "List.txt";
        public int Chek;
        public string line;
        public List<Escl> Listall = new List<Escl>();

        public void Search()
        {

        }

        public void NewEsc()
        {

        }

        public void Retrac()
        {
                        
        }

        public void SaveAll() // сохранение списка в файл
        {
            StreamWriter sw1 = new StreamWriter(path, false, System.Text.Encoding.Default);
            sw1.Write("");
            StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default);

            for (int i = 0; i < Listall.LongCount(); i++) // используется список
            {
                sw.WriteLine(Listall.GetType());
                Listall.RemoveAt(i);
            }


        }

        public void RewewAll() // выгрузка списка из файла
        {
            
            Chek = 0;
            StreamReader sr = new StreamReader(path);
            while ((line = sr.ReadLine()) != null)
                Chek++;
            //Listall = new string[Chek/2, 2];
            Chek = 0;
            while(!sr.EndOfStream)
            //for (int i = 0; i<Listall.LongLength; i++)
            // {
            //     line = sr.ReadLine();
            //     if ((i % 2) == 0) Listall[i, 1] = line;
            //     else Listall[i-1, 2] = line;
            // }
            {
                Listall.Add(new Escl(sr.ReadLine(), sr.ReadLine()));
            }
            sr.Close();
        }
        
    }
}
