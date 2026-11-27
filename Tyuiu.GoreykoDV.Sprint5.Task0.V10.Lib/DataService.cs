using tyuiu.cources.programming.interfaces.Sprint5;

using System;
using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task0.V10.Lib
{
    public class DataService : ISprint5Task0V10
    {
        public string SaveToFileTextData(int x)
        {
            string fileName = "OutPutFileTask0.txt";
            string path = Path.Combine(AppContext.BaseDirectory, fileName);

            double z = 1.6 * Math.Pow(x, 3) - 2.1 * Math.Pow(x, 2) + 7 * x;
            z = Math.Round(z, 3);

            try
            {
                File.WriteAllText(path, z.ToString());
            }
            catch (UnauthorizedAccessException)
            {
                
                path = Path.Combine(Path.GetTempPath(), fileName);
                File.WriteAllText(path, z.ToString());
            }

            return path;
        }
    }
}