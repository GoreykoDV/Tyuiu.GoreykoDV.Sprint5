using tyuiu.cources.programming.interfaces.Sprint5;

using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task6.V17.Lib
{
    public class DataService : ISprint5Task6V17
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int i = 0;                          
                    while (i < line.Length)
                    {
                        if (line[i] == ' ')
                        {
                            int groupLength = 0;
                            while (i < line.Length && line[i] == ' ')
                            {
                                groupLength++;
                                i++;
                            }

                            if (groupLength > 1)
                            {
                                count += groupLength;
                            }
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
            }
            return count;
        }
    }
}