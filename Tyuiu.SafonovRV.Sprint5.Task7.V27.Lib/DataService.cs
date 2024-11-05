using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SafonovRV.Sprint5.Task7.V27.Lib
{
    public class DataService : ISprint5Task7V27
    {
        public string LoadDataAndSave(string path)
        {
            
            FileInfo fileInfo = new FileInfo(Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V27.txt" }));
            if (fileInfo.Exists)
            {
                File.Delete(Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V27.txt" }));
            }


            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string str = "  c  o d  e  r ";
                string tmp = "";
                for (int i = 0; i < str.Length; i++)
                {
                    bool exit = false;
                    if (str[i] == ' ')
                    {
                        for (int j = i + 1; j < str.Length; j++)
                        {
                            if (str[j] != ' ')
                                break;
                            if (j + 1 > str.Length - 1)
                            {
                                exit = true;
                                break;
                            }
                            i = j + 1;
                        }
                    }
                    if (exit)
                        break;
                    tmp = tmp + str[i];
                    Console.Write(str[i]);
                }
                Console.ReadLine();
                File.AppendAllText(path, strLine + Environment.NewLine);
                strLine = "";
            }

            ;

            return path;
        }
    }
}



