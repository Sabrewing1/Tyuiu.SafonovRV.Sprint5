using Tyuiu.SafonovRV.Sprint5.Task7.V27.Lib;

namespace Tyuiu.SafonovRV.Sprint5.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\rusla\source\repos\Tyuiu.SafonovRV.Sprint5\Tyuiu.SafonovRV.Sprint5.Task7.V27\bin\Debug\net8.0\OutPutDataFileTask7V27";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}