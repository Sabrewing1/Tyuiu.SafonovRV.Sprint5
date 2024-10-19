using Tyuiu.SafonovRV.Sprint5.Task0.V13.Lib;

namespace Tyuiu.SafonovRV.Sprint5.Task0.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Сафонов Р.В | АСОиУБ-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт5                                                                   *");
            Console.WriteLine("*Тема: Класс File. Запись данных в текстовый файл                          *");
            Console.WriteLine("*Задание #0                                                                *");
            Console.WriteLine("*Вариант #13                                                               *");
            Console.WriteLine("*Выполнил: Сафонов Руслан Васильевич| АСОиУБ-24-1                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дано выражение, вычислить его значение при x = 5, результат сохранить в  *");
            Console.WriteLine("* текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до    *");
            Console.WriteLine("* трёх знаков после запятой.                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            int x = 5;
            Console.WriteLine("x = " + x);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл:" + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
