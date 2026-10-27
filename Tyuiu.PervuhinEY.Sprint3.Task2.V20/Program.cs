using System;
using Tyuiu.PervuhinEY.Sprint3.Task2.V20.Lib;

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
            Console.WriteLine("* Задание #2                                                       *");
            Console.WriteLine("* Вариант #20                                                      *");
            Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                         *");
            Console.WriteLine("* Написать программу используя цикл do while, которая вычисляет    *");
            Console.WriteLine("* произведение ряда по формуле, при X=1                            *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
            int value = 1;
            int startValue = 1;
            int stopValue = 6;
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