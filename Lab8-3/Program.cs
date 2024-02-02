using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_3
{
    class Program
    {
        //Метод выводит на консоль статистику по текстовому файлу: кол-во символов, строк и слов
        static void Main(string[] args)
        {
            string path = @"D:\TEMP\t2.txt";

            int countLine = File.ReadAllLines(path).Length;
            int countChar = File.ReadAllText(path).Length;
            int countWord = 0;

            string text = "";
            string[] textWord;

            using (StreamReader sReader = new StreamReader(path))
            {
                while (sReader.EndOfStream != true)
                {
                    text = text + sReader.ReadLine();
                }
            }

            textWord = text.Split();
            countWord = textWord.Length;

            Console.WriteLine("Статистика по файлу {0} ", path);
            Console.WriteLine();
            Console.WriteLine("Количество строк: {0}", countLine);
            Console.WriteLine("Количество символов: {0}", countChar);
            Console.WriteLine("Количество слов: {0}", countWord);

            Console.ReadKey();
        }
    }
}
