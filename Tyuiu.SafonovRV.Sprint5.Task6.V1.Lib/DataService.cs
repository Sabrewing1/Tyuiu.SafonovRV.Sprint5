using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SafonovRV.Sprint5.Task6.V1.Lib
{
 
    public class DataService : ISprint5Task6V1
    {
        public int LoadFromDataFile(string path)
        {
            int res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char i in line)
                    {
                        if (char.IsDigit(i))
                        {
                            res++;
                        }
                    }
                }
            }
            return res;
        }
    }
}
