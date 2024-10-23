using Tyuiu.SafonovRV.Sprint5.Task3.V18.Lib;


namespace Tyuiu.SafonovRV.Sprint5.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 2;
            double result = Math.Round((2.12 * (Math.Pow(x, 3))) + (1.05 * (Math.Pow(x, 2))) + 4.1 * (x) * 2, 3);
            double wait = 37.56;
            Assert.AreEqual(wait, result);
        }
    }
}