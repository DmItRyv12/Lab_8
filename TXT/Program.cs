using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TXT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string patch = "Logs2/Logs.txt";
            //if (!File.Exists(patch))
            //{
            //    File.Create(patch);
            //}
            using (StreamWriter sw = new StreamWriter(patch, true)) 
            {
                sw.WriteLine("Старт программы");
                sw.WriteLine("Ошибка");
                // sw.Close(); 
            }
            using (StreamReader sr = new StreamReader(patch))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();
        }

    }
}
