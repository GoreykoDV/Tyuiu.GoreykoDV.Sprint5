using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text;
using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task3.V5.Lib
{
    public class DataService : ISprint5Task3V5
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

            double z = 2 * Math.Pow(x, 3) + 1 / 2 * Math.Pow(x, 2) - 3.5 * x + 2;
            z = Math.Round(z, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(z));
            }

            return path;

        }
    }
}
