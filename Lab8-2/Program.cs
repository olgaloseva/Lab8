using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_2
{
    class Program
    {
        //Метод создает текстовый файл и записывает в него 10 случайных чисел. 
        //Затем считывает их, расчитывает сумму чисел и выводит результат на консоль
        static void Main(string[] args)
        {
            string path = @"D:\TEMP\Num1.txt";
            const int n = 10;
            Random rand = new Random();
            using (StreamWriter sWriter = new StreamWriter(path, false))    //запись в файл n случайных чисел
            {
                for (int i = 0; i < n; i++)
                {
                    sWriter.WriteLine(rand.Next(-100, 100));
                }
            }

            int summ = 0;
            using (StreamReader sReader = new StreamReader(path))           //чтение из файла n чисел и их суммирование
            {
                for (int i = 0; i < n; i++)
                {
                    summ = summ + Convert.ToInt32(sReader.ReadLine());
                }
            }
            Console.Write("Сумма {0} записанных чисел = {1}", n, summ);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
