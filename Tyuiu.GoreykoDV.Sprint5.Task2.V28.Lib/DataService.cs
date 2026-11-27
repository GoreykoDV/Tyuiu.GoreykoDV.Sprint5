using tyuiu.cources.programming.interfaces.Sprint5;

using System;
using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task2.V28.Lib
{
    public class DataService : ISprint5Task2V28
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string fileName = "OutPutFileTask2.csv";
            string path = Path.Combine(AppContext.BaseDirectory, fileName);

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string content = "";

            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < columns; ++j)
                {
                    if (j != columns - 1)
                    {
                        content += matrix[i, j] + ";";
                    }
                    else
                    {
                        content += matrix[i, j];
                    }
                }

                if (i != rows - 1)
                {
                    content += Environment.NewLine;
                }
            }

            try
            {
                File.WriteAllText(path, content);
            }
            catch (UnauthorizedAccessException)
            {
                path = Path.Combine(Path.GetTempPath(), fileName);
                File.WriteAllText(path, content);
            }

            return path;
        }
    }
}