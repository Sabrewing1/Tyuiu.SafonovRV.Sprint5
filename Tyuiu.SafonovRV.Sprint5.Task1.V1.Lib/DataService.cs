using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SafonovRV.Sprint5.Task1.V1.Lib
{
    public class DataService : ISprint5Task1V1
    {
        
            public string SaveToFileTextData(int startValue, int stopValue)
            {
                //string path = $@"{Path.Combine("OutPutFileTask1.txt")}";
                string path = $@"{Path.GetTempPath()}\OutPutFileTask1.txt";

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;

                if (fileExists)
                {
                    File.Delete(path);
                }

                double result;
                string strResult;

                for (double x = startValue; x <= stopValue; x++)
                {
                    result = Math.Round((5*(x))+2.5 / (Math.Sin(x)+3))+2*x+Math.Cos(x);
                    strResult = Convert.ToString(result);

                    if (x != stopValue)
                    {
                        File.AppendAllText(path, strResult + Environment.NewLine);
                    }
                    else
                    {
                        File.AppendAllText(path, strResult);
                    }
                }
                return path;
            }
        }
    }
