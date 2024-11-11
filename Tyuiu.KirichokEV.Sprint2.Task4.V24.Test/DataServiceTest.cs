using Tyuiu.KirichokEV.Sprint2.Task4.V24.Lib;

namespace Tyuiu.KirichokEV.Sprint2.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 28;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 0.494;
            Assert.AreEqual(wait, res);
        }
    }
}