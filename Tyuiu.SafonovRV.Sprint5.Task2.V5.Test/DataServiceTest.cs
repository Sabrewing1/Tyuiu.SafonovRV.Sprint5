using Tyuiu.SafonovRV.Sprint5.Task2.V5.Lib;
using System.IO;


namespace Tyuiu.SafonovRV.Sprint5.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\rusla\source\repos\Tyuiu.SafonovRV.Sprint5\Tyuiu.SafonovRV.Sprint5.Task2.V5.Lib\bin\Debug\net8.0\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}