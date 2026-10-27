using Tyuiu.PervuhinEY.Sprint3.Task5.V15.Lib;
using System;
using Tyuiu.PervuhinEY.Sprint3.Task5.V15.Lib;



namespace Tyuiu.PervuhinEY.Sprint3.Task0.V25
{
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
            Console.WriteLine("* Задание #5                                                        *");
            Console.WriteLine("* Вариант #15                                                       *");
            Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                             *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                          *");
            Console.WriteLine("* Решить уравнение с вложенным циклом for *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                  *");
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;
            Console.WriteLine("*X = " + x);
            Console.WriteLine("*Стартовое значение1 =" + startValue1);
            Console.WriteLine("*Стартовое значение2 =" + startValue2);
            Console.WriteLine("*Конечное значение1  =" + stopValue1);
            Console.WriteLine("*Конечное значение2  =" + stopValue2);
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* Результат                                                        *");
            Console.WriteLine("Итоговая сумма = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
            Console.ReadKey();

        }
    }
}
