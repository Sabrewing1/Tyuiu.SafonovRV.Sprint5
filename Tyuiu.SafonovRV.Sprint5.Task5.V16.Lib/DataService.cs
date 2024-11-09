using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SafonovRV.Sprint5.Task5.V16.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {
            double MaxValue = int.MinValue;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) < MaxValue)
                        MaxValue = Math.Round(Convert.ToDouble(line)/10, 3);
                }
                return MaxValue;
            }
        }
    }
}
    

