using Tyuiu.FrankoVA.Sprint1.Task2.V8.Lib;

namespace Tyuiu.FrankoVA.Sprint1.Task2.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #1| Выполнила: Франко В.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Франко В.А. | ИБКСб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* Формулировка задания: Известны длины стороны прямоугольника. Вычислить  *");
            Console.WriteLine("* периметр прямоугольника.                                                *");
            Console.WriteLine("* Что пользователь вводит? Длина первой стороны прямоугольника (целое     *");
            Console.WriteLine("* число), Длина второй стороны прямоугольника (целое число)               *");
            Console.WriteLine("* Что программа печатает на экране? Периметр прямоугольника (целое число) *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int a;
            int b;
            Console.WriteLine("Введите значение a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine(" Периметр прямоугольника равен:" + ds.CalculatePerimetr(a,b));
            Console.ReadKey();
        }
    }
}

