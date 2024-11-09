using Tyuiu.SafonovRV.Sprint5.Task5.V16.Lib;

namespace Tyuiu.SafonovRV.Sprint5.Task5.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Сафонов Р.В АСОиУБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Сафонов Руслан Васиильевич | АСОиУБ-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти максимальное целое число в файле, которое делится на 10           *");


            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\Users\rusla\source\repos\Tyuiu.SafonovRV.Sprint5\Tyuiu.SafonovRV.Sprint5.Task5.V16\bin\Debug\net8.0\OutPutFileTask5.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Минимальное вещественное число: " + res);
            Console.ReadKey();
        }
    }
}
