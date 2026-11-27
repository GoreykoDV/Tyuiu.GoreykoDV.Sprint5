using tyuiu.cources.programming.interfaces.Sprint5;

using System.Text;
using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {
            double sumPositive = 0;
            double sumNegative = 0;
            double res = 0;

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
                        double num = Convert.ToDouble(part);

                        if (num > 0)
                            sumPositive += num;
                        else if (num < 0)
                            sumNegative += num;
                    }
                }
                res = Math.Round(sumPositive - sumNegative, 3);
                return res;
            }
        }
    }
}
