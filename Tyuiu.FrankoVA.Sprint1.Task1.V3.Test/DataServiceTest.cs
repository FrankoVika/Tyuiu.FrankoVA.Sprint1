using Tyuiu.FrankoVA.Sprint1.Task1.V3.Lib;
namespace Tyuiu.FrankoVA.Sprint1.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 5.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.0, res);
        }
    }
}