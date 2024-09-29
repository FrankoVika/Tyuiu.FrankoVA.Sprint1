using Tyuiu.FrankoVA.Sprint1.Task4.V20.Lib;
namespace Tyuiu.FrankoVA.Sprint1.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 7;
            double wait = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}