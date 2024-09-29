using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.FrankoVA.Sprint1.Task3.V12.Lib
{
    public class DataService : ISprint1Task3V12
    {
        public double TriangleArea(double a, double b)

        {
            var res = 0.5 * (a * b);
            return Math.Round(res,3);
        }
    }
}
