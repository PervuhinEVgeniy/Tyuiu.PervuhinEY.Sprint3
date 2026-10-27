using System;
using Tyuiu.PervuhinEY.Sprint3.Task1.V29.Lib;

namespace Tyuiu.PervuhinEY.Sprint3.Task0.V25
{
    class Program
    {
        static void Main(string[] args)
        {


            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Первухин Е. Ю.| АСОиУБ-26-1";
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* Спринт #3                                                        *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* Тема: Базовые навыки работы с C#                                 *");
            Console.WriteLine("* Задание #1                                                       *");
            Console.WriteLine("* Вариант #29                                                      *");
            Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                         *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет       *");
            Console.WriteLine("* произведение ряда по формуле, при X=0.25                          *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
            double value = 0.25;
            int startValue = 1;
            int stopValue = 11;
            Console.WriteLine("*Переменная X =" + value + "*");
            Console.WriteLine("*Старт шага =" + startValue + "*");
            Console.WriteLine("*Конец шага =" + stopValue + "*");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* Результат                                                        *");
            Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();

        }
    }
}