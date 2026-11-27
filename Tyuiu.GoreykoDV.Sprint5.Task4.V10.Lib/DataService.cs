using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.Globalization;
using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task4.V10.Lib
{
    public class DataService : ISprint5Task4V10
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Trim();
                        
            strX = strX.Replace(',', '.');
            double x = double.Parse(strX, CultureInfo.InvariantCulture);

            double res = Math.Pow(x, 3) * 1.2 * x + 2;   
            return Math.Round(res, 3);
        }
    }
}