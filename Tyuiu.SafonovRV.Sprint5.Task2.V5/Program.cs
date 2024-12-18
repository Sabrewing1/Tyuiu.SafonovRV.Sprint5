﻿using Tyuiu.SafonovRV.Sprint5.Task2.V5.Lib;
using System.IO;

namespace Tyuiu.SafonovRV.Sprint5.Task2.V5
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                int[,] mtrx = new int[3, 3] { { 9, 6, 6},
                                          { 8, 7, 2},
                                          { 1, 7, 8} };
                int rows = mtrx.GetUpperBound(0) + 1;
                int colums = mtrx.Length / rows;

                DataService ds = new DataService();

                Console.Title = "Спринт #5 | Выполнил: Сафонов Р.В | АСОиУБ-24-1";
            Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Спринт #5                                                               *");
                Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
                Console.WriteLine("* Задание: 2                                                              *");
                Console.WriteLine("* Вариант #5                                                              *");
                Console.WriteLine("* Выполнил: Сафонов Руслан Васильевич                                     *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                *");
                Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
                Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
                Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(mtrx);

            Console.WriteLine($"Файл: {path}");
            Console.WriteLine("Создан!");
            Console.WriteLine();

            string[] y = File.ReadAllLines(path);

            Console.WriteLine("Результирующий массив:");
            for (int i = 0; i < rows; i++)
            {
                string[] yy = y[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    Console.Write(($"{Convert.ToDouble(yy[j])} \t"));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
