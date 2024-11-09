using Tyuiu.SafonovRV.Sprint5.Task5.V16.Lib;

namespace Tyuiu.SafonovRV.Sprint5.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\rusla\source\repos\Tyuiu.SafonovRV.Sprint5\Tyuiu.SafonovRV.Sprint5.Task5.V16\bin\Debug\net8.0\OutPutFileTask5.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

        
    
