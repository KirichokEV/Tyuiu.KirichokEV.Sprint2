using System.Net.Http.Headers;
using Tyuiu.KirichokEV.Sprint2.Task2.V6.Lib;

namespace Tyuiu.KirichokEV.Sprint2.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadeArea()
        {
            DataService ds = new DataService();
            int x = 8;
            int y = 6;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}