using Tyuiu.GoreykoDV.Sprint5.Task0.V10.Lib;

namespace Tyuiu.GoreykoDV.Sprint5.Task0.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                              *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #10                                                              *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дано выражение , вычислить его значение при x = 2,                       *");
            Console.WriteLine("* результат сохранить в текстовый файл OutPutFileTask0.txt                 *");
            Console.WriteLine("* и вывести на консоль.                                                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
                       
            Console.WriteLine("x = " + x);
            
            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            string res = ds.SaveToFileTextData(x);
            
            Console.WriteLine("Файл:" + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
