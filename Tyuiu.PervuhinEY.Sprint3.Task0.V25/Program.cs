using System;
using Tyuiu.PervuhinEY.Sprint3.Task0.V25.Lib;

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
            Console.WriteLine("* Задание #0                                                       *");
            Console.WriteLine("* Вариант #25                                                      *");
            Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                         *");
            Console.WriteLine("* Написать программу используя цикл for,   которая вычисляет сумму *");
            Console.WriteLine("* ряда по формуле, при X=5                                         *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
            int value = 5;
            int startValue = 1;
            int stopValue = 14;
            Console.WriteLine("*Переменная X =" + value + "*");
            Console.WriteLine("*Старт шага =" + startValue + "*");
            Console.WriteLine("*Конец шага =" + stopValue + "*");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* Результат                                                        *");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue,stopValue));
            Console.ReadKey();

        }
    }
}
