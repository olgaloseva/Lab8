using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Метод выводит на консоль содержимое указанной папки и содержимое всех подкаталогов
           
                string path = @"D:\TEMP";
                string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }
                Console.ReadKey();
            }
    }
}
