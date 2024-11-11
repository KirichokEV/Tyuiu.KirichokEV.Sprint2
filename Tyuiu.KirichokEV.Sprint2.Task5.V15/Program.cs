using Tyuiu.KirichokEV.Sprint2.Task5.V15.Lib;

namespace Tyuiu.KirichokEV.Sprint2.Task5.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Киричoк Е. В.| РППб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Оператор switch                                                             *");
            Console.WriteLine("* Задание #5                                                                        *");
            Console.WriteLine("* Вариант #15                                                                       *");
            Console.WriteLine("* Выполнила: Киричок Елиавета Викторовна | РППб-24-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели                 *");
            Console.WriteLine("* (понедельником, вторником, …, субботой или воскресеньем) является k-й день        *");
            Console.WriteLine("* не високосного года, в котором 1 января понедельник.                              *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Введите номер дня недели");
            int numMouth = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numMouth < 1) || (numMouth > 7))
            {
                res = "Введено неверное заначение!";
            }
            else
            {
                res = "Это день недели: " + ds.FindDayName(numMouth);
            }

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
