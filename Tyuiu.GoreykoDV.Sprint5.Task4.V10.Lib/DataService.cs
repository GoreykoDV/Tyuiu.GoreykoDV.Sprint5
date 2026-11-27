using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task4.V10.Lib
{
    public class DataService : ISprint5Task4V10
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Trim();   
            double x = Convert.ToDouble(strX);
            double res = Math.Pow(x, 3) * 1.2 * x + 2;     
            return Math.Round(res, 3);                     
        }
    }
}