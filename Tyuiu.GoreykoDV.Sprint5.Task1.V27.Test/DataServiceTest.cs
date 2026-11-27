using Tyuiu.GoreykoDV.Sprint5.Task1.V27.Lib;

using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\darya\source\repos\Tyuiu.GoreykoDV.Sprint5\Tyuiu.GoreykoDV.Sprint5.Task1.V27\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
