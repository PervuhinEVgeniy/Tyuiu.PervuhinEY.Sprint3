using System;
using Tyuiu.PervuhinEY.Sprint3.Task4.V23.Lib;



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
            Console.WriteLine("* Задание #3                                                        *");
            Console.WriteLine("* Вариант #12                                                       *");
            Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                             *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                          *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5,                  *");
            Console.WriteLine("* вычислить значение функции y=(cos(x)/x)+3. При х = 0 прервать цикл*");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*Полученные значения перемножать.                                   *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                  *");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("*Стартовое значение" + startValue);
            Console.WriteLine("*Конечное  значение" + stopValue);
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* Результат                                                        *");
            Console.WriteLine("Итоговая сумма = " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();

        }
    }
}
