﻿using Tyuiu.FrankoVA.Sprint1.Task0.V7.Lib;
namespace Tyuiu.FrankoVA.Sprint1.Task0.V7
{
    internal class Program
    {
            static void Main(string[] args)
            {
                DataService ds = new DataService();



                Console.Title = "Спринт #1| Выполнила: Франко В.А. | ИБКСб-24-1";
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Спринт #1                                                               *");
                Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
                Console.WriteLine("* Задание #0                                                              *");
                Console.WriteLine("* Вариант #7                                                              *");
                Console.WriteLine("* Выполнила: Франко В.А. | ИБКСб-24-1                                     *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                *");
                Console.WriteLine("* Написать программу, которая вычисляет выражение 18/6*2 - (4-3) и        *");
                Console.WriteLine("* печатает результат на экране.                                           *");
                Console.WriteLine("*                                                                         *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* 18/6*2 - (4-3)                                                          *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine(ds.Calculate());
                Console.ReadKey();
            }
    }
}
