using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.FrankoVA.Sprint1.Task5.V1.Lib
{
    public class DataService :ISprint1Task5V1
    {
        public int DistanceBetweenDots(double x1, double y1, double x2, double y2)
        {
            var res = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
            int result = Convert.ToInt32(res);
            return result;
        }
    }
}
//AB = √(xb - xa)2 + (yb - ya)2