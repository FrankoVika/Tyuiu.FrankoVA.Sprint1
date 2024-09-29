using Tyuiu.FrankoVA.Sprint1.Task3.V12.Lib;
namespace Tyuiu.FrankoVA.Sprint1.Task3.V12.Test
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
            double wait = 2.5;
            var res = ds.TriangleArea(a, b);
            Assert.AreEqual(wait, res);
        }
    }
}