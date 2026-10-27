using System;
using Tyuiu.PervuhinEY.Sprint3.Task3.V12.Lib;


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
            Console.WriteLine("* Задание #3                                                       *");
            Console.WriteLine("* Вариант #12                                                      *");
            Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                         *");
            Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв k,*");
            Console.WriteLine("* находящихся на соседних позициях в строкe: bkkrk ckkkcs ksr      *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
            string value = "bkkrk ckkkcs ksr";
            char item = 'k';
            Console.WriteLine("*Строка :bkkrk ckkkcs ksr*");
            Console.WriteLine("*Искомая буква: k*");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* Результат                                                        *");
            Console.WriteLine("Максимальное количество = " + ds.GetMaxCharCount(value,item));
            Console.ReadKey();

        }
    }
}