using Tyuiu.SafonovRV.Sprint5.Task6.V1.Lib;

namespace Tyuiu.SafonovRV.Sprint5.Task6.V1
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                DataService ds = new DataService();
                Console.Title = "Спринт #5 | Выполнил: Сафонов Р.В | АСОиУБ-24-1";
                Console.WriteLine("**************************************************************************");
                Console.WriteLine("* Спринт #5                                                              *");
                Console.WriteLine("* Тема: Обработка текстовых файлов                                       *");
                Console.WriteLine("* Задание #6                                                             *");
                Console.WriteLine("* Вариант #1                                                             *");
                Console.WriteLine("* Выполнил: Сафонов Руслан Васильевич | АСОиУБ-24-1                      *");
                Console.WriteLine("**************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                               *");
                Console.WriteLine(@"* Дан файл С:\DataSprint5\InPutDataFileTask6V1.txt в котором есть       *");
                Console.WriteLine("* набор символьных данных. Найти количество цифр в заданной строке.      *");
                Console.WriteLine("**************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
                Console.WriteLine("**************************************************************************");

                string path = @"C:\Users\rusla\source\repos\Tyuiu.SafonovRV.Sprint5\Tyuiu.SafonovRV.Sprint5.Task6.V1.Lib\bin\Debug\net8.0\InPutDataFileTask6V1.txt";

                Console.WriteLine("Данные находятся в файле " + path);

                Console.WriteLine("**************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
                Console.WriteLine("**************************************************************************");

                int res = ds.LoadFromDataFile(path);
                Console.WriteLine(res);
                Console.ReadKey();
            }
        }
    }

    

