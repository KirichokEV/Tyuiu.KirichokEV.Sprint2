using Tyuiu.KirichokEV.Sprint2.Task2.V6.Lib;

namespace Tyuiu.KirichokEV.Sprint2.Task2.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнила: Киричoк Е. В.| РППб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Логические операции                                                         *");
            Console.WriteLine("* Задание #2                                                                        *");
            Console.WriteLine("* Вариант #6                                                                        *");
            Console.WriteLine("* Выполнила: Киричок Елиавета Викторовна | РППб-24-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры и вычисляет   *");
            Console.WriteLine("* находится ли точка с координатами X,Y в заштрихованной области.                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Введите значение Х: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            if (res == true)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}
