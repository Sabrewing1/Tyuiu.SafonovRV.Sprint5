using Tyuiu.SafonovRV.Sprint5.Task1.V1.Lib;

namespace Tyuiu.SafonovRV.Sprint5.Task1.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            DataService ds = new DataService();
           
            Console.Title = "Спринт #5 | Выполнил: Сафонов Р.В | АСОиУБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Сафонов Руслан Васильевич| АСОиУБ-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, f(x) (произвести табулирование) на заданном диапазоне     *");
            Console.WriteLine("* [-5;5] с шагом 1. Результат сохранить в текстовый файл                  *");
            Console.WriteLine("* OutPutFileTask1.txt и вывести на консоль. Округлить до двух знаков.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}



