﻿using Tyuiu.SafonovRV.Sprint5.Task7.V27.Lib;

namespace Tyuiu.SafonovRV.Sprint5.Task7.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                DataService ds = new DataService();
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Исходные данные:                                                        *");
                Console.WriteLine("***************************************************************************");


                string path = $@"C:\DataSprint5\InPutDataFileTask7V23.txt";
                string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V27.txt";


                Console.WriteLine("Данные находяться в файле: " + path);

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine("Находится в файле : ");
                pathSaveFile = ds.LoadDataAndSave(path);
                Console.WriteLine(pathSaveFile);
                Console.ReadKey();

            }
        }
    }
}
    

