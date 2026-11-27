using Tyuiu.GoreykoDV.Sprint5.Task6.V17.Lib;

using System.IO;
using System.Text;

namespace Tyuiu.GoreykoDV.Sprint5.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\darya\source\repos\Tyuiu.GoreykoDV.Sprint5\Tyuiu.GoreykoDV.Sprint5.Task6.V17\bin\Debug\net8.0\InPutDataFileTask6V17.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }

        public void TestMethod1()
        {
            string path = @"C:\Users\darya\source\repos\Tyuiu.GoreykoDV.Sprint5\Tyuiu.GoreykoDV.Sprint5.Task6.V17\bin\Debug\net8.0\InPutDataFileTask6V17.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

