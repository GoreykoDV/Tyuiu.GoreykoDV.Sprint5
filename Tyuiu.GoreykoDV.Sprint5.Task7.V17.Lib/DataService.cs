using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;

namespace Tyuiu.GoreykoDV.Sprint5.Task7.V17.Lib
{
    public class DataService : ISprint5Task7V17
    {
        public string LoadDataAndSave(string path)
        {
            string fileName = "OutPutDataFileTask7V17.txt";
            string pathSaveFile = Path.Combine(AppContext.BaseDirectory, fileName);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            StringBuilder result = new StringBuilder();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string processedLine = line.Replace("нн", "н");
                    result.AppendLine(processedLine);
                }
            }

            File.WriteAllText(pathSaveFile, result.ToString());

            return pathSaveFile;
        }
    }
}