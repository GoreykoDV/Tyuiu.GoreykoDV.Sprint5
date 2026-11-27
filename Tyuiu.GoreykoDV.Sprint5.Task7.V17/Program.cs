using Tyuiu.GoreykoDV.Sprint5.Task7.V17.Lib;
using System;
using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Чтение и запись набора данных в текстовый файл                     *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #17                                                              *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан файл InPutDataFileTask7V17.txt, в котором есть набор символьных      *");
            Console.WriteLine("* данных. Заменить в тексте все вхождения \"нн\" на \"н\".                   *");
            Console.WriteLine("* Результат сохранить в OutPutDataFileTask7V17.txt и вывести на консоль.   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string path = Path.Combine(AppContext.BaseDirectory, "InPutDataFileTask7V17.txt");

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            string pathSaveFile = ds.LoadDataAndSave(path);

            Console.WriteLine("Файл: " + pathSaveFile);
            Console.WriteLine("Создан!");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}