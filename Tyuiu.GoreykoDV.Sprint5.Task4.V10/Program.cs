using Tyuiu.GoreykoDV.Sprint5.Task4.V10.Lib;

namespace Tyuiu.GoreykoDV.Sprint5.Task4.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                  *");
            Console.WriteLine("* Задание #4                                                               *");
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

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V10.txt";

            Console.WriteLine("Данные находятся в файле: " + path);


            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
