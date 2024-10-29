using Tyuiu.MolchankinaAP.Sprint4.Task3.V24.Lib;
namespace Tyuiu.MolchankinaAP.Sprint4.Task3.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] array = {
            { 3, 6, 1, 7, 3 },
            { 2, 3, 7, 1, 1 },
            { 1, 2, 5, 5, 1 },
            { 7, 6, 7, 6, 2 },
            { 7, 6, 4, 5, 8 }
            };
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine($"Минимальный элемент во втором столбце:" + res);
            Console.ReadKey();
        }
    }
}
