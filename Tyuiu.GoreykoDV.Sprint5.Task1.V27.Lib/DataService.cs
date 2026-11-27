using tyuiu.cources.programming.interfaces.Sprint5;

using System;
using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task1.V27.Lib
{
    public class DataService : ISprint5Task1V27
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string fileName = "OutPutFileTask1.txt";
            string path = Path.Combine(AppContext.BaseDirectory, fileName);

            string content = "";

            for (int x = startValue; x <= stopValue; x++)
            {
                double z = Math.Sin(x) - 3 + x;
                double y;

                if (z == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round((3 * x - 1.5) / z + 2, 2);
                }

                if (x != stopValue)
                {
                    content += y.ToString() + Environment.NewLine;
                }
                else
                {
                    content += y.ToString();
                }
            }

            try
            {
                File.WriteAllText(path, content);
            }
            catch (UnauthorizedAccessException)
            {
                path = Path.Combine(Path.GetTempPath(), fileName);
                File.WriteAllText(path, content);
            }

            return path;
        }
    }
}