using Tyuiu.FrankoVA.Sprint1.Task3.V12.Lib;
namespace Tyuiu.FrankoVA.Sprint1.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #1| Выполнила: Франко В.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Франко В.А. | ИБКСб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* Расчеты: Написать программу для вычисления площади прямоугольного       *");
            Console.WriteLine("* треугольника по длинам двух катетов. Ответ округлите до 3 знаков после  *");
            Console.WriteLine("* запятой.                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            double a;
            double b;
            Console.WriteLine("Введите значение a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Площадь прямоугольного треугольника равна:" +  ds.TriangleArea(a, b));
            Console.ReadKey();
        }
    }
}
