﻿using System.Net.Http.Headers;
using Tyuiu.KirichokEV.Sprint2.Task3.V22.Lib;

namespace Tyuiu.KirichokEV.Sprint2.Task3.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Киричoк Е. В.| РППб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Вложенные операторы if-else                                                 *");
            Console.WriteLine("* Задание #3                                                                        *");
            Console.WriteLine("* Вариант #22                                                                       *");
            Console.WriteLine("* Выполнила: Киричок Елиавета Викторовна | РППб-24-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y                *");
            Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит              *");
            Console.WriteLine("* значение переменной X с клавиатуры.                                               *");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой.                       *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Введите значение переменной Х:");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Значение функции =" + res);

            Console.ReadKey();
        }
    }
}

