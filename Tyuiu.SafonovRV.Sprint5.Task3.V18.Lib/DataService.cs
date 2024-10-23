using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SafonovRV.Sprint5.Task3.V18.Lib
{
    public class DataService : ISprint5Task3V18
    {
        public string SaveToFileTextData(int x)
        {
            double calculation = Math.Round((2.12 * (Math.Pow(x, 3))) + (1.05 * (Math.Pow(x, 2)))+4.1*(x)*2, 3);
            byte[] byteArray = BitConverter.GetBytes(calculation);
            string tempFilePath = Path.GetTempFileName();
            File.WriteAllBytes(tempFilePath, byteArray);
            return tempFilePath;
        }
    }
}
