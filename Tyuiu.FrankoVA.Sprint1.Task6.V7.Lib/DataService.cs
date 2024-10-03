using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.FrankoVA.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            string result = ""; 

            string[] words = value.Split(' ');

            for (int i = 0; i < words.Length; i++) 
            {
                if (words[i].Length > 0) 
                {
                    result += words[i].Substring(0, words[i].Length - 1) + " ";
                    
                }
            }
            return result.TrimEnd();
        }
    }
}
