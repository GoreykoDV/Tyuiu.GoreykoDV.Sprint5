using Tyuiu.GoreykoDV.Sprint5.Task1.V27.Lib;

namespace Tyuiu.GoreykoDV.Sprint5.Task1.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                  *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #27                                                              *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дано выражение , вычислить его значение при x = 2,                       *");
            Console.WriteLine("* результат сохранить в текстовый файл OutPutFileTask0.txt                 *");
            Console.WriteLine("* и вывести на консоль.                                                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл:" + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
