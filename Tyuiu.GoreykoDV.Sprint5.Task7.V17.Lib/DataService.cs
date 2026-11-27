using tyuiu.cources.programming.interfaces.Sprint5;

using System.Text;
using System;
using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task7.V17.Lib
{
    public class DataService : ISprint5Task7V17
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V17.txt";
            
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
                        
            string strLine = "";
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
