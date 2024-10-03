using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.FrankoVA.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            string result = string.Join(" ", value.Split(' ').Select(word => word.Length > 1 ? word.Substring(0, word.Length - 1) : ""));
            return result;
        }
    }
}
