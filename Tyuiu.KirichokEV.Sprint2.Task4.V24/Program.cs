using Tyuiu.KirichokEV.Sprint2.Task4.V24.Lib;

namespace Tyuiu.KirichokEV.Sprint2.Task4.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Киричoк Е. В.| РППб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Тернарный оператор                                                          *");
            Console.WriteLine("* Задание #4                                                                        *");
            Console.WriteLine("* Вариант #24                                                                       *");
            Console.WriteLine("* Выполнила: Киричок Елиавета Викторовна | РППб-24-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использование          *");
            Console.WriteLine("* тернарного опрератора, где пользователь вводит значение переменных x, y           *");
            Console.WriteLine("* с клавиатуры.                                                                     *");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой.                       *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Введите значение переменной Х:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Значение функции =" + res);

            Console.ReadKey();
        }
    }
}
