using Tyuiu.GoreykoDV.Sprint5.Task3.V5.Lib;

using System.IO;

namespace Tyuiu.GoreykoDV.Sprint5.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\darya\source\repos\Tyuiu.GoreykoDV.Sprint5\Tyuiu.GoreykoDV.Sprint5.Task3.V5\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
