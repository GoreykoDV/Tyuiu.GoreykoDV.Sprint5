using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text;
using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task3.V5.Lib
{
    public class DataService : ISprint5Task3V5
    {
        public string SaveToFileTextData(int x)
        {
            string fileName = "OutPutFileTask3.bin";
            string path = Path.Combine(AppContext.BaseDirectory, fileName);

            double z = 2 * Math.Pow(x, 3) + 1 / 2 * Math.Pow(x, 2) - 3.5 * x + 2;
            z = Math.Round(z, 3);

            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
                {
                    writer.Write(BitConverter.GetBytes(z));
                }
            }
            catch (UnauthorizedAccessException)
            {
                path = Path.Combine(Path.GetTempPath(), fileName);
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
                {
                    writer.Write(BitConverter.GetBytes(z));
                }
            }

            return path;
        }
    }
}