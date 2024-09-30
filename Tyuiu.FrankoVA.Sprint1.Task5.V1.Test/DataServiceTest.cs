using Tyuiu.FrankoVA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.FrankoVA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x1 = 1;
            int y1 = 4;
            int x2 = 3;
            int y2 = 7;
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            int result = Convert.ToInt32(res);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
//AB = √(xb - xa)2 + (yb - ya)2