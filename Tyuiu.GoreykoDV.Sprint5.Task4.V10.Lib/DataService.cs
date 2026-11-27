using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task4.V10.Lib
{
    public class DataService : ISprint5Task4V10
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Pow(Convert.ToDouble(strX), 3)*1.2* Convert.ToDouble(strX) + 2;
            double res1 = Math.Round(res, 3);
            return res1;
        }
    }
}
