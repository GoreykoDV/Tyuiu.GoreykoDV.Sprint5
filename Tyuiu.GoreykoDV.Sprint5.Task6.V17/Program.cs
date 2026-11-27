using Tyuiu.GoreykoDV.Sprint5.Task6.V17.Lib;
using System;
using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task6.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                           *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #17                                                              *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан файл InPutDataFileTask6V17.txt, в котором есть набор символьных      *");
            Console.WriteLine("* данных. Найти количество пробелов, идущих подряд больше одного,          *");
            Console.WriteLine("* в заданной строке.                                                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string path = Path.Combine(AppContext.BaseDirectory, "InPutDataFileTask6V17.txt");

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.LoadFromDataFile(path);   // int, не double!

            Console.WriteLine(res);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}