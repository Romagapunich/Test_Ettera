using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roma_Gapunich_Ettero
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "";
            string[] textMass;
            StreamReader sr = new StreamReader("data.txt");
            FileStream fs = new FileStream("results.txt", FileMode.Create);
            fs.Close();

            while (sr.EndOfStream != true)
            {
                s = sr.ReadLine();
            }
            int x = 1;
            textMass = s.Split(' ');
            Array.Sort(textMass);

            for (int i = 0; i < textMass.Length - 1; i++)
            {

                if (textMass[i].ToUpper() == textMass[i + 1].ToUpper())
                {
                    x++;
                }
                else
                {
                    File.AppendAllText("results.txt",textMass[i] + " " + x + " " + "\r\n");
                    x = 1;
                }
            }

            sr.Close();
            Console.WriteLine("Завершено" + "Количетсво слов " +  textMass.Length  + " Результат в файле result.txt по адрессу Roma_Gapunich_Ettero/Roma_Gapunich_Ettero/bin/Debug");
            Console.ReadKey();
        }
    }
}

