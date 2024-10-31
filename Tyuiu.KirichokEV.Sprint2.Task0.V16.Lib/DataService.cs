using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KirichokEV.Sprint2.Task0.V16.Lib
{
    public class DataService : ISprint2Task0V16
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x - 750 == y;
            res[1] = x - 750 != y;
            res[2] = x - 800 < y;
            res[3] = x - 800 > y;
            res[4] = x - 800 <= y;
            res[5] = x - 800 >= y;

            return res;

        }
    }
}
