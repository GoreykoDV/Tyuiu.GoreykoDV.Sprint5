using Tyuiu.GoreykoDV.Sprint5.Task5.V26.Lib;

using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task5.V26.Test
{
    [TestClass]
    public sealed class DataServicTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\darya\source\repos\Tyuiu.GoreykoDV.Sprint5\Tyuiu.GoreykoDV.Sprint5.Task5.V26\bin\Debug\net8.0\InPutDataFileTask5V26.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
