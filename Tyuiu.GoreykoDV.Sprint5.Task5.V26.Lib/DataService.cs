using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.Globalization;
using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {
            double sumPositive = 0;
            double sumNegative = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(
                        new char[] { ' ', '\t', ';' },
                        StringSplitOptions.RemoveEmptyEntries
                    );

                    foreach (string part in parts)
                    {
                        string s = part.Trim().Replace(',', '.');
                        double num = double.Parse(s, CultureInfo.InvariantCulture);

                        num = Math.Round(num, 3);

                        if (num > 0)
                            sumPositive += num;
                        else if (num < 0)
                            sumNegative += num;  
                    }
                }
            }
                        
            return Math.Round(sumPositive - Math.Abs(sumNegative), 3);
        }
    }
}