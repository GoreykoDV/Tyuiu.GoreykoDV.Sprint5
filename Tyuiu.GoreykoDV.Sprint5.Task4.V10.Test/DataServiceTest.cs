using Tyuiu.GoreykoDV.Sprint5.Task4.V10.Lib;

using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\darya\source\repos\Tyuiu.GoreykoDV.Sprint5\Tyuiu.GoreykoDV.Sprint5.Task4.V10\bin\Debug\net8.0\InPutDataFileTask4V10.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
