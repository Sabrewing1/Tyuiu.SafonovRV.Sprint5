using Tyuiu.SafonovRV.Sprint5.Task4.V5.Lib;

namespace Tyuiu.SafonovRV.Sprint5.Task4.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Сафонов Р.В | АСОиУБ-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #5                                                             *");
            Console.WriteLine("* Выполнил: Сафонов Руслан Васильевич | АСОиУБ-24-1                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан файл C:|DataSprint5|Sprint5Task4|InPutDataFileTask4V12.txt         *");
            Console.WriteLine("* в котором есть вещественное значение. Прочитать значение из файла и    *");
            Console.WriteLine("* подставить вместо Х в формулу. Вычислить значение по формуле           *");
            Console.WriteLine("* (Полученное значение округлить до трёх знаков после запятой) и вернуть *");
            Console.WriteLine("* полученный результат на консоль.                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            string path = @"C:\Users\rusla\source\repos\Tyuiu.SafonovRV.Sprint5\Tyuiu.SafonovRV.Sprint5.Task4.V5\bin\Debug\net8.0\OutPutFileTask4.txt";

            Console.WriteLine("Данные находятся в файле" + path);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
        
    

