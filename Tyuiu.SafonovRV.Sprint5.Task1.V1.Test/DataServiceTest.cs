using Tyuiu.SafonovRV.Sprint5.Task1.V1.Lib;

namespace Tyuiu.SafonovRV.Sprint5.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\rusla\source\repos\Tyuiu.SafonovRV.Sprint5\Tyuiu.SafonovRV.Sprint5.Task1.V1.Test\bin\Debug\OutPutFileTask1.txt.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}