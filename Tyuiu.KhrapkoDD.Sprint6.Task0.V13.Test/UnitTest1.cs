using Tyuiu.KhrapkoDD.Sprint6.Task0.V13.Lib;
namespace Tyuiu.KhapkoDD.Sprint6.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 3.375;
            Assert.AreEqual(res, wait);
        }
    }
}