using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SafonovRV.Sprint5.Task1.V1.Lib
{
    public class DataService : ISprint5Task1V1
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {


            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            try
            {
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    StringBuilder sb = new StringBuilder();

                    for (int x = startValue; x <= stopValue; x++)
                    {
                        double denominator = Math.Sin(x) + 2 + x;

                        if (Math.Abs(denominator) < double.Epsilon)
                        {
                            sb.AppendLine("0");
                        }
                        else
                        {
                            double res = Math.Round((5 * x + 2.5) / denominator + 2, 2);
                            sb.AppendLine(res.ToString());
                        }
                    }

                    // Remove the last newline
                    if (sb.Length > 0) sb.Length--;

                    writer.Write(sb.ToString());
                }

                return path;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
    }
}





