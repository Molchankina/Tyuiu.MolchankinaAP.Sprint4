using System;
using Tyuiu.MolchankinaAP.Sprint4.Task7.V8.Lib;
namespace Tyuiu.MolchankinaAP.Sprint4.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №4 | Выполнил: Молчанкина А.П. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Молчанкина Ангелина Павловна | СМАРТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '264795863157'.                    *");
            Console.WriteLine("* Преобразуйте ее в матрицу 3 на 4                                        *");
            Console.WriteLine("* и подсчитайте произведение четных чисел.                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int rows = 3;
            int columns = 4;
            int[,] mtrx = new int[rows, columns];
            string value = "264795863157";
            int index = 0;

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{value[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(rows, columns, value);

            Console.WriteLine("Произведение чётных элементов = " + res);
            Console.ReadKey();
        }
    }
}
