using Tyuiu.FrankoVA.Sprint1.Task2.V8.Lib;
namespace Tyuiu.FrankoVA.Sprint1.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 1;
            int b = 5;
            var res = ds.CalculatePerimetr(a, b);
            Assert.AreEqual(6.0, res);
        }
    }
}