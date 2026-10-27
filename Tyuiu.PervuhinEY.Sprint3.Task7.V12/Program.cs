using Tyuiu.SpirinIS.Sprint3.Task7.V12.Lib;
namespace Tyuiu.PervuhinEY.Sprint3.Task7.V12;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Первухин Е. Ю. | АСОиУБ-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы с C#                                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнил: Первухин Е. Ю. | АСОиУБ-26-1                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        // Получаем длину массива (11 элементов)
        int len = ds.GetMassFunction(startValue, stopValue).Length;

        // Создаем массив и заполняем его результатами
        double[] valueArray = new double[len];
        valueArray = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        // Вывод таблицы
        Console.WriteLine("+----------------------+");
        Console.WriteLine("|   X   |    F(x)      |");
        Console.WriteLine("+----------------------+");

        for (int i = 0; i < len; i++)
        {
            // Вычисляем текущее значение x для каждого шага (от -5 до 5)
            int currentX = startValue + i;

            // Выводим X (по ширине 5) и F(x) (с 2 знаками после запятой)
            Console.WriteLine("| {0,5} | {1,12:f2} |", currentX, valueArray[i]);
        }

        Console.WriteLine("+----------------------+");
        Console.ReadKey();



    }
}

