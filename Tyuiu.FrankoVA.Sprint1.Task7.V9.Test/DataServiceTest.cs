using Tyuiu.FrankoVA.Sprint1.Task7.V9.Lib;
namespace Tyuiu.FrankoVA.Sprint1.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 7;
            double wait = 5.750;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}