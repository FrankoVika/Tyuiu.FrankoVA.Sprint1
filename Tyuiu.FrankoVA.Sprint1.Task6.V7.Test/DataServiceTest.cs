using System.Text.RegularExpressions;
using Tyuiu.FrankoVA.Sprint1.Task6.V7.Lib;
namespace Tyuiu.FrankoVA.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression(string value)
        {
            value = Regex.Replace(value, @"\b(\w+)(\w)\b", "$1");

        }
    }
}