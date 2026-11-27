using Tyuiu.GoreykoDV.Sprint5.Task2.V28.Lib;

using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\darya\source\repos\Tyuiu.GoreykoDV.Sprint5\Tyuiu.GoreykoDV.Sprint5.Task2.V28\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
