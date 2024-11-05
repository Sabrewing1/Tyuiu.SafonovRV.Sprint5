using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SafonovRV.Sprint5.Task7.V27.Lib
{
    public class DataService : ISprint5Task7V27
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V27.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
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
                File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                strLine = "";
            }


            return pathSaveFile;
        }
    }
}



