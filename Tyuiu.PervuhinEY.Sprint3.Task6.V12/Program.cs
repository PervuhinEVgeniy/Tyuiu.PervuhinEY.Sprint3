
using System;
using Tyuiu.PervuhinEY.Sprint3.Task6.V12.Lib;



namespace Tyuiu.PervuhinEY.Sprint3.Task6.V12;

    class Program
    {
        static void Main(string[] args)
        {


            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Первухин Е. Ю.| АСОиУБ-26-1";
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* Спринт #3                                                         *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* Тема: Базовые навыки работы с C#                                  *");
            Console.WriteLine("* Задание #6                                                        *");
            Console.WriteLine("* Вариант #12                                                       *");
            Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                             *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                          *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,               *");
            Console.WriteLine("* принадлежащих числовому отрезку [9, 18] сумму  всех делителей     *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                  *");
            int startValue = 9;
            int stopValue = 18;
            Console.WriteLine("*Начало отрезка = " + startValue);
            Console.WriteLine("*Конец отезка = " + stopValue);
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* Результат                                                        *");
            Console.WriteLine("Итоговая сумма = " + ds.GetSumTheDivisors(startValue,stopValue));
            Console.ReadKey();

        }
    }

