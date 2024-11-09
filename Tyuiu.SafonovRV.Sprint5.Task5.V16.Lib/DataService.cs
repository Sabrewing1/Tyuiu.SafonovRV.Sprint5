using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SafonovRV.Sprint5.Task5.V16.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path);
            var values = fileContent
                .Split(new[] { ' ', '\n', '\r', ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(val =>
                {
                    if (double.TryParse(val, out double doubleValue))
                    {
                        return Math.Round(doubleValue, 3);
                    }
                    return (double?)null;
                })
                .Where(val => val.HasValue)
                .Select(val => val.Value)
                .ToArray();
            var maxInteger = values.Where(val => val == Math.Truncate(val)).Min();
            return maxInteger;
        }
    }
}
    




